using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Employee
    {
        public int Id { get; set; }
        public int BirthDate { get; set; }
        public double Salary { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string RoleType { get; set; }
        private int _id;

        public Employee(string username="konulh03",string name = "konul", string surname = "huseynli", string password = "K03#hus2@", string roloetype ="Admin")
        {
            _id++;
            Id = _id;
            UserName = username;
            Name = name;
            SurName = surname;
            Password = password;
            RoleType = roloetype;
           
        }
        
    }
}
