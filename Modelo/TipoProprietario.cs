using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class TipoProprietario
    {
        public int TipoProprietarioID { get; set; }
        public string Descricao { get; set; }
        public int PercentualDesconto { get; set; }
        public virtual List<Proprietario> Proprietario { get; set; }
    }
}
