using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence
{
    class Program
    {
        static void Main(string[] args)
        {
            AddUser addUser = new AddUser();
            addUser.OnOverlap += AddUser_OnOverlap;
            addUser.OnNoneOverlap += AddUser_OnNoneOverlap;
            Console.WriteLine(@"For Adding a user please enter 'add' ");
            if(Console.ReadLine() == "add")
            {
                addUser.AddingUser();
            }
        }

        private static void AddUser_OnNoneOverlap(string userName)
        {
            Console.WriteLine($"Welcome {userName}");
        }

        private static void AddUser_OnOverlap(string userName)
        {
            Console.WriteLine($"You entered {userName}. Please enter another name");
        }
    }
}
