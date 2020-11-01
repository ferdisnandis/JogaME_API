using Jogame.Context;
using Jogame.Domains;
using Jogame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Repositories
{
    public class JogosJogadoresRepository : IJogosJogadoresRepository
    {
        private readonly JogameContext ctx;
        public JogosJogadoresRepository()
        {
            ctx = new JogameContext();
        }

        public JogosJogadores BuscarPorId(Guid Id)
        {
            try
            {
                return ctx.JogosJogadores.Find(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        List<JogosJogadores> IJogosJogadoresRepository.Listar()
        {
            try
            {
                return ctx.JogosJogadores.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
