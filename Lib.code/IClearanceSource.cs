using System;
using System.Collections.Generic;
using System.Reflection;

namespace Security {

  public interface IClearanceSource {
    DateTime LastClearanceChangeDateUtc { get; }
    String[] GetClearancesOfDimension(string dimensionName);
  }

}
