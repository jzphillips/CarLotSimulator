using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instantiate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            var frstCar =  new Car();
            frstCar.Year = 1999;
            frstCar.Model = "R34 Skyline";
            frstCar.Make = "Nissan";
            frstCar.IsDriveable = true;
            
            frstCar.MakeEngineNoise("Whistling");
            frstCar.MakeHonkNoise("Honk");
            
            var scndCar =  new Car(1970, "Dodge", "Charger", true);
            
            scndCar.MakeEngineNoise("Vroom Growl");
            scndCar.MakeHonkNoise("Honk");

            var thrdCar = new Car()
            {
                Year = 2022,
                Make = "Hyundai",
                Model = "Sonata",
                IsDriveable = true
            };
            
            thrdCar.MakeEngineNoise("vroom");
            thrdCar.MakeHonkNoise("Beep");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the CarLot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
