using System;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise =  honkNoise;
    }

    public Car()
    {
        CarLot._numberOfCars++;
    }

    public Car(int year, string make, string model, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        IsDriveable = isDriveable;
        
        CarLot._numberOfCars++;
    }
}