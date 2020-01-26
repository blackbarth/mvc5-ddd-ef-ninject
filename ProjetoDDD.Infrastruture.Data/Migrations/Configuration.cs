using System.IO;
using System.Linq;
using ProjetoDDD.Infrastruture.Data.Initializer;

namespace ProjetoDDD.Infrastruture.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoDDD.Infrastruture.Data.Context.ContextoBanco>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Context.ContextoBanco context)
        {
            if (context.PerfilUsuario.Where(p => p.NomePerfil == "Administrador Master").Count() == 0)
                UserDatabaseInitializer.GetPerfilUsuarios().ForEach(c => context.PerfilUsuario.Add(c));

            //Delete all stored procedures, views
            foreach (var file in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug", ""), "Sql\\Seed"), "*.sql"))
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(file), new object[0]);
            }

            //Add Stored Procedures
            foreach (var file in Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug", ""), "Sql\\StoredProcs"), "*.sql"))
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(file), new object[0]);
            }

        }
    }
}
