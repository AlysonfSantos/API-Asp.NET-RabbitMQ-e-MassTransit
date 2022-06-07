using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.ViewModel
{
    public class NovaMarcaViewModel
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
        public NovoVeiculoViewModel novoVeiculoViewMocel { get; set; }
    }
}
