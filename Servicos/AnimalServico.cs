using Modelo;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servicos
{
    public class AnimalServico
    {
        private AnimalDAL aDal = new AnimalDAL();

        public IList<Animal> TodosAnimais()
        {
            return aDal.TodosAnimais();
        }

        public IList<Animal> TodosAnimais(string nome)
        {
            return aDal.TodosAnimais(nome);
        }

        public void Gravar(Animal a)
        {
            aDal.Gravar(a);
        }

        public Animal ObterPorID(int id)
        {
            return aDal.ObterPorID(id);
        }

        public void Remover(int id)
        {
            aDal.Remover(id);
        }

        public IList<Animal> AnimaisPorTipo(int idTipo)
        {
            return aDal.AnimaisPorTipo(idTipo);
        }

        public IList<Animal> AnimaisPorProprietario(int id)
        {
            return aDal.AnimaisPorProprietario(id);
        }
    }
}
