using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_AbstractionandRepository.Entities.Abstraction
{
    public enum Status { Active = 1, Modified = 2, Passive = 3 }

    public abstract class BaseEntity<T>
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public abstract T Description { get; } //generic type, have to override concrete class

        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
