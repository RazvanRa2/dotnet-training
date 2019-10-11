using System;

namespace lab1
{
    class Student 
    {
        string testString;

        internal string secondTestString;

        public string name;
        public int age;
        public string emailAddress;
        
        private float grade;

        public void setterGrade(float newGrade) {
            if (newGrade > 0 && newGrade <= 10) {
                grade = newGrade;
            } else {
                Console.WriteLine("Warning: grade is not valid");
            }
        }
        public float getterGrade()
        {
            return grade;
        }

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
        public Student() 
        {
            name = "unnamed student";
            age = -1;
            emailAddress = "NO ADDRESS";
            grade = 5;
            passed = false;
        }

        public Student(string newName, int newAge, string newEmail, float newGrade) {
            name = newName;
            age = newAge;
            emailAddress = newEmail;

            setGrade(newGrade);
        }

        public Student(string newName, int newAge, string newEmail, double newGrade)
        {
            name = newName;
            age = newAge;
            emailAddress = newEmail;

            setGrade((float) newGrade);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           int[] intArray = new int[10];

            for (int i = 0; i <= 10; i = i + 1) {
                Console.WriteLine($"i = {i}");
                intArray[i] = i * 10;
            }


            var students = new Student[10];
            var test = "1245";

            string readFromKeyboard = "";
            while(readFromKeyboard != "exit") {
                readFromKeyboard = Console.ReadLine();
            }

            //var list = new List<int>();
            //Student testStudent = new Student();
            //Console.WriteLine(testStudent.getterGrade());
            //Student myStudent = new Student("Razvan", 22, "razvan@gmail.com", 5.2f);
            //Console.WriteLine(myStudent.passed);
        }
    }
}
