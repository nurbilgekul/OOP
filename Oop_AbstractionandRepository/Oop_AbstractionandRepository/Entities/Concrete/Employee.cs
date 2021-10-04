using Oop_AbstractionandRepository.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_AbstractionandRepository.Entities.Concrete
{
    public class Employee : BaseEntity<Boolean>
    {
        public override bool Description { get => true; }
        public DateTime HiredDate = DateTime.Now;

    }
}
