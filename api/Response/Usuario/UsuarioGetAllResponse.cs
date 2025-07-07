using API_Biblioteca.Entities;

namespace API_Biblioteca.Response.Usuario
{
    public class UsuarioGetAllResponse
    {
        public IEnumerable<UsuarioEntity> Data { get; set; }
    }
}
