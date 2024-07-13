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
            _menu.printMasterMenu();
            userResponse=_menu.getResponse();

            switch (userResponse)
            {
                case 1:
                    Console.WriteLine("Student Login");
                    break;
            }

            
        }
    }
}
