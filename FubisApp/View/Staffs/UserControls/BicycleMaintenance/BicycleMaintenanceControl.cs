using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fubis.Model;
using Fubis.DataAccessLayer.Repository.impl;
using Fubis.DataAccessLayer;
using Fubis.DataAccessLayer.Model;

namespace Fubis.View.Staffs.UserControls.BicycleMaintenance
{
    public partial class BicycleMaintenanceControl : UserControl, IBicycleMaintenance
    {
        public BicycleMaintenanceControl()
        {
            InitializeComponent();
            startMaintenanceButton.Click += (sender, e) => startMaintenanceButtonClicked(this, EventArgs.Empty);
            finishMaintenanceButton.Click += (sender, e) => finishMaintenanceButtonClicked(this, EventArgs.Empty);
            instance = this;
            BicycleMaintenanceController controller = new BicycleMaintenanceController();
        }

        private static BicycleMaintenanceControl instance;

        public int GetBicycleId => GetRowBicycleId();

        public bool GetInMaintenance => GetRowInMaintenance();

        public static BicycleMaintenanceControl GetInstance()
        {
            if (instance == null)
            {
                instance = new BicycleMaintenanceControl();
            }
            return instance;
        }

        public event EventHandler startMaintenanceButtonClicked;
        public event EventHandler finishMaintenanceButtonClicked;

        public void GetDataGridView()
        {
            BicycleRepository bicycleRepository = new BicycleRepository();
            bicycleDataGridView.DataSource = bicycleRepository.GetBicycles(Staff.GetInstance().DistrictId);
        }

        private int GetRowBicycleId()
        {
            if (bicycleDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bicycleDataGridView.SelectedRows[0];
                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow.Cells["BICYCLE_ID"].Value);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bakım işlemleri için ilgili satırı seçiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        private bool GetRowInMaintenance()
        {
            if (bicycleDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bicycleDataGridView.SelectedRows[0];
                if (selectedRow != null)
                {
                    return Convert.ToBoolean(selectedRow.Cells["IN_MAINTENANCE"].Value);
                }
            }
            return false;
        }

        private void BicycleMaintenanceControl_Load(object sender, EventArgs e)
        {
            Staff.GetInstance().DistrictId = 1;
            StaffRepository staffRepository = new StaffRepository();
            DistrictRepository districtRepository = new DistrictRepository();
            string districtName = districtRepository.GetDistrictName(Staff.GetInstance().DistrictId);
            string fullName = staffRepository.GetServiceInformation(Staff.GetInstance().DistrictId);
            GetDataGridView();
            staffInformationLabel.Text = fullName + " - " + districtName;
        }
    }
}
