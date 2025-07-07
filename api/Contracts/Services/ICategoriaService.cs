using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Categoria;

namespace API_Biblioteca.Contracts.Services
{
    public interface ICategoriaService
    {
        Task<CategoriaGetAllResponse> GetAll();

        Task<CategoriaEntity> GetById(int id);

        Task<MessageResponse> Post(CategoriaInsertDTO categoria);

        Task<MessageResponse> Update(CategoriaEntity categoria);

        Task<MessageResponse> Delete(int id);
    }
}
