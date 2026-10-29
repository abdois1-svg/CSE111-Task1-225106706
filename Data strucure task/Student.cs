using System;
using System.Collections.Generic;
using System.Text;

namespace Cse111Task1
{
    public class Student
    {
        public int Id { get; set; }
        public Student? Next { get; set; }

        public Student(int id)
        {
            Id = id;
            Next = null;
        }

    }
}
