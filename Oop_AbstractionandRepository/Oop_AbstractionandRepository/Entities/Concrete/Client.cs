using Oop_AbstractionandRepository.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_AbstractionandRepository.Entities.Concrete
{
    public class Client : BaseEntity<string>
    {
        public override string Description { get => "Musteri"; }
        public string Choice { get; set; }
    }
}
