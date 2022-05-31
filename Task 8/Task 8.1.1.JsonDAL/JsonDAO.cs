using Task8.Entities;
using Newtonsoft.Json;
using Task8.DAL.Interfaces;

namespace Task8.DAL.Json
{
    public class JsonDAO : IUsersDAO, IAwardsDAO
    {

        public const string JsonFilesPath = @"C:\Temp\";

        public User AddUser(int age)
        {
            var user = new User(age);

            string json = JsonConvert.SerializeObject(user);

            File.WriteAllText(GetFileFullNameById(user.UserID), json);

            return user;
        }

        public void RemoveUser(Guid id)
        {
            if (File.Exists(GetFileFullNameById(id)))
                File.Delete(GetFileFullNameById(id));

            else throw new FileNotFoundException(
                string.Format("File with name {0} at path {1} isn't created!", id + ".json", JsonFilesPath));
        }

        public void EditUser(Guid id, string newName, DateTime newDateOfBirth, int newAge)
        {
            if (!File.Exists(GetFileFullNameById(id)))
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!",
                        id, JsonFilesPath));

            User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(GetFileFullNameById(id)));

            user?.Edit(newName, newDateOfBirth, newAge);

            File.WriteAllText(GetFileFullNameById(user.UserID), JsonConvert.SerializeObject(user));
        }

        public User GetUser(Guid id)
        {

            if (!File.Exists(GetFileFullNameById(id)))
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!",
                        id, JsonFilesPath));
            var textContent = File.ReadAllText(GetFileFullNameById(id));

            return JsonConvert.DeserializeObject<User>(textContent);
        }

        public IEnumerable<User> GetUsers(bool orderedById)
        {
            // TODO: Getting all notes via JSON
            throw new NotImplementedException();
        }

       /***********************************
        **           AWARDS              **
        ***********************************/

             public Award AddAward(string newTitle)
        {
            var award = new Award(newTitle);

            string json = JsonConvert.SerializeObject(award);

            File.WriteAllText(GetFileFullNameById(award.AwardID), json);

            return award;
        }

        public void RemoveAward(Guid id)
        {
            if (File.Exists(GetFileFullNameById(id)))
                File.Delete(GetFileFullNameById(id));

            else throw new FileNotFoundException(
                string.Format("File with name {0} at path {1} isn't created!", id + ".json", JsonFilesPath));
        }

        public void EditAward(Guid id, string newTitle)
        {
            if (!File.Exists(GetFileFullNameById(id)))
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!",
                        id, JsonFilesPath));

            Award award = JsonConvert.DeserializeObject<Award>(File.ReadAllText(GetFileFullNameById(id)));

            award?.Edit(newTitle);

            File.WriteAllText(GetFileFullNameById(award.AwardID), JsonConvert.SerializeObject(award));
        }

        public Award GetAward(Guid id)
        {

            if (!File.Exists(GetFileFullNameById(id)))
                throw new FileNotFoundException(
                    string.Format("File with name {0} at path {1} isn't created!",
                        id, JsonFilesPath));
            var textContent = File.ReadAllText(GetFileFullNameById(id));

            return JsonConvert.DeserializeObject<Award>(textContent);
        }

        public IEnumerable<Award> GetAwards(bool orderedById)
        {
            // TODO: Getting all notes via JSON
            throw new NotImplementedException();
        }


        private string GetFileFullNameById(Guid id) => JsonFilesPath + id + ".json";


    }
}
