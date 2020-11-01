using Jogame.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Interfaces
{
    interface IJogadorRepository
    {
        List<Jogador> Listar();
        List<Jogador> BuscarPorNome(string nome);
        Jogador BuscarPorId(Guid Id);
        void Adicionar(Jogador jogador);
        void Editar(Jogador jogador);
        void Remover(Guid id);
    }
}
