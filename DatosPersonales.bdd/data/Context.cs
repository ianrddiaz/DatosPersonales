using DatosPersonales.bdd.data.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonales.bdd.data
{
    public class Context : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
