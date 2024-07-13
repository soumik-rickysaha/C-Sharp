using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Menu
{
    internal class LibraryMenu
    {

        public LibraryMenu()
        {
            printBlankLines();
            Console.WriteLine("Welcome to Library Management System");
            Console.WriteLine("==========================================");
        }

        public void printMasterMenu()
        {
            printBlankLines();
            Console.WriteLine("1. Student Login");
            Console.WriteLine("2. Librarian Login");
            Console.WriteLine("3. Admin Login");

        }
        public void printStudentMenu()
        {
            printBlankLines();
            Console.WriteLine("1. Enroll for a Book");
            Console.WriteLine("2. Return a Book");
            //Console.WriteLine("3. Admin Login");

        }
        public void printBookMenu()
        {
            printBlankLines();
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Delete Book");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Return Book");
        }

        public void printAdminMenu()
        {
            printBlankLines();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Add Admin");
            Console.WriteLine("3. Create Student Card");
            Console.WriteLine("4. Print Book Inventory Count");
            Console.WriteLine("5. Print Total Student Cards");
            Console.WriteLine("6. Add Librarian");
            Console.WriteLine("7. Update Librarian Details");
            Console.WriteLine("8. Delete Librarian");
            Console.WriteLine("9. Print Inventory");
        }

        private void printBlankLines()
        {
            Console.WriteLine("\n\n\n\n");
        }

        public int getResponse()
        {
            int response;

            while (true)
            {
                Console.Write("\nEnter your response : ");
                response = int.Parse(Console.ReadLine());

                if (response != 0)
                {
                    break;
                }
            }
            return response;
        }
    }
}
