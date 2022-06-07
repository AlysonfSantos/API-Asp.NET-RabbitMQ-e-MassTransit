using CadVeicular.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadVeicular.Domain.Interfaces.Repositories
{
    public interface IMarcaRepository : IBaseRepository<Marca>
    {
        Task CadastrarMarca(Marca marca);

        Task<IEnumerable<Marca>> ListarMarca();
    }
}
