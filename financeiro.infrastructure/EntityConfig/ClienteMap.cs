﻿using financeiro.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace financeiro.infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.Contatos)
                   .WithOne(c=>c.Cliente)
                   .HasForeignKey(c=>c.ClienteId)
                   .HasPrincipalKey(c=>c.Id);
        }
    }
}
