using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendence
{
    class AddUser
    {
        public List<string> userName { get; set; } = new List<string>();

        public delegate void NamesAreOverlaped(string user);
        public event NamesAreOverlaped OnOverlap;
        public event NamesAreOverlaped OnNoneOverlap;

        public void AddingUser()
        {
            Console.WriteLine("Enter UserName");
            userName.Add(Console.ReadLine());
            CheckUser();
        }

        public void CheckUser()
        {
            switch (userName[userName.Count - 1])
            {
                case "Jack":
                    this.OnOverlap(userName[userName.Count - 1]);
                    break;
                case "Steven":
                    this.OnOverlap(userName[userName.Count - 1]);
                    break;
                case "Mathew":
                    this.OnOverlap(userName[userName.Count - 1]);
                    break;
                default:
                    if (OnNoneOverlap != null)
                    {
                        this.OnNoneOverlap(userName[userName.Count - 1]);
                    }
                    break;
            }
            
        }
    }
}
