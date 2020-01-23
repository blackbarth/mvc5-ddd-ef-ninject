using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    public partial class PerfilUsuario
    {
        public PerfilUsuario()
        {
            this.Usuarios = new List<Usuario>();
            this.ModuloAcessos = new List<ModuloAcesso>();
        }
        public int IdPerfilUsuario { get; set; }
        public string NomePerfil { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<ModuloAcesso> ModuloAcessos { get; set; }
    }
}
