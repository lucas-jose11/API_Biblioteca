namespace API_Biblioteca.Entities
{
    public class AvaliacaoEntity
    {
        public int Id { get; set; }
       
        public int Usuario_Id { get; set; }
        
        public int Livro_Id { get; set; }
        
        public string Texto { get; set; }
    }
}
