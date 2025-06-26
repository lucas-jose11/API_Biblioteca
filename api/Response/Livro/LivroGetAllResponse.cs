using API_Biblioteca.Entity;

namespace API_Biblioteca.Response.Livro
{
    public class LivroGetAllResponse
    {
        public IEnumerable<LivroEntity> Data { get; set; }

    }
}
