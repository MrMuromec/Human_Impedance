namespace HumanImpedance
{
  partial class FHelpForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.currentDB = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.currentDoc = new System.Windows.Forms.TextBox();
      this.currentPac = new System.Windows.Forms.TextBox();
      this.PacCount = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.DocCount = new System.Windows.Forms.TextBox();
      this.MeasureCount = new System.Windows.Forms.TextBox();
      this.BDSize = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Текущая База";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Текущий Врач";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Текущий Пациент";
      // 
      // currentDB
      // 
      this.currentDB.Location = new System.Drawing.Point(108, 6);
      this.currentDB.Name = "currentDB";
      this.currentDB.ReadOnly = true;
      this.currentDB.Size = new System.Drawing.Size(321, 20);
      this.currentDB.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(170, 22);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(49, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Размер:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(5, 48);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(46, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Врачей:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(5, 22);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(65, 13);
      this.label6.TabIndex = 0;
      this.label6.Text = "Пациентов:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(170, 48);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(84, 13);
      this.label7.TabIndex = 0;
      this.label7.Text = "Обследований:";
      // 
      // currentDoc
      // 
      this.currentDoc.Location = new System.Drawing.Point(108, 32);
      this.currentDoc.Name = "currentDoc";
      this.currentDoc.ReadOnly = true;
      this.currentDoc.Size = new System.Drawing.Size(321, 20);
      this.currentDoc.TabIndex = 1;
      // 
      // currentPac
      // 
      this.currentPac.Location = new System.Drawing.Point(108, 58);
      this.currentPac.Name = "currentPac";
      this.currentPac.ReadOnly = true;
      this.currentPac.Size = new System.Drawing.Size(321, 20);
      this.currentPac.TabIndex = 1;
      // 
      // PacCount
      // 
      this.PacCount.Location = new System.Drawing.Point(101, 19);
      this.PacCount.Name = "PacCount";
      this.PacCount.ReadOnly = true;
      this.PacCount.Size = new System.Drawing.Size(52, 20);
      this.PacCount.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.BDSize);
      this.groupBox1.Controls.Add(this.MeasureCount);
      this.groupBox1.Controls.Add(this.DocCount);
      this.groupBox1.Controls.Add(this.PacCount);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Location = new System.Drawing.Point(435, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(363, 72);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Содержание базы данных";
      // 
      // DocCount
      // 
      this.DocCount.Location = new System.Drawing.Point(101, 45);
      this.DocCount.Name = "DocCount";
      this.DocCount.ReadOnly = true;
      this.DocCount.Size = new System.Drawing.Size(52, 20);
      this.DocCount.TabIndex = 1;
      // 
      // MeasureCount
      // 
      this.MeasureCount.Location = new System.Drawing.Point(266, 45);
      this.MeasureCount.Name = "MeasureCount";
      this.MeasureCount.ReadOnly = true;
      this.MeasureCount.Size = new System.Drawing.Size(52, 20);
      this.MeasureCount.TabIndex = 1;
      // 
      // BDSize
      // 
      this.BDSize.Location = new System.Drawing.Point(225, 19);
      this.BDSize.Name = "BDSize";
      this.BDSize.ReadOnly = true;
      this.BDSize.Size = new System.Drawing.Size(131, 20);
      this.BDSize.TabIndex = 1;
      // 
      // FHelpForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 81);
      this.ControlBox = false;
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.currentPac);
      this.Controls.Add(this.currentDoc);
      this.Controls.Add(this.currentDB);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FHelpForm";
      this.Text = "FHelpForm";
      this.Activated += new System.EventHandler(this.FHelpForm_Activated);
      this.Load += new System.EventHandler(this.FHelpForm_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox currentDB;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox currentDoc;
    private System.Windows.Forms.TextBox currentPac;
    private System.Windows.Forms.TextBox PacCount;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox BDSize;
    private System.Windows.Forms.TextBox MeasureCount;
    private System.Windows.Forms.TextBox DocCount;
  }
}