using System;
namespace CarLotSimulator
{
    public class Car
    {

        public Car() 
        {
            CarLot.NumberOfCars++;
        }

        ~Car() //This is a destructor. When we decide something is no longer needed, will free open the memory allocated
        {       //This is more theortetical, we don't actually use much

        }

        //If we want to overload Car() and make another version where the constructor takes arguments
        public Car
            (int year,
            string make,
            string model,
            string engineNoise,
            string honkNoise,
            bool isDrivable
            )
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
            CarLot.NumberOfCars++;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise) { }


        



    }

}
