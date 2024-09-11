using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurachProductManager.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description {  get; set; }
        public decimal Price { get; set; }

        // constructor

        public Product( int id, string code,string description, decimal price) 
        {
            Id = id;
            Code = code;
            Description = description;
            Price = price;
        }
        //Default constractor
        public Product() 
        {
            Id = 0;
            Code = "";
            Description = "";
            Price = 0;
        }

        public override string ToString() 
        { 
            return $"Product :  Id : {Id}  Code : {Code} Description : {Description} Price  : {Price}"; 
        }
    }
}
