using ProjetoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infrastruture.Data.Configuration
{
    public class ModuloAcessoMap : EntityTypeConfiguration<ModuloAcesso>
    {
        public ModuloAcessoMap()
        {
            this.HasKey(p => p.IdModulo);
            this.Property(p => p.NomeModulo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(p => p.NomeMenuAcesso)
                .IsRequired()
                .HasMaxLength(100);
            this.Property(p => p.UrlMenu)
                .IsRequired()
                .HasMaxLength(300);

            this.ToTable("ModuloAcesso", "dbo");
            //this.Property(p => p.IdModulo).HasColumnName("NomeCampoDesejado");

            this.HasMany(p => p.PerfisUsuario)
                .WithMany(p => p.ModulosAcesso)
                .Map(m =>
                {
                    m.ToTable("PerfilModulos", "dbo");
                    m.MapLeftKey("IdModulo");
                    m.MapRightKey("IdPerfilUsuario");
                });
        }
    }
}
