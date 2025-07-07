using API_Biblioteca.Contracts.Services;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Usuario;

namespace API_Biblioteca.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Task<MessageResponse> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioGetAllResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Post(UsuarioInsertDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Update(UsuarioEntity usuario)
        {
            throw new NotImplementedException();
        }
    }
}
