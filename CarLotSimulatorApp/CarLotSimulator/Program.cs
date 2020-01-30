﻿using System;
using System.Collections.Generic;
namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Way 1
            var volvo = new Car()
            
            {
                Year = 2000,
                Make = "Volvo",
                Model = "sedan",
                EngineNoise = "vrooooo",
                HonkNoise = "tootoot",
                IsDrivable = true,
               
            };

            Console.WriteLine($"Number of cars = {CarLot.NumberOfCars}");

            volvo.MakeEngineNoise(volvo.EngineNoise);


            //Way 2
            var suburban = new Car();

            suburban.Year = 1982;
            suburban.Make = "GMC";
            suburban.Model = "Suburban";
            //suburban.EngineNoise = "chugalug";
            suburban.HonkNoise = "boopboop";
            suburban.IsDrivable = true;
            suburban.MakeEngineNoise("vrumdeedum");

            Console.WriteLine($"Number of cars = {CarLot.NumberOfCars}");

            //Way 3
            //var honda = new Car()
            var honda = new Car(2005, "Honda", "sedan", "rrrrrrm", "wahhhhh", true); // the alternate way to set the properties honda.EngineNoise = "vrooom";

            Console.WriteLine($"Number of cars = {CarLot.NumberOfCars}");

            carLot.ListOfCars.Add(honda);
            carLot.ListOfCars.Add(volvo);
            carLot.ListOfCars.Add(suburban);

            

            foreach (var item in carLot.ListOfCars)
                {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                
                }
            // volvo.MakeEngineNoise(volvo.EngineNoise);




            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


           

        }
    }
}
