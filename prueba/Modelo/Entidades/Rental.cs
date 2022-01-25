using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Rental
    {
        public int RentalId { get; set; } 
        public DateTime RentalDate { get; set; }
        public int InventoryId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int StaffId { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
