namespace HumanImpedance
{
  partial class FShowDocs
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
      this.DocGrid = new System.Windows.Forms.DataGridView();
      this.DocFIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SetAsCurrent = new System.Windows.Forms.Button();
      this.UpdateButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DocGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // DocGrid
      // 
      this.DocGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DocGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DocFIO});
      this.DocGrid.Location = new System.Drawing.Point(12, 12);
      this.DocGrid.Name = "DocGrid";
      this.DocGrid.Size = new System.Drawing.Size(643, 370);
      this.DocGrid.TabIndex = 0;
      // 
      // DocFIO
      // 
      this.DocFIO.HeaderText = "ФИО Врача";
      this.DocFIO.Name = "DocFIO";
      this.DocFIO.Width = 600;
      // 
      // SetAsCurrent
      // 
      this.SetAsCurrent.Location = new System.Drawing.Point(689, 358);
      this.SetAsCurrent.Name = "SetAsCurrent";
      this.SetAsCurrent.Size = new System.Drawing.Size(141, 23);
      this.SetAsCurrent.TabIndex = 1;
      this.SetAsCurrent.Text = "Выбрать текущим";
      this.SetAsCurrent.UseVisualStyleBackColor = true;
      // 
      // UpdateButton
      // 
      this.UpdateButton.Location = new System.Drawing.Point(689, 329);
      this.UpdateButton.Name = "UpdateButton";
      this.UpdateButton.Size = new System.Drawing.Size(141, 23);
      this.UpdateButton.TabIndex = 2;
      this.UpdateButton.Text = "Обновить";
      this.UpdateButton.UseVisualStyleBackColor = true;
      this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // FShowDocs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(842, 393);
      this.Controls.Add(this.UpdateButton);
      this.Controls.Add(this.SetAsCurrent);
      this.Controls.Add(this.DocGrid);
      this.Name = "FShowDocs";
      this.Text = "Врачи в базе";
      this.Load += new System.EventHandler(this.FShowDocs_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DocGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView DocGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn DocFIO;
    private System.Windows.Forms.Button SetAsCurrent;
    private System.Windows.Forms.Button UpdateButton;
  }
}