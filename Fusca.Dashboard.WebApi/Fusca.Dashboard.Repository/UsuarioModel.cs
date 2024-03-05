using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusca.Dashboard.Repository
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public int? NivelAcesso { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
