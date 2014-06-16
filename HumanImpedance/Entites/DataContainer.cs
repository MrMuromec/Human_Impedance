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
  }
}
