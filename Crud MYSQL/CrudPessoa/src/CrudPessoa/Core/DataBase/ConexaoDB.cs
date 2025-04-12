using CrudPessoa.Core.Settings;
using MySql.Data.MySqlClient;

namespace CrudPessoa.Core.DataBase
{
    // Classe responsável por gerenciar a conexão com o banco de dados
    public class ConexaoDB
    {
        // Conexão protegida, acessível apenas dentro da classe e suas classes filhas
        protected MySqlConnection Connection;

        // Construtor da classe que inicializa a conexão com o banco de dados
        public ConexaoDB()
        {
            // Cria um novo objeto MySqlConnection usando a string de conexão armazenada em ConfigDB
            Connection = new MySqlConnection(ConfigDB.ConnectionStringMySQL);
        }

        // Método protegido para abrir a conexão com o banco de dados
        protected void AbrirConexao()
        {
            try
            {
                // Verifica se a conexão está fechada antes de tentar abrir
                if (Connection.State == System.Data.ConnectionState.Closed)
                {
                    Connection.Open(); // Abre a conexão com o banco de dados
                }
            }
            catch (MySqlException ex) // Captura erros relacionados ao MySQL
            {
                // Exibe a mensagem de erro no console para facilitar depuração
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                throw; // Relança a exceção para que o erro possa ser tratado em outro lugar, se necessário
            }
        }

        // Método protegido para fechar a conexão com o banco de dados
        protected void FecharConexao()
        {
            // Verifica se a conexão está aberta antes de fechá-la
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close(); // Fecha a conexão
            }
        }
    }
}