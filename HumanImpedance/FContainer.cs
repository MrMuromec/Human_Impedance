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
using HumanImpedance.Common;
namespace HumanImpedance
{
  public partial class FContainer : Form
  {
    public DataContainer currentDatabase = null;
    public string currentDataPath;

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

    private void подкючитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();

      switch (dialog.ShowDialog())
      {
        case System.Windows.Forms.DialogResult.Cancel:
          MessageBox.Show("Пользователь отменил действие", "отмена");
          return;
        case System.Windows.Forms.DialogResult.OK:
          currentDatabase = CDataFileInterface.ReadFromFile(dialog.FileName);
          currentDataPath = dialog.FileName;
          break;
      }
    }

    private void базуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
    {
      currentDatabase = new DataContainer();
      SaveFileDialog dialog = new SaveFileDialog();
      dialog.Filter = "Файл Базы Данных Студии (*.cuсf) | *.cucf"; // Creative Universal Compress Format   =)
      dialog.ShowDialog();
      CDataFileInterface.WriteToFile(dialog.FileName, currentDatabase);
      currentDataPath = dialog.FileName;
    }

    private void врачаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (currentDatabase == null)
      {
        MessageBox.Show("Создание не возможно, база не подключена", "предупреждение");
        return;
      }
      FCreateDoc createDoc = new FCreateDoc();
      createDoc.ShowDialog();
      currentDatabase.AddDoc(createDoc.doctor);
    }

    private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Студия измерения импеданса Version 0.2.11(unstable release)\nДешин Илья \nВсе права защищены");
    }

    private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void врачиToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FShowDocs showDocs = new FShowDocs(this);
      showDocs.Show();

    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        CDataFileInterface.WriteToFile(currentDataPath, currentDatabase);
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message, "ошибка");
      }
    }

    private void пациентаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FCreatePacient createPac = new FCreatePacient();
      createPac.ShowDialog();
      currentDatabase.AddPacient(createPac.pacient);
    }

    private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FShowPacients showPacs = new FShowPacients(this);
      showPacs.Show();
    }

    private void новоеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FCreateFromFile createMeasure = new FCreateFromFile();
      createMeasure.ShowDialog();
    }
  }
}
