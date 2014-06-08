using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanImpedance.Common
{
    public class CMeasure
    {
      public int id;
      public double Current;
      public double Voltage;
      public CMeasure()
      {
        id = 0;
        Current = 0;
        Voltage = 0;
      }
    }
}
