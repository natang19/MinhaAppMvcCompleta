﻿using System;
using System.Collections.Generic;
using System.Text;
using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(e => e.Logradouro)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(e => e.Numero)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(p => p.Cep)
                   .IsRequired()
                   .HasColumnType("varchar(8)");

            builder.Property(p => p.Complemento)
                   .IsRequired()
                   .HasColumnType("varchar(250)");

            builder.Property(p => p.Bairro)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.Cidade)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.Estado)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
