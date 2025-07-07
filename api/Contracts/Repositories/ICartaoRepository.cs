using API_Biblioteca.DTO;
using API_Biblioteca.Entity;

namespace API_Biblioteca.Contracts.Repositories
{
    public interface ICartaoRepository
    {
        Task<IEnumerable<CartaoEntity>> GetAll();

        Task<CartaoEntity> GetById(int id);

        Task Insert(CartaoInsertDTO cartao);

        Task Delete(int id);

        Task Update(CartaoEntity cartao);
    }
}
