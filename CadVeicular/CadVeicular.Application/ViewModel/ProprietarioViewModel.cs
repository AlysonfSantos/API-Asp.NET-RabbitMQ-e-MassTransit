using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.ViewModel
{
    public class ProprietarioViewModel : EnderecoViewModel
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string E_mail { get; set; }
        public bool Status { get; set; }

    }
}
