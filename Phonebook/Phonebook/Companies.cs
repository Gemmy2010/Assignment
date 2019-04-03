using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Companies : User
    {
        public string CompanyName { get; set; }
        public Companies() :
            base()
        {
            this.CompanyName = null;
        }
        public override string ToString()
        {
            return base.ToString() + " Company name : " + this.CompanyName;
        }
    }
}
