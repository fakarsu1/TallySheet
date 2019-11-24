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
    public partial class MonthlyTallySheetForm : Form
    {
        IEmployeeService _employeeService;
        IWorkingTimeService _workingTimeService;
        public MonthlyTallySheetForm(IEmployeeService employeeService, IWorkingTimeService workingTimeService)
        {
            _employeeService = employeeService;
            _workingTimeService = workingTimeService;
            InitializeComponent();
        }

        private void MonthlyTallySheetForm_Load(object sender, EventArgs e)
        {
            FillEmployees();
            SetPickersDateTimeNow();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            List<WorkingTime> result = null;
            Employee employee = (Employee)comboBox1.SelectedItem;
            int year = (int)year_picker.Value;
            int month = (int)month_picker.Value;
            if (employee != null)
            {
                result = _workingTimeService.GetMonthlyWorkingTime(employee, month, year);
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            #region dataGridView1
           
            if (result.Count > 0)
            {
                // dataGridView1 columns
                dataGridView1.Columns.Add("TC", "TC No");
                dataGridView1.Columns.Add("Name", "Ad Soyad");

                for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
                {
                    DateTime date = new DateTime(year, month, i);

                    bool isWeekEnd = false;
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        isWeekEnd = true;
                    }
                    var dgc = new DataGridViewColumn
                    {
                        Name = $"{i}",
                        HeaderText = $"{i}",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,

                        CellTemplate = new DataGridViewTextBoxCell(),
                        DefaultCellStyle = new DataGridViewCellStyle { BackColor = isWeekEnd ? Color.LightBlue : Color.LightGray, NullValue = "X" }
                    };
                    dataGridView1.Columns.Add(dgc);
                }
                dataGridView1.Columns.Add("Date", "Puantaj Dönemi");


                // dataGridView1 data
                dataGridView1.Rows.Add();
                var dr = dataGridView1.Rows[0];
                dr.Cells["TC"].Value = employee.TC;
                dr.Cells["Name"].Value = employee.GetFullName();
                foreach (var item in result)
                {
                    dr.Cells[$"{item.WorkingDate.Day}"].Value = item.WorkingHours;
                }
                dr.Cells["Date"].Value = $"{month}/{year}";
            }
            else
            {
                MessageBox.Show("Aranan koşullarda veri bulunamadı.");
            }
            #endregion

            #region dataGridView2
            // dataGridView2 columns
            //dataGridView2.Columns.Add("WorkingDays", "Çalışma Günü  Sayısı");
            //    dataGridView2.Columns.Add("HoliDays", "Tatil Günü Sayısı");
                // dataGridView2 data
                // feature property
            
            #endregion
            


        }
        private void FillEmployees()
        {
            List<Employee> employees = _employeeService.Get().ToList();
            foreach (var item in employees)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void SetPickersDateTimeNow()
        {
            month_picker.Value = DateTime.Now.Month;
            year_picker.Value = DateTime.Now.Year;
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
