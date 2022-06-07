using CadVeicular.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Infra.Data.EF.Maps
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Loradouro)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Cidade)
               .HasMaxLength(40)
               .IsRequired();

            builder.Property(x => x.Estado)
               .HasMaxLength(40)
               .IsRequired();

            builder.Property(x => x.CEP)
               .HasMaxLength(8)
               .IsRequired();

            builder.Property(x => x.Numero)
               .HasMaxLength(10)
               .IsRequired();

        }
    }
}
