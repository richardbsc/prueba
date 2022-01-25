using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public string? FistName { get; set; }
        public string? LastName { get; set; }
        public char Email { get; set; }
        public int AddresId { get; set; }
        public int Activebool { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public Boolean Active { get; set; }


    }
}
