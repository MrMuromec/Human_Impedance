using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using HumanImpedance.Entites;
using System.Runtime.Serialization.Formatters.Binary;

namespace HumanImpedance
{
  static public class CDataFileInterface
  {
    static public DataContainer ReadFromFile(string Path)
    {
      BinaryFormatter formatter = new BinaryFormatter();
      using (Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None))
      {
        return (DataContainer)formatter.Deserialize(fStream);
      }
    }
    static public void WriteToFile(string Path, DataContainer data)
    {
      BinaryFormatter formatter = new BinaryFormatter();
      using (Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.None))
      {
        formatter.Serialize(fStream, data);
      }
    }
  }
}
