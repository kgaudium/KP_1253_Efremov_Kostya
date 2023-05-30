using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Quiz;

public partial class ResultsForm : Form
{
    public ResultsForm()
    {
        InitializeComponent();
        FillListBox();
    }

    // Заполняем ListBox данными из списка ответов
    private void FillListBox()
    {
        ResultsListBox.Items.Clear();
        
        foreach (var result in AppController.ResultsList)
        {
            ResultsListBox.Items.Add(result.ToString());
        }
    }

    // Возвращаемся назад. Форму можно уничтожить - там нет ничего ценного.
    private void BackButton_Click(object sender, EventArgs e)
    {
        AppController.menuForm.Location = Location;
        AppController.menuForm.Show();
        Dispose();
    }

    // Сохранение списка
    private void SaveButton_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        
        saveFileDialog.Filter = "JSON Files (*.json)|*.json";       // название расширения - JSON
        saveFileDialog.DefaultExt = "json";                         // расширение - .json
        DialogResult dialogResult = saveFileDialog.ShowDialog();    // Показывает диалог выбора
        
        if (dialogResult == DialogResult.OK)                        // Если нажали ОК
        {
            string jsonData = AppController.ResultsListToJson();    // Переводит в JSON
            
            FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);   // Создаёт нужный файл
            byte[] info = new UTF8Encoding(true).GetBytes(jsonData);                    // Переводит в массив байтов
            fs.Write(info, 0, info.Length);                                   // Записывает в файл массив
            fs.Close();     // Закрывает файл
            
            AppController.IsListSaved = true;   // флажок на тру
        }
    }

    // Открытие списка
    private void OpenButton_Click(object sender, EventArgs e)
    {
        if (!AppController.IsListSaved && AppController.ResultsList.Count != 0) 
                    // Наверное, можно в один if засунуть, когда он увидит, что !AppController.IsListSaved - ложно, 
        {           //      то второе условие проверять, вероятно, не будет; следовательно и не будет открывать MessageBox (наверное)
            
            // Предупреждение о том, что результаты не сохранены
            if (MessageBox.Show("Изменения не сохранены!\nПродолжить?", "Внимание!", MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Asterisk) != DialogResult.OK) return;
        }
        
        OpenFileDialog openFileDialog = new OpenFileDialog();
        
        openFileDialog.Filter = "JSON Files (*.json)|*.json";       // название расширения - JSON
        DialogResult dialogResult = openFileDialog.ShowDialog();    // Показывает диалог выбора
        if (dialogResult == DialogResult.OK)                        // Test result.
        {
            FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);     // Открывает файл
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);                      // Создаём потоковый читатель
            
            try
            {
                AppController.ResultsList = AppController.JsonToResultsList(sr.ReadToEnd());    // Пробуем десериализовать (перезаписываем список результатов)
            }
            // catch (Exception exception)     // Что-то пошло не по плану
            // {
            //     MessageBox.Show($"Что-то не так :(\n{exception.Message}", "Ошибка файла", MessageBoxButtons.OK,
            //         MessageBoxIcon.Error);
            // }
            finally
            {
                sr.Close();     // Закрываем все стримы
                fs.Close();
            }
            
            FillListBox();      // Перезаписываем ListBox
            AppController.IsListSaved = true;   // Флажок на тру
        }
    }

    // Закрыли форму
    private void ResultsForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        // При закрытии окна показывает окно меню в том же месте, где и было это
        AppController.menuForm.Location = Location;
        AppController.menuForm.Show();
    }

    // Выделили другой объект - поменялись значения
    private void ResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        QuizResult result = AppController.ResultsList[ResultsListBox.SelectedIndex];

        NameTextBox.Text = result.Name;
        SurnameTextBox.Text = result.Surname;
        GroupTextBox.Text = result.Group.ToString();
        BudgetTextBox.Text = (bool) result.Budget ? "Да" : "Нет";
        CardTextBox.Text = result.CardNumber;
        FacultyTextBox.Text = ((AppController.Faculty) result.Faculty).ToDescription();
        FutureTextBox.Text = ((AppController.FutureEnum) result.InTheFuture).ToDescription();
    }
}