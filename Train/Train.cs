using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Train
    {
        private Locomotive locomotive;
        private List<Wagon> wagons;
        public Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        public List<Wagon> Wagons { get => wagons; set => wagons = value; }



        public Train(Locomotive locomotive)
        {
            this.Locomotive = locomotive;
            this.Wagons = new List<Wagon>();
        }

        public void ConnectWagon(Wagon wagon)
        {
            bool steamLocomotive = false;
            if (this.locomotive.Engine.Type == EngineType.Steam)
            {
                steamLocomotive = true;
            }
            if (steamLocomotive && this.Wagons.Count >= 5)
            {
                Console.WriteLine("Nelze pripojit vice nez pet vagonu k parni lokomotive");
            }
            else
            {
                this.Wagons.Add(wagon);
            }
        }

        public void DisconnectWagon(Wagon wagon)
        {
            this.Wagons.Remove(wagon);
        }
        public void ReserveChair(int wagonNumber, int seatNumber)
        {
            if (wagonNumber < 0 || wagonNumber >= Wagons.Count)
            {
                Console.WriteLine("Vagon neexistuje");
                return;
            }

            var wagon = Wagons[wagonNumber];
            if (!(wagon is PersonalWagon))
            {
                Console.WriteLine("Tento vagon nema sedadla.");
                return;
            }

            var personalWagon = (PersonalWagon)wagon;
            var chair = personalWagon.Sits.FirstOrDefault(c => c.Number == seatNumber);

            if (chair == null)
            {
                Console.WriteLine("Sedadlo neexistuje v tomto vagonu.");
                return;
            }

            if (chair.IsReserved)
            {
                Console.WriteLine("Sedadlo je již obsazeno.");
                return;
            }

            chair.IsReserved = true;
            Console.WriteLine("Sedadlo uspesne zarezervovano.");
        }

        public void ListReservedChairs()
        {
            for (int i = 0; i < Wagons.Count; i++)
            {
                if (Wagons[i] is PersonalWagon)
                {
                    var personalWagon = (PersonalWagon)Wagons[i];
                    var number = Wagons.IndexOf(personalWagon);
                    Console.WriteLine($"Vagon {number}:");
                    foreach (var chair in personalWagon.Sits)
                    {
                        if (chair.IsReserved)
                        {
                            Console.WriteLine($"Sedadlo {chair.Number} je rezervováno.");
                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Lokomotiva: {locomotive.ToString()}");
            sb.AppendLine("Seznam vagonů:");
            foreach (var wagon in Wagons)
            {
                sb.AppendLine(wagon.ToString());
            }
            return sb.ToString();
        }


    }
}