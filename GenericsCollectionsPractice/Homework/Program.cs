using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Student student = new Student()
        //    {
        //        Fullname = "test1"
        //    };
        //    Student student1 = new Student()
        //    {
        //        Fullname = "test2"
        //    };

        //    Group group = new Group(Type.Programming);
        //    Group group1 = new Group(Type.Design);
        //    group.students = new Student[] { student, student1 };

        //    Console.WriteLine(group.No);
        //    Console.WriteLine(group1.No);
        //    Console.WriteLine(group.FindStudentByNo(1).Fullname);
            Company company = new Company();
            company.Age = 12;
            Company company1 = new Company();
            company1.Age = 1;
            int sum = company1 + company;
            Console.WriteLine(sum); 

        }
    }
}
