using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ProprietarioDAL
    {
        public IList<Proprietario> TodosProprietarios()
        {
            using(var context = new EFContext())
            {
                return context.Proprietarios.Include(tp => tp.TipoProprietario).ToList<Proprietario>();
            }
        }

        public IList<Proprietario> TodosProprietarios(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Proprietarios.Where(p => p.Nome.StartsWith(nome)).Include(tp => tp.TipoProprietario).ToList<Proprietario>();
            }
        }

        public IList<Proprietario> ProprietariosPorTipo(int idTipo)
        {
            using (var context = new EFContext())
            {
                return context.Proprietarios.Include(a => a.TipoProprietario).Where(a => a.TipoProprietarioID == idTipo).ToList<Proprietario>();
            }
        }

        public void Gravar(Proprietario p)
        {
            using (var context = new EFContext())
            {
                if (p.ProprietarioID > 0)
                {
                    context.Entry(p).State = EntityState.Modified;
                }
                else
                {
                    context.Proprietarios.Add(p);
                }
                context.SaveChanges();
            }
        }

        public Proprietario ObterPorID(int id)
        {
            using(var context = new EFContext())
            {
                var proprietario = context.Proprietarios.Single(p => p.ProprietarioID == id);
                context.Entry(proprietario).Reference(p => p.TipoProprietario).Load();
                return proprietario;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var propr = context.Proprietarios.Single(p => p.ProprietarioID == id);
                context.Proprietarios.Remove(propr);
                context.SaveChanges();
            }
        }
    }
}
