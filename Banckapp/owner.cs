using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_hajyahia_yazan.Banckapp
{
    class Owner
    {
        private string firstname;
        private string lastname;

        public Owner(string firstName,string lastName)
        {
            this.firstname = firstName;
            this.lastname = lastName;
        }

        public string GitFirstName()
        {
            return firstname;
        }

        public string GetLastName()
        {
            return lastname;
        }

        public string GetFirstName()
        {
            return firstname;
        }
    }
}
