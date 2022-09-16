using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_16._09._2022
{
    public class Program
    {
        static void Main(string[] args)
        {

            {
                List<User> UserList = new List<User>();
                UserList.Add(new User("Nijat", "Huseynli", 18, "Azerbaijan"));
                UserList.Add(new User("Huseyn", "Hasanov", 19, "Turkey"));
                UserList.Add(new User("Ali", "Aliyev", 23, "Italy"));
                UserList.Add(new User("Rauf", "Ibadov", 28, "Russia"));
                UserList.Add(new User("Samir", "Huseynov", 25, "Ispain"));
                UserList.Add(new User("Mehdi", "Babazade", 26, "England"));
                UserList.Add(new User("Mehemmed", "Aliyev", 22, "Poland"));
                UserList.Add(new User("Nabi", "Nabiyev", 3, "Turkey"));
                UserList.Add(new User("Asker", "Eyvazov", 9, "Turkey"));

                Console.WriteLine("Find all users that age is greater than 20 and print them as Name Surname Age Country format : ");

                List<User> list = UserList.Where(x => x.Age > 20).ToList();
                foreach (User user in list)
                {
                    Console.WriteLine(user.Name + " " + user.Surname + " " + user.Age + " " + user.Country);
                }

                Console.WriteLine("Remove all users that belong to Turkey and their Age lower than 10 : ");

                UserList.RemoveAll(x => x.Country == "Turkey");
                List<User> list1 = UserList.Where(x => x.Age < 10).ToList();
                foreach (User user in list)
                {
                    Console.WriteLine(user.Name + " " + user.Surname + " " + user.Age + " " + user.Country);
                }
            }
        }
    }  }
