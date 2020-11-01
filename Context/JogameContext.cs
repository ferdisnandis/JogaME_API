using Jogame.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Context
{
    public class JogameContext : DbContext
    {
        public DbSet<JogosJogadores> JogosJogadores { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<Jogador> Jogador { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=.\SqlExpress; Initial Catalog=JogaMe; user id=sa; password=sa132");
        }
    }
}
    
