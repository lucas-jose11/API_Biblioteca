using API_Biblioteca.DTO;
using API_Biblioteca.Entity;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Livro;

namespace API_Biblioteca.Contracts.Services
{
    public interface ILivroService
    {
        Task<LivroGetAllResponse> GetAll();

        Task<LivroEntity> GetById(int id);

        Task<MessageResponse> Post(LivroInsertDTO livro);

        Task<MessageResponse> Update(LivroEntity livro);

        Task<MessageResponse> Delete(int id);
    }
}
