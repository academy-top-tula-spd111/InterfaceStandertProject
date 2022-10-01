using System.Collections;

namespace InterfaceStandertProject
{
    class StudentSortName : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return String.Compare(x.Name, y.Name);
        }
    }

    class StudentSortAge : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            if (x.Age == y.Age) return 0;
            else if (x.Age < y.Age) return -1;
            else return 1;
        }
    }

    class Student //: IComparable
    {
        public string Name { get; set; }
        public int Age { set; get; }

        public static bool operator>(Student s1, Student s2)
        {
            return s1.Age > s2.Age;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Age < s2.Age;
        }

        //public int CompareTo(object? obj)
        //{
        //    //if(obj is Student)
        //    return Name.CompareTo((obj as Student).Name);
        //}

        public override string ToString()
        {
            return $"{Name} - {Age}";
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student(){ Name = "Joe", Age = 22 },
                new Student(){ Name = "Bob", Age = 41 },
                new Student(){ Name = "Tim", Age = 35 },
            };

            Array.Sort(students, new StudentSortAge());

            foreach (Student student in students)
                Console.WriteLine(student);
        }
    }
}