using PasswordManager.Data_Objects;
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
    public partial class PasswordManagerMain : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _startPoint = new Point(0, 0);
        private List<PasswordObject> Passwords;
        private bool isNewPassword = true;
        public PasswordManagerMain()
        {
            InitializeComponent();
        }

        private void PasswordManagerMain_Load(object sender, EventArgs e)
        {
            update_text.Visible = false;
            save_text.Visible = true;
            delete_text.Visible = false;
            cancel_text.Visible = true;

            loadPasswords();
        }

        private void loadPasswords()
        {
            passwordList1.Rows.Clear();
            Passwords = UserService.GetPasswords();
            if (Passwords == null)
            {

            }
            else
            {
                foreach (PasswordObject p in Passwords)
                {
                    passwordList1.Rows.Add(p.Title);
                }
            }

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


        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void newPassword_Click(object sender, EventArgs e)
        {
            clearFields();
            isNewPassword = true;
            update_text.Visible = false;
            save_text.Visible = true;
            delete_text.Visible = false;
            cancel_text.Visible = true;
        }

        private void clearFields()
        {
            title.Clear();
            username.Clear();
            password.Clear();
            url.Clear();
            notes.Clear();
        }

        private void FillTextBoxWithPassword(PasswordObject p)
        {
            title.Text = p.Title;
            username.Text = p.Username;
            password.Text = p.Password;
            url.Text = p.Url;
            notes.Text = p.Notes;
        }

        private void passwordList1_Click(object sender, EventArgs e)
        {
            isNewPassword = false;
            update_text.Visible = true;
            save_text.Visible = false;
            delete_text.Visible = true;
            cancel_text.Visible = false;
            int rowIndex = passwordList1.SelectedCells[0].RowIndex;
            PasswordObject p = Passwords[rowIndex];
            FillTextBoxWithPassword(p);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (isNewPassword)
            {
                PasswordObject p = new PasswordObject();
                p.Title = title.Text;
                p.Username = username.Text;
                p.Password = password.Text;
                p.Url = url.Text;
                p.Notes = notes.Text;

                string response = UserService.SavePassword(p);
                MessageBox.Show(response);
                loadPasswords();
            }
            else
            {
                PasswordObject p = new PasswordObject();
                p.Title = title.Text;
                p.Username = username.Text;
                p.Password = password.Text;
                p.Url = url.Text;
                p.Notes = notes.Text;
                int rowIndex = passwordList1.SelectedCells[0].RowIndex;
                PasswordObject passwordobj = Passwords[rowIndex];
                string response = UserService.UpdatePassword(passwordobj.Id, p);
                MessageBox.Show(response);
                loadPasswords();
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (isNewPassword)
            {
                clearFields();
            }
            else
            {
                int rowIndex = passwordList1.SelectedCells[0].RowIndex;
                PasswordObject passwordobj = Passwords[rowIndex];
                UserService.DeletePassword(passwordobj.Id);
                loadPasswords();
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = "Uzunluk :" + trackBar1.Value.ToString();
            PasswordGenerateOptions options = new PasswordGenerateOptions();
            if (trackBar1.Value > 0)
            {
                if (upper.Checked)
                {
                    options.hasUpperCaseCharacters = true;
                }
                if (lower.Checked)
                {
                    options.hasLowerCaseCharacters = true;
                }
                if (num.Checked)
                {
                    options.hasNumericCharacters = true;
                }
                if (special.Checked)
                {
                    options.hasSpecialCharacters = true;
                }
                options.length = trackBar1.Value;

                string generatedPass = UserService.GeneratePassword(options);
                generatedPassword.Text = generatedPass;
            }
        }

        private void generate_exit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password.Text = generatedPassword.Text;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            trackBar1_Scroll(sender, e);
        }

        private void exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                LoginPage page = new LoginPage();
                page.Show();
                this.Hide();
            }
            
        }
    }
}
