using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Chair
    {
        private bool nearWindow;
        private int number;
        private bool isReserved;

        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public int Number { get => number; set => number = value; }
        public bool IsReserved { get => isReserved; set => isReserved = value; }

        public Chair() { }

        public Chair(bool nearWindow, int number)
        {
            this.nearWindow = nearWindow;
            this.Number = number;
            this.IsReserved = false;
        }
    }
}