using CarLotSimulator;
using System;
using System.Reflection;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            CarLot._numberOfCars++;
        
        }
                                               // this is a customer constructor
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable) 
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            CarLot._numberOfCars++;

        }




        public int Year { get; set; }


        public string Make { get; set; }


        public string Model { get; set; }


        public string EngineNoise { get; set; }



        public string HonkNoise { get; set; }



        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"{Make}{Model}makes a noise like {engineNoise}.");
        }

        public void MakeHonkeNoise(string honkNoise)
        {
            Console.WriteLine($"{Make}{Model}makes a noise like {honkNoise}.");
        }





    }
}
//Now that the Car class is created we can instanciate 3 new cars
//Set the properties for each of the cars
//Call each of the methods for each car




/*public string MakeEngineNoise()
    {
        string engnoise = ("vroom");

        return engnoise;

    }   Console.WriteLine(engnoise);*/



/*public Car()
{
    
}




public string stingray { get; set; }


public string charger { get; set; }


public string challenger { get; set; }

public string MakeHonkNoise()
        {
            string honknoise = ("meep meep");

            return honknoise;

            Console.WriteLine(honknoise);
        }
 
 
 
 
 
 
 
 */
