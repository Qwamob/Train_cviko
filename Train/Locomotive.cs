using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Locomotive
    {

        public Person driver;
        private Engine engine;

        public Locomotive()
        {
        }

        public Locomotive(Person driver, EngineType engineType)
        {
            this.driver = driver;
            this.Engine = new Engine(engineType);
        }

        public Engine Engine { get => engine; set => engine = value; }

        public override string? ToString()
        {
            return $" Driver: {driver} Engine: {Engine}";
        }
    }
}