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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.PacientName = new System.Windows.Forms.TextBox();
      this.DocName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.Date = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.DocComment = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.PlotPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // PlotPanel
      // 
      this.PlotPanel.BackColor = System.Drawing.SystemColors.Window;
      this.PlotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PlotPanel.Location = new System.Drawing.Point(12, 158);
      this.PlotPanel.Name = "PlotPanel";
      this.PlotPanel.Size = new System.Drawing.Size(701, 274);
      this.PlotPanel.TabIndex = 3;
      this.PlotPanel.TabStop = false;
      this.PlotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlotPanel_Paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Пациент";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 61);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Дата";
      // 
      // PacientName
      // 
      this.PacientName.Location = new System.Drawing.Point(169, 6);
      this.PacientName.Name = "PacientName";
      this.PacientName.Size = new System.Drawing.Size(265, 20);
      this.PacientName.TabIndex = 5;
      // 
      // DocName
      // 
      this.DocName.Location = new System.Drawing.Point(169, 32);
      this.DocName.Name = "DocName";
      this.DocName.Size = new System.Drawing.Size(265, 20);
      this.DocName.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 35);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Врач";
      // 
      // Date
      // 
      this.Date.Location = new System.Drawing.Point(169, 58);
      this.Date.Name = "Date";
      this.Date.Size = new System.Drawing.Size(265, 20);
      this.Date.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 88);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Комментарий";
      // 
      // DocComment
      // 
      this.DocComment.Location = new System.Drawing.Point(169, 85);
      this.DocComment.Multiline = true;
      this.DocComment.Name = "DocComment";
      this.DocComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.DocComment.Size = new System.Drawing.Size(265, 67);
      this.DocComment.TabIndex = 8;
      // 
      // FShowMeasure
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(740, 433);
      this.Controls.Add(this.DocComment);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.Date);
      this.Controls.Add(this.DocName);
      this.Controls.Add(this.PacientName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.PlotPanel);
      this.Name = "FShowMeasure";
      this.Text = "Human Impedance";
      ((System.ComponentModel.ISupportInitialize)(this.PlotPanel)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox PlotPanel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox PacientName;
    private System.Windows.Forms.TextBox DocName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox Date;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox DocComment;
  }
}

