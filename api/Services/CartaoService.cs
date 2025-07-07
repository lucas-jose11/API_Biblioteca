using API_Biblioteca.Contracts.Services;
using API_Biblioteca.DTO;
using API_Biblioteca.Entity;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Cartao;

namespace API_Biblioteca.Services
{
    public class CartaoService : ICartaoService
    {
        public Task<MessageResponse> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CartaoGetAllResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CartaoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Post(CartaoInsertDTO cartao)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Update(CartaoEntity cartao)
        {
            throw new NotImplementedException();
        }
    }
}
