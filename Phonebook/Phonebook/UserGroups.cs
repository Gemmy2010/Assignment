using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class UserGroups:User
    {
        public string Groups { get; set; }
        public UserGroups() : 
            base()
        {
            this.Groups = null;
        }
      
    }
}
