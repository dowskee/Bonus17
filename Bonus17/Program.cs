using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a class named CarApp that gets the user input, creates a car object, and displays the car information
            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            int AmountofCars;
            Console.WriteLine("How many cars are you entering:");
            AmountofCars = int.Parse(Console.ReadLine());

            //create an array to hold the objects 

            Car[] CarApp = new Car[AmountofCars];

            for (int i = 0; i < CarApp.Length; i++)
            {
                CarApp[i] = new Car(); //create an object 
            }

            //initialize

            for (int i = 0; i < CarApp.Length; i++)
            {
                Console.WriteLine("Please enter the car's Make");
                CarApp[i].Make = Console.ReadLine();

                Console.WriteLine("Please enter the car's Model");
                CarApp[i].Model = Console.ReadLine();

                Console.WriteLine("Please enter the car's Year");
                CarApp[i].Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the car's Price:");
                CarApp[i].Price = double.Parse(Console.ReadLine()); //n2 for price writing in class has to be where it is written below
            }
            Console.WriteLine("Current Inventory:");
            Console.WriteLine("Make \tModel \tYear \tPrice");

            foreach (Car Element in CarApp)
            {
                Console.WriteLine($"{Element.Make} \t{Element.Model} \t{Element.Year} \t${Element.Price.ToString("N2")}");
            }

        }
    }
}
