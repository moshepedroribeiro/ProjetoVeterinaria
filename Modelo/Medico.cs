using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo
{
    public class Medico
    {
        public int MedicoID { get; set; }
        public string Nome { get; set; }
        public string Crmv { get; set; }
        public string Senha { get; set; }
        public List<Consulta> Consulta { get; set; }
    }
}
