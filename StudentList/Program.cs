using System;

namespace StudentList
{
    class StudentInformation
    {
        static void Main(string[] args)
        {
            string studentNameInput;
            string studentAgeInput;
            int ageInput;
            


            Console.WriteLine("Enter New Student's Name: ");
            studentNameInput = Console.ReadLine();
            Console.WriteLine("Enter New Student's Age: ");
            studentAgeInput = Console.ReadLine();
            ageInput = Convert.ToInt32(studentAgeInput);



            Person student1 = new Person(studentNameInput, ageInput);
            Console.WriteLine("The Name Of The New Student: " + student1.NAME);
            Console.WriteLine("The Age of The New Student Is: " + student1.AGE);





        }

    }


    class Person
    {


        public string NAME { get; set; }
        public int AGE { get; set; }


       public Person(string name, int age)
        {

            NAME = name;
            AGE = age;

       }










    }




}
