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
    public partial class ForgotPassword : Form
    {

        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);

        public ForgotPassword()
        {
            InitializeComponent();
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

        private void ForgotPasswor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reset_password_Click(object sender, EventArgs e)
        {
            if (password1.Text.Equals(password_r.Text))
            {
                string response = UserService.ResetPassword(code.Text, password1.Text);
                MessageBox.Show(response);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords must be same", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            password1.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            password1.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            password_r.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            password_r.UseSystemPasswordChar = true;
        }
    }
}
