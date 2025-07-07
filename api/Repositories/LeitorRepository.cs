using API_Biblioteca.Contracts.Repository;
using API_Biblioteca.DTO;
using API_Biblioteca.Entity;

namespace API_Biblioteca.Repository
{
    public class LeitorRepository : ILeitorRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeitorEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LeitorEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(LeitorInsertDTO leitor)
        {
            throw new NotImplementedException();
        }

        public Task Update(LeitorEntity leitor)
        {
            throw new NotImplementedException();
        }
    }
}
