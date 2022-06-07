using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Models
{
    public class Proprietario : Endereco
    {
        public Proprietario() { }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public string E_mail { get; private set; }
        public bool Status { get; private set; }

        public Proprietario(string nome, string documento, string e_mail, bool status, string loradouro, string cidade, string estado, string cep, string numero)
        {
            Nome = nome;
            Documento = documento;
            E_mail = e_mail;
            Status = status;

        }

    }
}
