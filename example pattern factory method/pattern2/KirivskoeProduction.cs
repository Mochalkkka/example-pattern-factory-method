using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    class KirivskoeProduction : VyatushkaFacility
    {
        public override Products CreateProducts(string type)
        {
            Products product = new Products();

            if (type == "Kefir")
            {
                product = new KirovskyKefir();
            }
            else if (type == "Milk")
                product = new KirovskyMilk();
            else if (type == "Yogurt")
                product = new KirovskyYogurt();



            return product;
        }
    }
}
