namespace Phonebook
{
    public interface IPhonebook
    {
        string Adress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PersonalId { get; set; }
        string PhoneNumber { get; set; }

        void CreateUser(User user);
        void DeleteUser(User user);
        User RetrieveByPersonalId(User user);
        string ToString();
        void UpdateUser(User user);
    }
}