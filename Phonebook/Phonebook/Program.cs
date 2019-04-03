using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {


        public static void Main(string[] args)
        {
            string personalid;
            string firstname;
            string lastname;
            string adress;
            string phonenumber;


            User user = new User();
            personalid = "1236458";
            firstname = "Jemima";
            lastname = "Nyambura";
            adress = "Gävle";
            phonenumber = "1234567890";

            user = new User(personalid, firstname, lastname, adress, phonenumber);


            user.CreateUser(user);
            user.RetrieveByPersonalId(user);
            user.UpdateUser(user);
            user.DeleteUser(user);

            Console.WriteLine(user);
        }
    }
}