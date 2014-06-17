using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanImpedance.Entites
{
  [Serializable]
  public class DataContainer
  {

    private List<Doctor> Doctors;
    private List<Measure> Measures;
    private List<Pacient> Pacients;
    public int currentDocID;
    public int currentPacID;
    private int NextFreeDoc;
    private int NextFreeMeasure;
    private int NextFreePac;

    public DataContainer()
    {
      Doctors = new List<Doctor>();
      Measures = new List<Measure>();
      Pacients = new List<Pacient>();
      NextFreeDoc = 0;
      NextFreeMeasure = 0;
      NextFreePac = 0;
      currentDocID = currentPacID = -1;
    }

    #region Add Methods
    public int AddDoc(Doctor doctor)
    {
      doctor.id = NextFreeDoc;
      NextFreeDoc++;
      Doctors.Add(doctor);
      return doctor.id;
    }
    public int AddMeasure(Measure measure)
    {
      measure.id = NextFreeMeasure;
      NextFreeMeasure++;
      Measures.Add(measure);
      return measure.id;
    }
    public int AddPacient(Pacient pacient)
    {
      pacient.id = NextFreePac;
      NextFreePac++;
      Pacients.Add(pacient);
      return pacient.id;
    }
    #endregion

    #region Get List Methods 
    public List<Doctor> GetDocList()
    {
      return Doctors;
    }
    public List<Measure> GetMeasureList()
    {
      return Measures;
    }
    public List<Pacient> GetPacientList()
    {
      return Pacients;
    }
    #endregion

    #region Find By FIO Methods
    public Pacient FindPacient(string FIO)
    {
      return (from p in Pacients where p.FIO.Equals(FIO) select p).FirstOrDefault();
    }
    public Doctor FindDoctor(string FIO)
    {
      return (from d in Doctors where d.FIO.Equals(FIO) select d).FirstOrDefault();
    }
    #endregion
  }
}
