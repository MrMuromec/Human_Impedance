namespace HumanImpedance.Common
{
  partial class FCreatePacient
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
      this.FIOTextBox = new System.Windows.Forms.TextBox();
      this.CreateButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ФИО";
      // 
      // FIOTextBox
      // 
      this.FIOTextBox.Location = new System.Drawing.Point(62, 10);
      this.FIOTextBox.Name = "FIOTextBox";
      this.FIOTextBox.Size = new System.Drawing.Size(450, 20);
      this.FIOTextBox.TabIndex = 1;
      // 
      // CreateButton
      // 
      this.CreateButton.Location = new System.Drawing.Point(437, 36);
      this.CreateButton.Name = "CreateButton";
      this.CreateButton.Size = new System.Drawing.Size(75, 23);
      this.CreateButton.TabIndex = 2;
      this.CreateButton.Text = "Создать";
      this.CreateButton.UseVisualStyleBackColor = true;
      this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
      // 
      // FCreatePacient
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(517, 63);
      this.Controls.Add(this.CreateButton);
      this.Controls.Add(this.FIOTextBox);
      this.Controls.Add(this.label1);
      this.Name = "FCreatePacient";
      this.Text = "FCreatePacient";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox FIOTextBox;
    private System.Windows.Forms.Button CreateButton;
  }
}