using Oop_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Abstraction.Entities.Concrete
{
    public class Owl : Carnivores
    {
        public string Foots;
        public override int Lifelong { get => 39; }

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
            return "uuuwuwuwuus";
        }

        public void Fly()
        {

        }
    }
}
