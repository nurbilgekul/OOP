using Oop_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Abstraction.Entities.Concrete
{
    public class Tiger : Carnivores
    {
        public bool paw = true;
        public override int Lifelong { get => 45; }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Kill()
        {
            throw new NotImplementedException();
        }

        public override string Sound()
        {
            return "rouersrdwr";
        }
        public void Figth()
        {
        }
    }
}
