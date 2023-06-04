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
    public partial class ForgotPasswordRequest : Form
    {
        public ForgotPasswordRequest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = UserService.RequestPasswordReset(email.Text);
            MessageBox.Show(message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
