using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Contracts.Repository
{
    public interface ILeitorRepository
    {
        Task<IEnumerable<LeitorEntity>> GetAll();

        Task<LeitorEntity> GetById(int id);

        Task Insert(LeitorInsertDTO leitor);

        Task Delete(int id);

        Task Update(LeitorEntity leitor);
    }
}
