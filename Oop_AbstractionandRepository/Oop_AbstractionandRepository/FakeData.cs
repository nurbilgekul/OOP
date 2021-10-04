using Oop_AbstractionandRepository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_AbstractionandRepository
{
    public static class FakeData
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee { Id=1, FullName="Joe Brick" },
            new Employee { Id=2, FullName="Sarah Bright"},
            new Employee { Id=3, FullName="Oliver Sun"}
        };
    }
}
