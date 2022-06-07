using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Interfaces.Services
{
    public interface IProprietarioService
    {
        Task<Proprietario> CadastrarProprietario(Proprietario Proprietario);

        Task<IEnumerable<Proprietario>> ListarProprietario();
    }
}
