using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Business : PersonalWagon
    {

        private Person steward;

        public Business(Person steward, int numberOfChairs) : base(numberOfChairs)
        {
            this.Steward = steward;
        }

        public Person Steward { get => steward; set => steward = value; }

        public override string? ToString()
        {
            string text;
            text = base.ToString();
            text += $" steward: " + steward.ToString();
            return text;
        }
    }
}