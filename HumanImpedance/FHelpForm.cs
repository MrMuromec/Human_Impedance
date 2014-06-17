using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanImpedance
{
  public partial class FHelpForm : Form
  {
    private FContainer Parent = null;
    public FHelpForm(FContainer parent)
    {
      this.Parent = parent;
      this.MdiParent = Parent;
      InitializeComponent();
    }

    private void FHelpForm_Load(object sender, EventArgs e)
    {
      this.StartPosition = FormStartPosition.Manual;

    }
    public void Invalidate_Text()
    {
      if (Parent.currentDatabase == null)
      {
        this.currentDB.Text = "База не подключена";
        this.BDSize.Text = " 0 ";
        this.currentDoc.Text = "Не выбран";
        this.currentPac.Text = "Не выбран";
        return;
      }
      FileInfo info = new FileInfo(Parent.currentDataPath);

      this.currentDB.Text = Parent.currentDataPath;
      this.BDSize.Text = (info.Length / 1024).ToString() + "КБайт";

      //Счетчики
      this.DocCount.Text = Parent.currentDatabase.GetDocList().Count.ToString();
      this.MeasureCount.Text = Parent.currentDatabase.GetMeasureList().Count.ToString();
      this.PacCount.Text = Parent.currentDatabase.GetPacientList().Count.ToString();
      
      #region Выбранные
      if (Parent.currentDatabase.currentDocID < 0)
        this.currentDoc.Text = "Не выбран";
      else
        this.currentDoc.Text = Parent.currentDatabase.GetDocList().Where(d => d.id == Parent.currentDatabase.currentDocID).FirstOrDefault().FIO;
      if (Parent.currentDatabase.currentPacID < 0)
        this.currentPac.Text = "Не выбран";
      else
        this.currentPac.Text = Parent.currentDatabase.GetPacientList().Where(p => p.id == Parent.currentDatabase.currentPacID).FirstOrDefault().FIO;
      #endregion

      
    }

    private void FHelpForm_Activated(object sender, EventArgs e)
    {
      this.Invalidate_Text();
    }
  }
}
