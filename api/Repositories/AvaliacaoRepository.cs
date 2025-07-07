using API_Biblioteca.Contracts.Repositories;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AvaliacaoEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AvaliacaoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(AvaliacaoInsertDTO avaliacao)
        {
            throw new NotImplementedException();
        }

        public Task Update(AvaliacaoEntity avaliacao)
        {
            throw new NotImplementedException();
        }
    }
}
