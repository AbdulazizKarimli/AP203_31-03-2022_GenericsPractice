using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Company
    {
        public List<string> employees;

        public int Age { get; set; }


        
        public static int operator +(Company a,Company b)
        {
            return a.Age + b.Age;
        }

        public static bool operator >(Company a, Company b)
        {
            return a.Age > b.Age; 
        }

        public static bool operator <(Company a, Company b)
        {
            return a.Age < b.Age;
        }




        public List<string> FindEmployeesByName(string name)
        {
            List<string> filteredEmployees = new List<string>();

            foreach (var item in employees)
            {
                if (employees.Contains(name))
                    filteredEmployees.Add(item);
            }

            return filteredEmployees;
        }
    }


}
