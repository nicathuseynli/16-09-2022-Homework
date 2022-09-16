using System;
using System.Collections.Generic;
using System.Text;

namespace homework_16._09._2022
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }



        public User(string Name,string Surname,int Age,string Country)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Country = Country;
        }



    }
}
