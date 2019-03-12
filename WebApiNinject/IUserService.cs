using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiNinject
{
    public interface IUserService
    {
        List<string> GetUserFullNames();
    }
}