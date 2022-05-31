using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8.Entities
{

    //(User: Id, Name, DateOfBirth, Age): создавать и удалять их, а также запрашивать их перечень
    public class User
    {
        public Guid UserID { get; set; }

        public Guid AwardID { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public User(Guid userId, string name, DateTime dateOfBirth, int age)
        {
            UserID = userId;
            AwardID = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;
        }

        public User(string name, DateTime dateOfBirth, int age)
        {
            UserID = Guid.NewGuid();
            AwardID = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;
        }

        public User(DateTime dateOfBirth, int age)
        {
            UserID = Guid.NewGuid();
            AwardID = Guid.NewGuid();
            Name = "undefined";
            DateOfBirth = dateOfBirth;
            Age = age;
        }

        public User(int age)
        {
            UserID = Guid.NewGuid();
            AwardID = Guid.NewGuid();
            Name = "undefined";
            DateOfBirth = new DateTime(1990, 01, 01);
            Age = age;
        }

        public User()
        {


        }


        public void Edit(string newName, DateTime newDateOfBirth, int newAge)
        {
            Name = newName;
            DateOfBirth = newDateOfBirth;
            Age = newAge;
        }

        public void AddAward(Guid awardId)
        {
            AwardID=awardId;
        }

    }
}
