using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_DescriptionsandApplications.Models.Entities
{
    //Inheritance: allows classes to inherit features of other classes, like parent class to child class, supports reusability
    class Shoes :ParentClass
    {
        public string Description { get; set; }
        private decimal _price;
        public decimal UnitPrice
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
            }
        }
        private int _stock;

        public int UnitinStock
        {
            get => _stock;
            set
            {
                if (value > 0)
                    _stock = value;

            }

        }
    }
}
