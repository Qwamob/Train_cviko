using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public enum EngineType
    {
        Diesel,
        Electric,
        Steam
    }

    public class Engine
    {
        private EngineType type;
        public EngineType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Engine(EngineType type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return "Engine Type: " + type.ToString();
        }
    }
}