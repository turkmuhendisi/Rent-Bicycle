
namespace Fubis
{
    public class Bicycle
    {
        private int bicycleId;
        private bool isAvailable;

        public int BicycleId { get => bicycleId; set => bicycleId = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public Bicycle()
        {
        }

        public Bicycle(int bicycleId, bool isAvailable)
        {
            this.bicycleId = bicycleId;
            this.isAvailable = isAvailable;
        }
    }
}
