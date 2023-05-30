using System.ComponentModel;

namespace AccountManager;

partial class LoginForm
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
        this.LoginTextBox = new System.Windows.Forms.TextBox();
        this.LoginLabel = new System.Windows.Forms.Label();
        this.PasswordTextBox = new System.Windows.Forms.TextBox();
        this.PasswordLabel = new System.Windows.Forms.Label();
        this.LoginButton = new System.Windows.Forms.Button();
        this.GuestButton = new System.Windows.Forms.Button();
        this.ErrorLabel = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // LoginTextBox
        // 
        this.LoginTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.LoginTextBox.Location = new System.Drawing.Point(38, 58);
        this.LoginTextBox.Name = "LoginTextBox";
        this.LoginTextBox.Size = new System.Drawing.Size(262, 26);
        this.LoginTextBox.TabIndex = 1;
        this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
        // 
        // LoginLabel
        // 
        this.LoginLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.LoginLabel.Location = new System.Drawing.Point(38, 31);
        this.LoginLabel.Name = "LoginLabel";
        this.LoginLabel.Size = new System.Drawing.Size(140, 24);
        this.LoginLabel.TabIndex = 1;
        this.LoginLabel.Text = "Логин";
        this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // PasswordTextBox
        // 
        this.PasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.PasswordTextBox.Location = new System.Drawing.Point(38, 118);
        this.PasswordTextBox.Name = "PasswordTextBox";
        this.PasswordTextBox.Size = new System.Drawing.Size(262, 26);
        this.PasswordTextBox.TabIndex = 2;
        this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
        // 
        // PasswordLabel
        // 
        this.PasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.PasswordLabel.Location = new System.Drawing.Point(38, 91);
        this.PasswordLabel.Name = "PasswordLabel";
        this.PasswordLabel.Size = new System.Drawing.Size(140, 24);
        this.PasswordLabel.TabIndex = 1;
        this.PasswordLabel.Text = "Пароль";
        this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // LoginButton
        // 
        this.LoginButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.LoginButton.Location = new System.Drawing.Point(38, 160);
        this.LoginButton.Name = "LoginButton";
        this.LoginButton.Size = new System.Drawing.Size(261, 43);
        this.LoginButton.TabIndex = 4;
        this.LoginButton.Text = "Авторизация";
        this.LoginButton.UseVisualStyleBackColor = true;
        this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
        // 
        // GuestButton
        // 
        this.GuestButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.GuestButton.Location = new System.Drawing.Point(91, 209);
        this.GuestButton.Name = "GuestButton";
        this.GuestButton.Size = new System.Drawing.Size(157, 33);
        this.GuestButton.TabIndex = 5;
        this.GuestButton.Text = "Войти как гость";
        this.GuestButton.UseVisualStyleBackColor = true;
        this.GuestButton.Click += new System.EventHandler(this.GuestButton_Click);
        // 
        // ErrorLabel
        // 
        this.ErrorLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (254)));
        this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
        this.ErrorLabel.Location = new System.Drawing.Point(38, 248);
        this.ErrorLabel.Name = "ErrorLabel";
        this.ErrorLabel.Size = new System.Drawing.Size(262, 35);
        this.ErrorLabel.TabIndex = 1;
        this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = global::AccountManager.Properties.Resources.eye;
        this.pictureBox1.Location = new System.Drawing.Point(12, 120);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(20, 20);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 3;
        this.pictureBox1.TabStop = false;
        this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
        // 
        // LoginForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(350, 292);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.GuestButton);
        this.Controls.Add(this.LoginButton);
        this.Controls.Add(this.ErrorLabel);
        this.Controls.Add(this.PasswordLabel);
        this.Controls.Add(this.LoginLabel);
        this.Controls.Add(this.PasswordTextBox);
        this.Controls.Add(this.LoginTextBox);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "LoginForm";
        this.Text = "Авторизация";
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Button GuestButton;

    private System.Windows.Forms.Button LoginButton;

    private System.Windows.Forms.TextBox LoginTextBox;
    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.Label LoginLabel;
    private System.Windows.Forms.Label PasswordLabel;

    #endregion
}