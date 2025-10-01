using System;
/*Write a C# program that declares the following variables and prints their values:

An integer to store your age

A double to store your height in meters

A string to store your name*/
class Practice1
{

    public int Age;
    public double Height;
    public string Name;

    public void CreatePerson()
    {
        Console.WriteLine("Enter Age:");
        Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Height in meters:");
        Height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Name:");
        Name = Console.ReadLine();
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Age:{0}", Age);
        Console.WriteLine("Height in meters:{0}", Height);
        Console.WriteLine("Name:{0}", Name);
    }

}

