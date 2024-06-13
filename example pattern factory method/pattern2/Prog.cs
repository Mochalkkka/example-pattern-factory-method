using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    class Prog
    {
        static void Main(string[] args)
        {
            VyatushkaFacility facility = new KirivskoeProduction();
            facility.GetProducts("Kefir");
            facility.GetProducts("Milk");
            facility.GetProducts("Yogurt");

            Console.ReadLine();
        }
    }
}
