using CajemesfoodProyect.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CajemesfoodProyect.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestra DB

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.platillos.Any())
                {
                    context.platillos.AddRange(new platillos()
                    {
                        nombre = "Tacos",
                        precio = 40,
                        descripcion = "unos ricos tacos de las cortinas",
                        caducidad = DateTime.Now.AddDays(+4),
                    },
                        new platillos()
                        {
                            nombre = "sushi",
                            precio = 90,
                            descripcion = "un sushi recien salido de japon",
                            caducidad = DateTime.Now.AddDays(+5),
                        });
                    context.SaveChanges();
                }
            }
        }
    }
}
