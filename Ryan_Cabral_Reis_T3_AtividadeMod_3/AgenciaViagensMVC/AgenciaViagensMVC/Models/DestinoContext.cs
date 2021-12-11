using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgenciaViagensMVC.Models
{
    public class DestinoContext : DbContext
    {
        public DestinoContext(DbContextOptions<DestinoContext> options) : base(options)
        {

        }

        public DbSet<Destino> Destinos { get; set;}

    }
}
