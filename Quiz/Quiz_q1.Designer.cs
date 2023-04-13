using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Quiz
{
    partial class Quiz_q1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button DebugButton;
        private Button ResetButton;
        private Button NextButton;
        public TextBox NameTextBox;
        public TextBox SurnameTextBox;
        public TextBox GroupTextBox;
        public TextBox CardNumberTextBox;
        public CheckBox BudgetCheckBox;
        public ComboBox FacultyComboBox;
        private Label FacultyLabel;
        private Label CardNumberLabel;
        private Label BudgetLabel;
        private Label NameLabel;
        private Label SurnameLabel;
        private Label GroupLabel;
        private Label MainLabel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz_q1));
            this.MainLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.BudgetCheckBox = new System.Windows.Forms.CheckBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DebugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(182, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(338, 58);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.Text = "Информация";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 99);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(254, 30);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Имя";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(12, 141);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(254, 30);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Фамилия";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupLabel
            // 
            this.GroupLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(12, 183);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(254, 30);
            this.GroupLabel.TabIndex = 3;
            this.GroupLabel.Text = "Группа";
            this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BudgetLabel.Location = new System.Drawing.Point(12, 223);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(254, 30);
            this.BudgetLabel.TabIndex = 4;
            this.BudgetLabel.Text = "Бюджет";
            this.BudgetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumberLabel.Location = new System.Drawing.Point(12, 267);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(254, 30);
            this.CardNumberLabel.TabIndex = 5;
            this.CardNumberLabel.Text = "Номер карты родителей";
            this.CardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultyLabel.Location = new System.Drawing.Point(12, 311);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(254, 30);
            this.FacultyLabel.TabIndex = 6;
            this.FacultyLabel.Text = "Факультет";
            this.FacultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(294, 99);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(327, 35);
            this.NameTextBox.TabIndex = 7;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(294, 141);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(327, 35);
            this.SurnameTextBox.TabIndex = 8;
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNumberTextBox.Location = new System.Drawing.Point(294, 267);
            this.CardNumberTextBox.MaxLength = 16;
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(327, 35);
            this.CardNumberTextBox.TabIndex = 11;
            this.CardNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumberTextBox_KeyPress);
            // 
            // BudgetCheckBox
            // 
            this.BudgetCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BudgetCheckBox.Location = new System.Drawing.Point(294, 227);
            this.BudgetCheckBox.Name = "BudgetCheckBox";
            this.BudgetCheckBox.Size = new System.Drawing.Size(30, 30);
            this.BudgetCheckBox.TabIndex = 13;
            this.BudgetCheckBox.UseVisualStyleBackColor = true;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(294, 311);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(327, 36);
            this.FacultyComboBox.TabIndex = 14;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupTextBox.Location = new System.Drawing.Point(294, 183);
            this.GroupTextBox.MaxLength = 4;
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(327, 35);
            this.GroupTextBox.TabIndex = 9;
            this.GroupTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GroupTextBox_KeyPress);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(586, 429);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(96, 30);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(484, 429);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(96, 30);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DebugButton
            // 
            this.DebugButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DebugButton.Location = new System.Drawing.Point(12, 429);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(96, 30);
            this.DebugButton.TabIndex = 17;
            this.DebugButton.Text = "Дебуг";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // Quiz_q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.DebugButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.BudgetCheckBox);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Quiz_q1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Quiz_q1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}