using System;
using System.Collections.Generic;
using System.Text;

namespace Jwt.Exemplo.Domain.Command.Inputs
{
    public class VerificarPermissaoCommand
    {
        public string Usuario { get; set; }
        public string Permissao { get; set; }
    }
}
