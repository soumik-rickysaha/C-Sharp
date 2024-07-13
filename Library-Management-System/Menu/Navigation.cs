using Library_Management_System.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Menu
{
    internal class Navigation
    {
        //Objects Declarations

        LibraryMenu _menu = new LibraryMenu();
        StudentLogin _studentLogin = new StudentLogin();

        //Variable Declarations
        int userResponse;
        public void startProgram()
        {
            int totalInvalidTrys = 0;
            while (totalInvalidTrys < 4)
            {
                _menu.printMasterMenu();
                userResponse = _menu.getResponse();

                switch (userResponse)
                {
                    case 1:
                        bool validStudentFlag = _studentLogin.VerifyUsernameAndPassword();
                        if (validStudentFlag)
                        {
                            _menu.printStudentMenu();

                        }
                        else
                        {
                            Console.WriteLine("Invalid User");
                        }
                        break;
                    case 2:
                        _menu.printBookMenu();
                        break;
                    case 3:
                        _menu.printAdminMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Please Try Again.");
                        totalInvalidTrys++;
                        break;

                }

            }

            if (totalInvalidTrys > 3)
            {
                Console.WriteLine("Exiting Application. Reached Total Number of Invalid tries");
            }

        }
    }
}
