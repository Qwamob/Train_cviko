using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Hopper : Wagon
    {
        private double loadingCapacity;

        public Hopper(double loadingCapacity)
        {
            this.loadingCapacity = loadingCapacity;
        }

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

        public override string? ToString()
        {
            string className = GetType().Name;
            return $"{className} (loadingCapacity={loadingCapacity})";
        }
    }
}