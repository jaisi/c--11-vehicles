using System;
using System.Collections.Generic;

public class Boeing : IVehicle,IAir
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } = 3;
  public int PassengerCapacity { get; set; } = 200;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 45.1;
  public double MaxAirSpeed { get; set; } = 405.0;

  public void Fly()
  {
    Console.WriteLine("The Boeing is the queen of all planes and makes travel a pleasure!");
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
