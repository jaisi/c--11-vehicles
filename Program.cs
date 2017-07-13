using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{

    public static void Main() {

        // Build a collection of all vehicles that fly
        Cessna newCessna = new Cessna();
        Boeing newBoeing = new Boeing();

        List<IAir> airVehicles = new List<IAir>();

        airVehicles.Add(newCessna);
        airVehicles.Add(newBoeing);

        // With a single `foreach`, have each vehicle Fly()
       foreach(var vehicle in airVehicles)
       {
           vehicle.Fly();
       }

        // Build a collection of all vehicles that operate on roads
        Motorcycle newCycle = new Motorcycle();
        BMW newBmw = new BMW();
        
        List<IGround> groundVehicles = new List<IGround>();

        groundVehicles.Add(newCycle);
        groundVehicles.Add(newBmw);

        // With a single `foreach`, have each road vehicle Drive()
        foreach(var vehicle in groundVehicles)
        {
            vehicle.Drive();
        }

        // Build a collection of all vehicles that operate on water
        JetSki newJetski = new JetSki();
        Yacht newYacht = new Yacht();

        List<IWater> waterVehicles = new List<IWater>();

        waterVehicles.Add(newJetski);
        waterVehicles.Add(newYacht);
        
        // With a single `foreach`, have each water vehicle Drive()
        foreach(var vehicle in waterVehicles)
        {
            vehicle.Drive();
        }
    }

}