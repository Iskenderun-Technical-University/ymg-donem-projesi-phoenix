using PasswordManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    internal partial class RegisterPage : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);

        public RegisterPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void visible_MouseDown(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void visible_MouseUp(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = true;
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

        private void register_Click(object sender, EventArgs e)
        {
            if (isFieldEmpty(email.Text) && isFieldEmpty(name.Text) && isFieldEmpty(password.Text))
            {
                MessageBox.Show("Fields can't be empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RegistrationRequest registrationRequest = new RegistrationRequest(name.Text, email.Text, password.Text);
                var response = UserService.Register(registrationRequest);
                if (!response.isResultSuccess())
                {
                    MessageBox.Show("Registration failed." + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(response.Message());
                    AccountVerificationPage verificationPage = new AccountVerificationPage();
                    verificationPage.Show();
                }
            }

        }

        private bool isFieldEmpty(string str)
        {
            if (str.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
