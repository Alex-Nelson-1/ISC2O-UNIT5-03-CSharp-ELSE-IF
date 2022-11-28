// Created by: Alex Nelson
// Created on: Nov 2022
//
// This program tells you which age range of movies you can
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Input
        Console.WriteLine("This program Tells you which age range of movies you can");
        Console.WriteLine("");
        Console.WriteLine("Please enter your age.");
        int age = Convert.ToInt32(Console.ReadLine());
        //Procces
        Console.WriteLine("");
        //Procces
        if (age > 122)
        {
            //Output
            Console.WriteLine("NOT POSSIBLE!");
        }
        //Procces
        else if (age > 17) 
        {
            //Output
            Console.WriteLine("You can watch R rated movies");
        }
        //Procces
        else if (age > 12) 
        {
            //Output
            Console.WriteLine("You can watch PG-13 movies");
        }
        //Procces
        else if (age < 13) 
        {
            //Output
            Console.WriteLine("You can watch G rated movies");
        }
        //Output
        else
        {
        Console.WriteLine("Invalid Input.");
        }
        Console.WriteLine("\nDone");
    }
}
