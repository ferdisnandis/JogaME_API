using Jogame.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();
        List<Jogo> BuscarPorNome(string nome);
        Jogo BuscarPorId(Guid Id);
        void Adicionar(Jogo jogo);
        void Editar(Jogo jogo);
        void Remover(Guid id);
    }
}
