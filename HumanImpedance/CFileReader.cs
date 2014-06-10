using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using HumanImpedance.Common;

namespace HumanImpedance
{
    public class CFileReader
    {
      private string path = "";
      public CFileReader(string _path)
      {
        path = _path;
      }
      public List<CMeasure> GetMeasure()
      {
        string line;
        string[] lineelemets;
        List<CMeasure> outlist = new List<CMeasure>();
        using (StreamReader sr = new StreamReader(path))
        {
          int Count = 0;
          while ((line = sr.ReadLine()) != null)
          {
            lineelemets = line.Split(' ');
            if (lineelemets.Count() != 3)
            {
              MessageBox.Show("Ошибка чтения из файла");
              return null;
            }
            CMeasure Measure = new CMeasure();
            double.TryParse(lineelemets[1], out Measure.Current);
            double.TryParse(lineelemets[2], out Measure.Voltage);

            Count++;

            outlist.Add(Measure);
          }
          MessageBox.Show("Чтение успешно завершено");
        }
        return outlist;
      }
    }
}
