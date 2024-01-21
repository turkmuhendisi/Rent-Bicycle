using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Admin.UserControls.BicycleManagement
{
    class BicycleManagementController
    {
        private IBicycleManagement _view = BicycleManagementControl.GetInstance();
        private Bicycle bicycle = new Bicycle();

        public BicycleManagementController()
        {
            _view.AddButtonClicked += OnAddButtonClicked;
            _view.DeleteButtonClicked += OnDeleteButtonClicked;
        }

        public void OnAddButtonClicked(object sender, EventArgs e)
        {
            string quantityString = _view.Quantity;
            if (int.TryParse(quantityString, out int quantityInt))
            {
                // Dönüşüm başarılı, quantityInt değişkeni şimdi tam sayıya eşit.
                for (int i = 0; i < quantityInt; i++)
                {
                    // İşlemler
                    BicycleRepository bicycleRepository = new BicycleRepository(bicycle);
                    bicycle.DistrictId = _view.GetDistrictId + 1;
                    bicycle.IsAvailable = true;
                    bicycle.InMaintenance = false;
                    bicycleRepository.AddItem();
                    BicycleManagementControl.GetInstance().GetDataGridView();
                }
                DialogResult dialog = MessageBox.Show("Bisiklet Eklendi", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bisiklet Ekleme Başarısız!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        public void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            BicycleRepository bicycleRepository = new BicycleRepository(bicycle);
            if (_view.GetBicycleId != -1)
            {
                bicycle.BicycleId = _view.GetBicycleId;
                bicycleRepository.DeleteItem();
                BicycleManagementControl.GetInstance().GetDataGridView();
                DialogResult dialog = MessageBox.Show("Bisiklet Silindi", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
