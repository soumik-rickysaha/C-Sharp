using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Menu
{
    internal class LibraryMenu
    {
       public void LoadBookMenu()
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Return Book");
        }

        public void LoadAdminMenu()
        {
            Console.WriteLine("1. Login");            
            Console.WriteLine("2. Add Admin");
            Console.WriteLine("3. Create Student Card");
            Console.WriteLine("4. Print Book Inventory Count");
            Console.WriteLine("5. Print Total Student Cards");
            Console.WriteLine("6. Add Librarian");
            Console.WriteLine("7. Update Librarian Details");
            Console.WriteLine("8. Delete Librarian");
        }
    }
}
