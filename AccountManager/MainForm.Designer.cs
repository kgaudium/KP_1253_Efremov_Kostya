﻿namespace AccountManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.SeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SeedCheckBox = new System.Windows.Forms.CheckBox();
            this.DigitsCheckBox = new System.Windows.Forms.CheckBox();
            this.LettersCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.UpperCheckBox = new System.Windows.Forms.CheckBox();
            this.LowerCheckBox = new System.Windows.Forms.CheckBox();
            this.DigitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.LettersUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordHashTextBox = new System.Windows.Forms.TextBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.AccountListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.ResetSelectionButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.AccountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AccountTypeLabel = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.SeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.DigitsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LettersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.LengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.NameLabel.Location = new System.Drawing.Point(12, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(222, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(222, 26);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.SurnameTextBox.Location = new System.Drawing.Point(290, 66);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(222, 26);
            this.SurnameTextBox.TabIndex = 2;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.SurnameLabel.Location = new System.Drawing.Point(290, 32);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(222, 31);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // BirthLabel
            // 
            this.BirthLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.BirthLabel.Location = new System.Drawing.Point(566, 32);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(222, 31);
            this.BirthLabel.TabIndex = 4;
            this.BirthLabel.Text = "Дата рождения";
            this.BirthLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LoginTextBox.Location = new System.Drawing.Point(12, 154);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(222, 26);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 120);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(222, 31);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 208);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(222, 31);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PasswordLabel.Visible = false;
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordPanel.Controls.Add(this.SeedUpDown);
            this.PasswordPanel.Controls.Add(this.GenerateButton);
            this.PasswordPanel.Controls.Add(this.SeedCheckBox);
            this.PasswordPanel.Controls.Add(this.DigitsCheckBox);
            this.PasswordPanel.Controls.Add(this.LettersCheckBox);
            this.PasswordPanel.Controls.Add(this.SpecialCheckBox);
            this.PasswordPanel.Controls.Add(this.UpperCheckBox);
            this.PasswordPanel.Controls.Add(this.LowerCheckBox);
            this.PasswordPanel.Controls.Add(this.DigitsUpDown);
            this.PasswordPanel.Controls.Add(this.LettersUpDown);
            this.PasswordPanel.Controls.Add(this.LengthUpDown);
            this.PasswordPanel.Controls.Add(this.LengthLabel);
            this.PasswordPanel.Controls.Add(this.PasswordTextBox);
            this.PasswordPanel.Location = new System.Drawing.Point(12, 242);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(394, 230);
            this.PasswordPanel.TabIndex = 9;
            // 
            // SeedUpDown
            // 
            this.SeedUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.SeedUpDown.Location = new System.Drawing.Point(143, 190);
            this.SeedUpDown.Name = "SeedUpDown";
            this.SeedUpDown.ReadOnly = true;
            this.SeedUpDown.Size = new System.Drawing.Size(79, 26);
            this.SeedUpDown.TabIndex = 12;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.GenerateButton.Location = new System.Drawing.Point(249, 175);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(127, 31);
            this.GenerateButton.TabIndex = 16;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SeedCheckBox
            // 
            this.SeedCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.SeedCheckBox.Location = new System.Drawing.Point(66, 190);
            this.SeedCheckBox.Name = "SeedCheckBox";
            this.SeedCheckBox.Size = new System.Drawing.Size(61, 25);
            this.SeedCheckBox.TabIndex = 11;
            this.SeedCheckBox.Text = "Сид";
            this.SeedCheckBox.UseVisualStyleBackColor = true;
            this.SeedCheckBox.CheckedChanged += new System.EventHandler(this.SeedCheckBox_CheckedChanged);
            // 
            // DigitsCheckBox
            // 
            this.DigitsCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.DigitsCheckBox.Location = new System.Drawing.Point(13, 118);
            this.DigitsCheckBox.Name = "DigitsCheckBox";
            this.DigitsCheckBox.Size = new System.Drawing.Size(125, 25);
            this.DigitsCheckBox.TabIndex = 8;
            this.DigitsCheckBox.Text = "Кол-во цифр";
            this.DigitsCheckBox.UseVisualStyleBackColor = true;
            this.DigitsCheckBox.CheckedChanged += new System.EventHandler(this.DigitsCheckBox_CheckedChanged);
            // 
            // LettersCheckBox
            // 
            this.LettersCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LettersCheckBox.Location = new System.Drawing.Point(13, 64);
            this.LettersCheckBox.Name = "LettersCheckBox";
            this.LettersCheckBox.Size = new System.Drawing.Size(125, 25);
            this.LettersCheckBox.TabIndex = 6;
            this.LettersCheckBox.Text = "Кол-во букв";
            this.LettersCheckBox.UseVisualStyleBackColor = true;
            this.LettersCheckBox.CheckedChanged += new System.EventHandler(this.LettersCheckBox_CheckedChanged);
            // 
            // SpecialCheckBox
            // 
            this.SpecialCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.SpecialCheckBox.Location = new System.Drawing.Point(245, 124);
            this.SpecialCheckBox.Name = "SpecialCheckBox";
            this.SpecialCheckBox.Size = new System.Drawing.Size(128, 25);
            this.SpecialCheckBox.TabIndex = 15;
            this.SpecialCheckBox.Text = "Спецсимволы";
            this.SpecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpperCheckBox
            // 
            this.UpperCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.UpperCheckBox.Location = new System.Drawing.Point(245, 62);
            this.UpperCheckBox.Name = "UpperCheckBox";
            this.UpperCheckBox.Size = new System.Drawing.Size(109, 25);
            this.UpperCheckBox.TabIndex = 13;
            this.UpperCheckBox.Text = "Заглавные";
            this.UpperCheckBox.UseVisualStyleBackColor = true;
            this.UpperCheckBox.CheckedChanged += new System.EventHandler(this.UpperCheckBox_CheckedChanged);
            // 
            // LowerCheckBox
            // 
            this.LowerCheckBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LowerCheckBox.Location = new System.Drawing.Point(245, 93);
            this.LowerCheckBox.Name = "LowerCheckBox";
            this.LowerCheckBox.Size = new System.Drawing.Size(109, 25);
            this.LowerCheckBox.TabIndex = 14;
            this.LowerCheckBox.Text = "Строчные";
            this.LowerCheckBox.UseVisualStyleBackColor = true;
            this.LowerCheckBox.CheckedChanged += new System.EventHandler(this.LowerCheckBox_CheckedChanged);
            // 
            // DigitsUpDown
            // 
            this.DigitsUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.DigitsUpDown.Location = new System.Drawing.Point(144, 117);
            this.DigitsUpDown.Name = "DigitsUpDown";
            this.DigitsUpDown.ReadOnly = true;
            this.DigitsUpDown.Size = new System.Drawing.Size(79, 26);
            this.DigitsUpDown.TabIndex = 9;
            // 
            // LettersUpDown
            // 
            this.LettersUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LettersUpDown.Location = new System.Drawing.Point(144, 63);
            this.LettersUpDown.Name = "LettersUpDown";
            this.LettersUpDown.ReadOnly = true;
            this.LettersUpDown.Size = new System.Drawing.Size(79, 26);
            this.LettersUpDown.TabIndex = 7;
            // 
            // LengthUpDown
            // 
            this.LengthUpDown.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LengthUpDown.Location = new System.Drawing.Point(143, 158);
            this.LengthUpDown.Name = "LengthUpDown";
            this.LengthUpDown.Size = new System.Drawing.Size(79, 26);
            this.LengthUpDown.TabIndex = 10;
            // 
            // LengthLabel
            // 
            this.LengthLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LengthLabel.Location = new System.Drawing.Point(59, 155);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(63, 24);
            this.LengthLabel.TabIndex = 12;
            this.LengthLabel.Text = "Длина";
            this.LengthLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 18);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(357, 26);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // PasswordHashTextBox
            // 
            this.PasswordHashTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.PasswordHashTextBox.Location = new System.Drawing.Point(12, 242);
            this.PasswordHashTextBox.Multiline = true;
            this.PasswordHashTextBox.Name = "PasswordHashTextBox";
            this.PasswordHashTextBox.ReadOnly = true;
            this.PasswordHashTextBox.Size = new System.Drawing.Size(394, 44);
            this.PasswordHashTextBox.TabIndex = 17;
            this.PasswordHashTextBox.Visible = false;
            // 
            // ListLabel
            // 
            this.ListLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.ListLabel.Location = new System.Drawing.Point(457, 146);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(261, 31);
            this.ListLabel.TabIndex = 10;
            this.ListLabel.Text = "Список пользователей";
            this.ListLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AccountListBox
            // 
            this.AccountListBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.AccountListBox.FormattingEnabled = true;
            this.AccountListBox.ItemHeight = 18;
            this.AccountListBox.Location = new System.Drawing.Point(457, 180);
            this.AccountListBox.Name = "AccountListBox";
            this.AccountListBox.Size = new System.Drawing.Size(331, 292);
            this.AccountListBox.TabIndex = 23;
            this.AccountListBox.SelectedIndexChanged += new System.EventHandler(this.AccountListBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.SaveButton.Location = new System.Drawing.Point(661, 541);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 31);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.BirthDatePicker.Location = new System.Drawing.Point(566, 66);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(221, 26);
            this.BirthDatePicker.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.AddButton.Location = new System.Drawing.Point(12, 478);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 31);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ResetSelectionButton
            // 
            this.ResetSelectionButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.ResetSelectionButton.Location = new System.Drawing.Point(651, 478);
            this.ResetSelectionButton.Name = "ResetSelectionButton";
            this.ResetSelectionButton.Size = new System.Drawing.Size(137, 31);
            this.ResetSelectionButton.TabIndex = 24;
            this.ResetSelectionButton.Text = "Снять выбор";
            this.ResetSelectionButton.UseVisualStyleBackColor = true;
            this.ResetSelectionButton.Click += new System.EventHandler(this.ResetSelectionButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.LogoutButton.Location = new System.Drawing.Point(12, 541);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(127, 31);
            this.LogoutButton.TabIndex = 26;
            this.LogoutButton.Text = "Выход";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.DeleteButton.Location = new System.Drawing.Point(145, 478);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(127, 31);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.ApplyButton.Location = new System.Drawing.Point(278, 478);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(127, 31);
            this.ApplyButton.TabIndex = 22;
            this.ApplyButton.Text = "Применить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // AccountTypeComboBox
            // 
            this.AccountTypeComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.AccountTypeComboBox.FormattingEnabled = true;
            this.AccountTypeComboBox.Location = new System.Drawing.Point(270, 154);
            this.AccountTypeComboBox.Name = "AccountTypeComboBox";
            this.AccountTypeComboBox.Size = new System.Drawing.Size(163, 26);
            this.AccountTypeComboBox.TabIndex = 5;
            // 
            // AccountTypeLabel
            // 
            this.AccountTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.AccountTypeLabel.Location = new System.Drawing.Point(270, 120);
            this.AccountTypeLabel.Name = "AccountTypeLabel";
            this.AccountTypeLabel.Size = new System.Drawing.Size(163, 31);
            this.AccountTypeLabel.TabIndex = 6;
            this.AccountTypeLabel.Text = "Тип аккаунта";
            this.AccountTypeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(12, 324);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(145, 31);
            this.ChangePasswordButton.TabIndex = 19;
            this.ChangePasswordButton.Text = "Изменить пароль";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Visible = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
            this.NewPasswordTextBox.Location = new System.Drawing.Point(12, 292);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(393, 26);
            this.NewPasswordTextBox.TabIndex = 18;
            this.NewPasswordTextBox.Visible = false;
            this.NewPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.AccountTypeComboBox);
            this.Controls.Add(this.ResetSelectionButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AccountListBox);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.PasswordPanel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.AccountTypeLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.PasswordHashTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Account Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.SeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.DigitsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LettersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.LengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox NewPasswordTextBox;

        private System.Windows.Forms.Label AccountTypeLabel;

        private System.Windows.Forms.ComboBox AccountTypeComboBox;

        private System.Windows.Forms.Button ApplyButton;

        private System.Windows.Forms.Button DeleteButton;

        private System.Windows.Forms.Button LogoutButton;

        private System.Windows.Forms.TextBox PasswordHashTextBox;

        private System.Windows.Forms.Button ResetSelectionButton;

        private System.Windows.Forms.CheckBox SeedCheckBox;
        
        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.NumericUpDown LengthUpDown;

        private System.Windows.Forms.CheckBox LowerCheckBox;

        private System.Windows.Forms.DateTimePicker BirthDatePicker;

        private System.Windows.Forms.Button SaveButton;

        private System.Windows.Forms.Button GenerateButton;

        private System.Windows.Forms.CheckBox SpecialCheckBox;
        private System.Windows.Forms.CheckBox LettersCheckBox;
        private System.Windows.Forms.CheckBox DigitsCheckBox;

        private System.Windows.Forms.CheckBox UpperCheckBox;

        private System.Windows.Forms.NumericUpDown LettersUpDown;
        private System.Windows.Forms.NumericUpDown DigitsUpDown;

        private System.Windows.Forms.NumericUpDown SeedUpDown;

        private System.Windows.Forms.Label LengthLabel;

        private System.Windows.Forms.TextBox PasswordTextBox;

        private System.Windows.Forms.ListBox AccountListBox;

        private System.Windows.Forms.Label ListLabel;

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Panel PasswordPanel;

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LoginLabel;

        private System.Windows.Forms.Label BirthLabel;

        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;

        private System.Windows.Forms.TextBox NameTextBox;

        private System.Windows.Forms.Label NameLabel;

        #endregion
    }
}