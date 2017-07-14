using System;
using System.Collections.Generic;

public class Yacht : Vehicle,IWater
{
    public double MaxWaterSpeed { get; set; }
    
    public void Drive()
    {
        Console.WriteLine("The yacht is a symbol of luxury and only the rich and famous can sail away in one!");
    }

   
}

