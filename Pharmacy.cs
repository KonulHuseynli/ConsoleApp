using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Pharmacy
    {
        List<Employee> employerss = new List<Employee>();
        List<Drug> drugss = new List<Drug>();

       // private List<Employee> _employers;
       // private List<Drug> _drugs;
        public int Id { get; set; }
        public double MinSalary { get; set; }
        public double Budget { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        private int _id;

        public Pharmacy(string name = "BioNTech", double minsalary = 750, double budget = 9.000500, string location = "Germany")
        {
            _id++;
            Id = _id;
            Name = name;
            MinSalary = minsalary;
            Budget = budget;
            Location = location;
        }
        

    }
}
