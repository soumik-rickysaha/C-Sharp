using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Menu
{
    internal class Navigation
    {
        LibraryMenu _menu = new LibraryMenu();
        int userResponse;
        public void startProgram()
        {
            int totalInvalidTrys = 0;
            while (totalInvalidTrys<4)
            {
                _menu.printMasterMenu();
                userResponse = _menu.getResponse();

                switch (userResponse)
                {
                    case 1:
                        _menu.printStudentMenu();
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
