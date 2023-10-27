using Stock.Data;
using Stock.Data.Entities;
using System.Security.AccessControl;

namespace Stock.Services.Implementatios
{
    public class UserService
    {
        private readonly ConsultaContext _consultaContext;
        public UserService(ConsultaContext consultaContext)
        {
            _consultaContext = consultaContext;
        }
        //Usamos una tupla para poder validar el usuario
        public Tuple<bool, User?> ValidarUsuario(string email, string password)
        {
            User? userForLogin= _consultaContext.Users.SingleOrDefault(u=>u.Email == email);
            if (userForLogin != null) 
            {
                if (userForLogin.Password == password) 
                {
                    return new Tuple<bool, User?>(true, userForLogin);
                }
                return new Tuple<bool, User?>(false, userForLogin);
            }
            return new Tuple<bool, User?>(false, null);
        }
    }
}
