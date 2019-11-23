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
using TSheet.Services.Concrete;

namespace TSheet.Forms
{
    public partial class EmployeeDeleteUpdateForm : Form
    {
        IEmployeeService _employeeService;
        IEmployeeTitleService _employeeTitleService;
        ISalaryTypeService _salaryTypeService;
        public EmployeeDeleteUpdateForm(IEmployeeService employeeService, IEmployeeTitleService employeeTitleService, ISalaryTypeService salaryTypeService)
        {
            _employeeService = employeeService;
            _employeeTitleService = employeeTitleService;
            _salaryTypeService = salaryTypeService;

            InitializeComponent();
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadEmployeeFormComboboxes();

        }
        void LoadEmployeeFormComboboxes()
        {
            List<EmployeeTitle> employeeTitles = _employeeTitleService.Get().ToList();
            foreach (var item in employeeTitles)
            {
                fc_title.Items.Add(item);
            }

            List<Employee> Employees = _employeeService.Get().ToList();
            fc_mgr.Items.Add(new Employee { FName = "Yok" });
            foreach (var item in Employees)
            {
                fc_mgr.Items.Add(item);
            }

            List<SalaryType> salaryTypes = _salaryTypeService.Get().ToList();
            foreach (var item in salaryTypes)
            {
                fc_stype.Items.Add(item);
            }
        }
        void LoadEmployees()
        {
            var Employees = _employeeService.Get().ToList();
            foreach (var item in Employees)
            {
                listBox1.Items.Add(item);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                var selectedEmp = (Employee)listBox1.SelectedItem;
                fc_fname.Text = selectedEmp.FName;
                fc_lname.Text = selectedEmp.LName;
                fc_tc.Text = selectedEmp.TC;
                fc_hiredate.Value = selectedEmp.HireDate;

                fc_phone.Text = selectedEmp.Phone;
                fc_mail.Text = selectedEmp.Email;
                fc_addres.Text = selectedEmp.Adress;
                fc_salary.Text = selectedEmp.Salary.ToString();

                foreach (EmployeeTitle item in fc_title.Items)
                {
                    if (selectedEmp.EmployeeTitleID == item.ID)
                    {
                        fc_title.SelectedItem = item;
                        break;
                    }
                }

                if (selectedEmp.ReportTo == null)
                {
                    fc_mgr.SelectedIndex = 0;
                }
                else
                {
                    foreach (Employee item in fc_mgr.Items)
                    {
                        if (selectedEmp.ReportTo == item.ID)
                        {
                            fc_mgr.SelectedItem = item;
                            break;
                        }
                    }

                }

                foreach (SalaryType item in fc_stype.Items)
                {
                    if (selectedEmp.SalaryTypeID == item.ID)
                    {
                        fc_stype.SelectedItem = item;
                        break;
                    }
                }
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedEmp = (Employee)listBox1.SelectedItem;
            DialogResult result = MessageBox.Show($"{selectedEmp.ToString()} adlı çalışanını silmek istediğinize emin misiniz?", "Çalışan Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _employeeService.Remove(selectedEmp);

                ClearFormAllControls(groupBox2);
                LoadEmployeeFormComboboxes();
                listBox1.Items.Clear();
                LoadEmployees();
            }


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var selectedEmp = (Employee)listBox1.SelectedItem;
            DialogResult result = MessageBox.Show($"{selectedEmp.ToString()} adlı çalışanını güncellemek istediğinize emin misiniz?", "Çalışan Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {

                selectedEmp.FName = fc_fname.Text;
                selectedEmp.LName = fc_lname.Text;
                selectedEmp.EmployeeTitleID = ((EmployeeTitle)fc_title.SelectedItem).ID;
                selectedEmp.TC = fc_tc.Text;
                selectedEmp.HireDate = fc_hiredate.Value;
                selectedEmp.Phone = fc_phone.Text;
                selectedEmp.Email = fc_mail.Text;
                selectedEmp.Adress = fc_addres.Text;
                selectedEmp.Salary = Convert.ToDecimal(fc_salary.Text);
                selectedEmp.SalaryTypeID = ((SalaryType)fc_stype.SelectedItem).ID;

                if (fc_mgr.SelectedIndex != 0)
                {
                    selectedEmp.ReportTo = ((Employee)fc_mgr.SelectedItem).ID;
                }
               

                int updateResult = _employeeService.Update(selectedEmp);
                
                if (updateResult >=1)
                {
                    MessageBox.Show("İşlem Başarılı.");
                }
                else
                {

                }

                ClearFormAllControls(groupBox2);
                LoadEmployeeFormComboboxes();
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

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
