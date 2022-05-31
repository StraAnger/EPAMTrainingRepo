using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8.BLL.Interfaces;
using Task8.DAL.Interfaces;
using Task8.DAL.Json;
using Task8.Entities;

namespace Task8.BLL
{
    public class UsersAndAwardsLogic : IUsersAndAwardsBLL
    {

        private IUsersDAO _jsonDalUsers;

        public UsersAndAwardsLogic(IUsersDAO jsonDaoUsers)
        {
            _jsonDalUsers = jsonDaoUsers;

        }

        public User AddUser(int age) => _jsonDalUsers.AddUser(age);

        public void RemoveUser(Guid id) => _jsonDalUsers.RemoveUser(id);

        public void EditUser(Guid id, string newName, DateTime newDateOfBirth, int newAge) => _jsonDalUsers.EditUser(id, newName, newDateOfBirth, newAge);

        public User GetUser(Guid id) => _jsonDalUsers.GetUser(id);

        public IEnumerable<User> GetUsers(bool orderById) => _jsonDalUsers.GetUsers(orderById);



        private IAwardsDAO _jsonDalAwards;

        public UsersAndAwardsLogic(IAwardsDAO jsonDaoAwards)
        {
            _jsonDalAwards = jsonDaoAwards;

        }

        public Award AddAward(string title) => _jsonDalAwards.AddAward(title);

        public void RemoveAward(Guid id) => _jsonDalAwards.RemoveAward(id);

        public void EditAward(Guid id, string newText) => _jsonDalAwards.EditAward(id, newText);

        public Award GetAward(Guid id) => _jsonDalAwards.GetAward(id);

        public IEnumerable<Award> GetAwards(bool orderById) => _jsonDalAwards.GetAwards(orderById);




    }
}

