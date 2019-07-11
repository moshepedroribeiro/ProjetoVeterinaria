using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ContasReceberDAL
    {
        public IList<ContasReceber> TodasContasReceber()
        {
            using (var context = new EFContext())
            {
                return context.ContasReceber.Include(a => a.Consulta).ToList<ContasReceber>();
            }
        }

        public IList<ContasReceber> TodasContasReceber(string data)
        {
            using (var context = new EFContext())
            {
                return context.ContasReceber.Where(p => p.DataCriacao == data).Include(a => a.Consulta).ToList<ContasReceber>();
            }
        }

        public void Gravar(ContasReceber cr)
        {
            using (var context = new EFContext())
            {
                if (cr.ContasReceberID > 0)
                {
                    context.Entry(cr).State = EntityState.Modified;
                }
                else
                {
                    context.ContasReceber.Add(cr);
                }

                context.SaveChanges();
            }
        }

        public void GravarList(List<ContasReceber> cr)
        {
            using (var context = new EFContext())
            {
                foreach (var c in cr)
                {
                    context.ContasReceber.Add(c);
                    
                }
                context.SaveChanges();
            }
        }

        public ContasReceber ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var conta = context.ContasReceber.Single(a => a.ServicoID == id);
                context.Entry(conta).Reference(a => a.Consulta).Load();
                return conta;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var c = context.ContasReceber.Single(a => a.ContasReceberID == id);
                context.ContasReceber.Remove(c);
                context.SaveChanges();
            }
        }
    }
}
