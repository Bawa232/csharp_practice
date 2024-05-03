using System;


namespace cars
{

	class Car
	{
    		// Fields
    		public string Make;
    		public string Model;
    		public int Year;
    		public string Color;
    		private bool IsRunning;

    		// Constructor
    		public Car(string make, string model, int year, string color)
    		{
        		Make = make;
        		Model = model;
        		Year = year;
        		Color = color;
        		IsRunning = false;
    		}

    		// Method to start the car
    		public void Start()
    		{
        		IsRunning = true;
        		Console.WriteLine($"The {Year} {Make} {Model} starts.");
    		}

    		// Method to stop the car
    		public void Stop()
    		{
        		IsRunning = false;
        		Console.WriteLine($"The {Year} {Make} {Model} stops.");
    		}

   		 // Method to print car information
    		public void PrintInfo()
    		{
        		Console.WriteLine($"Make: {Make}");
        		Console.WriteLine($"Model: {Model}");
        		Console.WriteLine($"Year: {Year}");
        		Console.WriteLine($"Color: {Color}");
        		Console.WriteLine($"Is Running: {(IsRunning ? "Yes" : "No")}");
    		}
}

	class Program
	{
    		static void Main()
    		{
        		// Creating an instance of Car
        		Car car1 = new Car("Toyota", "Camry", 2022, "Black");

        		// Start the car
        		car1.Start();

        		// Print car information
        		car1.PrintInfo();
    		}
	}

}
