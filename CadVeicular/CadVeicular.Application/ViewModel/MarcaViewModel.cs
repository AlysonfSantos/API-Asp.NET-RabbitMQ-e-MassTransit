using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.ViewModel
{
    public class MarcaViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public VeiculoViewModel veiculoViewModel { get; set; }

    }
}
