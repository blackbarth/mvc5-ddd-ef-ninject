using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Infrastruture.Data.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoDDD.Infrastruture.Data.Context
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco() : base("ProjetoDDD")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public DbSet<ModuloAcesso> ModuloAcesso { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == "Id" + p.ReflectedType.Name).Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));
            modelBuilder.Properties<string>().Where(p => p.Name.Contains("Descricao")).Configure(p => p.HasMaxLength(200));
            modelBuilder.Properties<string>().Where(p => p.Name.Contains("UF")).Configure(p => p.HasMaxLength(2));


            modelBuilder.Configurations.Add(new ModuloAcessoMap());
            modelBuilder.Configurations.Add(new PerfilUsuarioMap());
            modelBuilder.Configurations.Add(new UsuarioMap());


            base.OnModelCreating(modelBuilder);
        }

    }
}
