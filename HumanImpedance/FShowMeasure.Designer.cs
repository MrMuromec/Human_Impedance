namespace HumanImpedance
{
  partial class FShowMeasure
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.PlotPanel = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PlotPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // PlotPanel
      // 
      this.PlotPanel.BackColor = System.Drawing.SystemColors.Window;
      this.PlotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PlotPanel.Location = new System.Drawing.Point(12, 12);
      this.PlotPanel.Name = "PlotPanel";
      this.PlotPanel.Size = new System.Drawing.Size(701, 340);
      this.PlotPanel.TabIndex = 3;
      this.PlotPanel.TabStop = false;
      this.PlotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlotPanel_Paint);
      // 
      // FShowMeasure
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(740, 372);
      this.Controls.Add(this.PlotPanel);
      this.Name = "FShowMeasure";
      this.Text = "Human Impedance";
      ((System.ComponentModel.ISupportInitialize)(this.PlotPanel)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox PlotPanel;
  }
}

