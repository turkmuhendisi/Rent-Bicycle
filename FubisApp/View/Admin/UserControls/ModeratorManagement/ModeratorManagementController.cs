using Fubis.DataAccessLayer.Model;
using Fubis.DataAccessLayer.Repository.impl;
using Fubis.Service;
using Fubis.View.Admin.ModeratorManagement;
using System;
using System.Windows.Forms;

namespace Fubis.View.Admin.UserControls.ModeratorManagement
{
    class ModeratorManagementController
    {
        private IModeratorManagement _view = ModeratorManagementControl.GetInstance();
        private Staff staff = new Staff();

        public ModeratorManagementController()
        {
            _view.AddButtonClicked += OnAddButtonClicked;
            _view.DeleteButtonClicked += OnDeleteButtonClicked;
            _view.UpdateButtonClicked += OnUpdateButtonClicked;
        }

        public void OnAddButtonClicked(object sender, EventArgs e)
        {
            if (ModeratorManagementControl.GetInstance().IsSelected() && ModeratorManagementControl.GetInstance().CheckRoleCount())
            {
                CardNumberGenerator cardNumberGenerator = new CardNumberGenerator();
                staff.FirstName = _view.GetFirstName;
                staff.LastName = _view.GetLastName;
                staff.Role = _view.GetRole;
                if (staff.Role == "MODERATOR")
                { 
                    staff.StaffCardNumber = cardNumberGenerator.GeneratedCardNumberForModerator();
                }
                else
                {
                    staff.StaffCardNumber = cardNumberGenerator.GeneratedCardNumberForService();
                }
                staff.DistrictId = _view.GetDistrcitId;

                StaffRepository staffRepository = new StaffRepository(staff);
                staffRepository.AddItem();
                ModeratorManagementControl.GetInstance().GetDataGridView();
                DialogResult dialog = MessageBox.Show("Personel Eklendi", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetStaffId != -1 && ModeratorManagementControl.GetInstance().CheckRoleCount())
            {
                staff.FirstName = _view.GetFirstName;
                staff.LastName = _view.GetLastName;
                staff.Role = _view.GetRole;
                staff.DistrictId = _view.GetDistrcitId;
                staff.StaffId = _view.GetStaffId;

                StaffRepository staffRepository = new StaffRepository(staff);
                staffRepository.UpdateItem();
                ModeratorManagementControl.GetInstance().GetDataGridView();
                DialogResult dialog = MessageBox.Show("Personel Bilgileri Güncellendi", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetStaffId != -1)
            {
                staff.StaffId = _view.GetStaffId;
                StaffRepository staffRepository = new StaffRepository(staff);
                staffRepository.DeleteItem();
                ModeratorManagementControl.GetInstance().GetDataGridView();
                DialogResult dialog = MessageBox.Show("Personel Silindi", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
