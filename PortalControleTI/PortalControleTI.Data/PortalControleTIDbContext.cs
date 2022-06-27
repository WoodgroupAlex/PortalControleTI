using PortalControleTI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalControleTI.Data
{
    public class PortalControleTIDbContext : DbContext
    {
        public DbSet<Computador> Clientes { get; set; }
    }
}
