using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ContasReceberServico
    {
        private ContasReceberDAL crDal = new ContasReceberDAL();

        public IList<ContasReceber> TodasContasReceber()
        {
            return crDal.TodasContasReceber();
        }

        public IList<ContasReceber> TodasContasReceber(string nome)
        {
            return crDal.TodasContasReceber(nome);
        }

        public void Gravar(ContasReceber a)
        {
            crDal.Gravar(a);
        }

        public void GravarList(List<ContasReceber> a)
        {
            crDal.GravarList(a);
        }

        public ContasReceber ObterPorID(int id)
        {
            return crDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            crDal.Remover(id);
        }
    }
}
