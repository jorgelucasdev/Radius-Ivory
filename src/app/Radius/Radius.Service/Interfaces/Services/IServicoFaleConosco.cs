using Radius.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IServicoFaleConosco
    {
        Task<FaleConoscoDTO> Adicionar(FaleConoscoDTO vm);
        Task<IEnumerable<FaleConoscoDTO>> ListarTodos();
    }
}
