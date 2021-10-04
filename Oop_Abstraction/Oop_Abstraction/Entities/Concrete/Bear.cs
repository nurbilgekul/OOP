using Oop_Abstraction.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Abstraction.Entities.Concrete
{
    public class Bear : Carnivores
    {
        public bool Fur=true;
        public override int Lifelong { get => 12;}

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Kill()
        {
            throw new NotImplementedException();
        }

        public override string Sound() => "ouwouoow";

        public override string WinterSleep()
        {
            return "Sleep in Winter";
        }
        public void Run()
        {

        }


    }
}
