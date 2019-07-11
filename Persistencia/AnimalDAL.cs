
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class AnimalDAL
    {
        public IList<Animal> TodosAnimais()
        {
            using(var context = new EFContext())
            {
                return context.Animais.Include(a => a.TipoAnimal).Include(a => a.Proprietario).ToList<Animal>();
            }
        }

        public IList<Animal> TodosAnimais(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Animais.Where(p => p.Nome.StartsWith(nome)).Include(tp => tp.Proprietario).Include(tp => tp.TipoAnimal).ToList<Animal>();
            }
        }

        public IList<Animal> AnimaisPorTipo(int idTipo)
        {
            using(var context = new EFContext())
            {
                return context.Animais.Include(a => a.TipoAnimal).Include(a => a.Proprietario).Where(a => a.TipoAnimalID == idTipo).ToList<Animal>();
            }
        }

        public IList<Animal> AnimaisPorProprietario(int idProp)
        {
            using (var context = new EFContext())
            {
                return context.Animais.Include(a => a.Proprietario).Where(a => a.ProprietarioID == idProp).ToList<Animal>();
            }
        }

        public void Gravar(Animal a)
        {
            using (var context = new EFContext())
            {
                if (a.AnimalID > 0)
                {
                    context.Entry(a).State = EntityState.Modified;
                } else
                {
                    context.Animais.Add(a);
                }

                context.SaveChanges();
            }
        }

        public Animal ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var animal = context.Animais.Single(a => a.AnimalID == id);
                context.Entry(animal).Reference(a => a.TipoAnimal).Load();
                context.Entry(animal).Reference(a => a.Proprietario).Load();
                return animal;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var animal = context.Animais.Single(a => a.AnimalID == id);
                context.Animais.Remove(animal);
                context.SaveChanges();
            }
        }
    }
}
