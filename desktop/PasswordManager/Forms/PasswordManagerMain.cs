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
        public PasswordManagerMain()
        {
            InitializeComponent();
            label2.Text += UserService.getToken();
        }

        private void PasswordManagerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
