using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace LibraryParking
{
    public class Garage : Parking
    {
        private Stack<IVehicle> spaces;

        public Garage()
        {
            spaces = new Stack<IVehicle>();
        }


        public override IVehicle GetVehicle() => spaces.Pop();

        public override void InsertVehicle(IVehicle veichle)
            => spaces.Push(veichle);


        protected override int GetTotal() => spaces.Count;
    }
}
