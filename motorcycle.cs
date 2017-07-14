using System;
using System.Collections.Generic;

public class Motorcycle : Vehicle,IGround
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
 
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;
    
    public void Drive()
    {
        Console.WriteLine($"The motorcycle has {Wheels} wheels and screams down the highway");
    }

   
}