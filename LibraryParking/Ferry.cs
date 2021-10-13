using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace LibraryParking
{
    public class Ferry : Parking
    {
        private Queue<IVehicle> spaces;

        public Ferry()
        {
            spaces = new Queue<IVehicle>();
        }

        public override IVehicle GetVehicle()
        {
            return spaces.Dequeue();
        }

        public override void InsertVehicle(IVehicle vehicle)
        {
            spaces.Enqueue(vehicle);
        }

        protected override int GetTotal()
        {
            return spaces.Count;
        }
    }
}
