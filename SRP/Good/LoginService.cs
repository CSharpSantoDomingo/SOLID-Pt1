using SRP.Common;

namespace SRP.Good
{
    public class LoginService
    {
        private readonly LoginDal _loginDal;

        public LoginService()
        {
            _loginDal = new LoginDal();
        }

        public bool AuthenticateUser(UserDto userDto)
        {
            var result = true;

            var authenticatedUser = _loginDal.Login(userDto);

            if (authenticatedUser == null)
                result = false;

            return result;
        }
    }
}
