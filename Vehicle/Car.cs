using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car : IVehicle
    {
        private int Seats = 5;
        private Person[] passengers;


        public Car()
        {
            passengers = new Person[Seats];
        }

        public Car(int quantityPassengers)
        {
            Seats = quantityPassengers;
            passengers = new Person[Seats];
        }

        public int GetTotalPassenger()
        {
            int totalPassengers = 0;

            for (int i = 0; i < passengers.Length; i++)
            {
                if (passengers[i] != null)
                    totalPassengers++;
            }
            return totalPassengers;
        }

        public bool Input(Person person)
        {
            if (GetTotalPassenger() < Seats)
            {
                for (int i = 0; i < passengers.Length; i++)
                {
                    if (passengers[i] == null)
                    {
                        passengers[i] = person;
                        return true;
                    }
                }
            }
            return false;
        }

        public Person Output(int position)
        {
            if (position > Seats)
                return null;
            var outputPerson = passengers[position];
            passengers[position] = null;
            return outputPerson;
        }
    }
}
