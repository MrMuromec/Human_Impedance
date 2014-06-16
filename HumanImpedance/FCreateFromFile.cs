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
using HumanImpedance.Entites;

namespace HumanImpedance
{
  public partial class FCreateFromFile : Form
  {

    public Measure measure;

    public FCreateFromFile()
    {
      InitializeComponent();
      measure = new Measure();
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
      measure.MeasureList = fileReader.GetMeasure();
      FilterMeasure();
      PlotPanel.Refresh();
      SaveButton.Enabled = true;
    }

    private void PlotPanel_Paint(object sender, PaintEventArgs e)
    {
      Pen pen_1 = Pens.Green;
      Pen pen_2 = Pens.Blue;

      if(measure.MeasureList == null || measure.MeasureList.Count() < 3) return;
      for (int i = 1; i < measure.MeasureList.Count; i++)
      {
        e.Graphics.DrawLine(
          pen_1, 
          (float)i / 3, 
          (float)measure.MeasureList[i - 1].Current, 
          (float)(i + 1) / 3, 
          (float)measure.MeasureList[i].Current);
        e.Graphics.DrawLine(
         pen_2, 
         (float)i / 3,
         (float)measure.MeasureList[i - 1].Voltage,
         (float)(i + 1) / 3,
         (float)measure.MeasureList[i].Voltage);
      }
    }

    private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FExportForm exportForm = new FExportForm();
      exportForm.ShowDialog();
    }
    private void FilterMeasure()
    {
      List<CMeasure> measure2 = new List<CMeasure>();
      List<CMeasure> measure3 = new List<CMeasure>();


      double Voltage, Current;


      /*****************Начало фильтров*****************/

      measure2.Add(new CMeasure());
      measure2.Add(new CMeasure());
      for (int i = 0; i < measure.MeasureList.Count; i++)
      {
        measure2.Add(measure.MeasureList[i]);
      }
      measure3.Clear();
      measure3.Add(new CMeasure());
      measure3.Add(new CMeasure());
      for (int i = 2; i < measure2.Count; i++)
      {
        /***************************первый фильтр*******************************/
        CMeasure measureHelp = new CMeasure();

        Voltage = (1 * measure2[i - 2].Voltage - 1.9735364316538304 * measure2[i - 1].Voltage + 1 * measure2[i].Voltage);
        Voltage = (Voltage - (0.97522899205898828 * measure3[i - 2].Voltage - -1.9599511990359928 * measure3[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure2[i - 2].Current - 1.9735364316538304 * measure2[i - 1].Current + 1 * measure2[i].Current);
        Current = (Current - (0.97522899205898828 * measure3[i - 2].Current - -1.9599511990359928 * measure3[i - 1].Current)) / 1;
        measureHelp.Current = Current;

        measure3.Add(measureHelp);
      }

      measure2.Clear();
      measure2.Add(new CMeasure());
      measure2.Add(new CMeasure());
      for (int i = 2; i < measure3.Count; i++)
      {
        /***************************второй фильтр*******************************/
        CMeasure measureHelp = new CMeasure();

        Voltage = (1 * measure3[i - 2].Voltage - 1.9675309476158529 * measure3[i - 1].Voltage + 1 * measure3[i].Voltage);
        Voltage = (Voltage - (0.92158600088844911 * measure2[i - 2].Voltage - 1.9049213498646491 * measure2[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure3[i - 2].Current - 1.9675309476158529 * measure3[i - 1].Current + 1 * measure3[i].Current);
        Current = (Current - (0.92158600088844911 * measure2[i - 2].Current - 1.9049213498646491 * measure2[i - 1].Current)) / 1;
        measureHelp.Current = Current;

        measure2.Add(measureHelp);
      }

      measure3.Clear();
      measure3.Add(new CMeasure());
      measure3.Add(new CMeasure());
      for (int i = 2; i < measure2.Count; i++)
      {
        /***************************Третий фильтр*******************************/
        CMeasure measureHelp = new CMeasure();

        Voltage = (1 * measure2[i - 2].Voltage - 1.9486909237199943 * measure2[i - 1].Voltage + 1 * measure2[i].Voltage);
        Voltage = (Voltage - (0.85345281255781213 * measure3[i - 2].Voltage - 1.833456870457691 * measure3[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure2[i - 2].Current - 1.9486909237199943 * measure2[i - 1].Current + 1 * measure2[i].Current);
        Current = (Current - (0.85345281255781213 * measure3[i - 2].Current - 1.833456870457691 * measure3[i - 1].Current)) / 1;
        measureHelp.Current = Current;

        measure3.Add(measureHelp);
      }

      measure2.Clear();
      measure2.Add(new CMeasure());
      measure2.Add(new CMeasure());
      for (int i = 2; i < measure3.Count; i++)
      {
        /*************************** Четвёртый фильтр*******************************/
        CMeasure measureHelp = new CMeasure();

        Voltage = (1 * measure3[i - 2].Voltage - 1.8777640616901443 * measure3[i - 1].Voltage + 1 * measure3[i].Voltage);
        Voltage = (Voltage - (0.7671153819972949 * measure2[i - 2].Voltage - 1.7418974595250869 * measure2[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure3[i - 2].Current - 1.8777640616901443 * measure3[i - 1].Current + 1 * measure3[i].Current);
        Current = (Current - (0.7671153819972949 * measure2[i - 2].Current - 1.7418974595250869 * measure2[i - 1].Current)) / 1;
        measureHelp.Current = Current;

        measure2.Add(measureHelp);
      }

      measure3.Clear();
      measure3.Add(new CMeasure());
      measure3.Add(new CMeasure());
      for (int i = 2; i < measure2.Count; i++)
      {
        /***************************Пятый фильтр*******************************/
        CMeasure measureHelp = new CMeasure();

        Voltage = (1 * measure2[i - 2].Voltage - 1.1608340229048444 * measure2[i - 1].Voltage + 1 * measure2[i].Voltage);
        Voltage = (Voltage - (0.69134326008778102 * measure3[i - 2].Voltage - 1.6611920169645864 * measure3[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure2[i - 2].Current - 1.1608340229048444 * measure2[i - 1].Current + 1 * measure2[i].Current);
        Current = (Current - (0.69134326008778102 * measure3[i - 2].Current - 1.6611920169645864 * measure3[i - 1].Current)) / 1;
        measureHelp.Current = Current;

        measure3.Add(measureHelp);
      }

      /*****************Фильры кончились*****************/

      measure.MeasureList.Clear();
      for (int i = 0; i < measure3.Count; i++)
      {
        measure.MeasureList.Add(measure3[i]);
      }

      double MaxVoltage = 1, MaxCurrent = 1;
      foreach (CMeasure _measure in measure.MeasureList)
      {
        if (Math.Abs(_measure.Voltage) > MaxVoltage) MaxVoltage = Math.Abs(_measure.Voltage);
        if (Math.Abs(_measure.Current) > MaxCurrent) MaxCurrent = Math.Abs(_measure.Current);
      }
      foreach (CMeasure _measure in measure.MeasureList)
      {
        _measure.Voltage /= MaxVoltage;
        _measure.Current /= MaxCurrent;
        _measure.Voltage *= 150;
        _measure.Current *= 150;
        _measure.Voltage += 170;
        _measure.Current += 170;
      }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
