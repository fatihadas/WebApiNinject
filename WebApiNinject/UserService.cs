using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiNinject
{
    public class UserService : IUserService
    {
        public List<string> GetUserFullNames()
        {
            return new List<string> { "Fatih ADAŞ", "Mehmet Yilmaz", "Ahmet Coşan", "Kadir Dönmez", "Akif Sönmez" };
        }
    }
}