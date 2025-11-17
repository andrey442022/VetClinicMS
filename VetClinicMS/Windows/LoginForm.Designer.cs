using System.ComponentModel;

namespace VetClinicMS.Windows;

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
        lblTitle = new Label();
        lblUsername = new Label();
        txtUsername = new TextBox();
        lblPassword = new Label();
        txtPassword = new TextBox();
        btnLogin = new Button();
        labelError = new Label();
        pictureBox1 = new PictureBox();
        ((ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTitle.Location = new Point(95, 9);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(255, 58);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Система управління ветеринарною клінікою";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblUsername
        // 
        lblUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        lblUsername.Location = new Point(12, 80);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(80, 23);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Логін:";
        lblUsername.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtUsername
        // 
        txtUsername.Font = new Font("Segoe UI", 11.25F);
        txtUsername.Location = new Point(95, 78);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(252, 27);
        txtUsername.TabIndex = 2;
        // 
        // lblPassword
        // 
        lblPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
        lblPassword.Location = new Point(12, 120);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(80, 23);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Пароль:";
        lblPassword.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 11.25F);
        txtPassword.Location = new Point(95, 118);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '●';
        txtPassword.Size = new Size(252, 27);
        txtPassword.TabIndex = 4;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(0, 120, 215);
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(12, 173);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(335, 30);
        btnLogin.TabIndex = 7;
        btnLogin.Text = "Увійти";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // labelError
        // 
        labelError.ForeColor = Color.FromArgb(231, 76, 60);
        labelError.Location = new Point(12, 146);
        labelError.Name = "labelError";
        labelError.Size = new Size(335, 23);
        labelError.TabIndex = 8;
        labelError.TextAlign = ContentAlignment.MiddleCenter;
        labelError.Visible = false;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = Properties.Resources.hospital;
        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(80, 50);
        pictureBox1.TabIndex = 9;
        pictureBox1.TabStop = false;
        // 
        // LoginForm
        // 
        ClientSize = new Size(359, 214);
        Controls.Add(pictureBox1);
        Controls.Add(labelError);
        Controls.Add(lblTitle);
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Вхід до системи";
        ((ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label lblPassword;

    #endregion

    private Label labelError;
    private PictureBox pictureBox1;
}