using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    public class Products
    {
        protected string name = "";
        protected string package = "bottle";
        protected string volume = "1 liter";
        protected string category = "dairy";
        protected string date = "13.05.2024";

        public void Configure()
        {
            Console.WriteLine("Product {0}", name);
            Console.WriteLine("Tipe og package {0}", package);
            Console.WriteLine("Volume package {0}", volume);
            Console.WriteLine("Зroduct category {0}", category);
            Console.WriteLine("Date of manufacture {0}", date);
        }

        public void PreparedPackage()
        {
            Console.WriteLine("Packaging prepared!");
        }

        public void СorrespondingСategory()
        {
            Console.WriteLine("Сategory matches!");
        }

        public void SuitableVolume() 
        {
            Console.WriteLine("Suitable volume!");
        }

        public void СorrectleDate()
        {
            Console.WriteLine("Correct date");
        }


    }
}
