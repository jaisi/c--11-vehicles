using System;
using System.Collections.Generic;

public class JetSki : Vehicle,IWater
{
    public double MaxWaterSpeed { get; set; }
 

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }


}

