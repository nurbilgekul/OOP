using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Interface.Entities.Interface
{

    //Interface: used to achieve multiple inheritance. have to override all the methods and props declared inside the interface.
    //cannot apply access modifiers to interface members, default public.


    public interface IPolitician
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string PoliticalParty { get; set; }
        string Alias { get; set; }

        string Lie();
        void Defense();
        string Denial();

    }
}
