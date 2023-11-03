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
        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
