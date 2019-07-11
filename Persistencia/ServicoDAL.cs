using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ServicoDAL
    {
        public IList<Servico> TodosServicos()
        {
            using (var context = new EFContext())
            {
                return context.Servicos.Include(a => a.Animal).Include(a => a.TipoServico).ToList<Servico>();
            }
        }

        public IList<Servico> TodosServicos(string horario)
        {
            using (var context = new EFContext())
            {
                return context.Servicos.Where(p => p.Horario == horario).Include(a => a.Animal).Include(a => a.TipoServico).ToList<Servico>();
            }
        }

        public void Gravar(Servico s)
        {
            using (var context = new EFContext())
            {
                if (s.ServicoID > 0)
                {
                    context.Entry(s).State = EntityState.Modified;
                }
                else
                {
                    context.Servicos.Add(s);
                }

                context.SaveChanges();
            }
        }

        public Servico ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var servicos = context.Servicos.Single(a => a.ServicoID == id);
                context.Entry(servicos).Reference(a => a.Animal).Load();
                context.Entry(servicos).Reference(a => a.TipoServico).Load();
                return servicos;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var c = context.Servicos.Single(a => a.ServicoID == id);
                context.Servicos.Remove(c);
                context.SaveChanges();
            }
        }
    }
}
