using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Employee
    {

        //Assign the following security privileges to the employee
        #region Enum
        public enum privileges
        {
            guest = 1, Developer = 2, secretary = 4, DBA = 8
        }

        #endregion
        #region Attributes
        private int id;
        private string name;
        private int securityLevel;
        private double salary;
        private DateTime hiredate;
        private string gender;
        #endregion
        #region Properties
        public privileges Privilege { get; set; }
        public string Gender
        {
            get { return Gender; }
            set 
            {
                /// restrict the Gender field to be only M or F
                if (value =="F" || value== "M")
                {
                    Gender = value;
                }
                else { Console.WriteLine("Input invalid"); }
            }
        }


        public DateTime Hiredate
        {
            get { return Hiredate; }
            set { Hiredate = value; }
        }


        public double Salary
        {
            get { return Salary; }
            set { Salary = value; }
        }


        public int SecurityLevel
        {
            get { return SecurityLevel; }
            set { SecurityLevel = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }
        #endregion
        #region Constructors
        public Employee()
        {

        }
        public Employee(int ID, string Name, int Securitylevel, double Salary, DateTime HireDate,string Gender)
        {
            id = ID;
            name = Name;
            securityLevel = Securitylevel;
            salary = Salary;
            hiredate = HireDate;
            gender = Gender;
        }
        #endregion
        public override string ToString()
        {
            return $"ID: {id}\nName: {name}\nSecurityLevel: {securityLevel}\nSalary {salary:c}\nHireDate: {hiredate}\nGender: {gender}\nPrivelege: {Privilege}";
        }
    }
}
