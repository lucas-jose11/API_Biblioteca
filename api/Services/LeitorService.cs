using API_Biblioteca.Contracts.Services;
using API_Biblioteca.DTO;
using API_Biblioteca.Entity;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Leitor;

namespace API_Biblioteca.Services
{
    public class LeitorService : ILeitorService
    {
        public Task<MessageResponse> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LeitorGetAllResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LeitorEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Post(LeitorInsertDTO leitor)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Update(LeitorEntity leitor)
        {
            throw new NotImplementedException();
        }
    }
}
