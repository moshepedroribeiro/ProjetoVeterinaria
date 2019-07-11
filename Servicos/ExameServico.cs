using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ExameServico
    {
        private ExameDAL eDal = new ExameDAL();

        public void Gravar(Exame e)
        {
            eDal.Gravar(e);
        }

        public IList<Exame> TodosExames()
        {
            return eDal.TodosExames();
        }

        public IList<Exame> TodosExames(string descricao)
        {
            return eDal.TodosExames(descricao);
        }

        public Exame ObterPorID(int id)
        {
            return eDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            eDal.Remover(id);
        }
    }
}
