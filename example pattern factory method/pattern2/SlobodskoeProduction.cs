using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    class SlobodskoeProduction : VyatushkaFacility
    {
        public override Products CreateProducts(string type)
        {
            Products product = new Products();

            if (type == "Kefir")
            {
                product = new SlobodskoyKefir();
            }
            else if (type == "Milk")
                product = new SlobodskoyMilk();
            else if (type == "Yogurt")
                product = new SlobodskoyYogurt();



            return product;
        }
    }
}
