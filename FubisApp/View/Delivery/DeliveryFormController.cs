using Fubis.DataAccessLayer.Repository.impl;
using Fubis.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fubis.View.Delivery
{
    class DeliveryFormController
    {
        private IDeliveryForm _view = DeliveryForm.GetInstance();
        private User user = new User();
        private Bicycle bicycle = new Bicycle();

        public DeliveryFormController()
        {
            _view.DeliveryButtonClicked += OnDeliveryButtonClicked;
        }

        public object Threads { get; private set; }

        private void OnDeliveryButtonClicked(object sender, EventArgs e)
        {
            if (_view.GetCardNumber.Length == 16)
            {
                if (CardRepository.IsAvailableCard(_view.GetCardNumber))
                {
                    if (RentalRepository.Rentalable(_view.GetCardNumber))
                    {
                        user.UserId = UserRepository.GetUserId(_view.GetCardNumber);
                        bicycle.IsAvailable = true;

                        RentalService rentalService = new RentalService();
                        rentalService.DeliveryBicycle(user.UserId.ToString());
                        RentalRepository rentalRepository = new RentalRepository(user, bicycle);
                        rentalRepository.UpdateItem();
                        rentalRepository.DeleteRentalReport(user.UserId.ToString());

                        DialogResult dialog = MessageBox.Show($"{rentalService.ShowBicycleNumber()} numaralı bisiklet teslim edildi.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Thread.Sleep(3000);
                        HomeForm.GetInstance().Show();
                        DeliveryForm.GetInstance().Close();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Teslim edilecek bir bisiklet yok!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Thread.Sleep(3000);
                        HomeForm.GetInstance().Show();
                        DeliveryForm.GetInstance().Close();
                    }      
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Böyle bir kart mevcut değil!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Lütfen geçerli bir değer giriniz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
