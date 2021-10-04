using Oop_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Abstraction.Entities.Concrete
{
    
    public class Shark : Carnivores
    {

        public bool Fin = true;
        public override int Lifelong { get => 100; }

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
            return "kskskkskaas";
        }

        public void Swim()
        {
        }

    }
}
