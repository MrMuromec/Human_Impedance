namespace HumanImpedance.Common
{
  partial class FExportForm
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
      this.DateInput = new System.Windows.Forms.DateTimePicker();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ФИО врача";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(86, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "ФИО Пациента";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Дата обследования";
      // 
      // DateInput
      // 
      this.DateInput.Location = new System.Drawing.Point(153, 77);
      this.DateInput.Name = "DateInput";
      this.DateInput.Size = new System.Drawing.Size(183, 20);
      this.DateInput.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(108, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(464, 20);
      this.textBox1.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(108, 51);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(464, 20);
      this.textBox2.TabIndex = 2;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 110);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(77, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Комментарий";
      // 
      // textBox3
      // 
      this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox3.Location = new System.Drawing.Point(108, 111);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(463, 104);
      this.textBox3.TabIndex = 4;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.textBox3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.DateInput);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(584, 227);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Данные";
      // 
      // FExportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(675, 295);
      this.Controls.Add(this.groupBox1);
      this.Name = "FExportForm";
      this.Text = "Экспорт данных";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.DateTimePicker DateInput;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}