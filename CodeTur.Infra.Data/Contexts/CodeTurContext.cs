using CodeTur.Dominio;
using CodeTur.Dominio.Entidades;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Infra.Data.Contexts
{
    public class CodeTurContext : DbContext
    {
        // Passamos o argumento de options que sera definido posteriormente la na minha Startup
        public CodeTurContext(DbContextOptions<CodeTurContext> options) : base(options)
        {

        }

        // Declarar quais sao as tabelas que nos vamos criar, com dbset

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        // Modelamos como que as tabelas devem ficar
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ignoramos que a biblioteca de notificacoes do Flunt seja gerada no banco automaticamente
            modelBuilder.Ignore<Notification>();

            #region mapeamento da tabela Usuarios

            //  Mudamos o nome da tabela se necessario
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");

            //Determinar chaves, nao precisa determinar como primary key ja que esta nomeada como Id
            modelBuilder.Entity<Usuario>().Property(x => x.Id);

            //Nome
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired();

            //Email
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasMaxLength(60);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("varchar(60)");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<Usuario>().HasIndex(x => x.Email).IsUnique();

            //Senha
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("varchar(200)");
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired();

            //DataDescricao
            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasColumnType("DateTime");
            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasDefaultValueSql("getdate()");

            #endregion

            base.OnModelCreating(modelBuilder); 
        }
    }
}
