using System.Collections.Generic;
using WineCellar.Models;

namespace WineCellar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WineCellar.DAL.WineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WineCellar.DAL.WineContext context)
        {
            var wines = new List<Wine>
                {
                    new Wine {Name = "Block Nine", Grapes = "Pinot Noir", Country = "USA", Region = "California", Year = 2009},
                    new Wine {Name = "The Prisoner", Grapes = "Blend", Country = "USA", Region = "California", Year = 2011},
                    new Wine {Name = "Barrandica", Grapes = "Blend", Country = "Argentina", Region = "Mendoza", Year = 2005},
                    new Wine {Name = "Fiorano Montepulciano D'abruzzo", Grapes = "Blend", Country = "Italy", Region = "Abruzzi", Year = 2007},
                    new Wine {Name = "Chateau Balthus La Reserve", Grapes = "Merlot", Country = "France", Region = "Bordeaux", Year = 2006},
                    new Wine {Name = "Alamos", Grapes = "Malbec", Country = "Argentina", Region = "Mendoza", Year = 2012},
                    new Wine {Name = "Villacreces Pruno", Grapes = "Tempranillo", Country = "Spain", Region = "Castille and Leon", Year = 2009},
                    new Wine {Name = "Robert Mondavi Reserve", Grapes = "Cabernet Sauvignon", Country = "USA", Region = "California", Year = 2010},
                    new Wine {Name = "Trimbach", Grapes = "Gewurztraminer", Country = "France", Region = "Alsace", Year = 2010},
                    new Wine {Name = "Messina Hof", Grapes = "Cabernet Franc", Country = "USA", Region = "Texas", Year = 2012}

                };
            wines.ForEach(s => context.Wines.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}
