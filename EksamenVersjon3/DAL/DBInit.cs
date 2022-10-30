using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksamenVersjon3.DAL
{
    //Denne klassen er hentet fra KundeApp2-med-DB filen i KundeApp2-med-DAL mappen fra canvas
    public static class DBInit //Klasse som initierer databasen, og legger til dummy data i databasen
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ObservasjonContext>();

                // Disse forsikrer at databasen slettes og opprettes hver gang den skal initieres
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var observasjon1 = new Observasjoner //Dummy data #1
                {
                    Id = 1,
                    Postkode = "0001",
                    Beskrivelse = "Grønn UFO",
                    Navn = "Ola Nordmann",
                    Dato = "1 januar 2022",
                    Tid = "22:30"
                };

                var observasjon2 = new Observasjoner //Dummy data #2
                {
                    Id = 2,
                    Postkode = "0002",
                    Beskrivelse = "Blå UFO",
                    Navn = "Sam Møller",
                    Dato = "2 januar 2022",
                    Tid = "20:00"
                };
                //Legger til dummy dataen i databasen
                context.Observasjoner.Add(observasjon1);
                context.Observasjoner.Add(observasjon2);

                context.SaveChanges();
            }
        }
    }
}