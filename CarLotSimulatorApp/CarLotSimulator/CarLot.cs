using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {
        }

        public List<Car> ListOfCars = new List<Car>(); //this is a field
        /*use property (public List<Car> ListOfCars if you are going to
        create the list in Main then set the list to ListOfCars */

        public static int NumberOfCars = 0;
    }
    

}
