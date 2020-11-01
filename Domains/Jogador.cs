using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains
{
    public class Jogador : BaseDomain
    {
        //public Guid IdJogador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNasc { get; set; }

        public List<JogosJogadores> JogosJogadores { get; set; }
    }
}
