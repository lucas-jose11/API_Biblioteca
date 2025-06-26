using API_Biblioteca.Entity;

namespace API_Biblioteca.Response.Leitor
{
    public class LeitorGetAllResponse
    {
        public IEnumerable<LeitorEntity> Data { get; set; }
    }
}
