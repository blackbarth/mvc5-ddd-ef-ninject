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
            this.ModulosAcesso = new List<ModuloAcesso>();
        }
        public int IdPerfilUsuario { get; set; }
        public string NomePerfil { get; set; }
        public bool FlAdminMaster { get; set; }
        public bool FlAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<ModuloAcesso> ModulosAcesso { get; set; }
    }
}
