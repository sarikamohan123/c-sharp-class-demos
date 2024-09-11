using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Product_class_inheritance
{
    abstract internal class Product
        
    {
        // base class
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }


        // constructor for product
       /* public Product(string name, decimal price)
        {
            ProductName = name;
            ProductPrice = price;
        }*/


    }
    // appliance class inheriting from class Product
    internal class Appliance : Product
    {
        public int ApplianceId { get; set; }
        public string ApplianceBrand { get; set; }
        public string ApplianceName { get; set; }


        // class Electronics inheriting from class Product
        internal class Electronics : Product
        {
            public int WarrantyInMonths { get; set; }
        }

        // class TV inheriting from Electronics
        internal class TV : Electronics
        {
            public int Screensize { get; set; }
            public string BrandName{ get; set; }
        }

        //Class computer inheriting from Electronics
        internal class Computer : Electronics
        {
            public string Processor { get; set; }
        }


        // class stove inheriting from Appliance
        internal class Stove : Appliance
        {
            public int StoveId { get; set; }
        }

        // class toys inheriting from Product
        internal class toys : Product
        {
            public string category { get; set; }
        }
    }
}
