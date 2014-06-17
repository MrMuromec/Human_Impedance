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
  public partial class FShowDocs : Form
  {
    private DataContainer localDB;
    private FContainer Parent = null;

    public FShowDocs(FContainer parent)
    {
      localDB = parent.currentDatabase;
      this.MdiParent = parent;
      Parent = parent;
      InitializeComponent();
    }

    private void Add_Click(object sender, EventArgs e)
    {
      throw new NotImplementedException("Данная функция не реализована");
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
      localDB = Parent.currentDatabase;
      GridRefresh();
    }

    private void FShowDocs_Load(object sender, EventArgs e)
    {
      DocGrid.AllowUserToAddRows = false;
      GridRefresh();
    }
    private void GridRefresh()
    {
      DocGrid.Rows.Clear();
      foreach (Doctor doc in localDB.GetDocList())
      {
        DocGrid.Rows.Add(doc.FIO);
      }
    }

    private void DocGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      {
        Doctor Doc = Parent.currentDatabase.GetDocList()[e.RowIndex];
        MessageBox.Show("Врач  " + Doc.FIO + " выбран текущим");
        Parent.currentDatabase.currentDocID = Doc.id;
        Parent.HelpForm.Invalidate_Text();
      }
    }

  }
}
