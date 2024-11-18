using BankingPortal.Repositories;
using HDFCBankApp.Models;
using JsonDataRepositoryLib;
using System;
using System.Collections.Generic;
using System.IO;
using HDFCBankApp.Services;
using System.Linq;
using System.Web;

namespace HDFCBankApp.Services
{
    public class AuthServices : IAuthServices
    {
        string relativePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json_files", "credentials.json");

        public bool SeedingCred()
        {
            bool status;
            List<BankingUsers> credentials = new List<BankingUsers>
            {
                new BankingUsers { Email = "sp28@gmail.com", Password = "shub" }
            };

            IDataRepository<BankingUsers> repo = new JsonDataRepository<BankingUsers>();

            status = repo.Serialize(relativePath, credentials);
            return status;
        }

        public List<BankingUsers> GetAllCredentials()
        {
            
            List<BankingUsers> credentials = new List<BankingUsers>();
            IDataRepository<BankingUsers> repository = new JsonDataRepository<BankingUsers>();

            credentials = repository.Deserialize(relativePath);
            return credentials;
        }

        //Deserialize karun list madhe throw ani list madhe for each karun bool value retun karaychi 
        public bool Login(string username, string password)
        {
            // credentails from cred dat file 
            List<BankingUsers> credentials = GetAllCredentials();

            foreach (BankingUsers user in credentials)
            {
                if (user.Email == username)
                {
                    if (user.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}