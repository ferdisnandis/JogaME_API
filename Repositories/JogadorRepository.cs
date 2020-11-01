using Jogame.Context;
using Jogame.Domains;
using Jogame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly JogameContext ctx;
        public JogadorRepository()
        {
            ctx = new JogameContext();
        }

        public void Adicionar(Jogador jogador)
        {
            try
            {
                ctx.Add(jogador);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Jogador BuscarPorId(Guid Id)
        {
            try
            {
                return ctx.Jogador.Find(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Jogador> BuscarPorNome(string nome)
        {
            try
            {
                return ctx.Jogador.Where(c => c.Nome == nome).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Editar(Jogador jogador)
        {
            try
            {
                var JogadorTemp = ctx.Jogador.Find(jogador.Id);
                JogadorTemp.Nome = jogador.Nome;
                JogadorTemp.Email = jogador.Email;
                JogadorTemp.Senha = jogador.Senha;

                ctx.Update(JogadorTemp);
                ctx.SaveChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Jogador> Listar()
        {
            try
            {
                return ctx.Jogador.ToList();
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
                var JogadorTemp = ctx.Jogador.Find(id);
                ctx.Remove(JogadorTemp);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
