using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Usuario;

namespace API_Biblioteca.Contracts.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioGetAllResponse> GetAll();

        Task<UsuarioEntity> GetById(int id);

        Task<MessageResponse> Post(UsuarioInsertDTO usuario);

        Task<MessageResponse> Update(UsuarioEntity usuario);

        Task<MessageResponse> Delete(int id);
    }
}
