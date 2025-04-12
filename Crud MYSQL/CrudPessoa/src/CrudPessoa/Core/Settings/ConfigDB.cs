namespace CrudPessoa.Core.Settings
{
    public static class ConfigDB
    {
        // Defina constantes para a conexão com o banco
        private const string SERVER = "localhost";

        private const string DATABASE = "cadastro";
        private const string USER = "root";
        private const string PASSWORD = "1234567";

        // String de conexão formatada
        public static string ConnectionStringMySQL =>
            $"Server={SERVER};Database={DATABASE};User Id={USER};Password={PASSWORD};";
    }
}