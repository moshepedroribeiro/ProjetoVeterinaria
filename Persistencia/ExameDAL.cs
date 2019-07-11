using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ExameDAL
    {
        public void Gravar(Exame e)
        {
            using (var context = new EFContext())
            {
                if (e.ExameID > 0)
                {
                    context.Entry(e).State = EntityState.Modified;
                }
                else
                {
                    context.Exames.Add(e);
                }
                context.SaveChanges();
            }
        }

        public IList<Exame> TodosExames()
        {
            using (var context = new EFContext())
            {
                return context.Exames.ToList<Exame>();
            }
        }

        public IList<Exame> TodosExames(string descricao)
        {
            using (var context = new EFContext())
            {
                return context.Exames.Where(p => p.Descricao.StartsWith(descricao)).ToList<Exame>();
            }
        }

        public Exame ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var ex = context.Exames.Single(i => i.ExameID == id);
                return ex;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var exame = context.Exames.Single(a => a.ExameID == id);
                context.Exames.Remove(exame);
                context.SaveChanges();
            }
        }
    }
}
