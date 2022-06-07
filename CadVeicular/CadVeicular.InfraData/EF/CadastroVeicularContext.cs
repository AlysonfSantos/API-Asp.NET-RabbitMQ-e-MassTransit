using CadVeicular.Domain.Interfaces;
using CadVeicular.Domain.Models;
using CadVeicular.Infra.Data.EF.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Infra.Data.EF
{
    public class CadastroVeicularContext : DbContext, IUnitOfWork
    {
        public CadastroVeicularContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
            CriarBancoCasoNaoExista();

        }
        private void CriarBancoCasoNaoExista()
        {
            if (!(Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VeiculoMapping());
            modelBuilder.ApplyConfiguration(new ProprietarioMapping());
            modelBuilder.ApplyConfiguration(new MarcaMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
        }
        //duvidas de referencias as tabelas
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
