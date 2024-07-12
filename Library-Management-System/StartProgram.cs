using Library_Management_System.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class StartProgram
    {
        static Navigation _Navigation = new Navigation();
        public static void Main(string[] args)
        {
            _Navigation.startProgram();

        }
    }
}
