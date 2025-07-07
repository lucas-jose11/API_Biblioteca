using API_Biblioteca.Contracts.Repositories;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LivroEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LivroEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(LivroInsertDTO livro)
        {
            throw new NotImplementedException();
        }

        public Task Update(LivroEntity livro)
        {
            throw new NotImplementedException();
        }
    }
}
