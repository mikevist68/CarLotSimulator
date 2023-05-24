using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();



















            //TODO

            //Create a seperate class file called Car -  done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // Dot Notation
            var charger = new Car();
            charger.Make = "Dodge";
            charger.Model = "Charger";
            charger.Year = 1967;
            charger.EngineNoise = "rumble";
            charger.HonkNoise = "Honk";
            charger.IsDriveable = true;

            Console.WriteLine($"here is the new number of cars {CarLot._numberOfCars}"); 

            carLot.ParkingLot.Add(charger);

            //Object Initializer Syntax
            var honda = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = 2021,
                EngineNoise = "Rumble",
                HonkNoise = "Meep",
                IsDriveable = true
            };

            carLot.ParkingLot.Add(honda);

            // Using customer constructor
            var camry = new Car(2021, "Toyota", "Camry", "Vroom", "Horn", false);

            Console.WriteLine($"here is the new number of cars {CarLot._numberOfCars}");

            carLot.ParkingLot.Add(camry);

            carLot.CheckCars();

        }














    }
}