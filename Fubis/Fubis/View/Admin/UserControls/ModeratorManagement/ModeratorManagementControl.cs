using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fubis.View.Admin.UserControls.ModeratorManagement;
using Fubis.Model;
using Fubis.DataAccessLayer.Repository.impl;
using Fubis.DataAccessLayer;
using Fubis.Service;

namespace Fubis.View.Admin.ModeratorManagement
{
    public partial class ModeratorManagementControl : UserControl, IModeratorManagement
    {
        public ModeratorManagementControl()
        {
            InitializeComponent();
            addButton.Click += (sender, e) => AddButtonClicked(this, EventArgs.Empty);
            updateButton.Click += (sender, e) => UpdateButtonClicked(this, EventArgs.Empty);
            deleteButton.Click += (sender, e) => DeleteButtonClicked(this, EventArgs.Empty);
            instance = this;
            ModeratorManagementController controller = new ModeratorManagementController();
        }
        private static ModeratorManagementControl instance;
        public static ModeratorManagementControl GetInstance()
        {
            if (instance == null)
            {
                instance = new ModeratorManagementControl();
            }
            return instance;
        }

        public int GetStaffId => GetRowStaffId();
        public string GetFirstName => firstNameField.Text.Trim();
        public string GetLastName => lastNameField.Text.Trim();
        public string GetRole => GetRoleSelection();
        public int GetDistrcitId => districtListBox.SelectedIndex + 1;


        public event EventHandler AddButtonClicked;
        public event EventHandler UpdateButtonClicked;
        public event EventHandler DeleteButtonClicked;

        public string GetRoleSelection()
        {
            DialogResult dialog;
            if (moderatorRadioButton.Checked == true)
            {
                return Role.MODERATOR.ToString();
            }
            else if (serviceRadioButton.Checked == true)
            {
                return Role.SERVICE.ToString();
            }
            else
            {
                dialog = MessageBox.Show("Lütfen bir rol seçiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dialog.ToString();
        }

        public bool IsSelected()
        {
            if (moderatorRadioButton.Checked == false && serviceRadioButton.Checked == false)
            {
                return false;
            }
            return true;
        }

        private int GetRowStaffId()
        {
            if (bicycleDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bicycleDataGridView.SelectedRows[0];
                if (selectedRow != null)
                {
                    return Convert.ToInt32(selectedRow.Cells["STAFF_ID"].Value);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Kaldırmak istediğiniz satırı seçiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public bool CheckRoleCount()
        {
            StaffRepository staffRepository = new StaffRepository();
            int moderatorCount = staffRepository.GetModeratorRoleCount(GetDistrcitId);

            int serviceCount = staffRepository.GetServiceRoleCount(GetDistrcitId);

            bool canAddModerator = moderatorCount < 1;
            bool canAddService = serviceCount < 1;

            if (GetRoleSelection() == "MODERATOR" && canAddModerator)
            {
                return true;
            }
            else if (GetRoleSelection() == "SERVICE" && canAddService)
            {
                return true;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Aynı role sahip yalnızca bir kişi ekleyebilirsiniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        public void GetDataGridView()
        {
            if (districtListBox.SelectedItem != null)
            {
                StaffRepository staffRepository = new StaffRepository();
                string selectedDistrictName = districtListBox.SelectedItem.ToString();
                bicycleDataGridView.DataSource = staffRepository.ShowTableInDataGridView(selectedDistrictName);
            }
        }

        private void districtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataGridView();
        }

        private void ModeratorManagementControl_Load(object sender, EventArgs e)
        {
            DistrictRepository districtRepository = new DistrictRepository();
            string[] columnData = districtRepository.GetDistrictNameForList();
            districtListBox.Items.AddRange(columnData);
        }
    }
}
