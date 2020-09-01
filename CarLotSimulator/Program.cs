using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO



            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var johnsCar = new Car();
            johnsCar.Year = (2006);
            johnsCar.Make=("LandRover");
            johnsCar.Model = ("LR3");
            johnsCar.EngineNoise = ("Loud");
            johnsCar.HonkNoise = ("HONK!");
            johnsCar.MakeEngineNoise("RHMRHMRHMRHMRHM");
            johnsCar.MakeHonkNoise("HOOOONNKKK!");
            Console.WriteLine(johnsCar.Year);
            Console.WriteLine(johnsCar.Make);
            Console.WriteLine(johnsCar.Model);
            Console.WriteLine(johnsCar.EngineNoise);
            Console.WriteLine(johnsCar.HonkNoise);
            


            Console.WriteLine("------------------------");

            var ellasCar = new Car();
            ellasCar.Year = (2013);
            ellasCar.Make = ("Mazda");
            ellasCar.Model = ("Cx 5");
            ellasCar.EngineNoise = ("Quiet");
            ellasCar.HonkNoise = ("Beep");
            ellasCar.MakeEngineNoise("rhmrhmrhm");
            ellasCar.MakeHonkNoise("beeeeeeep");
            Console.WriteLine(ellasCar.Year);
            Console.WriteLine(ellasCar.Make);
            Console.WriteLine(ellasCar.Model);
            Console.WriteLine(ellasCar.EngineNoise);
            Console.WriteLine(ellasCar.HonkNoise);






            Console.WriteLine("------------------------");

            var nicksCar = new Car();
            nicksCar.Year = (2001);
            nicksCar.Make = ("Toyota");
            nicksCar.Model = ("Tundra");
            nicksCar.EngineNoise = ("Medium Noise");
            nicksCar.HonkNoise = ("honk");
            nicksCar.MakeEngineNoise("rHMrHMrHMrHM");
            nicksCar.MakeHonkNoise("honkkkkkkkk");
            Console.WriteLine(nicksCar.Year);
            Console.WriteLine(nicksCar.Make);
            Console.WriteLine(nicksCar.Model);
            Console.WriteLine(nicksCar.EngineNoise);
            Console.WriteLine(nicksCar.HonkNoise);


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
