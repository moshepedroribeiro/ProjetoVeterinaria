using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Exame
    {
        public int ExameID { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public virtual List<ProntuarioExame> ProntuarioExame { get; set; }
    }
}
