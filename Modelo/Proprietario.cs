using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Proprietario
    {
        public int ProprietarioID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string RgIe { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public int TipoProprietarioID { get; set; }
        public virtual TipoProprietario TipoProprietario { get; set; }
        public virtual List<Animal> Animal { get; set; }
    }
}
