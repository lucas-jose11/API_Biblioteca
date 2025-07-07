using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Contracts.Repositories
{
    public interface IAvaliacaoRepository
    {
        Task<IEnumerable<AvaliacaoEntity>> GetAll();

        Task<AvaliacaoEntity> GetById(int id);

        Task Insert(AvaliacaoInsertDTO avaliacao);

        Task Delete(int id);

        Task Update(AvaliacaoEntity avaliacao);
    }
}
