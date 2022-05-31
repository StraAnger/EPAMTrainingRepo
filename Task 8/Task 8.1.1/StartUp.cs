using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Task8.Entities;
using Task8.BLL;
using Task8.Dependencies;
using Task8.BLL.Interfaces;

namespace Task8.PL.Console
{
    public partial class StartUp
    {
        public static void Main(string[] args)
        {
            SerilogHelper.InitializeLogger();

            int _choiceNumber = 0;

            System.Console.WriteLine("To create award- press 1, to create user- press 2");
            while (!int.TryParse(System.Console.ReadLine(), out _choiceNumber) || _choiceNumber <= 0 || _choiceNumber > 2)
            {
                System.Console.WriteLine("Invalid number!");
                System.Console.WriteLine("Enter number:");
            }

            while (System.Console.ReadKey().Key != ConsoleKey.Escape)

            {
                System.Console.WriteLine(Environment.NewLine);
                System.Console.WriteLine("-=To exit- press Escape key=-");
                System.Console.WriteLine(Environment.NewLine);
                switch (_choiceNumber)
                {
                    case 1:

                        IUsersAndAwardsBLL userBll = DependencyResolver.Instance.UsersBLL;

                        var user = userBll.AddUser(15);

                        userBll.EditUser(user.UserID, "Евгений", DateTime.Now, 18);

                        break;

                    case 2:
                        IUsersAndAwardsBLL awardBll = DependencyResolver.Instance.AwardsBLL;

                        var award = awardBll.AddAward("Премия дарвина");

                        break;

                }
            }
        }

    }
}