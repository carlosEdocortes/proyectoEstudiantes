using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace apiEstudiante.Models;

public partial class RegistroEstudiantesContext : DbContext
{
    public RegistroEstudiantesContext()
    {
    }

    public RegistroEstudiantesContext(DbContextOptions<RegistroEstudiantesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<EstudianteMateria> EstudianteMateria { get; set; }

    public virtual DbSet<Materia> Materia { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<ProfesorMateria> ProfesorMateria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.ToTable("Estudiante");

            entity.Property(e => e.Clave).HasMaxLength(50);
            entity.Property(e => e.Dni).HasMaxLength(100);
            entity.Property(e => e.NombreEstudiante).HasMaxLength(100);
        });

        modelBuilder.Entity<EstudianteMateria>(entity =>
        {
            entity.HasIndex(e => e.EstudianteId, "IX_EstudianteMateria_EstudianteId");

            entity.HasIndex(e => e.MateriaId, "IX_EstudianteMateria_MateriaId");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.objEstudianteMateria).HasForeignKey(d => d.EstudianteId);

            entity.HasOne(d => d.Materia).WithMany(p => p.objEstudianteMateria).HasForeignKey(d => d.MateriaId);
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.ToTable("Profesor");

            entity.Property(e => e.NombreProfesor).HasMaxLength(100);
        });

        modelBuilder.Entity<ProfesorMateria>(entity =>
        {
            entity.HasKey(e => e.IdProfesorMateria).HasName("PK__profesor__31D461B0064C5B61");

            entity.ToTable("profesorMateria");

            entity.Property(e => e.IdProfesorMateria).HasColumnName("idProfesorMateria");
            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.IdProfesor).HasColumnName("idProfesor");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.objProfesorMateria)
                .HasForeignKey(d => d.IdMateria)
                .HasConstraintName("FK__profesorM__idMat__503BEA1C");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.objProfesorMateria)
                .HasForeignKey(d => d.IdProfesor)
                .HasConstraintName("FK__profesorM__idPro__4F47C5E3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
