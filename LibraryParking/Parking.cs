using Vehicle;

namespace LibraryParking
{
    public abstract class Parking : IPlace
    {
        public int GetTotalVehicle()
        {
           return GetTotal();
        }

        protected abstract int GetTotal();

        public abstract IVehicle GetVehicle();

        public abstract void InsertVehicle(IVehicle veichle);
    }
}
