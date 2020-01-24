using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BusTicketBookingApplication
{
    class UserRepositary
    {
        static Dictionary<string, UserDetails> UserData = new Dictionary<string, UserDetails>();
        static string Username { set;get; }
        private static string Password { set; get; }
      
        internal static void SignUp()
        {
            Console.WriteLine("Sign-up");
            Console.WriteLine("Enter Email Id to continue");
            do
            {
                Username = Console.ReadLine();
            } while (!isValidEmail(Username));

            UserData.Add(Username, new UserDetails());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Username added");
            Console.WriteLine("Please login to book ticket");
            Console.WriteLine("--------------------------------------");
            //Login(Username,Password,UserData);
        }
        public static bool isValidEmail(string inputEmail)
        {

            // This Pattern is use to verify the email 
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                Console.WriteLine("enter correct Email");
                return (false);
        }
        internal static bool Login(String username,string password)
        {
            Username = username;
            Password=password;
           
                foreach (KeyValuePair<string, UserDetails> key in UserData)
                {
                    UserDetails user = (UserDetails)key.Value;
                    if (UserData.ContainsKey(Username) && user.Password == Password)
                    {
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("Logged In");
                        
                        return true;
                    }
                    else
                    {
                    
                        return false;
                    }

                }
            
            return false;
        } 
    }
}
