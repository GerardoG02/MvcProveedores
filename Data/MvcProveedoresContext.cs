#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcProveedores.Models;

namespace MvcProveedores.Data
{
    public class MvcProveedoresContext : DbContext
    {
        public MvcProveedoresContext (DbContextOptions<MvcProveedoresContext> options)
            : base(options)
        {
        }

        public DbSet<MvcProveedores.Models.Proveedor> Proveedor { get; set; }
    }
}
