﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HumanImpedance.Entites;

namespace HumanImpedance
{
  public partial class FShowPacients : Form
  {
    public DataContainer localDB = null;
    private FContainer Parent = null;

    public FShowPacients(FContainer parent)
    {

      this.MdiParent = parent;
      Parent = parent;
      localDB = parent.currentDatabase;
      InitializeComponent();
    }
    private void GridRefresh()
    {
      foreach (Pacient pac in localDB.GetPacientList())
      {
        string[] array = new string[2];
        array[0] = pac.FIO;
        array[1] = (from m in localDB.GetMeasureList() where m.PacID == pac.id select m).Count().ToString(); 
        PacGrid.Rows.Add(array);
      }
    }
  }
}