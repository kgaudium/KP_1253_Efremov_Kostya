using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Quiz;

partial class ResultsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.ResultsLabel = new System.Windows.Forms.Label();
        this.ResultsListBox = new System.Windows.Forms.ListBox();
        this.NameTextBox = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.SurnameTextBox = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.GroupTextBox = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.BudgetTextBox = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.CardTextBox = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.FacultyTextBox = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.FutureTextBox = new System.Windows.Forms.TextBox();
        this.BackButton = new System.Windows.Forms.Button();
        this.SaveButton = new System.Windows.Forms.Button();
        this.OpenButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // ResultsLabel
        // 
        this.ResultsLabel.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.ResultsLabel.Location = new System.Drawing.Point(200, 30);
        this.ResultsLabel.Name = "ResultsLabel";
        this.ResultsLabel.Size = new System.Drawing.Size(300, 50);
        this.ResultsLabel.TabIndex = 0;
        this.ResultsLabel.Text = "Результаты";
        this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // ResultsListBox
        // 
        this.ResultsListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.ResultsListBox.FormattingEnabled = true;
        this.ResultsListBox.ItemHeight = 23;
        this.ResultsListBox.Location = new System.Drawing.Point(400, 110);
        this.ResultsListBox.Name = "ResultsListBox";
        this.ResultsListBox.Size = new System.Drawing.Size(260, 280);
        this.ResultsListBox.TabIndex = 1;
        this.ResultsListBox.SelectedIndexChanged += new System.EventHandler(this.ResultsListBox_SelectedIndexChanged);
        // 
        // NameTextBox
        // 
        this.NameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.NameTextBox.Location = new System.Drawing.Point(137, 110);
        this.NameTextBox.Name = "NameTextBox";
        this.NameTextBox.ReadOnly = true;
        this.NameTextBox.Size = new System.Drawing.Size(250, 30);
        this.NameTextBox.TabIndex = 2;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label1.Location = new System.Drawing.Point(8, 110);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(111, 25);
        this.label1.TabIndex = 3;
        this.label1.Text = "Имя";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label2.Location = new System.Drawing.Point(8, 146);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(111, 25);
        this.label2.TabIndex = 5;
        this.label2.Text = "Фамилия";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // SurnameTextBox
        // 
        this.SurnameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.SurnameTextBox.Location = new System.Drawing.Point(137, 146);
        this.SurnameTextBox.Name = "SurnameTextBox";
        this.SurnameTextBox.ReadOnly = true;
        this.SurnameTextBox.Size = new System.Drawing.Size(250, 30);
        this.SurnameTextBox.TabIndex = 4;
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label3.Location = new System.Drawing.Point(8, 182);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(111, 25);
        this.label3.TabIndex = 7;
        this.label3.Text = "Группа";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // GroupTextBox
        // 
        this.GroupTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.GroupTextBox.Location = new System.Drawing.Point(137, 182);
        this.GroupTextBox.Name = "GroupTextBox";
        this.GroupTextBox.ReadOnly = true;
        this.GroupTextBox.Size = new System.Drawing.Size(250, 30);
        this.GroupTextBox.TabIndex = 6;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label4.Location = new System.Drawing.Point(8, 218);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(111, 25);
        this.label4.TabIndex = 9;
        this.label4.Text = "Бюджет?";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // BudgetTextBox
        // 
        this.BudgetTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.BudgetTextBox.Location = new System.Drawing.Point(137, 218);
        this.BudgetTextBox.Name = "BudgetTextBox";
        this.BudgetTextBox.ReadOnly = true;
        this.BudgetTextBox.Size = new System.Drawing.Size(250, 30);
        this.BudgetTextBox.TabIndex = 8;
        // 
        // label5
        // 
        this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label5.Location = new System.Drawing.Point(8, 254);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(111, 25);
        this.label5.TabIndex = 11;
        this.label5.Text = "Номер карты";
        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CardTextBox
        // 
        this.CardTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.CardTextBox.Location = new System.Drawing.Point(137, 254);
        this.CardTextBox.Name = "CardTextBox";
        this.CardTextBox.ReadOnly = true;
        this.CardTextBox.Size = new System.Drawing.Size(250, 30);
        this.CardTextBox.TabIndex = 10;
        // 
        // label6
        // 
        this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label6.Location = new System.Drawing.Point(8, 290);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(111, 25);
        this.label6.TabIndex = 13;
        this.label6.Text = "Факультет";
        this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // FacultyTextBox
        // 
        this.FacultyTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.FacultyTextBox.Location = new System.Drawing.Point(137, 290);
        this.FacultyTextBox.Name = "FacultyTextBox";
        this.FacultyTextBox.ReadOnly = true;
        this.FacultyTextBox.Size = new System.Drawing.Size(250, 30);
        this.FacultyTextBox.TabIndex = 12;
        // 
        // label7
        // 
        this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label7.Location = new System.Drawing.Point(8, 326);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(111, 25);
        this.label7.TabIndex = 15;
        this.label7.Text = "В будущем";
        this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // FutureTextBox
        // 
        this.FutureTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.FutureTextBox.Location = new System.Drawing.Point(137, 326);
        this.FutureTextBox.Name = "FutureTextBox";
        this.FutureTextBox.ReadOnly = true;
        this.FutureTextBox.Size = new System.Drawing.Size(250, 30);
        this.FutureTextBox.TabIndex = 14;
        // 
        // BackButton
        // 
        this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.BackButton.Location = new System.Drawing.Point(12, 419);
        this.BackButton.Name = "BackButton";
        this.BackButton.Size = new System.Drawing.Size(96, 30);
        this.BackButton.TabIndex = 17;
        this.BackButton.Text = "Назад";
        this.BackButton.UseVisualStyleBackColor = true;
        this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
        // 
        // SaveButton
        // 
        this.SaveButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.SaveButton.Location = new System.Drawing.Point(400, 396);
        this.SaveButton.Name = "SaveButton";
        this.SaveButton.Size = new System.Drawing.Size(127, 30);
        this.SaveButton.TabIndex = 18;
        this.SaveButton.Text = "Сохранить";
        this.SaveButton.UseVisualStyleBackColor = true;
        this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
        // 
        // OpenButton
        // 
        this.OpenButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.OpenButton.Location = new System.Drawing.Point(533, 396);
        this.OpenButton.Name = "OpenButton";
        this.OpenButton.Size = new System.Drawing.Size(127, 30);
        this.OpenButton.TabIndex = 19;
        this.OpenButton.Text = "Открыть";
        this.OpenButton.UseVisualStyleBackColor = true;
        this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
        // 
        // ResultsForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(684, 461);
        this.Controls.Add(this.OpenButton);
        this.Controls.Add(this.SaveButton);
        this.Controls.Add(this.BackButton);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.FutureTextBox);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.FacultyTextBox);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.CardTextBox);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.BudgetTextBox);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.GroupTextBox);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.SurnameTextBox);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.NameTextBox);
        this.Controls.Add(this.ResultsListBox);
        this.Controls.Add(this.ResultsLabel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "ResultsForm";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Button OpenButton;

    private System.Windows.Forms.Button BackButton;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox SurnameTextBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox GroupTextBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox BudgetTextBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox CardTextBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox FacultyTextBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox FutureTextBox;

    private System.Windows.Forms.TextBox NameTextBox;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ListBox ResultsListBox;

    private System.Windows.Forms.Label ResultsLabel;

    #endregion
}