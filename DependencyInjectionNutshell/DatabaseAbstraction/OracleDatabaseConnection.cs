namespace DependencyInjectionNutshell.DatabaseAbstraction
{
    class OracleDatabaseConnection
    {
        private readonly string _connectionString;

        public OracleDatabaseConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
