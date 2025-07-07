using API_Biblioteca.Entities;

namespace API_Biblioteca.Response.Categoria
{
    public class CategoriaGetAllResponse
    {
        public IEnumerable<CategoriaEntity> Data { get; set; }
    }
}
