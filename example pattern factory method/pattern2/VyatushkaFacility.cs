using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    abstract class VyatushkaFacility
    {
        //private SimpleFactory _factory;

        //public VyatushkaFacility(SimpleFactory factory)
        //{
        //    _factory = factory;
        //}

        public Products GetProducts(string type)
        {
            //Products product = _factory.GetProducts(type);
            Products product = CreateProducts(type);


            product.Configure();
            product.PreparedPackage();
            product.СorrespondingСategory();
            product.SuitableVolume();
            product.СorrectleDate();

            return product;
        }

        public abstract Products CreateProducts(string type);
    }
}
