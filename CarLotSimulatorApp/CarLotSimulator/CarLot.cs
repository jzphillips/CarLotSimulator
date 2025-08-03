using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> TheLot { get; set; } = new List<Car>();

    public void CarStock()
    {
        foreach (var car in TheLot)
        {
            Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
        }
    }
   
    public static int _numberOfCars;
}
