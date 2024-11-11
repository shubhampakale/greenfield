using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;

namespace Specifications
{
    public interface IAuthServices
    {
        bool Login(string username, string password);

        bool Register(Users users);

        string ForgotPassword(string username);

        bool ChangePassword(string username, string oldpassword);




    }
}
