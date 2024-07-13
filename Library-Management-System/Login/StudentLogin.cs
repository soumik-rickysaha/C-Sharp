using Library_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Login
{
    internal class StudentLogin
    {
        String username;
        String password;

        //public StudentLogin() { 
        //    printBlankLines();
            
        //}

        public bool VerifyUsernameAndPassword() {

            Console.Write("Enter Username : ");
            username = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();

            // Verify user input with hard coded values for now
            // Username : StudentAdmin
            // Password : Gei321itc


            if (username == "StudentAdmin" && password == "Gei321itc")
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
