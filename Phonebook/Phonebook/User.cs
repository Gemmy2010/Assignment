using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class User : IPhonebook
    {
        private Hashtable adressBook = new Hashtable();
        public string personalid;
        public string firstname;
        public string lastname;
        public string adress;
        public string phonenumber;

        public string PersonalId
        {
            get { return personalid; }
            set { personalid = value; }
        }

        public string FirstName

        {

            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string PhoneNumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        // constructor

        public User(string personalId, string firstName, string lastName, string adress, string phoneNumber)


        {
            this.PersonalId = personalId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
        }

        public User()
        {
        }

        public override string ToString()

        {
            return "PersonalId : " + this.PersonalId +  " " + this.FirstName + " " + this.LastName + " " + this.Adress + " " + this.PhoneNumber;
        }

        public void CreateUser(User user)
        {   
            if (!adressBook.Contains(user.PersonalId))
                //Console.WriteLine("This personalid already exists!");
                adressBook.Add(user.PersonalId, user);
            Console.WriteLine("User {0} added succesfully: " + user);
            
        }
        public User RetrieveByPersonalId(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user doesn't exist!");
            Console.WriteLine(user);
            return (user);
        }
        public void UpdateUser(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user already exists!");
            Console.WriteLine(user);
        }
        public void DeleteUser(User user)
        {
            if (!adressBook.Contains(user.PersonalId))
                Console.WriteLine("This user does not exist!");
            adressBook.Remove(user.PersonalId);
            Console.WriteLine("user {0} has been deleted" + user.PersonalId);
        }
    }

}
