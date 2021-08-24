using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas01
{
    class Login : DataLogin, InterfaceLogin
    {
        public string unames { get; set; }
        public string passs { get; set; }

        public bool login(string uname, string pass)
        {
            if (uname = uname)
            {
                if (pass = pass)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public override void register()
        {
            Console.Write("Masukkan Username : ");
            uname = Console.ReadLine();
            Console.Write("Masukkan Password : ");
            pass = Console.ReadLine();

            base.register();
        }
    }
}
