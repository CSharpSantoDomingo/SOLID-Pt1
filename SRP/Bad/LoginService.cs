using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace SRP.Bad
{
    public class LoginService
    {
        public bool LoginUsuario(string userName, string password)
        {
            var result = false;

            var connection = new SqlConnection(@"Server=.\sqlexpress;Database=RHN;Integrated Security=true");
            var command = connection.CreateCommand();

            command.CommandText = @"SELECT UserName FROM Users WHERE UserName = '" + userName + "'" + 
                                    "AND Password = '" + password + "'";

            try
            {
                connection.Open();
                var name = command.ExecuteScalar().ToString();

                return !string.IsNullOrEmpty(name);    
            }
            catch (Exception ex)
            {
                var logger = new StringWriter();
                logger.WriteLine(ex.Message);
                logger.Flush();
            }

            return false;
        }
    }
}
