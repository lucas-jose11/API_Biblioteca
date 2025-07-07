using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Contracts.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<CategoriaEntity>> GetAll();

        Task<CategoriaEntity> GetById(int id);

        Task Insert(CategoriaInsertDTO categoria);

        Task Delete(int id);

        Task Update(CategoriaEntity categoria);
    }
}
