using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Abstraction.Entities.Abstraction
{

    //Abstraction hides internal implements details
    //abstract classes include general, abstract implementation.
    //concrete classes include detailed implementations.
    // with abstract class we set rules for concrete class, aim is inheritance, cannot take instance from abstract class, not static.
    // abstract methods dont have body because of implementing the method in concrete class. if need make body do when override it .




    public abstract class Carnivores
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract int Lifelong { get; }

        public abstract string Sound();
        public virtual string WinterSleep()
        {
            return "Winter Sleep";
        }

        public abstract void Kill();
        public abstract void Eat();

    }
}
