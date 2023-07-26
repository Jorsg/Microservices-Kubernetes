using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MicroServicesKub.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProd)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProd);
            }            
        }

        private static void SeedData(AppDbContext  context, bool isProd)
        {
            if (isProd)
            {
                Console.WriteLine("--> Attempting to apply migration...");
                try
                {
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                   Console.WriteLine($"--> Could not run migrations: {ex.Message}" );
                }
            }
            if (!context.Pasajero.Any())
            {
                Console.WriteLine("--> Seending Data...");
                context.Pasajero.AddRange(
                    new Pasajero() {NombresCompletos = "Natalia Quintero", Email = "nquinto@g.com",
                        FechaNacimiento = Convert.ToDateTime("13/11/1986"), Genero = "M",NumDocumento = "58121288",TelefonoContacto = "545485422",TipoDocumento = "Cedula" },
                    new Pasajero() { NombresCompletos = "Dante",Email = "dante@g.com", FechaNacimiento = Convert.ToDateTime("10/08/2015")
                                    , Genero = "Macho",NumDocumento = "65458",TelefonoContacto = "658722", TipoDocumento = "cedula canina"},
                    new Pasajero() {NombresCompletos = "Luna",Email = "luna@g.com",FechaNacimiento = Convert.ToDateTime("05/05/2015"),
                        Genero = "Hembra",NumDocumento = "854786",TelefonoContacto = "658722", TipoDocumento = "cedula canina"}
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}
