using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class TipoServicoServico
    {
        TipoServicoDAL tsDal = new TipoServicoDAL();

        public void Gravar(TipoServico ts)
        {
            tsDal.Gravar(ts);
        }

        public IList<TipoServico> TodosTiposServico()
        {
            return tsDal.TodosTiposServico();
        }

        public IList<TipoServico> TodosTiposServico(string descricao)
        {
            return tsDal.TodosTiposServico(descricao);
        }

        public TipoServico ObterPorID(int id)
        {
            return tsDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            tsDal.Remover(id);
        }
    }
}
