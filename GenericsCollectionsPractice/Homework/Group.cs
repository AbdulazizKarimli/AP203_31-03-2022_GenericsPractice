using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Group
    {
        private static int _programmingNo = 100;
        private static int _designNo = 100;
        private static int _systemNo = 100;
        public Student[] students;

        public string No { get; }
        public Type Type { get; set; }
        
        public Group(Type type)
        {
            string typeStr = type.ToString();
            if(type == Type.Programming)
            { 
                _programmingNo++;
                No = $"{typeStr[0]}{_programmingNo}";
            }
            else if(type == Type.Design)
            {
                _designNo++;
                No = $"{typeStr[0]}{_designNo}";
            }
            else if (type == Type.system)
            {
                _systemNo++;
                No = $"{typeStr[0]}{_systemNo}";
            }
        }

        public Student FindStudentByNo(int no)
        {
            foreach (var item in students)
            {
                if (item.No == no)
                    return item;
            }

            return null;
        }
    }
}
