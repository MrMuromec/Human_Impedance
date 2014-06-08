using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HumanImpedance.Common;

namespace HumanImpedance
{
  public partial class FMainForm : Form
  {

    private List<CMeasure> MeasureList;

    public FMainForm()
    {
      InitializeComponent();
    }

    private void OpenFileButton_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      switch (dialog.ShowDialog())
      {
        case System.Windows.Forms.DialogResult.OK:
          // пользователь нажал кнопку OK при выборе файла
          PathBox.Text = dialog.FileName;
          break;
        case System.Windows.Forms.DialogResult.Cancel:
          // пользователь нажал кнопку отмена
          PathBox.Text = "";
          return;
      }

    }

    private void ReadFileButton_Click(object sender, EventArgs e)
    {
      if (!File.Exists(PathBox.Text))
      {
        MessageBox.Show("Файл не существует");
        return;
      }
      CFileReader fileReader = new CFileReader(PathBox.Text);
      MeasureList = fileReader.GetMeasure();
      PlotPanel.Refresh();
    }

    private void ApplyFilter_Click(object sender, EventArgs e)
    {
      foreach (CMeasure measure in MeasureList)
      {
        measure.Voltage /= 1000;
        measure.Current /= 1000;
        measure.Current += 200;
      }
      PlotPanel.Refresh();
    }

    private void PlotPanel_Paint(object sender, PaintEventArgs e)
    {
      Pen pen_1 = Pens.Green;
      Pen pen_2 = Pens.Blue;

      if(MeasureList == null || MeasureList.Count() < 3) return;
      for (int i = 1; i < MeasureList.Count; i++)
      {
        e.Graphics.DrawLine(
          pen_1, (float)i / 10, 
          (float)MeasureList[i - 1].Current, 
          (float)(i + 1) / 10, 
          (float)MeasureList[i].Current);
        e.Graphics.DrawLine(
         pen_2, (float)i / 10,
         (float)MeasureList[i - 1].Voltage,
         (float)(i + 1) / 10,
         (float)MeasureList[i].Voltage);
      }
    }
  }
}
