using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.Messages
{
    public interface CustomerCreatedMarcaEvent
    {
        string Id { get;  }
        string Nome { get; }
        string Status { get;  }
       
    }
}
