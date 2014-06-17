namespace HumanImpedance
{
  partial class FContainer
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
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.базаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.подкючитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.пациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.врачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.измерениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.базуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.врачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.экспортToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.вТекущуюБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вНовуюБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.импортToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.измеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.новоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.MainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainMenu
      // 
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.базаToolStripMenuItem,
            this.измеренияToolStripMenuItem,
            this.справкаToolStripMenuItem});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Size = new System.Drawing.Size(1122, 24);
      this.MainMenu.TabIndex = 0;
      this.MainMenu.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // сохранитьКакToolStripMenuItem
      // 
      this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
      this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
      // 
      // базаToolStripMenuItem
      // 
      this.базаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подкючитьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.экспортToolStripMenuItem1,
            this.импортToolStripMenuItem1});
      this.базаToolStripMenuItem.Name = "базаToolStripMenuItem";
      this.базаToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.базаToolStripMenuItem.Text = "База";
      // 
      // подкючитьToolStripMenuItem
      // 
      this.подкючитьToolStripMenuItem.Name = "подкючитьToolStripMenuItem";
      this.подкючитьToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.подкючитьToolStripMenuItem.Text = "Подключить";
      this.подкючитьToolStripMenuItem.Click += new System.EventHandler(this.подкючитьToolStripMenuItem_Click);
      // 
      // создатьToolStripMenuItem
      // 
      this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентаToolStripMenuItem,
            this.врачаToolStripMenuItem,
            this.измерениеToolStripMenuItem,
            this.базуДанныхToolStripMenuItem});
      this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
      this.создатьToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.создатьToolStripMenuItem.Text = "Создать";
      this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
      // 
      // пациентаToolStripMenuItem
      // 
      this.пациентаToolStripMenuItem.Name = "пациентаToolStripMenuItem";
      this.пациентаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.пациентаToolStripMenuItem.Text = "Пациента";
      this.пациентаToolStripMenuItem.Click += new System.EventHandler(this.пациентаToolStripMenuItem_Click);
      // 
      // врачаToolStripMenuItem
      // 
      this.врачаToolStripMenuItem.Name = "врачаToolStripMenuItem";
      this.врачаToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.врачаToolStripMenuItem.Text = "Врача";
      this.врачаToolStripMenuItem.Click += new System.EventHandler(this.врачаToolStripMenuItem_Click);
      // 
      // измерениеToolStripMenuItem
      // 
      this.измерениеToolStripMenuItem.Name = "измерениеToolStripMenuItem";
      this.измерениеToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.измерениеToolStripMenuItem.Text = "Измерение";
      // 
      // базуДанныхToolStripMenuItem
      // 
      this.базуДанныхToolStripMenuItem.Name = "базуДанныхToolStripMenuItem";
      this.базуДанныхToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.базуДанныхToolStripMenuItem.Text = "Базу Данных";
      this.базуДанныхToolStripMenuItem.Click += new System.EventHandler(this.базуДанныхToolStripMenuItem_Click);
      // 
      // просмотрToolStripMenuItem
      // 
      this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.врачиToolStripMenuItem,
            this.пациентыToolStripMenuItem});
      this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
      this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.просмотрToolStripMenuItem.Text = "Просмотр";
      // 
      // врачиToolStripMenuItem
      // 
      this.врачиToolStripMenuItem.Name = "врачиToolStripMenuItem";
      this.врачиToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.врачиToolStripMenuItem.Text = "Врачи";
      this.врачиToolStripMenuItem.Click += new System.EventHandler(this.врачиToolStripMenuItem_Click);
      // 
      // пациентыToolStripMenuItem
      // 
      this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
      this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.пациентыToolStripMenuItem.Text = "Пациенты";
      this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);
      // 
      // экспортToolStripMenuItem1
      // 
      this.экспортToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вТекущуюБазуToolStripMenuItem,
            this.вНовуюБазуToolStripMenuItem});
      this.экспортToolStripMenuItem1.Name = "экспортToolStripMenuItem1";
      this.экспортToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
      this.экспортToolStripMenuItem1.Text = "Экспорт";
      // 
      // вТекущуюБазуToolStripMenuItem
      // 
      this.вТекущуюБазуToolStripMenuItem.Name = "вТекущуюБазуToolStripMenuItem";
      this.вТекущуюБазуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.вТекущуюБазуToolStripMenuItem.Text = "В текущую базу";
      // 
      // вНовуюБазуToolStripMenuItem
      // 
      this.вНовуюБазуToolStripMenuItem.Name = "вНовуюБазуToolStripMenuItem";
      this.вНовуюБазуToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.вНовуюБазуToolStripMenuItem.Text = "В новую базу";
      // 
      // импортToolStripMenuItem1
      // 
      this.импортToolStripMenuItem1.Name = "импортToolStripMenuItem1";
      this.импортToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
      this.импортToolStripMenuItem1.Text = "Импорт";
      // 
      // измеренияToolStripMenuItem
      // 
      this.измеренияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новоеToolStripMenuItem});
      this.измеренияToolStripMenuItem.Name = "измеренияToolStripMenuItem";
      this.измеренияToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
      this.измеренияToolStripMenuItem.Text = "Измерения";
      // 
      // новоеToolStripMenuItem
      // 
      this.новоеToolStripMenuItem.Name = "новоеToolStripMenuItem";
      this.новоеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.новоеToolStripMenuItem.Text = "Новое";
      this.новоеToolStripMenuItem.Click += new System.EventHandler(this.новоеToolStripMenuItem_Click);
      // 
      // справкаToolStripMenuItem
      // 
      this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem1});
      this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
      this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
      this.справкаToolStripMenuItem.Text = "Справка";
      // 
      // оПрограммеToolStripMenuItem
      // 
      this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.оПрограммеToolStripMenuItem.Text = "О программе";
      this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
      // 
      // справкаToolStripMenuItem1
      // 
      this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
      this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
      this.справкаToolStripMenuItem1.Text = "Справка";
      // 
      // FContainer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1122, 733);
      this.Controls.Add(this.MainMenu);
      this.IsMdiContainer = true;
      this.Name = "FContainer";
      this.Text = "Студия импеданса";
      this.Load += new System.EventHandler(this.FContainer_Load);
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem измеренияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem базаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem подкючитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem новоеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem вТекущуюБазуToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вНовуюБазуToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem пациентаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem врачаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem измерениеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem базуДанныхToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem врачиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;

  }
}