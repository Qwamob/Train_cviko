using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public  class Wagon
    {
        public Wagon() { }

        public void ConnectToTrain(Train train)
        {
            train.ConnectWagon(this);
        }

        public void DisconnectToTrain(Train train)
        {
            train.DisconnectWagon(this);
        }
    }
}