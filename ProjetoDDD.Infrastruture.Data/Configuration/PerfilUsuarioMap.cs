using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infrastruture.Data.Configuration
{
    public class PerfilUsuarioMap : EntityTypeConfiguration<PerfilUsuario>
    {
        public PerfilUsuarioMap()
        {
            this.HasKey(p => p.IdPerfilUsuario);

            this.Property(p => p.NomePerfil)
                .IsRequired()
                .HasMaxLength(100);

            this.ToTable("PerfilUsuario", "dbo");

        }
    }
}
