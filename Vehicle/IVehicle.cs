using People;

namespace Vehicle
{
    public interface IVehicle
    {
        bool Input(Person person);

        Person Output(int position);

        int GetTotalPassenger();
    }
}
