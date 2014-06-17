using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanImpedance.Common
{
  [Serializable]
  public class CMeasure
  {
    public double Current;
    public double Voltage;
    public CMeasure()
    {
      Current = 0;
      Voltage = 0;
    }
  }
}
