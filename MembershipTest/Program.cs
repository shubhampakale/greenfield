using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerseServices;
using ECommerseEntities;
using Services;
using Specifications;

namespace MembershipTes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAuthServices authServices = new AuthServices();
            AuthServices svc = new AuthServices();
            
            int choice;

            do
            {
                Console.WriteLine("\n 1.Login \n 2.Register \n 3.Forget Password \n 4.Change password \n 5.All users \n 0.Exit");
                Console.WriteLine("Enter your choice \n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    // Login
                    case 1: 
                        svc.SeedingCred();
                        Console.WriteLine("Enter your email :");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter your password :");
                        string loginpassword = Console.ReadLine();

                        if (svc.Login(username, loginpassword))
                        {
                            Console.WriteLine("Logged In");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Details");
                        }

                        break;

                    // Register
                    case 2: 
                        svc.SeedingUser();
                        Console.WriteLine("Enter ID = ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter fname = ");
                        string fname = Console.ReadLine();

                        Console.WriteLine("Enter lname = ");
                        string lname = Console.ReadLine();

                        Console.WriteLine("Enter email = ");
                        string email = Console.ReadLine();

                        Console.WriteLine("Enter Contact = ");
                        string contact = Console.ReadLine();

                        Console.WriteLine("Enter password = ");
                        string registerpassword = Console.ReadLine();

                        svc.Register(new Users {Id = id,FirstName =fname, LastName =lname, Email = email, ContactNumber =contact, Password= registerpassword } );

                        
                        

                        break;

                    //Forgot password
                    case 3:
                        Console.WriteLine("Enter username (email) = ");
                        string user = Console.ReadLine();
                        string pass = svc.ForgotPassword(user);
                        Console.WriteLine("Password is = "+ pass);
                        break;
                    
                    //Change password 
                    case 4:
                        // user naem and old password 
                        // list remove 
                        // new list with same user name and new pasword 
                        Console.WriteLine("Enter your email :");
                        string User= Console.ReadLine();
                        Console.WriteLine("Enter your old password :");
                        string Pass= Console.ReadLine();

                        if (svc.Login(User, Pass))
                        {
                            Console.WriteLine("Enter new password ");
                            string newPass = Console.ReadLine();
                            bool flag = svc.ChangePassword(User, newPass);
                            if (flag)
                            {
                                Console.WriteLine("Password changed succesfully");
                            }
                            else
                            {
                                Console.WriteLine("Error while changing password");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter correct credentials");
                        }
                           
                        break;
                    
                    // All users 
                    case 5:
                        List<Credential> alluser = svc.GetAllCredentials();
                        foreach(Credential c in alluser)
                        {
                            Console.WriteLine("Username = "+ c.Email +" " + "Password ="+ c.Password);
                        }
                        break;
                }
               
            }
            while(choice!=0);
            
        }
    }
}
