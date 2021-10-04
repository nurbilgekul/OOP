using Oop_AbstractionandRepository.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_AbstractionandRepository.Repositories.Abstract
{
    public abstract class BaseEmployeeRepository
    {
        //Repository Pattern
        //for an entity includes methods to implement CRUD Operations 


        public abstract void createEmployee(int Id, string FullName);
        public abstract List<Employee> GetEmployees();
        public abstract void updateEmployee(int Id, string FullName);
        public abstract void deleteEmployee(int Id);
    }
}
