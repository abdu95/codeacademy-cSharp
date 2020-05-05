using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden)
            {
                for (int i = 0; i < Password.Length; i++)
                    Console.Write("*");
            }
            else
                Console.WriteLine(Password);

        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}
