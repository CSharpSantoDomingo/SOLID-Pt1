using System;
using System.Data;
using System.Data.SqlClient;
using SRP.Common;

namespace SRP.Good
{
    public class LoginDal
    {
        private readonly Logger _logger;

        public LoginDal()
        {
            _logger = new Logger();
        }

        public UserDto Login(UserDto userDto)
        {
            try
            {
                var command = CreateAuthenticationCommandFromUser(userDto);
                
                command.Connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    userDto.Name = reader.GetString(0);
                }

                reader.Dispose();

                return userDto;
            }
            catch (Exception ex)
            {
                _logger.WriteToLog(ex.Message);
            }

            return null;
        }

        private SqlCommand CreateAuthenticationCommandFromUser(UserDto userDto)
        {
            var command = SqlDatabase.CreateCommand("uspLoginUser", CommandType.StoredProcedure, new []
            {
                SqlDatabase.GetParameter("UserName", userDto.UserName),
                SqlDatabase.GetParameter("Password", userDto.Password)
            });

            return command;
        }
    }
}
