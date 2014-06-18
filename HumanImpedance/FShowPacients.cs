using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanImpedance.Entites;

namespace HumanImpedance
{
  public partial class FShowPacients : Form
  {
    public DataContainer localDB = null;
    private FContainer Parent = null;

    public FShowPacients(FContainer parent)
    {
      InitializeComponent();

      this.MdiParent = parent;
      Parent = parent;
      localDB = parent.currentDatabase;
      GridRefresh();
    }
    private void GridRefresh()
    {
      PacGrid.Rows.Clear();
      foreach (Pacient pac in localDB.GetPacientList())
      {
        string[] array = new string[2];
        array[0] = pac.FIO;
        array[1] = (from m in localDB.GetMeasureList() where m.PacID == pac.id select m).Count().ToString();
        PacGrid.Rows.Add(array);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      localDB = Parent.currentDatabase;
      GridRefresh();
    }

    private void PacGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if(!localDB.Equals(Parent.currentDatabase))
      {
        Refresh();
        return;
      }
      if (e.RowIndex < 0) return;
      string FIO = PacGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
      

      MessageBox.Show(FIO);
    }

    private void PacGrid_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      Pacient pacient = Parent.currentDatabase.GetPacientList()[e.RowIndex];
      MessageBox.Show("Пациент" + pacient.FIO + "выбран текущим");
      Parent.currentDatabase.currentPacID = pacient.id;
      Parent.HelpForm.Invalidate_Text();

      switch (MessageBox.Show("показать анализы пациента?", "вопрос", MessageBoxButtons.YesNo))
      {
        case System.Windows.Forms.DialogResult.Yes:
          //открыть все окошки для измерений с этим пациентом
          List<Measure> PacientMeasureCollection = new List<Measure>();
          foreach (Measure measure in localDB.GetMeasureList())
          {
            if (measure.PacID == pacient.id)
              PacientMeasureCollection.Add(measure);
          }
          foreach (Measure measure in PacientMeasureCollection)
          {
            FShowMeasure ShowMeasure = new FShowMeasure(measure, Parent);
            ShowMeasure.MdiParent = Parent;
            ShowMeasure.Show();
          }
          break;
        case System.Windows.Forms.DialogResult.No:
          return;
      }
    }
  }
}
