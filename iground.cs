using System;
using System.Linq;
using System.Collections.Generic;

public interface IGround
{
     double MaxLandSpeed { get; set; }
     void Drive();
}
