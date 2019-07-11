using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ConsultaServico
    {
        private ConsultaDAL cDal = new ConsultaDAL();

        public IList<Consulta> TodasConsultas()
        {
            return cDal.TodasConsultas();
        }

        public IList<Consulta> TodasConsultas(string h)
        {
            return cDal.TodasConsultas(h);
        }

        public IList<Consulta> TodasConsultasData(string horario)
        {
            return cDal.TodasConsultasData(horario);
        }

        public void Gravar(Consulta a)
        {
            cDal.Gravar(a);
        }

        public Consulta ObterPorID(int id)
        {
            return cDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            cDal.Remover(id);
        }

        public IList<Consulta> ConsultasPorMedico(int idMedico)
        {
            return cDal.ConsultasPorMedico(idMedico);
        }

        public IList<Consulta> ConsultasPorAnimal(int id)
        {
            return cDal.ConsultasPorAnimal(id);
        }
    }
}
