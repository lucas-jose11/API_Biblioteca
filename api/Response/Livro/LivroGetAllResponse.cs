using API_Biblioteca.Entities;

namespace API_Biblioteca.Response.Livro
{
    public class LivroGetAllResponse
    {
        public IEnumerable<LivroEntity> Data { get; set; }

    }
}
