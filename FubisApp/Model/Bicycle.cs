
namespace Fubis
{
    public class Bicycle
    {
        private int bicycleId;
        private bool isAvailable;
        private bool inMaintenance;
        private int districtId;

        public int BicycleId { get => bicycleId; set => bicycleId = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
        public bool InMaintenance { get => inMaintenance; set => inMaintenance = value; }
        public int DistrictId { get => districtId; set => districtId = value; }

        public Bicycle()
        {
        }

        public Bicycle(bool isAvailable, bool inMaintenance, int districtId)
        {
            this.isAvailable = isAvailable;
            this.inMaintenance = inMaintenance;
            this.districtId = districtId;
        }
    }
}
