using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Interfaces.Repositories
{
    public interface IProprietarioRepository : IBaseRepository<Proprietario>
    {
        Task CadastrarProprietario(Proprietario proprietario);

        Task<IEnumerable<Proprietario>> ListarProprietario();
    }
}
