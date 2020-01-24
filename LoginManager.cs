using System.Configuration;
using System.Collections.Generic;
using System;

namespace BusTicketBookingApplication
{
    class LoginManager
    {
        public static string session;
        private static string AdminLoginId = ConfigurationManager.AppSettings["USERNAME"].ToString();
        private static string AdminPassword = ConfigurationManager.AppSettings["PASSWORD"].ToString();
        public static string username;
        public static string password;
        internal static void CheckLogin()
        {
            Console.WriteLine("Enter E-mail id");
            username = Console.ReadLine();
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
            if(CheckAdmin(username,password))
            {
                if (session == "finallogin")
                {
                    session = "logged";
                    Console.WriteLine("Welcome!!! Admin");
                }
                else
                {
                session = "logged";
                    Console.WriteLine("Welcome!!! Admin");
                    Operation.AdminOperation();
                }
            }
            else if (UserRepositary.Login(username,password))
            {
                if (session == "finallogin")
                {
                    session = "logged";
                }
                else
                {
                    Console.WriteLine("Welcome User!!");
                    BusManager.SearchBus();
                }
            }
            else
            {
                Console.WriteLine("Login Details not found!! SignUp");
            }

        }
        internal static bool CheckAdmin(string username, string password)
        {
            
            if(username==AdminLoginId&&password==AdminPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
