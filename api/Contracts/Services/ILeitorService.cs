using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Leitor;

namespace API_Biblioteca.Contracts.Services
{
    public interface ILeitorService
    {
        Task<LeitorGetAllResponse> GetAll();

        Task<LeitorEntity> GetById(int id);

        Task<MessageResponse> Post(LeitorInsertDTO leitor);

        Task<MessageResponse> Update(LeitorEntity leitor);

        Task<MessageResponse> Delete(int id);

    }
}
