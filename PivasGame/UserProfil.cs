using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivasGame
{
    public class UserProfil
    {
        private string userName;
        private static string finishName;


        public UserProfil(string name)
        {
            if (name.Contains(" "))
            {
                throw new ArgumentException("Недопустимое имя");
            }
            this.userName = name;
            
        }

        public static void EnterName()
        {
            Console.Write("Если вы готовы, введите свое имя: ");
            UserProfil tempUserNamername = new UserProfil(Console.ReadLine());
            finishName = tempUserNamername.UserName;

        }

        public string UserName
        {
            get { return userName; }
           
        }

        public static string FinishName
        {
            get { return finishName; }
        }
                
     }
}
