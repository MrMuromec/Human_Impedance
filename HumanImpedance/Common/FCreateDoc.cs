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
  public partial class FCreateDoc : Form
  {
    public Doctor doctor = null;
    public FCreateDoc()
    {
      InitializeComponent();
    }

    private void CreateButton_Click(object sender, EventArgs e)
    {
      if (FIOTexBox.Text.Length > 4)
      {
        doctor = new Doctor();
        doctor.FIO = FIOTexBox.Text;
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
