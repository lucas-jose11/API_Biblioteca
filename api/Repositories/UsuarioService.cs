using API_Biblioteca.Contracts.Repositories;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Repositories
{
    public class UsuarioService : IUsuarioRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(UsuarioInsertDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task Update(UsuarioEntity usuario)
        {
            throw new NotImplementedException();
        }
    }
}
