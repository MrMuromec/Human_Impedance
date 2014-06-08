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

namespace HumanImpedance
{
  public partial class FMainForm : Form
  {
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

    }
  }
}
