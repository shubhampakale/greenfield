using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BinaryDataRepositoryLib;
using JsonDataRepositoryLib;
using Specifications;
using ECommerseEntities;

namespace EcommerseServices
{
    public class AuthServices : IAuthServices
    {
        string realtivePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views/credentials");
        public bool SeedingCred()
        {
            bool status;
            List<Credential> credentials = new List<Credential>
            {
                new Credential { Email = "sp28@gmail.com", Password = "shub" }
            };

            IDataRepository<Credential> repo = new JsonRepository<Credential>();
            //string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files", "credentials.dat");

            status = repo.Serialize(realtivePath, credentials);
            return status;
        }
        public bool SeedingUser()
        {
            bool status;
            List<Users> user = new List<Users>
            {
                new Users { Id=1, FirstName = "shubh", LastName ="Pakale", ContactNumber="1234", Email = "sp28@gmail.com", Password = "shub" }
            };

            IDataRepository<Users> repo = new BinaryRepository<Users>();
            //string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files", "credentials.dat");

            status = repo.Serialize("users.dat", user);
            return status;
        }



        public List<Credential> GetAllCredentials()
        {
            //string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dat_files", "credentials.dat");
            List<Credential> credentials = new List<Credential>();
            IDataRepository<Credential> repository = new JsonRepository<Credential>();

            credentials = repository.Deserialize(realtivePath);
            return credentials;
        }
        public bool Login(string username, string password)
        {
            // credentails from cred dat file 
            List<Credential> credentials = GetAllCredentials();
           
            foreach(Credential user in credentials) 
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

     

        public bool Register(Users users)
        {

            IDataRepository<Users> userRepo = new BinaryRepository<Users>();
            IDataRepository<Credential> credRepo = new BinaryRepository<Credential>();


            List<Users> existingUser = userRepo.Deserialize("users.dat");
            existingUser.Add(users);
            userRepo.Serialize("users.dat", existingUser);

            List<Credential> existingCred =  credRepo.Deserialize("credentials.dat");
            existingCred.Add(new Credential { Email = users.Email, Password = users.Password });
            credRepo.Serialize("credentials.dat", existingCred);

            return true;

        }
        public string ForgotPassword(string username)
        {
            List<Credential> credentials = GetAllCredentials();
            foreach (Credential user in credentials)
            {
                if(user.Email == username)
                {
                    return user.Password;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    
        public bool ChangePassword(string username, string newpassword)
        {
            List<Credential> credentials = GetAllCredentials();
            foreach (Credential user in credentials)
            {
                if (user.Email == username)
                {
                    user.Password = newpassword;
                }
            }
            IDataRepository<Credential> credRepo = new BinaryRepository<Credential>();
                 
            return credRepo.Serialize("credentials.dat", credentials);
           
        }

    }

}
