using System;
using static System.Console;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Animation demo";
            TextAnimationUtils.Animation(@" 
 __          __  _                            _____  _                                           
 \ \        / / | |                          |  __ \| |                                          
  \ \  /\  / ___| | ___ ___  _ __ ___   ___  | |__) | |__   __ _ _ __ _ __ ___   __ _  ___ _   _ 
   \ \/  \/ / _ | |/ __/ _ \| '_ ` _ \ / _ \ |  ___/| '_ \ / _` | '__| '_ ` _ \ / _` |/ __| | | |
    \  /\  |  __| | (_| (_) | | | | | |  __/ | |    | | | | (_| | |  | | | | | | (_| | (__| |_| |
     \/  \/ \___|_|\___\___/|_| |_| |_|\___| |_|    |_| |_|\__,_|_|  |_| |_| |_|\__,_|\___|\__, |
                                                                                            __/ |
");
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Employee employer1 = new Employee();
            //List<Drug> drugss = new List<Drug>();
            //Pharmacy pharmacy1 = new Pharmacy();
            //Drug drugg = new Drug();
            List<Employee> employers = new List<Employee>();
            List<Drug> drugs = new List<Drug>();

            #region check
            while (true)
            {
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
                    employers.Add(employer1);
                    Clear();
                }
                else
                {
                    Helper.PrintColor($"No users were found with this {username} and {password}", ConsoleColor.DarkRed);
                    goto menu;
                }
                #endregion

                #region admin
                if (employer1.RoleType == "Admin")
                {
                adminmenu:
                    Helper.PrintColor($"1.Admin panel", ConsoleColor.DarkYellow);
                    Helper.PrintColor($"2.Sell", ConsoleColor.DarkYellow);
                    Helper.PrintColor($"3.Update my data", ConsoleColor.DarkYellow);
                    Helper.PrintColor($"Please choose one of them", ConsoleColor.DarkCyan);
                    string choosedataoption = Console.ReadLine();

                    Clear();
                    switch (choosedataoption)
                    {
                        case "1":
                            Helper.PrintColor($"*.Add employee", ConsoleColor.DarkYellow);
                            Helper.PrintColor($"**.Add drug", ConsoleColor.DarkGray);
                            Helper.PrintColor($"***.Delete drug", ConsoleColor.DarkGray);
                            Helper.PrintColor($"****.Delete employee", ConsoleColor.DarkYellow);
                            Helper.PrintColor($"*****.Edit drug", ConsoleColor.DarkGray);
                            Helper.PrintColor($"******.Edit employee", ConsoleColor.DarkYellow);
                            Helper.PrintColor($"Please choose one of them", ConsoleColor.DarkCyan);
                            string chooseoption = Console.ReadLine();
                            switch (chooseoption)
                            {
                                case "1":
                                    AddEmployee(employers);
                                    break;
                                case "2":
                                    AddDrug(drugs);
                                    break;
                                case "3":
                                    break;
                                case "4":
                                    break;
                                case "5":
                                    break;
                                case "6":
                                    break;
                            }

                            break;

                        case "2":
                            break;

                        case "3":
                            break;
                    }
                }
                #endregion
                #region staff
                else if (employer1.RoleType == "Staff")
                {
                    Helper.PrintColor($"1.Sell", ConsoleColor.DarkYellow);
                    Helper.PrintColor($"2.Update my data", ConsoleColor.DarkYellow);

                }
                #endregion

                ReadKey(true);


            }
        }
      
       
       
      
        public static void AddEmployee(List<Employee> employers)
        {
            Employee employer1 = new Employee();
            Pharmacy pharmacy1 = new Pharmacy();
            Helper.PrintColor("Please enter the name", ConsoleColor.Cyan);
        correctname:
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Helper.PrintColor("please enter your password correctly", ConsoleColor.DarkRed);
                goto correctname;
            }

            Helper.PrintColor("Please enter the surname", ConsoleColor.Cyan);
        correctsurname:
            string surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname))
            {
                Helper.PrintColor("please enter your password correctly", ConsoleColor.DarkRed);
                goto correctsurname;
            }

        inputroletype:
            Helper.PrintColor("Enter roletype", ConsoleColor.Cyan);
            string roletype1 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(roletype1))
            {
                Helper.PrintColor("please enter your roletype correctly", ConsoleColor.DarkRed);
                goto inputroletype;
            }

        inputdate:
            Helper.PrintColor("Please enter your birthdate", ConsoleColor.Cyan);
            string birthdate = Console.ReadLine();
            bool isParsabledate = DateTime.TryParse(birthdate, out DateTime newbirthdate);
            if (!isParsabledate)
            {
                Helper.PrintColor("Dont correct the date", ConsoleColor.DarkRed);
                goto inputdate;
            }

        inputsalary:
            Helper.PrintColor("Please enter the Salary", ConsoleColor.Cyan);
            string salary = Console.ReadLine();
            bool isParsableSalary = int.TryParse(salary, out int newsalary);
            if (!isParsableSalary)
            {
                Helper.PrintColor("DONT CORECCT THE SALARY", ConsoleColor.DarkRed);
                goto inputsalary;

            }
            if (newsalary < pharmacy1.MinSalary)
            {
                Helper.PrintColor("Please enter the correct salary", ConsoleColor.DarkRed);
                goto inputsalary;
            }
        inputpassword1:
            Helper.PrintColor("Please enter the password", ConsoleColor.Cyan);
            string password1 = Console.ReadLine();
            for (int i = 0; i < password1.Length; i++)
            {
                if (password1.Length < 5 && !char.IsDigit(password1[i]) && !char.IsUpper(password1[i]) && !char.IsLower(password1[i]) && !char.IsSymbol(password1[i]))

                {
                    Helper.PrintColor("Please enter the correct password", ConsoleColor.DarkRed);
                    goto inputpassword1;
                }
            }

        inputusername1:
            Helper.PrintColor("Please enter the username", ConsoleColor.Cyan);
            string username1 = Console.ReadLine();
            if (employer1.UserName.Contains(username1))
            {
                Helper.PrintColor("Please enter the another username", ConsoleColor.DarkRed);
                goto inputusername1;
                Employee employer2 = new Employee();
                employer2.Name = name;
                employer2.SurName = surname;
                employer2.RoleType = roletype1;
                //employer2.BirthDate = newbirthdate;
                employer2.Password = password1;
                employer2.UserName = username1;
                employer2.Salary = newsalary;
                employers.Add(employer2);
            }
        }
    public static void AddDrug(List <Drug >drugs)
            {
            Drug drug = new Drug();
        checkdrug:
                Helper.PrintColor("Please enter the durg name", ConsoleColor.Cyan);
                string drugname = Console.ReadLine();

            checkerdrug:
                Helper.PrintColor("Please enter the durg drugtype", ConsoleColor.Cyan);
                string drugtype = Console.ReadLine();
                if (drug.Name == drugname && drug.DrugType == drugtype)
                {
                    Helper.PrintColor("Please include in correct drugtype or drugname", ConsoleColor.DarkRed);
                    goto checkdrug;
                }
                else if (drug.DrugType == drugtype)
                {
                    Helper.PrintColor("Please include correct drug name", ConsoleColor.DarkRed);
                    goto checkerdrug;

                }

            inputchase:
                Helper.PrintColor("Please enter the durg purchase", ConsoleColor.Cyan);
                string drugpurchase = Console.ReadLine();
                bool isParsableChase = double.TryParse(drugpurchase, out double newppurchase);
                if (!isParsableChase)
                {
                    Helper.PrintColor("Please include correct purchase ", ConsoleColor.DarkRed);
                    goto inputchase;
                }

            inputsaleprice:
                Helper.PrintColor("Please enter the durg saleprice", ConsoleColor.Cyan);
                string drugsaleprice = Console.ReadLine();
                bool isParsablePrice = double.TryParse(drugsaleprice, out double newsaleprice);
                if (!isParsablePrice)
                {
                    Helper.PrintColor("Please include correct saleprice", ConsoleColor.DarkRed);
                    goto inputsaleprice;
                }
            inputcount:
                Helper.PrintColor("Please enter the durg count", ConsoleColor.Cyan);
                string drugcount = Console.ReadLine();
                bool isParsablecount = int.TryParse(drugcount, out int newcount);
                if (!isParsablecount)
                {
                    Helper.PrintColor("Please include correct count", ConsoleColor.DarkRed);
                    goto inputcount;

                }
                if (drug.Count * drug.SalePrice <= drug.PurchasePrice)
                {
                    Drug drug1 = new Drug();
                    drug1.Name = drugname;
                    drug1.DrugType = drugtype;
                    drug1.Count = newcount;
                    drug1.SalePrice = newsaleprice;
                    drug1.PurchasePrice = newppurchase;
                    drugs.Add(drug1);
                }
                else
                {
                    Helper.PrintFormat("You arent budget enough", ConsoleColor.DarkMagenta);
                    goto inputcount;
                }

            }
        }
    }
