using System;
using System.Windows.Forms;
using Fubis.DataAccessLayer;
using Fubis.DataAccessLayer.Model;
using Fubis.DataAccessLayer.Repository.impl;

namespace Fubis.View.Admin.UserControls.BicycleManagement
{
    public partial class BicycleManagementControl : UserControl, IBicycleManagement
    {
        private static BicycleManagementControl instance;
        public static BicycleManagementControl GetInstance()
        {
            if (instance == null)
            {
                instance = new BicycleManagementControl();
            }

            return instance;
        }
        public BicycleManagementControl()
        {
            InitializeComponent();
            addButton.Click += (sender, e) => AddButtonClicked(this, EventArgs.Empty);
            deleteButton.Click += (sender, e) => DeleteButtonClicked(this, EventArgs.Empty);
            instance = this;
            BicycleManagementController controller = new BicycleManagementController();
        }

        public string Quantity => addField.Text.Trim();

        public int GetDistrictId => districtListBox.SelectedIndex;

        public int GetBicycleId => GetRowBicycleId();

        public event EventHandler AddButtonClicked;
        public event EventHandler DeleteButtonClicked;

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
                DialogResult dialog = MessageBox.Show("Kaldırmak istediğiniz satırı seçiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public void GetDataGridView()
        {
            if (districtListBox.SelectedItem != null)
            {
                BicycleRepository bicycleRepository = new BicycleRepository();
                string selectedDistrictName = districtListBox.SelectedItem.ToString();
                bicycleDataGridView.DataSource = bicycleRepository.ShowTableInDataGridView(selectedDistrictName);

                StaffRepository staffRepository = new StaffRepository();

                serviceStaffInformationLabel.Visible = true;
                serviceStaffInformationLabel.Text =
                    "Teknik servis sorumlusu: " +
                    (staffRepository.GetServiceInformation(GetDistrictId + 1) != null ? staffRepository.GetServiceInformation(GetDistrictId + 1) : "Atanmamış");
            }
        }

        private void BicycleManagementControl_Load(object sender, EventArgs e)
        {
            DistrictRepository districtRepository = new DistrictRepository();
            string[] columnData = districtRepository.GetDistrictNameForList();
            districtListBox.Items.AddRange(columnData);
        }

        private void districtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataGridView();
        }
    }
}
