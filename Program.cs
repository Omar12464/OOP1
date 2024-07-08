using OOP1.Inheritance;
using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            ////int size = 5;
            ////PhoneBook phoneBook = new PhoneBook(5);
            ////phoneBook.addPerson(1, "Omar", 111);
            ////phoneBook.addPerson(2, "Mido", 123);
            ////phoneBook.addPerson(3, "Body", 115);
            //////Console.WriteLine(phoneBook.getNumber("Omar"));
            //////phoneBook.SetNumber("Omar", 15236);
            //////Console.WriteLine(phoneBook.getNumber("Omar")); 
            ////phoneBook["Omar"] = 1235;
            ////Console.WriteLine(phoneBook["Omar"]);
            ////string Name = "mm";
            ////Console.WriteLine(Name[0]);
            ////for (int i = 0; i <= phoneBook.Size-1; i++)
            ////{
            ////    Console.WriteLine(phoneBook[i]);
            ////}

            //Car c1;
            //c1 = new Car(10,"BM",400);
            //Console.WriteLine(c1.ToString());
            //c1 = new Car(15);
            //Console.WriteLine(c1.ToString());

            //Parent parent=new Parent(1,3);
            //Console.WriteLine(parent.Product()) ;
            //Console.WriteLine(parent.ToString());
            //Child C2 = new Child(1,2,3);
            //Console.WriteLine(C2.ToString());
            //Console.WriteLine(C2.Product());

            #endregion

            #region Part2
            Employee[] employee=new Employee[4];
            employee[0] = new Employee(1, "Alice", 8, 75000.50, new DateTime(2020, 1, 1), "F") { Privilege = Employee.privileges.DBA };
            employee[1] = new Employee(2, "Bob", 1, 50000.00, new DateTime(2021, 2, 1), "M") { Privilege = Employee.privileges.guest };
            employee[2] = new Employee(3, "Charlie", 15, 90000.00, new DateTime(2019, 3, 1), "M") { Privilege = Employee.privileges.Developer };
            employee[3] = new Employee(4, "Modi", 16, 100000.00, new DateTime(2020, 4, 6), "M") { Privilege = Employee.privileges.secretary };
            foreach (Employee emp in employee) {
                Console.WriteLine(emp.ToString());
            }



            #endregion

        }
    }
}
