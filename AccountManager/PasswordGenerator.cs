using System;
using System.Diagnostics;

namespace AccountManager;

public class PasswordGenerator
{
    public int? LettersCount;
    public int? DigitsCount;
    public int Length;
    public int? Seed;
    public bool UseUpper;
    public bool UseLower;
    public bool UseSpecial;

    public string ExecutablePath;

    public PasswordGenerator(string path)
    {
        ExecutablePath = path;
    }

    public string Generate()
    {
        return RunApp();
    }
    
    private string RunApp()
    {
        // Создание объекта для запуска внешнего приложения
        Process generatorProcess = new Process();

        generatorProcess.StartInfo.FileName = ExecutablePath;        // указание пути к файлу запускаемой программы
        generatorProcess.StartInfo.UseShellExecute = false;          // false требуется, чтобы можно было читать из вывода запущенного приложения
        generatorProcess.StartInfo.RedirectStandardOutput = true;    // true требуется, чтобы можно было читать из стандартного вывода запущенного приложения
        generatorProcess.StartInfo.RedirectStandardError = true;     // true требуется, чтобы можно было читать из ошибки запущенного приложения
        generatorProcess.StartInfo.CreateNoWindow = true;            // отключаем создание окна (на всякий случай)

        string args = $"-L {Length} {(LettersCount != null ? $"-l {LettersCount}":"")} {(DigitsCount != null ? $"-d {DigitsCount}":"")} {(Seed != null ? $"--seed {Seed}":"")} {(UseUpper? "-u":"")} {(UseLower? "-o":"")} {(UseSpecial? "-s":"")}";
        generatorProcess.StartInfo.Arguments = args;                 // передача аргументов запускаемой программы

        // Запускаем приложение
        bool started = generatorProcess.Start();
        if (!started)
        {
            // Console.WriteLine("Ошибка запуска приложения!");
            throw new Exception();
        }

        // Читамем вывод приложения
        string output = generatorProcess.StandardOutput.ReadToEnd();

        // Дождаемся окончания работы приложения и выходим
        generatorProcess.WaitForExit();

        return output;
    }
}