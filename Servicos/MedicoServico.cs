using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Servicos
{
    public class MedicoServico
    {
        MedicoDAL mDal = new MedicoDAL();

        public void Gravar(Medico m)
        {
            mDal.Gravar(m);
        }

        public IList<Medico> TodosMedicos()
        {
            return mDal.TodosMedicos();
        }

        public IList<Medico> TodosMedicos(string nome)
        {
            return mDal.TodosMedicos(nome);
        }

        public IList<Medico> TodosMedicos(int id)
        {
            return mDal.TodosMedicos(id);
        }

        public Medico ObterPorID(int id)
        {
            return mDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            mDal.Remover(id);
        }
    }
}
