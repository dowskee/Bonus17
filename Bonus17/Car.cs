using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Car
    {
        //create a class named Car to store the data about this car. This class should contain string make, model, int year, double price
        private string make;
        private string model;
        private int year;
        private double price; 

        public string Make //get set for each data piece
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public void CarTypes() //methods
            //add validation! Separate methods?
        {
            Console.WriteLine("Please enter the make of the car:");
            Make = Console.ReadLine(); //ValidateMake?

            Console.WriteLine("Please enter the model of the car:");
            Model = Console.ReadLine();

            Console.WriteLine("Please enter the year the car was made:");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of the car:");
            Price = double.Parse(Console.ReadLine());
        }
        //constructors

        //default constructor
        public Car() //base constructor? 
        {
            make = "";
            model = "";
            year = 0;
            price = 0;
        }

        //consturctor with values
        public Car(string CarMake, string CarModel, int CarYear, double CarPrice)
        {
            make = CarMake; //calls Make from the array Car
            model = CarModel;
            year = CarYear;
            price = CarPrice;
        }

        public void ValidateMake(string Make)
        {
            bool check = false;

            Console.WriteLine("Please enter the make of the car:");
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
                Console.WriteLine("Enter a valid car make:");
                Make = Console.ReadLine();
            }
        }

        public void ValidateModel(string Model)
        {
            bool check = false;

            Console.WriteLine("Please enter the model of the car:");
            Model = Console.ReadLine().ToLower(); //check for capitalization

            for (int i = 0; i < Make.Length; i++)
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

            Console.WriteLine("Please enter the car year:");
            Year = int.Parse(Console.ReadLine());

                if (Year < 1900 && Year > 3000) //covers valid years where cars have been made
                {
                    check = true;
                }
                else if (check == false)
                {
                Console.WriteLine("Enter a valid year:");
                Year = int.Parse(Console.ReadLine());
                check = false;
                }

        }

        public void ValidatePrice(double Price)
        {
            Console.WriteLine("Please enter the price of the car:"); 
            string input = Console.ReadLine(); //set the input as a string variable
            double price; //double variable

            if (!double.TryParse(input, out price)) //checks if input is a valid number
            {
                while (Price < 1) //catches if no number is entered 
                {
                    Console.WriteLine("Please enter a valid price:"); //display message to user
                    double.TryParse(Console.ReadLine(), out price); 
                }

            }
        }
    }
}
