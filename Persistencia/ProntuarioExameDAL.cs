using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ProntuarioExameDAL
    {
        public void Gravar(ProntuarioExame pe)
        {
            using (var context = new EFContext())
            {
                if (pe.ProntuarioExameID > 0)
                {
                    context.Entry(pe).State = EntityState.Modified;
                }
                else
                {
                    context.ProntuarioExame.Add(pe);
                }

                context.SaveChanges();
            }
        }

        public IList<ProntuarioExame> TodosExamesPorProntuario(int idProntuario)
        {
            using (var context = new EFContext())
            {
                return context.ProntuarioExame.Where(i => i.ProntuarioID == idProntuario).Include(e => e.Exame).ToList<ProntuarioExame>();
            }
        }
    }
}
