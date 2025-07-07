using API_Biblioteca.Contracts.Services;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Categoria;

namespace API_Biblioteca.Services
{
    public class CategoriaService : ICategoriaService
    {
        public Task<MessageResponse> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaGetAllResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Post(CategoriaInsertDTO categoria)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Update(CategoriaEntity categoria)
        {
            throw new NotImplementedException();
        }
    }
}
