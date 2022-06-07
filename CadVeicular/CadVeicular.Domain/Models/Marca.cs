using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Models
{
    public class Marca
    {
        public Marca() { }
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public bool Status { get; private set; }
        public Marca(string nome, bool status)
        {
            Nome = nome;
            Status = status;
        }


    }
}
