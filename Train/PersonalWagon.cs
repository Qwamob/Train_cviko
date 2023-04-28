using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    abstract public class PersonalWagon : Wagon
    {
        private List<Door> doors;
        private List<Chair> sits;
        private int numberOfChairs;

        protected PersonalWagon(int numberOfChairs)
        {
            this.numberOfChairs = numberOfChairs;
            this.Sits = new List<Chair>(numberOfChairs);
            for (int i = 0; i < numberOfChairs; i++)
            {
                this.Sits.Add(new Chair(false, i + 1)); // assuming seat numbering starts from 1
            }
        }

        public List<Door> Doors { get => doors; set => doors = value; }
        public List<Chair> Sits { get => sits; set => sits = value; }
        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }

        public override string? ToString()
        {

            string className = GetType().Name;
            return $"{className} počet sedadel={numberOfChairs}";

        }

    }
}