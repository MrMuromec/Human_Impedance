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

      List<CMeasure> measure2 = new List<CMeasure>();
      List<CMeasure> measure3 = new List<CMeasure>();
      

      double Voltage, Current;


      measure2.Add(new CMeasure());
      measure2.Add(new CMeasure());
      for (int i = 0; i < MeasureList.Count; i++)
      {
        measure2.Add(MeasureList[i]);
      }

      /*****************Начало фильтров*****************/

      measure3.Clear();
      measure3.Add(new CMeasure());
      measure3.Add(new CMeasure());
      for (int i = 2; i < measure2.Count; i++)
      {
        /***************************первый фильтр*******************************/
        CMeasure measureHelp = new CMeasure();

        Voltage = (1 * measure2[i - 2].Voltage - 1.9750682177514072 * measure2[i - 1].Voltage + 0.98258050109889983 * measure2[i].Voltage);
        Voltage = (Voltage - (1 * measure3[i - 2].Voltage - 1.987017507943311 * measure3[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure2[i - 2].Current - 1.9750682177514072 * measure2[i - 1].Current + 0.98258050109889983 * measure2[i].Current);
        Current = (Current - (1 * measure3[i - 2].Current - 1.987017507943311 * measure3[i - 1].Current)) / 1;
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

        Voltage = (1 * measure3[i - 2].Voltage - 1.9361338515598192 * measure3[i - 1].Voltage + 0.94439658006587768 * measure3[i].Voltage);
        Voltage = (Voltage - (1 * measure2[i - 2].Voltage - 1.9840590655040431 * measure2[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure3[i - 2].Current - 1.9361338515598192 * measure3[i - 1].Current + 0.94439658006587768 * measure3[i].Current);
        Current = (Current - (1 * measure2[i - 2].Current - 1.9840590655040431 * measure2[i - 1].Current)) / 1;
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

        Voltage = (1 * measure2[i - 2].Voltage - 1.8849234060305617 * measure2[i - 1].Voltage + 0.89494634126434935 * measure2[i].Voltage);
        Voltage = (Voltage - (1 * measure3[i - 2].Voltage - 1.974748370271302 * measure3[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure2[i - 2].Current - 1.8849234060305617 * measure2[i - 1].Current + 0.89494634126434935 * measure2[i].Current);
        Current = (Current - (1 * measure3[i - 2].Current - 1.974748370271302 * measure3[i - 1].Current)) / 1;
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

        Voltage = (1 * measure3[i - 2].Voltage - 1.8178651053118702 * measure3[i - 1].Voltage + 0.83068496809113224 * measure3[i].Voltage);
        Voltage = (Voltage - (1 * measure2[i - 2].Voltage - 1.939288077029953 * measure2[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure3[i - 2].Current - 1.8178651053118702 * measure3[i - 1].Current + 0.83068496809113224 * measure3[i].Current);
        Current = (Current - (1 * measure2[i - 2].Current - 1.939288077029953 * measure2[i - 1].Current)) / 1;
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

        Voltage = (1 * measure2[i - 2].Voltage - 1.7572328263428469 * measure2[i - 1].Voltage + 0.77275468602988517 * measure2[i].Voltage);
        Voltage = (Voltage - (1 * measure3[i - 2].Voltage - 1.5404400822203277 * measure3[i - 1].Voltage)) / 1;
        measureHelp.Voltage = Voltage;

        Current = (1 * measure2[i - 2].Current - 1.7572328263428469 * measure2[i - 1].Current + 0.77275468602988517 * measure2[i].Current);
        Current = (Current - (1 * measure3[i - 2].Current - 1.5404400822203277 * measure3[i - 1].Current)) / 1;
        measureHelp.Current = Current;

        measure3.Add(measureHelp);
      }

      /*****************Фильры кончились*****************/
      /*
      MeasureList.Clear();
      for (int i = 0; i < measure3.Count; i++)
      {
        MeasureList.Add(measure3[i]);
      }
      */
      double MaxVoltage = 1, MaxCurrent = 1;
      foreach (CMeasure measure in MeasureList)
      {
        if (Math.Abs(measure.Voltage) > MaxVoltage) MaxVoltage = Math.Abs(measure.Voltage);
        if (Math.Abs(measure.Current) > MaxCurrent) MaxCurrent = Math.Abs(measure.Current);
      }
      foreach (CMeasure measure in MeasureList)
      {
        measure.Voltage /= MaxVoltage;
        measure.Current /= MaxCurrent;
        measure.Voltage *= 150;
        measure.Current *= 150;
        measure.Voltage += 170;
        measure.Current += 170;
      }
      PlotPanel.Refresh();
    }

    private void ApplyFilter_Click(object sender, EventArgs e)
    {/*
      foreach (CMeasure measure in MeasureList)
      {
        measure.Voltage /= 1000;
        measure.Current /= 1000;
        measure.Current += 200;
      }*/
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
          pen_1, 
          (float)i / 3, 
          (float)MeasureList[i - 1].Current, 
          (float)(i + 1) / 3, 
          (float)MeasureList[i].Current);
        e.Graphics.DrawLine(
         pen_2, 
         (float)i / 3,
         (float)MeasureList[i - 1].Voltage,
         (float)(i + 1) / 3,
         (float)MeasureList[i].Voltage);
      }
    }
  }
}
