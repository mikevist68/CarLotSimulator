﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{           //field
    public class CarLot
    {   
        public static int _numberOfCars;
        public List<Car> ParkingLot { get; set; } = new List<Car>();

        public void CheckCars()
        {
            foreach (var car in ParkingLot)
            {
                Console.WriteLine($"This is a {car.Make} {car.Model} made in the year {car.Year}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkeNoise($"{car.HonkNoise}\n");
            }
        }
        

    
    
    
    }
    





}
//*************BONUS X 2*************//

//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console
