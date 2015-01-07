using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SRP.Good
{
    public static class SqlDatabase
    {
        private static SqlConnection _connection;

        public static SqlConnection GetConnection()
        {
            CreateConnection();            
            return _connection;
        }

        private static void CreateConnection()
        {
            if (_connection != null) 
                return;
            
            var connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            _connection = new SqlConnection(connectionString);
        }

        public static SqlCommand CreateCommand(string commandText, CommandType commandType)
        {
            var command = GetConnection().CreateCommand();
            command.Connection = GetConnection();
            command.CommandText = commandText;
            command.CommandType = commandType;

            return command;
        }

        public static SqlCommand CreateCommand(string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            var command = CreateCommand(commandText, commandType);

            command.Parameters.AddRange(parameters);

            return command;
        }

        public static SqlParameter GetParameter(string name, object value)
        {
            var parameter = new SqlParameter(name, value);
            return parameter;
        }
    }
}
