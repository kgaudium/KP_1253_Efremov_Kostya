using Quiz.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    partial class Quiz_q2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;
        private Button ResetButton;
        private Button BackButton;
        private RadioButton FutureRadioButton2;
        private RadioButton FutureRadioButton3;
        private Panel FuturePanel;
        private RadioButton FutureRadioButton1;
        private PictureBox FuturePictureBox0;
        private PictureBox FuturePictureBox1;
        private PictureBox FuturePictureBox2;
        private PictureBox FuturePictureBox3;
        private RadioButton FutureRadioButton0;
        private Label label1;
        private Button EndButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz_q2));
            this.EndButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FuturePictureBox0 = new System.Windows.Forms.PictureBox();
            this.FuturePictureBox1 = new System.Windows.Forms.PictureBox();
            this.FuturePictureBox2 = new System.Windows.Forms.PictureBox();
            this.FuturePictureBox3 = new System.Windows.Forms.PictureBox();
            this.FuturePanel = new System.Windows.Forms.Panel();
            this.FutureRadioButton3 = new System.Windows.Forms.RadioButton();
            this.FutureRadioButton2 = new System.Windows.Forms.RadioButton();
            this.FutureRadioButton1 = new System.Windows.Forms.RadioButton();
            this.FutureRadioButton0 = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox3)).BeginInit();
            this.FuturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EndButton
            // 
            this.EndButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndButton.Location = new System.Drawing.Point(576, 419);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(96, 30);
            this.EndButton.TabIndex = 0;
            this.EndButton.Text = "Завершить";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 124);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кем вы видите себя через 10 лет?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FuturePictureBox0
            // 
            this.FuturePictureBox0.Location = new System.Drawing.Point(48, 136);
            this.FuturePictureBox0.Name = "FuturePictureBox0";
            this.FuturePictureBox0.Size = new System.Drawing.Size(130, 170);
            this.FuturePictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FuturePictureBox0.TabIndex = 2;
            this.FuturePictureBox0.TabStop = false;
            this.FuturePictureBox0.Click += new System.EventHandler(this.FuturePictureBox0_Click);
            // 
            // FuturePictureBox1
            // 
            this.FuturePictureBox1.Location = new System.Drawing.Point(207, 136);
            this.FuturePictureBox1.Name = "FuturePictureBox1";
            this.FuturePictureBox1.Size = new System.Drawing.Size(130, 170);
            this.FuturePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FuturePictureBox1.TabIndex = 3;
            this.FuturePictureBox1.TabStop = false;
            this.FuturePictureBox1.Click += new System.EventHandler(this.FuturePictureBox1_Click);
            // 
            // FuturePictureBox2
            // 
            this.FuturePictureBox2.Location = new System.Drawing.Point(363, 136);
            this.FuturePictureBox2.Name = "FuturePictureBox2";
            this.FuturePictureBox2.Size = new System.Drawing.Size(130, 170);
            this.FuturePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FuturePictureBox2.TabIndex = 4;
            this.FuturePictureBox2.TabStop = false;
            this.FuturePictureBox2.Click += new System.EventHandler(this.FuturePictureBox2_Click);
            // 
            // FuturePictureBox3
            // 
            this.FuturePictureBox3.Location = new System.Drawing.Point(519, 136);
            this.FuturePictureBox3.Name = "FuturePictureBox3";
            this.FuturePictureBox3.Size = new System.Drawing.Size(130, 170);
            this.FuturePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FuturePictureBox3.TabIndex = 5;
            this.FuturePictureBox3.TabStop = false;
            this.FuturePictureBox3.Click += new System.EventHandler(this.FuturePictureBox3_Click);
            // 
            // FuturePanel
            // 
            this.FuturePanel.Controls.Add(this.FutureRadioButton3);
            this.FuturePanel.Controls.Add(this.FutureRadioButton2);
            this.FuturePanel.Controls.Add(this.FutureRadioButton1);
            this.FuturePanel.Controls.Add(this.FutureRadioButton0);
            this.FuturePanel.Location = new System.Drawing.Point(48, 336);
            this.FuturePanel.Name = "FuturePanel";
            this.FuturePanel.Size = new System.Drawing.Size(601, 41);
            this.FuturePanel.TabIndex = 8;
            // 
            // FutureRadioButton3
            // 
            this.FutureRadioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FutureRadioButton3.Location = new System.Drawing.Point(519, 10);
            this.FutureRadioButton3.Name = "FutureRadioButton3";
            this.FutureRadioButton3.Size = new System.Drawing.Size(15, 15);
            this.FutureRadioButton3.TabIndex = 9;
            this.FutureRadioButton3.TabStop = true;
            this.FutureRadioButton3.UseVisualStyleBackColor = true;
            this.FutureRadioButton3.CheckedChanged += new System.EventHandler(this.FutureRadioButton_CheckedChanged);
            // 
            // FutureRadioButton2
            // 
            this.FutureRadioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FutureRadioButton2.Location = new System.Drawing.Point(363, 10);
            this.FutureRadioButton2.Name = "FutureRadioButton2";
            this.FutureRadioButton2.Size = new System.Drawing.Size(15, 15);
            this.FutureRadioButton2.TabIndex = 8;
            this.FutureRadioButton2.TabStop = true;
            this.FutureRadioButton2.UseVisualStyleBackColor = true;
            this.FutureRadioButton2.CheckedChanged += new System.EventHandler(this.FutureRadioButton_CheckedChanged);
            // 
            // FutureRadioButton1
            // 
            this.FutureRadioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FutureRadioButton1.Location = new System.Drawing.Point(207, 10);
            this.FutureRadioButton1.Name = "FutureRadioButton1";
            this.FutureRadioButton1.Size = new System.Drawing.Size(15, 15);
            this.FutureRadioButton1.TabIndex = 7;
            this.FutureRadioButton1.TabStop = true;
            this.FutureRadioButton1.UseVisualStyleBackColor = true;
            this.FutureRadioButton1.CheckedChanged += new System.EventHandler(this.FutureRadioButton_CheckedChanged);
            // 
            // FutureRadioButton0
            // 
            this.FutureRadioButton0.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FutureRadioButton0.Location = new System.Drawing.Point(48, 10);
            this.FutureRadioButton0.Name = "FutureRadioButton0";
            this.FutureRadioButton0.Size = new System.Drawing.Size(15, 15);
            this.FutureRadioButton0.TabIndex = 0;
            this.FutureRadioButton0.TabStop = true;
            this.FutureRadioButton0.UseVisualStyleBackColor = true;
            this.FutureRadioButton0.CheckedChanged += new System.EventHandler(this.FutureRadioButton_CheckedChanged);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 419);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 30);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(474, 419);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(96, 30);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Quiz_q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FuturePanel);
            this.Controls.Add(this.FuturePictureBox3);
            this.Controls.Add(this.FuturePictureBox2);
            this.Controls.Add(this.FuturePictureBox1);
            this.Controls.Add(this.FuturePictureBox0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quiz_q2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Quiz_q2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuturePictureBox3)).EndInit();
            this.FuturePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}