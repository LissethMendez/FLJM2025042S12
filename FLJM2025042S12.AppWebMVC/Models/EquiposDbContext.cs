using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FLJM2025042S12.AppWebMVC.Models;

public partial class EquiposDbContext : DbContext
{
    public EquiposDbContext()
    {
    }

    public EquiposDbContext(DbContextOptions<EquiposDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Equipo> Equipos { get; set; }

   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Equipos__3214EC07FCED34D9");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
