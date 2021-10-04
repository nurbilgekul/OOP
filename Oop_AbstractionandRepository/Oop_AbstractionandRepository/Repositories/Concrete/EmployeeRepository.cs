using Oop_AbstractionandRepository.Entities.Concrete;
using Oop_AbstractionandRepository.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_AbstractionandRepository.Repositories.Concrete
{
    public class EmployeeRepository : BaseEmployeeRepository
    {
       

        public override void createEmployee(int Id, string FullName)
        {
            Employee employee = new Employee();
            employee.Id = Id;
            employee.FullName = FullName;
            FakeData.employees.Add(employee);
        }

        public override void deleteEmployee(int Id)
        {
            foreach (Employee employee in FakeData.employees)
            {
                if (employee.Id==Id)
                {
                    FakeData.employees.Remove(employee);
                }
            }
        }

        public override List<Employee> GetEmployees()
        {
            return FakeData.employees.ToList();
        }

        public override void updateEmployee(int Id, string FullName)
        {
            foreach (Employee employee  in FakeData.employees)
            {
                if (employee.Id==Id)
                {
                   employee.FullName = FullName;
                   employee.Status= Entities.Abstraction.Status.Modified;
                }
            }
        }
    }
}
