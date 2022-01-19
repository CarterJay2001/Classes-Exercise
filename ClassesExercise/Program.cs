using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var DreamCar = new Car();
            DreamCar.Make = "Telsa";
            DreamCar.Model = "Model S Plaid";
            DreamCar.Year = 2022;

            Console.WriteLine(DreamCar.Make);
            Console.WriteLine(DreamCar.Model);
            Console.WriteLine(DreamCar.Year);

            var LikeCar = new Car();
            LikeCar.Make = "Jeep";
            LikeCar.Model = "Wrangler Rubicon 392";
            LikeCar.Year = 2022;

            Console.WriteLine(LikeCar.Make);
            Console.WriteLine(LikeCar.Model);
            Console.WriteLine(LikeCar.Year);
        }
    }
}
