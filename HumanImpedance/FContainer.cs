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
    public FHelpForm HelpForm;
    public FContainer()
    {
      InitializeComponent();
      HelpForm = new FHelpForm(this);
    }

    private void CreateMeasureTollStrip_Click(object sender, EventArgs e)
    {
      FCreateFromFile loader = new FCreateFromFile();
      loader.MdiParent = this;
      loader.Show();
      HelpForm.Invalidate_Text();
    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void вДругуюБазуToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FExportForm exportForm = new FExportForm();
      exportForm.ShowDialog();
      HelpForm.Invalidate_Text();
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
      HelpForm.Invalidate_Text();
    }

    private void базуДанныхToolStripMenuItem_Click(object sender, EventArgs e)
    {
      currentDatabase = new DataContainer();
      SaveFileDialog dialog = new SaveFileDialog();
      dialog.Filter = "Файл Базы Данных Студии (*.cuсf) | *.cucf"; // Creative Universal Compress Format   =)
      dialog.ShowDialog();
      CDataFileInterface.WriteToFile(dialog.FileName, currentDatabase);
      currentDataPath = dialog.FileName;
      HelpForm.Invalidate_Text();
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
      HelpForm.Invalidate_Text();
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
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "ошибка");
      }
      HelpForm.Invalidate_Text();
    }

    private void пациентаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FCreatePacient createPac = new FCreatePacient();
      createPac.ShowDialog();
      currentDatabase.AddPacient(createPac.pacient);
      HelpForm.Invalidate_Text();
    }

    private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FShowPacients showPacs = new FShowPacients(this);
      showPacs.Show();
    }

    private void новоеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (currentDatabase.currentDocID < 0 || currentDatabase.currentPacID < 0)
      {
        MessageBox.Show("Не выбран врач или пациент, загрузка невозможна");
        return;
      }
      FCreateFromFile createMeasure = new FCreateFromFile();
      createMeasure.ShowDialog();
      createMeasure.measure.PacID = currentDatabase.currentPacID;
      createMeasure.measure.DocID = currentDatabase.currentDocID;
      currentDatabase.AddMeasure(createMeasure.measure);
      HelpForm.Invalidate_Text();
    }

    private void FContainer_Load(object sender, EventArgs e)
    {
      HelpForm.Show();
    }

    private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog dialog = new SaveFileDialog();
      dialog.Filter = "Файл Базы Данных Студии (*.cuсf) | *.cucf"; // Creative Universal Compress Format   =)

      HelpForm.Invalidate_Text();
      switch (dialog.ShowDialog())
      {
        case System.Windows.Forms.DialogResult.OK:
          try
          {
            CDataFileInterface.WriteToFile(dialog.FileName, currentDatabase);
            currentDataPath = dialog.FileName;
            HelpForm.Invalidate_Text();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, "ошибка");
          }
          break;
      }

    }
  }
}
