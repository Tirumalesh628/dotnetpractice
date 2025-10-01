using System;

namespace DOTNETPRACTICE.datatypes
{
    class Student
    {
       public string Name;
        string subject;
        int Marks;
        string Results;

        public void createstudent()
        {
            Console.WriteLine("Enter Student Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Subject:");
            subject = Console.ReadLine();
            Console.WriteLine("Enter {0} Marks for {1}", Name,subject);
            Marks = Int32.Parse(Console.ReadLine());
            if (Marks >= 40) Console.WriteLine("{0} Qualified",Name);
            else Console.WriteLine($"{0} Dis-Qualified", Name);
        }





        
    }
}
