using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class TipoProprietarioDAL
    {
        private EFContext context;

        public void Gravar(TipoProprietario tp)
        {
            using (var context = new EFContext())
            {
                if(tp.TipoProprietarioID > 0)
                {
                    context.Entry(tp).State = EntityState.Modified;
                } else
                {
                    context.TiposProprietario.Add(tp);
                }
                
                context.SaveChanges();
            }
        }

        public IList<TipoProprietario> TodosTiposProprietarios()
        {
            using(var context = new EFContext())
            {
                return context.TiposProprietario.ToList<TipoProprietario>();
            }
        }

        public IList<TipoProprietario> TodosTiposProprietarios(string nome)
        {
            using (var context = new EFContext())
            {
                return context.TiposProprietario.Where(p => p.Descricao.StartsWith(nome)).ToList<TipoProprietario>();
            }
        }

        public TipoProprietario ObterPorID(int id)
        {
            using(var context = new EFContext())
            {
                var tp = context.TiposProprietario.Single(tipo => tipo.TipoProprietarioID == id);
                return tp;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var tipo = context.TiposProprietario.Single(a => a.TipoProprietarioID == id);
                context.TiposProprietario.Remove(tipo);
                context.SaveChanges();
            }
        }
    }
}
