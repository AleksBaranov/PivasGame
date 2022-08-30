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

        public UserProfil(string name)
        {
            if (name.Contains(" "))
            {
                throw new ArgumentException("Недопустимое имя");
            }
            this.userName = name;
            
        }
        public string Name
        {
            get { return userName; }
        }
                
     }
}
