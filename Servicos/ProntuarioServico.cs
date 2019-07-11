using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ProntuarioServico
    {
        private ProntuarioDAL pdal = new ProntuarioDAL();
        ProntuarioExameServico pes = new ProntuarioExameServico();

        public IList<Prontuario> TodosProntuarios(int idAnimal)
        {
            return pdal.TodosProntuarios(idAnimal);
        }

        public IList<Prontuario> TodosProntuarios(int idAnimal, string data)
        {
            return pdal.TodosProntuarios(idAnimal, data);
        }

        public IList<Prontuario> ProntuariosPorAnimal(int idAnimal)
        {
            return pdal.ProntuariosPorAnimal(idAnimal);
        }

        public void Gravar(Prontuario p)
        {
            pdal.Gravar(p);
        }

        public Prontuario ObterPorID(int id)
        {
            return pdal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            pdal.Remover(id);
        }
    }
}
