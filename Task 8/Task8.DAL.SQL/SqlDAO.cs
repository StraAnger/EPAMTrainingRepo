using Task8.DAL.Interfaces;
using Task8.Entities;

namespace Task8.DAL.SQL
{
    public class SqlDAO : IUsersDAO, IAwardsDAO
    {
        public Award AddAward(string title)
        {
            throw new NotImplementedException();
        }

        public User AddUser(int age)
        {
            throw new NotImplementedException();
        }

        public void EditAward(Guid id, string newTitle)
        {
            throw new NotImplementedException();
        }

        public void EditUser(Guid id, string newName, DateTime newDateOfBirth, int newAge)
        {
            throw new NotImplementedException();
        }

        public Award GetAward(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Award> GetAwards(bool orderedById)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers(bool orderedById)
        {
            throw new NotImplementedException();
        }

        public void RemoveAward(Guid id)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}