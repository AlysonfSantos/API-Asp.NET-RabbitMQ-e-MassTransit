using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Models
{
    public class Veiculo
    {
        public Veiculo() { }
        public long Id { get; private set; }
        public string RENAVAM { get; private set; }
        public string Modelo { get; private set; }
        public DateTime AnoFabricacao { get; private set; }
        public DateTime AnoModelo { get; private set; }
        public long Quilometragem { get; private set; }
        public double Valor { get; private set; }
        public bool Status { get; private set; }
        public int ProprietarioId { get; private set; }
        public Proprietario Proprietario { get; private set; }
        public int MarcaId { get; private set; }
        public Marca Marca { get; private set; }
        //FERICAR A PASSAGEM DAS Fk PARA O CONSTRUTOR
        public Veiculo(string renavam, string modelo, DateTime anoFabricacao, DateTime anoModelo,
            long quilometragem, double valor, bool status, int proprietarioId, int marcaId)
        {
            RENAVAM = renavam;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            Quilometragem = quilometragem;
            Valor = valor;
            Status = status;
            ProprietarioId = proprietarioId;
            MarcaId = marcaId;

        }

    }
}
