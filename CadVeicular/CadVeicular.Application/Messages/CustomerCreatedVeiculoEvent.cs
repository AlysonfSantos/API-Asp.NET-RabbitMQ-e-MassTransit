using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.Messages
{
    public interface CustomerCreatedVeiculoEvent
    {
       
        string Id { get;  }
        string RENAVAM { get;  }
        string Modelo { get; }
        DateTime AnoFabricacao { get; }
        DateTime AnoModelo { get;  }
        string Quilometragem { get; }
        string Valor { get;  }
        string Status { get; }
        string ProprietarioId { get; }
        string MarcaId { get;  }
   
    }
}
