using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioEntity>> GetAll();

        Task<UsuarioEntity> GetById(int id);

        Task Insert(UsuarioInsertDTO usuario);

        Task Delete(int id);

        Task Update(UsuarioEntity usuario);
    }
}
