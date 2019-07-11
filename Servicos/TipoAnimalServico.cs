using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class TipoAnimalServico
    {
        TipoAnimalDAL taDal = new TipoAnimalDAL();

        public void Gravar(TipoAnimal ta)
        {
            taDal.Gravar(ta);
        }

        public IList<TipoAnimal> TodosTiposAnimal()
        {
            return taDal.TodosTiposAnimal();
        }

        public IList<TipoAnimal> TodosTiposAnimal(string nome)
        {
            return taDal.TodosTiposAnimal(nome);
        }

        public TipoAnimal ObterPorID(int id)
        {
            return taDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            taDal.Remover(id);
        }
    }
}
