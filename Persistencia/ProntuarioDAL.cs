using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ProntuarioDAL
    {
        public IList<Prontuario> TodosProntuarios(int idAnimal)
        {
            using(var context = new EFContext()) {
                return context.Prontuarios.Where(ida => ida.AnimalID == idAnimal).Include(a => a.Animal).ToList<Prontuario>();
            }
        }

        public IList<Prontuario> TodosProntuarios(int idAnimal, string data)
        {
            using (var context = new EFContext())
            {
                return context.Prontuarios.Include(a => a.Animal).Where(b => b.Data.ToString("dd/MM/yyyy") == data && b.AnimalID == idAnimal).ToList<Prontuario>();
            }
        }

        public void Gravar(Prontuario p)
        {
            using (var context = new EFContext())
            {
                if (p.ProntuarioID > 0)
                {
                    context.Entry(p).State = EntityState.Modified;
                }
                else
                {
                    context.Prontuarios.Add(p);
                }
                context.SaveChanges();
            }
        }

        public Prontuario ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var pron = context.Prontuarios.Single(p => p.ProntuarioID == id);
                context.Entry(pron).Reference(p => p.Animal).Load();
                return pron;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var pron = context.Prontuarios.Single(p => p.ProntuarioID == id);
                context.Prontuarios.Remove(pron);
                context.SaveChanges();
            }
        }

        public IList<Prontuario> ProntuariosPorAnimal(int idAnimal)
        {
            using (var context = new EFContext())
            {
                return context.Prontuarios.Include(a => a.Animal).Where(a => a.AnimalID == idAnimal).ToList<Prontuario>();
            }
        }
    }
}
