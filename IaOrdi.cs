using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jankenpon
{
    public class IaOrdi
    {
        public int Number { get; set; }
        private readonly Random random = new();


        //methode
        public string Display() 
        {
            if (Number == 1)
            {
                return"Ciseau";
            }
            if (Number == 2)
            {
                return "Pierre";
            }
            if (Number == 3)
            {
                return "Feuille";
            }

            return "";
        }

        public void IaPick()
        {
             Number= random.Next(1, 4);
        }
    }
}
