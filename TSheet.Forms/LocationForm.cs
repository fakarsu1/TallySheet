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
    public partial class LocationForm : Form
    {
        IWorkingLocationService _workingLocationService;
        public LocationForm(IWorkingLocationService workingLocationService)
        {
            _workingLocationService = workingLocationService;
            InitializeComponent();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {

            FillLocations();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var location = new WorkingLocation { Name = txt_name.Text };
            var result =_workingLocationService.Add(location);
            if (result>= 0)
            {
                MessageBox.Show("İşlem Başarılı.");
                FillLocations();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var selectedLocation = (WorkingLocation)listBox1.SelectedItem;
            _workingLocationService.Remove(selectedLocation);
            FillLocations();
        }

        void FillLocations()
        {
            listBox1.Items.Clear();
            var locations = _workingLocationService.Get();

            if (locations.Count > 0)
            {
                foreach (var item in locations)
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
