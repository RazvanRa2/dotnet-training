using System;

namespace lab1
{
    class Student 
    {
        public string name;
        public int age;
        public string emailAddress;
        
        private float grade;
        // acesta este un comentariu
        public Boolean passed;

        public void setGrade(float newGrade) {
            Console.WriteLine($"{name} got grade {newGrade}");
            grade = newGrade;

            if (grade >= 4.5f) {
                passed = true;
            } else {
                passed = false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.name = "Gigel";
            myStudent.age = 23;
            myStudent.emailAddress = "gigel@facultate.ro";

            Student myStudent2 = new Student();
            myStudent2.name = "Andrei";
            myStudent2.age = 22;
            myStudent2.emailAddress = "andrei@facultate.ro";
            
            myStudent.setGrade((float)4);
            myStudent2.setGrade((float)9.7);

            Console.WriteLine(myStudent.passed);
            Console.WriteLine(myStudent2.passed);
        }
    }
}
