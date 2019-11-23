using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSheet.Core.Domain;
using TSheet.Services.Abstract;

namespace TSheet.Forms
{
    public partial class EmployeeTitleForm : Form
    {
        IEmployeeTitleService _employeeTitleService;
        public EmployeeTitleForm(IEmployeeTitleService employeeTitleService)
        {
            _employeeTitleService = employeeTitleService;
            InitializeComponent();
        }

        private void EmployeeTitleForm_Load(object sender, EventArgs e)
        {
            FillTitles();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var title = new EmployeeTitle { Name = txt_name.Text };
            var result = _employeeTitleService.Add(title);
            if (result >= 0)
            {
                MessageBox.Show("İşlem Başarılı.");
                FillTitles();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedtitle = (EmployeeTitle)listBox1.SelectedItem;
            _employeeTitleService.Remove(selectedtitle);
            FillTitles();
        }

        void FillTitles()
        {
            listBox1.Items.Clear();
            var titles = _employeeTitleService.Get();

            if (titles.Count > 0)
            {
                foreach (var item in titles)
                {
                    listBox1.Items.Add(item);
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
