using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.ViewModel
{
    public class NovoVeiculoViewModel
    {
        public string RENAVAM { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
        public long Quilometragem { get; set; }
        public double Valor { get; set; }
        public bool Status { get; set; }
        public int ProprietarioId { get; set; }
        public NovoProprietarioViewModel Proprietario { get; set; }
        public int MarcaId { get; set; }
        public NovaMarcaViewModel Marca { get; set; }

    }
}
