using Vehicle;

namespace LibraryParking
{
    public interface IPlace
    {
        void InsertVehicle(IVehicle veichle);

        IVehicle GetVehicle();

        int GetTotalVehicle();
    }
}
