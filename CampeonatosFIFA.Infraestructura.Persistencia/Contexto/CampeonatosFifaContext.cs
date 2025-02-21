using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Infraestructura.Persistencia.Contexto
{
    public class CampeonatosFifaContext : DbContext
    {
        public CampeonatosFifaContext(DbContextOptions<CampeonatosFifaContext> options) : base(options)
        {
        }

        public DbSet<Seleccion> Selecciones { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Seleccion>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            modelBuilder.Entity<Campeonato>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            modelBuilder.Entity<Campeonato>()
                .HasOne(e => e.PaisOrganizador)
                .WithMany()
                .HasForeignKey(e => e.IdSeleccion);

            modelBuilder.Entity<Ciudad>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre);
            });

            modelBuilder.Entity<Ciudad>()
               .HasOne(e => e.Pais)
               .WithMany()
               .HasForeignKey(e => e.IdSeleccion);

            modelBuilder.Entity<GrupoPais>(entidad =>
            {
                entidad.HasKey(e => new { e.IdGrupo, e.IdSeleccion });
            });

            modelBuilder.Entity<GrupoPais>()
               .HasOne(e => e.Grupo)
               .WithMany()
               .HasForeignKey(e => e.IdGrupo);

            modelBuilder.Entity<GrupoPais>()
                   .HasOne(e => e.Seleccion)
                   .WithMany()
                   .HasForeignKey(e => e.IdSeleccion);
        }
    }
}
