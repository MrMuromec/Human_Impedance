using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanImpedance.Common;
namespace HumanImpedance.Entites
{
  [Serializable]
  public class Measure
  {
    public int id;

    public int DocID;
    public int PacID;

    public string FIO;
    public DateTime date;
    public List<CMeasure> MeasureList;
    public Measure()
    {
      MeasureList = new List<CMeasure>();
    }

  }
}
