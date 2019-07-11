using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Persistencia
{
    public class MedicoDAL
    {
        public void Gravar(Medico m)
        {
            using (var context = new EFContext())
            {
                if (m.MedicoID > 0)
                {
                    context.Entry(m).State = EntityState.Modified;
                }
                else
                {
                    context.Medicos.Add(m);
                }
                context.SaveChanges();
            }
        }

        public IList<Medico> TodosMedicos()
        {
            using (var context = new EFContext())
            {
                return context.Medicos.ToList<Medico>();
            }
        }

        public IList<Medico> TodosMedicos(string nome)
        {
            using (var context = new EFContext())
            {
                return context.Medicos.Where(p => p.Nome.StartsWith(nome)).ToList<Medico>();
            }
        }

        public IList<Medico> TodosMedicos(int id)
        {
            using (var context = new EFContext())
            {
                return context.Medicos.Where(p => p.MedicoID == id).ToList<Medico>();
            }
        }

        public Medico ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var m = context.Medicos.Single(i => i.MedicoID == id);
                return m;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var medico = context.Medicos.Single(a => a.MedicoID == id);
                context.Medicos.Remove(medico);
                context.SaveChanges();
            }
        }
    }
}
