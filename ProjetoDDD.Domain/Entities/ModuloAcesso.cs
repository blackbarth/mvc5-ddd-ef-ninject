using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Entities
{
    public class ModuloAcesso
    {
        public ModuloAcesso()
        {
            this.PerfisUsuario = new List<PerfilUsuario>();
        }
        public int IdModulo { get; set; }
        public string NomeModulo { get; set; }
        public string NomeMenuAcesso { get; set; }
        public string UrlMenu { get; set; }
        public bool FlAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdModuloPai { get; set; }
        public virtual ModuloAcesso ModuloAcessos { get; set; }
        public virtual ICollection<PerfilUsuario> PerfisUsuario { get; set; }
    }
}
