using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Models
{
    public class Endereco

    {
        public Endereco() { }
        public int Id { get; private set; }
        public string Loradouro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public string Numero { get; private set; }

        public Endereco(string loradouro, string cidade, string estado, string cep, string numero)
        {
            Loradouro = loradouro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
            Numero = numero;
        }
    }
}
