using Jogame.Context;
using Jogame.Domains;
using Jogame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly JogameContext ctx;
        public JogoRepository()
        {
            ctx = new JogameContext();
        }

        public void Adicionar(Jogo jogo)
        {
            try
            {
                ctx.Add(jogo);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Jogo BuscarPorId(Guid Id)
        {
            try
            {
                return ctx.Jogo.Find(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Jogo> BuscarPorNome(string nome)
        {
            try
            {
                return ctx.Jogo.Where(c => c.Nome == nome).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Editar(Jogo jogo)
        {
            try
            {
                var JogoTemp = ctx.Jogo.Find(jogo.Id);
                JogoTemp.Nome = jogo.Nome;
                JogoTemp.Descricao = jogo.Descricao;
                JogoTemp.DataLancamento = jogo.DataLancamento;

                ctx.Update(JogoTemp);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Jogo> Listar()
        {
            try
            {
                return ctx.Jogo.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remover(Guid id)
        {
            try
            {
                var JogoTemp = ctx.Jogador.Find(id);
                ctx.Remove(JogoTemp);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
