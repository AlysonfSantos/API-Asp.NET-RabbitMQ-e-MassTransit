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
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RENAVAM)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(x => x.Modelo)
                .IsRequired();

            builder.Property(x => x.Status)
                .IsRequired();

            builder.Property(x => x.Quilometragem)
                .IsRequired();

            builder.HasOne(x => x.Marca)
                .WithMany()
                .HasForeignKey(x => x.MarcaId);

            builder.HasOne(x => x.Proprietario)
                .WithMany()
                .HasForeignKey(x => x.ProprietarioId);

            builder.Property(x => x.AnoFabricacao)
                .IsRequired();

            builder.Property(x => x.AnoModelo)
                .IsRequired();

            builder.Property(x => x.Valor)
                .IsRequired();

        }
    }
}
