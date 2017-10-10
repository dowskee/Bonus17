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
                CarApp[i].Make = Console.ReadLine();

                CarApp[i].Model = Console.ReadLine();

                CarApp[i].Year = int.Parse(Console.ReadLine());

                CarApp[i].Price = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Current Inventory:");
            Console.WriteLine("Make".PadRight(10,' ') +"\t"+ "Model".PadRight(10, ' ') +"\t" + "Year".PadRight(10, ' ') + "\t" + "Price".PadRight(10, ' '));

            foreach (Car Element in CarApp)
            {
                Console.WriteLine($"{Element.Make.PadRight(10, ' ')} \t{Element.Model.PadRight(10, ' ')} \t{Element.Year.ToString().PadRight(10, ' ')} \t${Element.Price.ToString("N2").PadRight(10, ' ')}");
            }

        }
        public void ValidateMake(string Make)
        {
            bool check = false;

            Console.WriteLine("Please enter the car's Make:");
            Make = Console.ReadLine().ToLower(); //include lower and upper case

            for (int i = 0; i < Make.Length; i++)
            {
                if (Make[i] >= 'a' && Make[i] <= 'z' || Make[i] == ' ') //checks for letters a-z and blank spaces
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

            }

            if (check == false)
            {
                Console.WriteLine("Enter a valid car Make:");
                Make = Console.ReadLine();
            }
        }

        public void ValidateModel(string Model)
        {
            bool check = false;

            Console.WriteLine("Please enter the car Model:");
            Model = Console.ReadLine().ToLower(); //check for capitalization

            for (int i = 0; i < Model.Length; i++)
            {
                if (Model[i] >= 'a' && Model[i] <= 'z' || Model[i] == ' ') //checks that only letters a-z are covered for model input
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

            }

            if (check == false)
            {
                Console.WriteLine("Enter a valid car model:");
                Model = Console.ReadLine();
            }
        }

        public void ValidateYear(int Year)
        {
            bool check = false;
            //drop down list? 
            Console.WriteLine("Please enter the car Year:");
            Year = int.Parse(Console.ReadLine());

            if (Year < 1900 && Year > 3000) //covers valid years where cars have been made
            {
                check = true;
            }
            else if (check == false)
            {
                Console.WriteLine("Enter a valid Year:");
                Year = int.Parse(Console.ReadLine());
                check = false;
            }

        }

        public void ValidatePrice(double Price)
        {
            Console.WriteLine("Please enter the car Price:");
            string input = Console.ReadLine(); //set the input as a string variable
            double price; //double variable

            if (!double.TryParse(input, out price)) //checks if input is a valid number
            {
                while (Price < 0) //catches if no number is entered 
                {
                    Console.WriteLine("Please enter a valid Price:"); //display message to user
                    double.TryParse(Console.ReadLine(), out price);
                }

            }
        }
    }
}
