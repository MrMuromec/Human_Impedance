namespace HumanImpedance
{
    partial class FMainForm
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
      this.OpenFileButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.PathBox = new System.Windows.Forms.TextBox();
      this.PlotPanel = new System.Windows.Forms.PictureBox();
      this.ReadFileButton = new System.Windows.Forms.Button();
      this.ApplyFilter = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PlotPanel)).BeginInit();
      this.SuspendLayout();
      // 
      // OpenFileButton
      // 
      this.OpenFileButton.Location = new System.Drawing.Point(495, 41);
      this.OpenFileButton.Name = "OpenFileButton";
      this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
      this.OpenFileButton.TabIndex = 0;
      this.OpenFileButton.Text = "Выбрать";
      this.OpenFileButton.UseVisualStyleBackColor = true;
      this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 46);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Путь к файлу";
      // 
      // PathBox
      // 
      this.PathBox.Location = new System.Drawing.Point(92, 43);
      this.PathBox.Name = "PathBox";
      this.PathBox.Size = new System.Drawing.Size(397, 20);
      this.PathBox.TabIndex = 2;
      // 
      // PlotPanel
      // 
      this.PlotPanel.BackColor = System.Drawing.SystemColors.Window;
      this.PlotPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.PlotPanel.Location = new System.Drawing.Point(15, 108);
      this.PlotPanel.Name = "PlotPanel";
      this.PlotPanel.Size = new System.Drawing.Size(666, 294);
      this.PlotPanel.TabIndex = 3;
      this.PlotPanel.TabStop = false;
      this.PlotPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlotPanel_Paint);
      // 
      // ReadFileButton
      // 
      this.ReadFileButton.Location = new System.Drawing.Point(606, 40);
      this.ReadFileButton.Name = "ReadFileButton";
      this.ReadFileButton.Size = new System.Drawing.Size(75, 23);
      this.ReadFileButton.TabIndex = 4;
      this.ReadFileButton.Text = "Открыть";
      this.ReadFileButton.UseVisualStyleBackColor = true;
      this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
      // 
      // ApplyFilter
      // 
      this.ApplyFilter.Location = new System.Drawing.Point(15, 79);
      this.ApplyFilter.Name = "ApplyFilter";
      this.ApplyFilter.Size = new System.Drawing.Size(94, 23);
      this.ApplyFilter.TabIndex = 0;
      this.ApplyFilter.Text = "Отфилтровать";
      this.ApplyFilter.UseVisualStyleBackColor = true;
      this.ApplyFilter.Click += new System.EventHandler(this.ApplyFilter_Click);
      // 
      // FMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(693, 414);
      this.Controls.Add(this.ApplyFilter);
      this.Controls.Add(this.ReadFileButton);
      this.Controls.Add(this.PlotPanel);
      this.Controls.Add(this.PathBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.OpenFileButton);
      this.Name = "FMainForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.PlotPanel)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.PictureBox PlotPanel;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.Button ApplyFilter;
    }
}

