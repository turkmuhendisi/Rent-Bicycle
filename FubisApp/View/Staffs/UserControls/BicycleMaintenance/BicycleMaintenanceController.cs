using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Staffs.UserControls.BicycleMaintenance
{
    class BicycleMaintenanceController
    {
        private IBicycleMaintenance _view = BicycleMaintenanceControl.GetInstance();
        private Bicycle bicycle = new Bicycle();

        public BicycleMaintenanceController()
        {
            _view.startMaintenanceButtonClicked += OnStartMaintenanceButtonClicked;
            _view.finishMaintenanceButtonClicked += OnFinishMaintenanceButtonClicked;
        }

        public void OnStartMaintenanceButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetBicycleId != -1)
            {
                bicycle.BicycleId = _view.GetBicycleId;
                if (_view.GetInMaintenance == false)
                {
                    bicycle.InMaintenance = true;
                    bicycle.IsAvailable = false;
                    BicycleRepository bicycleRepository = new BicycleRepository(bicycle);
                    bicycleRepository.UpdateItem();
                    BicycleMaintenanceControl.GetInstance().GetDataGridView();
                    DialogResult dialog = MessageBox.Show("Bisiklet Bakıma Alındı", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Bisiklet Zaten Bakımda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        public void OnFinishMaintenanceButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetBicycleId != -1)
            {
                bicycle.BicycleId = _view.GetBicycleId;
                if (_view.GetInMaintenance == true)
                {
                    bicycle.InMaintenance = false;
                    bicycle.IsAvailable = true;
                    BicycleRepository bicycleRepository = new BicycleRepository(bicycle);
                    bicycleRepository.UpdateItem();
                    BicycleMaintenanceControl.GetInstance().GetDataGridView();
                    DialogResult dialog = MessageBox.Show("Bisiklet Bakımı Başarıyla Tamamlandı", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Bisiklet Halihazırda Bakımda Değildi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
