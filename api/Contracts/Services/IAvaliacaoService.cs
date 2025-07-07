using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Avaliacao;

namespace API_Biblioteca.Contracts.Services
{
    public interface IAvaliacaoService
    {
        Task<AvaliacaoGetAllResponse> GetAll();

        Task<AvaliacaoEntity> GetById(int id);

        Task<MessageResponse> Post(AvaliacaoInsertDTO avaliacao);

        Task<MessageResponse> Update(AvaliacaoEntity avaliacao);

        Task<MessageResponse> Delete(int id);
    }
}
