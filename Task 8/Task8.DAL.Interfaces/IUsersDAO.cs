using Task8.Entities;

namespace Task8.DAL.Interfaces
{
    public interface IUsersDAO
    {
        User AddUser(int age);

        void RemoveUser(Guid id);

        void EditUser(Guid id, string newName, DateTime newDateOfBirth, int newAge);

        User GetUser(Guid id);

        IEnumerable<User> GetUsers(bool orderedById);

    }
}
