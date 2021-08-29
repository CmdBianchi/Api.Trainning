using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Game.Domain.ValueObjects;
namespace X.Game.Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest
    {
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}
