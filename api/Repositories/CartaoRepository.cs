using API_Biblioteca.Contracts.Repositories;
using API_Biblioteca.DTO;
using API_Biblioteca.Entity;

namespace API_Biblioteca.Repositories
{
    public class CartaoRepository : ICartaoRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartaoEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CartaoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(CartaoInsertDTO cartao)
        {
            throw new NotImplementedException();
        }

        public Task Update(CartaoEntity cartao)
        {
            throw new NotImplementedException();
        }
    }
}
