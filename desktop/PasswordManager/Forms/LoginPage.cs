using PasswordManager.Forms;
using PasswordManager.Services;
using System.Drawing.Drawing2D;

namespace PasswordManager
{
    internal partial class LoginPage : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);

        public LoginPage()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var response = UserService.Login(email.Text, password.Text);
            if (!response.isResultSuccess())
            {
                MessageBox.Show("Invalid credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PasswordManagerMain main = new PasswordManagerMain();
                main.Show();
                this.Hide();
            }
        }

        private void panel_tab_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void panel_tab_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this._startPoint.X, point.Y - this._startPoint.Y);
            }
        }

        private void panel_tab_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (password.Text.Length > 0)
            {
                visible.Visible = true;
            }
            else
            {
                visible.Visible = false;
            }
        }

        private void visible_MouseDown(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void visible_MouseUp(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void visible_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountVerificationPage verificationPage = new AccountVerificationPage();
            verificationPage.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordRequest request = new ForgotPasswordRequest();
            request.Show();
        }
    }
}