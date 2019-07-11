using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class ConsultaDAL
    {
        public IList<Consulta> TodasConsultas()
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Include(a => a.Animal).Include(a => a.Medico).ToList<Consulta>();
            }
        }

        public IList<Consulta> TodasConsultas(string horario)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where(p => p.Horario.ToString("dd/MM/yyyy hh:mm") == horario).Include(a => a.Animal).Include(a => a.Medico).ToList<Consulta>();
            }
        }
        public IList<Consulta> TodasConsultasData(string horario)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Where(p => p.Horario.ToString("dd/MM/yyyy") == horario).Include(a => a.Animal).Include(a => a.Medico).ToList<Consulta>();
            }
        }


        public IList<Consulta> ConsultasPorMedico(int idMedico)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Include(a => a.Medico).Where(a => a.MedicoID == idMedico).ToList<Consulta>();
            }
        }

        public IList<Consulta> ConsultasPorAnimal(int idAnimal)
        {
            using (var context = new EFContext())
            {
                return context.Consultas.Include(a => a.Animal).Where(a => a.AnimalID == idAnimal).ToList<Consulta>();
            }
        }

        public void Gravar(Consulta a)
        {
            using (var context = new EFContext())
            {
                if (a.ConsultaID > 0)
                {
                    context.Entry(a).State = EntityState.Modified;
                }
                else
                {
                    context.Consultas.Add(a);
                }

                context.SaveChanges();
            }
        }

        public Consulta ObterPorID(int id)
        {
            using (var context = new EFContext())
            {
                var consulta = context.Consultas.Single(a => a.ConsultaID == id);
                context.Entry(consulta).Reference(a => a.Animal).Load();
                context.Entry(consulta).Reference(a => a.Medico).Load();
                return consulta;
            }
        }

        public void Remover(int id)
        {
            using (var context = new EFContext())
            {
                var c = context.Consultas.Single(a => a.ConsultaID == id);
                context.Consultas.Remove(c);
                context.SaveChanges();
            }
        }
    }
}
