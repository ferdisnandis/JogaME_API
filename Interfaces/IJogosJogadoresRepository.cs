using Jogame.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Interfaces
{
    interface IJogosJogadoresRepository
    {
        List<JogosJogadores> Listar();
        JogosJogadores BuscarPorId(Guid Id);

    }
}
