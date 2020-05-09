using IdentityModel;
using System.Collections.Generic;
using System.Security.Claims;

namespace Auth
{
    public class Users
    {
        public List<User> Get()
        {
            return new List<User>
            {
                new User
                {
                    SubjectId = "5BE86359-073C-434B-AD2D-A3932222DABE",
                    Username = "Jon",
                    Password = "password",
                    Claims = new List<Claim> 
                    {
                        new Claim(JwtClaimTypes.Email, "kvv.login@gmail.com"),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }
                }
            };
        }
    }
}
