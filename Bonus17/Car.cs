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
        {
            Console.WriteLine("Please enter the make of the car:");
            Make = Console.ReadLine();

            Console.WriteLine("Please enter the model of the car:");
            Model = Console.ReadLine();

            Console.WriteLine("Please enter the year the car was made:");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price of the car:");
            Price = double.Parse(Console.ReadLine());
            
        }
        //constructors

        //default constructor
        public Car()
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
    }
}
