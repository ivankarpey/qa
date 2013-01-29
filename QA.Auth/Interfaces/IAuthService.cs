using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.Auth
{
    interface IAuthService
    {
        bool LogIn(String hash);

        String GetHash(String username, String password);
    }
}
