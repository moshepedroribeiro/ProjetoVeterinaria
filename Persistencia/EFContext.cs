using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<TipoProprietario> TiposProprietario { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<TipoAnimal> TiposAnimal { get; set; }
        public DbSet<Animal> Animais  { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<ProntuarioExame> ProntuarioExame { get; set; }
        public DbSet<TipoServico> TiposServico { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ContasReceber> ContasReceber { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Projeto;Trusted_Connection=True");
        }

    }
}
