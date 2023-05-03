using Quiz.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    partial class MenuForm
    {
        private System.Windows.Forms.PictureBox MenuPictureBox;
        private Button ExitButton;
        private Label MenuLabel;
        private Button StartQuizButton;
        private Button ResultsButton;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.StartQuizButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.MenuPictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.MenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartQuizButton
            // 
            this.StartQuizButton.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.StartQuizButton.Location = new System.Drawing.Point(58, 142);
            this.StartQuizButton.Name = "StartQuizButton";
            this.StartQuizButton.Size = new System.Drawing.Size(315, 59);
            this.StartQuizButton.TabIndex = 0;
            this.StartQuizButton.Text = "Пройти опрос";
            this.StartQuizButton.UseVisualStyleBackColor = true;
            this.StartQuizButton.Click += new System.EventHandler(this.StartQuizButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ResultsButton.Location = new System.Drawing.Point(58, 242);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(315, 59);
            this.ResultsButton.TabIndex = 1;
            this.ResultsButton.Text = "Результаты";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // MenuPictureBox
            // 
            this.MenuPictureBox.Image = ((System.Drawing.Image) (resources.GetObject("MenuPictureBox.Image")));
            this.MenuPictureBox.InitialImage = null;
            this.MenuPictureBox.Location = new System.Drawing.Point(463, 142);
            this.MenuPictureBox.Name = "MenuPictureBox";
            this.MenuPictureBox.Size = new System.Drawing.Size(160, 160);
            this.MenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuPictureBox.TabIndex = 2;
            this.MenuPictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ExitButton.Location = new System.Drawing.Point(582, 429);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 30);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuLabel.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MenuLabel.Location = new System.Drawing.Point(200, 30);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(300, 50);
            this.MenuLabel.TabIndex = 4;
            this.MenuLabel.Text = "Опрос";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 471);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MenuPictureBox);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.StartQuizButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Опрос";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.MenuPictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
    
}