namespace HumanImpedance.Common
{
  partial class FCreateDoc
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
      this.CreateButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.FIOTexBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // CreateButton
      // 
      this.CreateButton.Location = new System.Drawing.Point(359, 36);
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(94, 23);
      this.CreateButton.TabIndex = 0;
      this.CreateButton.Text = "Создать";
      this.CreateButton.UseVisualStyleBackColor = true;
      this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(131, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Фамилия Имя Отчество";
      // 
      // FIOTexBox
      // 
      this.FIOTexBox.Location = new System.Drawing.Point(150, 10);
      this.FIOTexBox.Name = "FIOTexBox";
      this.FIOTexBox.Size = new System.Drawing.Size(303, 20);
      this.FIOTexBox.TabIndex = 2;
      // 
      // FCreateDoc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 65);
      this.Controls.Add(this.FIOTexBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CreateButton);
      this.Name = "FCreateDoc";
      this.Text = "Добавить врача";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CreateButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox FIOTexBox;
  }
}