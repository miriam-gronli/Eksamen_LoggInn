using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksamenVersjon3.DAL
{
    //Denne klassen er hentet fra KundeApp2-med-DB filen i KundeApp2-med-DAL mappen fra canvas
    public class Observasjoner //Denne klassen blir referert til dersom man oppretter data som skal bli lagt til i databasen
    {
        public int Id { get; set; } //auto-increment i databasen
        public string Navn { get; set; }
        public string Postkode { get; set; }
        public string Beskrivelse { get; set; }
        public string Dato { get; set; }
        public string Tid { get; set; }
    }


    public class ObservasjonContext : DbContext //Klasse som oppretter databasen fysisk dersom databasen ikke er opprettet
    {
        public ObservasjonContext(DbContextOptions<ObservasjonContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Observasjoner> Observasjoner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

    }
}
