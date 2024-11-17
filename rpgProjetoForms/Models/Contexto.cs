using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgProjetoForms.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Personagem> Personagem { get; set; }
        public DbSet<Habilidade> Habilidade { get; set; }
        public DbSet<Luta> Luta { get; set; }
        public DbSet<ListaPersonagem> ListaPersonagem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseNpgsql("Host=pgsql.projetoscti.com.br;Database=projetoscti16;Username=projetoscti16;Password=eq42369");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListaPersonagem>().HasKey(e => new { e.FkRpgPlayerId, e.FkRpgPersonagemId });
        }
    }
}
