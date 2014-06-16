namespace HumanImpedance
{
  partial class FShowPacients
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.PacGrid = new System.Windows.Forms.DataGridView();
      this.PacFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.MeasureCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PacGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // PacGrid
      // 
      this.PacGrid.AllowUserToAddRows = false;
      this.PacGrid.AllowUserToDeleteRows = false;
      this.PacGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.PacGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacFIO,
            this.MeasureCount});
      this.PacGrid.Location = new System.Drawing.Point(13, 13);
      this.PacGrid.Name = "PacGrid";
      this.PacGrid.ReadOnly = true;
      this.PacGrid.Size = new System.Drawing.Size(644, 366);
      this.PacGrid.TabIndex = 0;
      // 
      // PacFIO
      // 
      this.PacFIO.HeaderText = "FIO";
      this.PacFIO.Name = "PacFIO";
      this.PacFIO.ReadOnly = true;
      this.PacFIO.Width = 450;
      // 
      // MeasureCount
      // 
      this.MeasureCount.HeaderText = "Количество Измерений";
      this.MeasureCount.Name = "MeasureCount";
      this.MeasureCount.ReadOnly = true;
      this.MeasureCount.Width = 150;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(663, 327);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(139, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Обновить";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(663, 356);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(139, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Выбрать Текущим";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // FShowPacients
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(807, 391);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.PacGrid);
      this.Name = "FShowPacients";
      this.Text = "FShowPacients";
      ((System.ComponentModel.ISupportInitialize)(this.PacGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView PacGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn PacFIO;
    private System.Windows.Forms.DataGridViewTextBoxColumn MeasureCount;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}