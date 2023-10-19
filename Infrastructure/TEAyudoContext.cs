﻿using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class TEAyudoContext : DbContext
    {
        public DbSet<EstadoPropuesta> EstadoPropuesta { get; set; }
        public DbSet<Propuesta> Propuesta { get; set; }

        public TEAyudoContext(DbContextOptions<TEAyudoContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Propuesta>()
                .HasOne(p => p.EstadosPropuestas)
                .WithOne(ep => ep.Propuesta)
                .HasForeignKey<EstadoPropuesta>(ep => ep.EstadoPropuestaId);
          

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TEAyudo_Usuarios;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
