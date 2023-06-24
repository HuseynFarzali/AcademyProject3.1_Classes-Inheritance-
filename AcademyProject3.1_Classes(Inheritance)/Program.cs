using System;

namespace AcademyProject3._1_Classes_Inheritance_
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "(No Name)"; Surname = "(No Surname)"; Age = 0;
        }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

    public class Teacher : Person
    {
        public Teacher() : base() { }
        public Teacher(string name, string surname, int age) : base(name, surname, age) { }

        public void Explain()
        {
            Console.WriteLine("Explaining...");
        }
    }

    public class Student : Person
    {
        public Student() : base() { }
        public Student(string name, string surname, int age) : base(name, surname, age) { }

        public void Learn() 
        { 
            Console.WriteLine("Learning..."); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Leyla", "Muradkhanli", 44);
            Student student = new Student("Aliheydar", "Heydarov", 21);

            teacher.Explain();
            student.Learn();
        }
    }
}
