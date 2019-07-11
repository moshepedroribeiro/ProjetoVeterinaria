using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class TipoServico
    {
        public int TipoServicoID { get; set; }
        public string Descricao { get; set; }
        public List<Servico> Servico { get; set; }
    }
}
