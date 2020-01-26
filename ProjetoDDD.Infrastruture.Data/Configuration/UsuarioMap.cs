using ProjetoDDD.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD.Infrastruture.Data.Configuration
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            this.HasKey(p => p.IdUsuario);

            this.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();


            this.Property(t => t.Email)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true }));

            this.Property(p => p.Senha)
                .HasMaxLength(1024)
                .IsRequired();

            this.Property(p => p.DataCadastro)
                .HasColumnType("datetime2");

            this.HasRequired(p => p.PerfilUsuario)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(p => p.IdPerfilUsuario);

        }
    }
}
