using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains
{
    public class Jogo : BaseDomain
    {
        //public Guid IdJogo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }

        public List<JogosJogadores> JogosJogadores { get; set; }
    }
}
