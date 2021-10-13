using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Bus : IVehicle
    {
        private int Seats = 55;
        private List<Person> passengers;

        public Bus()
        {
            passengers = new List<Person>();        
        }
        public int GetTotalPassenger() => passengers.Count;

        public bool Input(Person person)
        {
            if (passengers.Count >= Seats)
            {
                return false;
            }

            passengers.Add(person);
            return true;
        }

        public Person Output(int position)
        {
            var outputPerson = passengers.ElementAt(position);
            if (outputPerson != null)
            {
                passengers.RemoveAt(position);
            }
            return outputPerson;

        }

        public List<Person> GetPassenger()
        {
            return passengers;
        }
    }
}
