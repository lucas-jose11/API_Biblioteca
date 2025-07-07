using API_Biblioteca.Contracts.Repositories;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;

namespace API_Biblioteca.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(CategoriaInsertDTO categoria)
        {
            throw new NotImplementedException();
        }

        public Task Update(CategoriaEntity categoria)
        {
            throw new NotImplementedException();
        }
    }
}
