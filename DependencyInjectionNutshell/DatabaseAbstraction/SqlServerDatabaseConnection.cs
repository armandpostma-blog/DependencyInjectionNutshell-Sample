namespace DependencyInjectionNutshell.DatabaseAbstraction
{
    public class SqlServerDatabaseConnection : IDatabaseConnection
    {
        private readonly string _connectionString;

        public SqlServerDatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
