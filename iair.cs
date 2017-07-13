using System;
using System.Linq;
using System.Collections.Generic;


public interface IAir
{
     bool Winged { get; set; }
     double MaxAirSpeed { get; set; }
     void Fly();
     
}