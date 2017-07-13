using System;
using System.Collections.Generic;

public class Yacht : IVehicle,IWater
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int PassengerCapacity { get; set; }
 
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
  

    public void Drive()
    {
        Console.WriteLine("The yacht is a symbol of luxury and only the rich and famous can sail away in one!");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

