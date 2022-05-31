using Task8.Entities;

namespace Task8.BLL.Interfaces
{
    public interface IUsersAndAwardsBLL
    {
        User AddUser(int age);

        void RemoveUser(Guid id);

        void EditUser(Guid id, string newName, DateTime newDateOfBirth, int newAge);
        User GetUser(Guid id);

        Award AddAward(string title);

        void RemoveAward(Guid id);

        void EditAward(Guid id, string newTitle);

        Award GetAward(Guid id);

    }

}
