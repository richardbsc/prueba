using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBD
{
    public class Repositorio: DbContext
    {
        //Configuracion de las entidades
        public DbSet<Rental>? Rental { get; set;}
        public DbSet<Inventory>? Inventory { get; set;}
    }
}
