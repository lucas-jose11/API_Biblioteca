using Microsoft.AspNetCore.Http.HttpResults;

namespace API_Biblioteca.Entities
{
    public class LivroEntity
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public int AnoPublicacao { get; set; }

        public int Genero_Id { get; set; }

        public string Sinopse {  get; set; }

        public int Avaliacao_Id { get; set; }

        public string ISBN { get; set; }
    }
}
