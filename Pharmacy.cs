using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Pharmacy
    {

        public int Id { get; set; }
        public double MinSalary { get; set; }
        public double Budget { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        private int _id;
        public double TotalIncome { get; set; }
        List<Employee> employers = new List<Employee>();
        List<Drug> drugs = new List<Drug>();
        public Pharmacy(string name = "BioNTech", double minsalary = 750, double budget = 9.000500, string location = "Germany")
        {
            _id++;
            Id = _id;
            Name = name;
            MinSalary = minsalary;
            Budget = budget;
            Location = location;
        }


        public static void CheckAdminorStaff()
        {
            Pharmacy pharmacy1 = new Pharmacy();
            Employee employer1 = new Employee();
        menu:
            Helper.PrintColor("Please enter the username", ConsoleColor.Cyan);
        inputusername:
            string username = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(username))
            {
                Helper.PrintColor("please enter your name correctly", ConsoleColor.DarkRed);
                goto inputusername;
            }

            Helper.PrintColor("Please enter the Password", ConsoleColor.Cyan);
        inputpassword:
            string password = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(password))
            {
                Helper.PrintColor("please enter your password correctly", ConsoleColor.DarkRed);
                goto inputpassword;
            }

            if (employer1.UserName == username && employer1.Password == password)
            {
                Helper.PrintFormat($"***You have logged in successfully***", ConsoleColor.Green);
                Console.WriteLine($"The role of the employee you include:   {employer1.RoleType}");
                pharmacy1.employers.Add(employer1);

            }
            else
            {
                Helper.PrintColor($"No users were found with this {username} and {password}", ConsoleColor.DarkRed);
                goto menu;
            }

        }
        //public static void AddEmployee(Pharmacyp)
        //{
        //    Employee employer2 = new Employee();
        //    Pharmacy pharmacy1 = new Pharmacy();


        //    Helper.PrintColor("Please enter the name", ConsoleColor.Cyan);
        //correctname:
        //    string name = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        Helper.PrintColor("please enter your password correctly", ConsoleColor.DarkRed);
        //        goto correctname;
        //    }

        //    Helper.PrintColor("Please enter the surname", ConsoleColor.Cyan);
        //correctsurname:
        //    string surname = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(surname))
        //    {
        //        Helper.PrintColor("please enter your password correctly", ConsoleColor.DarkRed);
        //        goto correctsurname;
        //    }

        //inputroletype:
        //    Helper.PrintColor("Enter roletype", ConsoleColor.Cyan);
        //    string roletype1 = Console.ReadLine();
        //    if (string.IsNullOrWhiteSpace(roletype1))
        //    {
        //        Helper.PrintColor("please enter your roletype correctly", ConsoleColor.DarkRed);
        //        goto inputroletype;
        //    }

        //inputdate:
        //    Helper.PrintColor("Please enter your birthdate", ConsoleColor.Cyan);
        //    string birthdate = Console.ReadLine();
        //    bool isParsabledate = DateTime.TryParse(birthdate, out DateTime newbirthdate);
        //    if (!isParsabledate)
        //    {
        //        Helper.PrintColor("Dont correct the date", ConsoleColor.DarkRed);
        //        goto inputdate;
        //    }

        //inputsalary:
        //    Helper.PrintColor("Please enter the Salary", ConsoleColor.Cyan);
        //    string salary = Console.ReadLine();
        //    bool isParsableSalary = int.TryParse(salary, out int newsalary);
        //    if (!isParsableSalary)
        //    {
        //        Helper.PrintColor("DONT CORECCT THE SALARY", ConsoleColor.DarkRed);
        //        goto inputsalary;

        //    }
        //    if (newsalary < pharmacy1.MinSalary)
        //    {
        //        Helper.PrintColor("Please enter the correct salary", ConsoleColor.DarkRed);
        //        goto inputsalary;
        //    }
        //inputpassword1:
        //    Helper.PrintColor("Please enter the password", ConsoleColor.Cyan);
        //    string password1 = Console.ReadLine();
        //      if (password1.Length < 5)
        //        {
        //            Helper.PrintColor("Plese enter long password   password.length>5", ConsoleColor.DarkRed);
        //            goto inputpassword1;
        //        }
        //        if (!password1.Any(char.IsNumber))
        //        {
        //            Helper.PrintColor("Please enter password with num", ConsoleColor.DarkRed);
        //            goto inputpassword1;
        //        }
        //        if (!password1.Any(char.IsUpper))
        //        {
        //            Helper.PrintColor("Please enter password with Upperletter", ConsoleColor.DarkRed);
        //            goto inputpassword1;
        //        }
        //        if (!password1.Any(char.IsLower))
        //        {
        //            Helper.PrintColor("Please enter  password with lowerletter", ConsoleColor.DarkRed);
        //            goto inputpassword1;
        //        }
        //        if (!password1.Any(char.IsSymbol))

        //        {
        //            Helper.PrintColor("Please enter the password with symbol", ConsoleColor.DarkRed);
        //            goto inputpassword1;
        //        }

        //        else
        //    {
        //        Helper.PrintColor("CORRECT PASSWORD", ConsoleColor.Green);
        //    }


        //inputusername1:
        //    Helper.PrintColor("Please enter the username", ConsoleColor.Cyan);
        //    string username1 = Console.ReadLine();
        //    if (pharmacy1.employers.Exists(x => x.UserName.ToLower() == username1.ToLower()))
        //        {
        //        Helper.PrintColor("Please enter the another username", ConsoleColor.DarkRed);
        //         goto inputusername1;
        //        }
        //    else
        //    {
        //        Employee employer3 = new Employee();
        //        employer3.Name = name;
        //        employer3.SurName = surname;
        //        employer3.RoleType = roletype1;
        //        //employer2.BirthDate = newbirthdate;
        //        employer3.Password = password1;
        //        employer3.UserName = username1;
        //        employer3.Salary = newsalary;
        //        pharmacy1.employers.Add(employer3);
        //        Helper.PrintFormat($"{name}--- {roletype1}:  employee created ", ConsoleColor.Green);

       
        //public static void sellDrug(string name,int count)
        //{

        //    Drug drug = new Drug();
        //    Helper.PrintColor("Which type of drug do you want", ConsoleColor.Cyan);
        //    string drugname1 = Console.ReadLine();
        //    if (drugname1 != drug.Name)
        //    {
        //        Helper.PrintColor("This drug  does not exist ", ConsoleColor.DarkRed);
        //    }
        //    Helper.PrintColor("Which type of drug do you want", ConsoleColor.Cyan);
        //    string drugtype1 = Console.ReadLine();
        //inputcountd:
        //    Helper.PrintColor("How many drug do you want", ConsoleColor.Cyan);
        //    string drugcount1 = Console.ReadLine();
        //    bool isParsableDCount = int.TryParse(drugcount1, out int dcount);
        //    if (!isParsableDCount)
        //    {
        //        Helper.PrintFormat("Please include in correct count", ConsoleColor.DarkRed);
        //        goto inputcountd;
        //    }
        //    if (drug.Count == 0)
        //    {
        //        Helper.PrintColor($"Unfortunately, there is no {drugname1} enough", ConsoleColor.DarkRed);
        //    }
        //    if (dcount >drug.Count)
        //    {
        //        Helper.PrintFormat($"We have {drug.Count}, Should we give that much  yes/no", ConsoleColor.DarkMagenta);
        //    }
        //    string answer = Console.ReadLine();
        //    if (answer == "yes")
        //     {
        //       sellDrug(name,count);
        //     }



        //    else
        //    {
        //                drug.Count -= dcount;
        //                drug.PurchasePrice += drug.SalePrice * dcount;
        //            }
        //        }
        public void Sell(string name, int count)
        {

            foreach (var item in drugs)
            {
                if (item.Name == name)
                {
                    if (item.Count < count)
                    {
                        if (item.Count != 0)
                        {
                            Console.WriteLine($"Just we have {item.Count} , Do you want? yes or no");
                            string answer = Console.ReadLine();
                            if (answer == "yes")
                            {
                                Sell(name, item.Count);
                            }
                        }
                        else if (item.Count == 0)
                        {
                            Console.WriteLine($"Unfortunately {name} doesnt exist");
                        }

                    }
                    else
                    {
                        item.Count -= count;
                        TotalIncome += item.SalePrice * count;
                    }
                }
            }
        }

        public static void EditEmployeeaAndDrug()
        {
            Pharmacy pharmacy1 = new Pharmacy();

            Helper.PrintColor("1.Searching employee", ConsoleColor.Yellow);
            Helper.PrintColor("2.Searching drug", ConsoleColor.Yellow);
            string inputnum = Console.ReadLine();
            switch (inputnum)
            {
                case "1":
                    Helper.PrintColor("Please enter the employee name which you are searching", ConsoleColor.Cyan);
                    string empname = Console.ReadLine();
                    List<Employee> result = pharmacy1.employers.FindAll((emp) => emp.Name.Contains(empname));
                    foreach (var item in result)
                    {

                        Helper.PrintColor($"{item.Name }---{item.Id}----{item.RoleType} ", ConsoleColor.DarkMagenta);
                    }


                    Helper.PrintColor("Please enter the employee ID", ConsoleColor.Cyan);
                    string inputId = Console.ReadLine();
                    bool isParsableId = int.TryParse(inputId, out int newid);
                    Employee removemploye = pharmacy1.employers.Find(x => x.Id == newid);
                    if (!isParsableId)
                    {
                        Helper.PrintColor("Please enter correct id", ConsoleColor.DarkRed);
                    }
                    if (removemploye == null)
                    {
                        Helper.PrintColor($"{removemploye} : Dont found", ConsoleColor.DarkRed);
                    }
                    else if (pharmacy1.employers.Remove(removemploye))
                    {

                        Helper.PrintFormat($"{removemploye}: employee is deleted", ConsoleColor.Green);
                    }

                    break;
                case "2":
                    Helper.PrintColor("Please enter the drug name which you are searching", ConsoleColor.Cyan);
                    string drname = Console.ReadLine();
                    List<Drug> resultdrug = pharmacy1.drugs.FindAll((emp) => emp.Name.Contains(drname));
                    foreach (var item in resultdrug)
                    {
                        Helper.PrintColor($"{item.Name }---{item.Id}----{item.DrugType} ", ConsoleColor.DarkMagenta);
                    }
                    Helper.PrintColor("Please enter the drug ID", ConsoleColor.Cyan);
                    string inputdrId = Console.ReadLine();
                    bool isParsabledrId = int.TryParse(inputdrId, out int newdrid);
                    Drug removerug = pharmacy1.drugs.Find(x => x.Id == newdrid);
                    if (!isParsabledrId)
                    {
                        Helper.PrintColor("Please enter correct id", ConsoleColor.DarkRed);
                    }
                    if (removerug == null)
                    {
                        Helper.PrintColor($"{removerug} : Dont found", ConsoleColor.DarkRed);
                    }
                    pharmacy1.drugs.Remove(removerug);
                    {
                        Helper.PrintFormat($"{removerug}: employee is deleted", ConsoleColor.Green);
                    }
                    break;
            }

        }
        public void Add(Employee employeee)
        {
        inputusername1:
            Helper.PrintColor("Please enter the username", ConsoleColor.Cyan);
            string username1 = Console.ReadLine();
            foreach (var item in employers)
            {
                Employee ExistEmpl = employers.Find(x => x.UserName ==username1 );
           
                if (ExistEmpl==null)
                {
                    Helper.PrintColor("does not exist ", ConsoleColor.DarkRed);
                    goto inputusername1;
                }
                if(employeee.UserName==username1)
                {
                    Helper.PrintColor("Please enter tehe another username ", ConsoleColor.DarkRed);
                    goto inputusername1;
                }
                employers.Add(employeee);
            }
    }
        public void Add2(Drug drug)
        {
            drugs.Add(drug);
        }
        public static void Update(Employee employer)
        {
            Pharmacy pharmacy1 = new Pharmacy();
            Helper.PrintColor($"{employer.UserName}  {employer.Password}", ConsoleColor.DarkGreen);

            Helper.PrintColor("Include new UserName:", ConsoleColor.Green);
            string newusername = Console.ReadLine();
            Helper.PrintColor("Include new Password:", ConsoleColor.Green);
            string newparol = Console.ReadLine();

           
            employer.UserName = newusername;
            employer.Password = newparol;
            pharmacy1.employers.Add(employer);

        }
       
        }
}
 

