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
namespace HumanImpedance.Common
{
  public partial class FCreatePacient : Form
  {
    public Pacient pacient;
    public FCreatePacient()
    {
      InitializeComponent();
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
      
      if (FIOTextBox.Text.Length > 4)
      {
        pacient = new Pacient();
        pacient.FIO = FIOTextBox.Text;
        this.Close();
      }
      else
      {
        MessageBox.Show("Вы не ввели полное фио", "ошибка");
        return;
      }
    }
  }
}
