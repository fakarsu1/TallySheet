using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSheet.Services.Concrete;

namespace TSheet.Forms
{
    public partial class LoginForm : Form
    {
        MainForm _mainForm;
        public LoginForm(MainForm mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _mainForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
