using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingPortal.Services
{
    public class AuthServices : IAuthServices
    {
        public bool ChangePassword(string username, string oldpassword)
        {
            throw new NotImplementedException();
        }

        public string ForgotPassword(string username)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(BankingUsers users)
        {
            throw new NotImplementedException();
        }
    }
}