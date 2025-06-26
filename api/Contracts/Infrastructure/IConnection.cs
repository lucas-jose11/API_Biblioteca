using MySql.Data.MySqlClient;

namespace API_Biblioteca.Contracts.Infrestructure
{
    public interface IConnection
    {
        MySqlConnection GetConnection();

        Task<int> Execute(string sql, object obj);
    }
}
