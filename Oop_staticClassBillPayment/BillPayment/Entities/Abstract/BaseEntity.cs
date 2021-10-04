using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillPayment.Entities.Abstract
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime BillDate { get; set; }
        public double Price { get; set; }
        public int son { get; set; }
        public int ilk { get; set; }
    }
}
