//Abdalrahman Mohamed Abdallah Mohamed Makled
//225106706
using System;
using System.Collections.Generic;
using System.Text;

namespace Cse111Task1
{
    internal class StudentList
    {
        public Student? First { get; set; }
        public Student? Last { get; set; }
        public int Count { get; set; }

        public StudentList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void AddFront(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                newStudent.Next = First;
                First = newStudent;
            }

            Count++;
        }


        public void AddEnd(int id)
        {
            Student newStudent = new Student(id);

            if (First == null)
            {
                First = newStudent;
                Last = newStudent;
            }
            else
            {
                Last!.Next = newStudent;
                Last = newStudent;
            }
            Count++;
        }

        public void Print()
        {
            Student? current = First;

            while (current != null)
            {
                Console.Write(current.Id + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void Reverse()
        {
            if (First == null || First == Last) return;

            Student? previous = null;
            Student? current = First;
            Student? nextNode = null;

            Last = First;

            while (current != null)
            {
               nextNode = current.Next;
               current.Next = previous; 
               previous = current;
               current = nextNode;
            }
            First = previous;
        }

        public bool Remove(int id)
        {
            if (First == null) return false;

            if (First.Id == id)
            {
                First = First.Next;
                Count--;
                if (First == null)
                {
                    Last = null;
                }
                return true;
            }

            Student? current = First;
            while (current.Next != null && current.Next.Id != id)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                Student studentToRemove = current.Next;
                current.Next = studentToRemove.Next;

                if (studentToRemove == Last)
                {
                    Last = current;
                }

                Count--;
                return true;
            }

            return false;
        }
    }
}

