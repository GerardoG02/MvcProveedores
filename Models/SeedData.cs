using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcProveedores.Data;
using System;
using System.Linq;

namespace MvcProveedores.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcProveedoresContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcProveedoresContext>>()))
            {
                // Look for any movies.
                if (context.Proveedor.Any())
                {
                    return;   // DB has been seeded
                }

                context.Proveedor.AddRange(
                    new Proveedor
                    {
                        RFC = "ECA1501548G5",
                        RazonSocial = "Energeticos Camper",
                        DirFiscal = "Av. Del Roble #403, Paseos, Mty, NL, 64222",
                        PermisoCRE = "H/15485/COM/2018",
                        RegCapital = "SA DE CV"
                    },

                    new Proveedor
                    {
                        RFC = "ERE1502544F1",
                        RazonSocial = "Energy Refinados",
                        DirFiscal = "Novena #231, Anahuac, San Nicolas, NL 66574",
                        PermisoCRE = "H/20154/COM/2015",
                        RegCapital = "SA DE CV"
                    },

                    new Proveedor
                    {
                        RFC = "MPH1548554H6",
                        RazonSocial = "Mapror de Hidrocarburos",
                        DirFiscal = "Octava #485, Anahuac, San Nicolas, NL, 66457",
                        PermisoCRE = "H/28443/COM/2016",
                        RegCapital = "SA DE CV"
                    },

                    new Proveedor
                    {
                        RFC = "TGU1548632F1",
                        RazonSocial = "Tiger Fuel",
                        DirFiscal = "Canario #1420, Residencial, Monterrey, NL, 66454",
                        PermisoCRE = "H/20596/COM/2020",
                        RegCapital = "SA DE CV"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
