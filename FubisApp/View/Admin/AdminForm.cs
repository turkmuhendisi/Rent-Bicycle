using Fubis.View.Admin.ModeratorManagement;
using Fubis.View.Admin.UserControls.BicycleManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fubis.View.Admin
{
    public partial class AdminForm : Form
    {

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        public AdminForm()
        {
            InitializeComponent();
        }

        private void bicycleManagementButton_Click(object sender, EventArgs e)
        {
            BicycleManagementControl bicycleManagementControl = new BicycleManagementControl();
            addUserControl(bicycleManagementControl);
        }

        private void districtManagementButton_Click(object sender, EventArgs e)
        {
            ModeratorManagementControl moderatorManagementControl = new ModeratorManagementControl();
            addUserControl(moderatorManagementControl);
        }

        private void BicycleManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            HomeForm.GetInstance().Show();
            this.Close();
        }
    }
}
