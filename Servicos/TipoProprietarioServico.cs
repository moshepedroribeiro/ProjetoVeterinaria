using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class TipoProprietarioServico
    {
        private TipoProprietarioDAL tpDal;

        public void Gravar(TipoProprietario tp)
        {
            tpDal = new TipoProprietarioDAL();
            tpDal.Gravar(tp);
        }

        public IList<TipoProprietario> TodosTiposProprietarios()
        {
            tpDal = new TipoProprietarioDAL();
            return tpDal.TodosTiposProprietarios();
        }

        public IList<TipoProprietario> TodosTiposProprietarios(string nome)
        {
            tpDal = new TipoProprietarioDAL();
            return tpDal.TodosTiposProprietarios(nome);
        }

        public TipoProprietario ObterPorID(int id)
        {
            return tpDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            tpDal.Remover(id);
        }
    }
}
