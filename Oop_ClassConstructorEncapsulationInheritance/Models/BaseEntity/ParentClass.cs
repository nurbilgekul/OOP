using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_DescriptionsandApplications
{

    //Inheritance: allows classes to inherit features of other classes, like from parent class to child class, supports reusability
    class ParentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreatedDate 
        { get=>_createDate; 
        set => _createDate = value;
        }
        
    }
}
