using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ProntuarioExameServico
    {
        ProntuarioExameDAL peDal = new ProntuarioExameDAL();

        public void Gravar(ProntuarioExame pe)
        {
            peDal.Gravar(pe);
        }

        public IList<ProntuarioExame> TodosExamesPorProntuario(int idProntuario)
        {
            return peDal.TodosExamesPorProntuario(idProntuario);
        }
    }
}
