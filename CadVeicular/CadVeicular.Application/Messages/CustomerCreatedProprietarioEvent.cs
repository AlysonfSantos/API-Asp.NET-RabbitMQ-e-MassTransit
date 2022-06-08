using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Application.Messages
{
    public interface CustomerCreatedProprietarioEvent
    {

        string Id { get; }
        string Nome { get; }
        string Documento { get; }
        string E_mail { get; }
        string Status { get; }
        string Loradouro { get; }
        string Cidade { get; }
        string Estado { get; }
        string CEP { get; }
        string Numero { get; }
    }
}
