using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Student
    {
        private static int _no;

        public int No { get; }
        public string Fullname { get; set; }

        public Student()
        {
            _no++;
            No = _no;
        }
    }
}
