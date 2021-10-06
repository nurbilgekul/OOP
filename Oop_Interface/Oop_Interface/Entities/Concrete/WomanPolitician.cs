using Oop_Interface.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Interface.Entities.Concrete
{
    class WomanPolitician : IPolitician
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PoliticalParty { get; set; }
        public string Alias { get; set; }

        public void Defense()
        {

        }

        public string Denial() => "There is no such thing, they are lying.";


        public string Lie() => "Its all for your good! ";

        public override string ToString() =>$"{FirstName } {LastName}";
        public bool IsRetired { get; set; }

        public void BeMomy()
        {

        }


    }
}
