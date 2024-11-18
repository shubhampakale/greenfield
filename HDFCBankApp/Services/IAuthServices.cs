using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankApp.Services
{
    public interface IAuthServices
    {
        bool Login(string username, string password);

       
    }
}
