using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ServicoServico
    {
        private ServicoDAL sDal = new ServicoDAL();

        public IList<Servico> TodosServicos()
        {
            return sDal.TodosServicos();
        }

        public IList<Servico> TodosServicos(string h)
        {
            return sDal.TodosServicos(h);
        }

        public void Gravar(Servico a)
        {
            sDal.Gravar(a);
        }

        public Servico ObterPorID(int id)
        {
            return sDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            sDal.Remover(id);
        }
    }
}
