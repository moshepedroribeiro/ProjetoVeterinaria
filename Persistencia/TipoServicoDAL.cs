using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class TipoServicoDAL
    {
        public void Gravar(TipoServico ts)
        {
            using (var context = new EFContext())
            {
                if (ts.TipoServicoID > 0)
                {
                    context.Entry(ts).State = EntityState.Modified;
                }
                else
                {
                    context.TiposServico.Add(ts);
                }
                context.SaveChanges();
            }
        }

        public IList<TipoServico> TodosTiposServico()
        {
            using (var context = new EFContext())
            {
                return context.TiposServico.ToList<TipoServico>();
            }
        }

        public IList<TipoServico> TodosTiposServico(string descricao)
        {
            using (var context = new EFContext())
            {
                return context.TiposServico.Where(p => p.Descricao.StartsWith(descricao)).ToList<TipoServico>();
            }
        }

        public TipoServico ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var ts = context.TiposServico.Single(i => i.TipoServicoID == id);
                return ts;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var tipo = context.TiposServico.Single(a => a.TipoServicoID == id);
                context.TiposServico.Remove(tipo);
                context.SaveChanges();
            }
        }
    }
}
