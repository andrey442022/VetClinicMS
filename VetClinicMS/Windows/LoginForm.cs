namespace VetClinicMS.Windows;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    public string Role { get; set; }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        var role = await Program.loginService.Login(txtUsername.Text, txtPassword.Text);

        if (string.IsNullOrEmpty(role))
        {
            labelError.Visible = true;
            labelError.Text = "Логін або парольне не вірний";
        }
        else
        {
            Role = role;
            DialogResult = DialogResult.OK;
        }
    }

    private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
    }
}