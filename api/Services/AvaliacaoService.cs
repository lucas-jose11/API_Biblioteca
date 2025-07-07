using API_Biblioteca.Contracts.Services;
using API_Biblioteca.DTO;
using API_Biblioteca.Entities;
using API_Biblioteca.Response;
using API_Biblioteca.Response.Avaliacao;

namespace API_Biblioteca.Services
{
    public class AvaliacaoService : IAvaliacaoService
    {
        public Task<MessageResponse> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AvaliacaoGetAllResponse> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AvaliacaoEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Post(AvaliacaoInsertDTO avaliacao)
        {
            throw new NotImplementedException();
        }

        public Task<MessageResponse> Update(AvaliacaoEntity avaliacao)
        {
            throw new NotImplementedException();
        }
    }
}
