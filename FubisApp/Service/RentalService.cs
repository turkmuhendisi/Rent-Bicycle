using Fubis.DataAccessLayer.Repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fubis.Service
{
    public class RentalService
    {
        private Bicycle bicycle = new Bicycle();
        private User user = new User();
        private int bicycleNumber;

        public RentalService()
        {
        }

        public void RentBicycle(string userId)
        {
            BicycleRepository bicycleRepository = new BicycleRepository();
            string bicycleId = bicycleRepository.GetAvailableBicycle();

            user.UserId = Convert.ToInt32(userId);
            bicycle.IsAvailable = false;
            bicycleNumber = Convert.ToInt32(bicycleId);
            bicycle.BicycleId = bicycleNumber;

            RentalRepository rentalRepository = new RentalRepository(user, bicycle);
            rentalRepository.AddItem();
            rentalRepository.UpdateItem();
        }

        public int ShowBicycleNumber()
        {
            return bicycleNumber;
        }

        public void DeliveryBicycle(string userId)
        {
            bicycle.IsAvailable = true;
            bicycleNumber = RentalRepository.GetBicycleId(userId);
            bicycle.BicycleId = bicycleNumber;

            RentalRepository rentalRepository = new RentalRepository(user, bicycle);
            rentalRepository.UpdateItem();
        }
    }
}
