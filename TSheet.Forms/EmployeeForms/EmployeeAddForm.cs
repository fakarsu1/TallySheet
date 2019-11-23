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
using TSheet.Services.Concrete;
using TSheet.Services.Abstract;

namespace TSheet.Forms
{
    public partial class EmployeeAddForm : Form
    {
        IEmployeeService _employeeService;
        IEmployeeTitleService _employeeTitleService;
        ISalaryTypeService _salaryTypeService;

        public EmployeeAddForm(IEmployeeService employeeService, IEmployeeTitleService employeeTitleService, ISalaryTypeService salaryTypeService)
        {
            _employeeService = employeeService;
            _employeeTitleService = employeeTitleService;
            _salaryTypeService = salaryTypeService;

            InitializeComponent();
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {
            ClearFormComboBoxes(groupBox1);
            LoadEmployeeFormComboboxes();
        }
        void LoadEmployeeFormComboboxes()
        {
            List<EmployeeTitle> employeeTitles = _employeeTitleService.Get().ToList();
            foreach (var item in employeeTitles)
            {
                fc_title.Items.Add(item);
            }
            fc_title.SelectedIndex = 0;

            List<Employee> Employees = _employeeService.Get().ToList();
            fc_mgr.Items.Add(new Employee { FName = "Yok" });
            if (Employees.Count>0)
            {
                foreach (var item in Employees)
                {
                    fc_mgr.Items.Add(item);
                }
            }
            fc_mgr.SelectedIndex = 0;

            
            List<SalaryType> salaryTypes = _salaryTypeService.Get().ToList();
            foreach (var item in salaryTypes)
            {
                fc_stype.Items.Add(item);
            }
            fc_stype.SelectedIndex = 0;
        }

        void ClearFormComboBoxes(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).Items.Clear();
                }
            }
        }

        void ClearFormAllControls(GroupBox groupBox)
        {
            foreach (var item in groupBox.Controls)
            {
                if (item is TextBoxBase)
                {
                    ((TextBoxBase)item).Clear();

                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).Items.Clear();
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {


            Employee newEmp = new Employee
            {
                FName = fc_fname.Text,
                LName = fc_lname.Text,
                EmployeeTitleID = ((EmployeeTitle)fc_title.SelectedItem).ID,
                TC = fc_tc.Text,
                HireDate = fc_hiredate.Value,
                Phone = fc_phone.Text,
                Email = fc_mail.Text,
                Adress = fc_addres.Text,
                Salary = Convert.ToDecimal(fc_salary.Text),
                SalaryTypeID = ((SalaryType)fc_stype.SelectedItem).ID
            };


            if (fc_mgr.SelectedIndex != 0)
            {
                newEmp.ReportTo = ((Employee)fc_mgr.SelectedItem).ID;
            }


           
            int result = _employeeService.Add(newEmp);
            if (result >= 1)
            {
                MessageBox.Show("Çalışan Başarıyla Eklendi.");

                ClearFormAllControls(groupBox1);
                LoadEmployeeFormComboboxes();

            }
            else
            {
                MessageBox.Show("Çalışan Eklenemedi.");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            ClearFormAllControls(groupBox1);
            e.Cancel = true;
        }
    }
}
