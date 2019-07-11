using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class ProprietarioServico
    {
        private ProprietarioDAL pdal = new ProprietarioDAL();

        public IList<Proprietario> TodosProprietarios()
        {
            return pdal.TodosProprietarios();
        }

        public IList<Proprietario> TodosProprietarios(string nome)
        {
            return pdal.TodosProprietarios(nome);
        }

        public void Gravar(Proprietario p)
        {
            pdal.Gravar(p);
        }

        public Proprietario ObterPorID(int id)
        {
            return pdal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            pdal.Remover(id);
        }

        public IList<Proprietario> ProprietariosPorTipo(int idTipo)
        {
            return pdal.ProprietariosPorTipo(idTipo);
        }
    }
}
