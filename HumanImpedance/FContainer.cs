using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanImpedance.Common;
namespace HumanImpedance
{
  public partial class FContainer : Form
  {
    public FContainer()
    {
      InitializeComponent();
    }

    private void CreateMeasureTollStrip_Click(object sender, EventArgs e)
    {
      FCreateFromFile loader = new FCreateFromFile();
      loader.MdiParent = this;
      loader.Show();

    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void вДругуюБазуToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FExportForm exportForm = new FExportForm();
      exportForm.ShowDialog();
    }
  }
}
