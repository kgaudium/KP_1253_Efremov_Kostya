using System;
using System.Diagnostics;
using System.Windows.Forms;

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
        // Error! Length cannot be less than (Digits + Letters)!\r\n
        // Warning! There is no place for special symbols. Digits + Letters = Length!\r\nYour Password: Y23b2R89My\r\n
        // Your Password: mqt93\r\n
        
        string appOutput = RunApp();
        string[] splittedString = appOutput.Split(new[] {"\r\n"}, StringSplitOptions.None);
        
        if (splittedString.Length == 2) // OK or ERROR
        {
            splittedString = splittedString[0].Split(' ');

            if (splittedString[0] == "Your")
            {
                return splittedString[2];
            }
            
            if (splittedString[0] == "Error!")
            {
                MessageBox.Show(appOutput, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else if (splittedString.Length == 3) // WARNING
        {
            if (splittedString[0].Split(' ')[0] == "Warning!")
            {
                MessageBox.Show(appOutput, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return splittedString[1].Split(' ')[2];
            }
            else
            {
                MessageBox.Show("Непредвиденная ошибка!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else // ??
        {
            MessageBox.Show("Непредвиденная ошибка!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        return "";
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