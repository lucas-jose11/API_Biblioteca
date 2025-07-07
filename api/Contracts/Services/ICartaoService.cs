using API_Biblioteca.DTO;
using API_Biblioteca.Entity;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Cartao;

namespace API_Biblioteca.Contracts.Services
{
    public interface ICartaoService
    {
        Task<CartaoGetAllResponse> GetAll();

        Task<CartaoEntity> GetById(int id);

        Task<MessageResponse> Post(CartaoInsertDTO cartao);

        Task<MessageResponse> Update(CartaoEntity cartao);

        Task<MessageResponse> Delete(int id);
    }
}
