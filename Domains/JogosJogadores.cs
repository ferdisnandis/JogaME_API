using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains
{
    public class JogosJogadores : BaseDomain
    {
           public Guid IdJogosJogadores { get; set; }

        //FK 
        [ForeignKey("Jogador")]
            public Guid IdJogador { get; set; }
            public Jogador Jogador { get; set; }
            
        [ForeignKey("Jogo")]
            public Guid IdJogo { get; set; }
            public Jogo Jogo { get; set; }
    }
}
