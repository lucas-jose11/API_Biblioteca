using API_Biblioteca.DTO;
using API_Biblioteca.Entity;

namespace API_Biblioteca.Contracts.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<LivroEntity>> GetAll();

        Task<LivroEntity> GetById(int id);

        Task Insert(LivroInsertDTO livro);

        Task Delete(int id);

        Task Update(LivroEntity livro);
    }
}
