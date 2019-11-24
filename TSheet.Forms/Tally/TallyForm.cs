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
    public partial class TallyForm : Form
    {
        IWorkingTimeService _workingTimeService;
        IEmployeeService _employeeService;
        IWorkingLocationService _workingLocationService;
        public TallyForm(IWorkingTimeService workingTimeService, IEmployeeService employeeService, IWorkingLocationService workingLocationService)
        {
            _workingTimeService = workingTimeService;
            _employeeService = employeeService;
            _workingLocationService = workingLocationService;

            InitializeComponent();
        }

        private void TallyForm_Load(object sender, EventArgs e)
        {
            var employees = _employeeService.Get();
            foreach (Employee item in employees)
            {
                lbx_employee.Items.Add(item);
            }

            var locations = _workingLocationService.Get();
            foreach (var item in locations)
            {
                cmb_location.Items.Add(item);
            }
            cmb_location.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            List<WorkingTime> workingTimes = new List<WorkingTime>();
            WorkingLocation workingLocation = (WorkingLocation)cmb_location.SelectedItem;

            if (lbx_employee.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir çalışan seçiniz.");
            }
            else
            {
                
                foreach (Employee employee in lbx_employee.CheckedItems)
                {
                    var startDate = monthCalendar1.SelectionRange.Start;
                    var endDate = monthCalendar1.SelectionRange.End;
                    for (DateTime start = startDate; start <= endDate; start = start.AddDays(1.0))
                    {
                        WorkingTime workingTime = new WorkingTime
                        {
                            EmployeeID = employee.ID,
                            WorkingDate = start,
                            WorkingHours = (int)txt_hour.Value,
                            WorkingLocationID = workingLocation.ID
                        };
                        workingTimes.Add(workingTime);
                    }
                }
            }
            string result = _workingTimeService.AddRange(workingTimes);

            MessageBox.Show(result);

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
