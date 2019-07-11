using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class TipoAnimalDAL
    {
        public void Gravar(TipoAnimal ta)
        {
            using (var context = new EFContext())
            {
                if (ta.TipoAnimalID > 0) {
                    context.Entry(ta).State = EntityState.Modified;
                } else {
                    context.TiposAnimal.Add(ta);
                }
                context.SaveChanges();
            }
        }

        public IList<TipoAnimal> TodosTiposAnimal()
        {
            using(var context = new EFContext())
            {
                return context.TiposAnimal.ToList<TipoAnimal>();
            }
        }

        public IList<TipoAnimal> TodosTiposAnimal(string nome)
        {
            using (var context = new EFContext())
            {
                return context.TiposAnimal.Where(p => p.Descricao.StartsWith(nome)).ToList<TipoAnimal>();
            }
        }

        public TipoAnimal ObterPorID(int id)
        {
            using(var context = new EFContext())
            {
                var tan = context.TiposAnimal.Single(i => i.TipoAnimalID == id);
                return tan;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var tipo = context.TiposAnimal.Single(a => a.TipoAnimalID == id);
                context.TiposAnimal.Remove(tipo);
                context.SaveChanges();
            }
        }
    }
}
