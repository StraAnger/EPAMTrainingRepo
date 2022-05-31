using Task8.BLL;
using Task8.BLL.Interfaces;
using Task8.DAL.Interfaces;
using Task8.DAL.Json;
using Task8.DAL.SQL;

namespace Task8.Dependencies
{
    public class DependencyResolver
    {

        #region SINGLETON

        private static DependencyResolver _instance;

        public static DependencyResolver Instance => _instance ??= new DependencyResolver();

        private DependencyResolver()
        {

        }

        #endregion

        private IUsersDAO _usersDAO;

        private IAwardsDAO _awardsDAO;


        public IAwardsDAO AwardsDAO => _awardsDAO ??= new JsonDAO(); // SqlDAO();
        public IUsersDAO UsersDAO => _usersDAO ??= new JsonDAO(); // SqlDAO();

        
        
        private IUsersAndAwardsBLL _usersAndAwardsBLL;


        public IUsersAndAwardsBLL UsersBLL => _usersAndAwardsBLL ??= new UsersAndAwardsLogic(UsersDAO);

        public IUsersAndAwardsBLL AwardsBLL => _usersAndAwardsBLL ??= new UsersAndAwardsLogic(AwardsDAO);

    }
}