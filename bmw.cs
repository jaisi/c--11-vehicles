using System;
using System.Collections.Generic;

public class BMW : IVehicle,IGround
{
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 4;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;
 

    public void Drive()
    {
        Console.WriteLine("The BMW is a status symbol from Germany and looks great on the roads!");
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