using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSheet.Forms
{
    public partial class MainForm : Form
    {
        EmployeeAddForm _employeeAddForm;
        EmployeeDeleteUpdateForm _employeeDeleteUpdateForm;
        LocationForm _locationForm;
        TallyForm _tallyForm;
        EmployeeTitleForm _employeeTitleForm;
        MonthlyTallySheetForm _monthlyTallySheetForm;
        public MainForm(EmployeeAddForm employeeAddForm, EmployeeDeleteUpdateForm employeeDeleteUpdateForm, LocationForm locationForm, TallyForm tallyForm, EmployeeTitleForm employeeTitleForm, MonthlyTallySheetForm monthlyTallySheetForm)
        {
            _employeeAddForm = employeeAddForm;
            _employeeDeleteUpdateForm = employeeDeleteUpdateForm;
            _locationForm = locationForm;
            _tallyForm = tallyForm;
            _employeeTitleForm = employeeTitleForm;
            _monthlyTallySheetForm = monthlyTallySheetForm;

            InitializeComponent();

            _employeeAddForm.MdiParent = this;
            _employeeDeleteUpdateForm.MdiParent = this;
            _locationForm.MdiParent = this;
            _tallyForm.MdiParent = this;
            _employeeTitleForm.MdiParent = this;
            _monthlyTallySheetForm.MdiParent = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }


        private void puantajGirişiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _tallyForm.Show();
        }


        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _employeeAddForm.Show();
        }

        private void güncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _employeeDeleteUpdateForm.Show();
        }

        private void lokasyonEkleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _locationForm.Show();
        }

        private void görevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _employeeTitleForm.Show();
        }

        private void çalışanPuantajCetveliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _monthlyTallySheetForm.Show();
        }
    }
}
