﻿namespace Sorting
{
  partial class MainForm
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сгенерироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.количествоЭлементовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
      this.укажитеМинимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
      this.укажитеМакимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
      this.оКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.checkBox5 = new System.Windows.Forms.CheckBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.OKbutton = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label8 = new System.Windows.Forms.Label();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.panel4 = new System.Windows.Forms.Panel();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.сгенерироватьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(903, 33);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // startToolStripMenuItem
      // 
      this.startToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.startToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.startToolStripMenuItem.Name = "startToolStripMenuItem";
      this.startToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
      this.startToolStripMenuItem.Text = "Start";
      this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
      // 
      // сгенерироватьToolStripMenuItem
      // 
      this.сгенерироватьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.сгенерироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоЭлементовToolStripMenuItem,
            this.укажитеМинимумToolStripMenuItem,
            this.укажитеМакимумToolStripMenuItem,
            this.оКToolStripMenuItem});
      this.сгенерироватьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.сгенерироватьToolStripMenuItem.Name = "сгенерироватьToolStripMenuItem";
      this.сгенерироватьToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
      this.сгенерироватьToolStripMenuItem.Text = "Сгенерировать";
      this.сгенерироватьToolStripMenuItem.Click += new System.EventHandler(this.сгенерироватьToolStripMenuItem_Click);
      // 
      // количествоЭлементовToolStripMenuItem
      // 
      this.количествоЭлементовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
      this.количествоЭлементовToolStripMenuItem.Name = "количествоЭлементовToolStripMenuItem";
      this.количествоЭлементовToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
      this.количествоЭлементовToolStripMenuItem.Text = "Количество элементов";
      // 
      // toolStripTextBox1
      // 
      this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
      // 
      // укажитеМинимумToolStripMenuItem
      // 
      this.укажитеМинимумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
      this.укажитеМинимумToolStripMenuItem.Name = "укажитеМинимумToolStripMenuItem";
      this.укажитеМинимумToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
      this.укажитеМинимумToolStripMenuItem.Text = "Укажите минимум числа";
      this.укажитеМинимумToolStripMenuItem.Click += new System.EventHandler(this.укажитеМинимумToolStripMenuItem_Click);
      // 
      // toolStripTextBox3
      // 
      this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox3.Name = "toolStripTextBox3";
      this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
      // 
      // укажитеМакимумToolStripMenuItem
      // 
      this.укажитеМакимумToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
      this.укажитеМакимумToolStripMenuItem.Name = "укажитеМакимумToolStripMenuItem";
      this.укажитеМакимумToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
      this.укажитеМакимумToolStripMenuItem.Text = "Укажите макимум числа";
      // 
      // toolStripTextBox2
      // 
      this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.toolStripTextBox2.Name = "toolStripTextBox2";
      this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
      // 
      // оКToolStripMenuItem
      // 
      this.оКToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
      this.оКToolStripMenuItem.Name = "оКToolStripMenuItem";
      this.оКToolStripMenuItem.Size = new System.Drawing.Size(299, 30);
      this.оКToolStripMenuItem.Text = "ОК";
      this.оКToolStripMenuItem.Click += new System.EventHandler(this.оКToolStripMenuItem_Click);
      // 
      // очиститьToolStripMenuItem
      // 
      this.очиститьToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.очиститьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
      this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
      this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
      this.очиститьToolStripMenuItem.Text = "Очистить";
      this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(12, 37);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(435, 29);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(462, 36);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Enabled = false;
      series1.Legend = "Legend1";
      series1.Name = "Пузыри";
      series2.ChartArea = "ChartArea1";
      series2.Enabled = false;
      series2.Legend = "Legend1";
      series2.Name = "Вставки";
      series3.ChartArea = "ChartArea1";
      series3.Enabled = false;
      series3.Legend = "Legend1";
      series3.Name = "Шейкер";
      series4.ChartArea = "ChartArea1";
      series4.Enabled = false;
      series4.Legend = "Legend1";
      series4.Name = "Быстрая";
      series5.ChartArea = "ChartArea1";
      series5.Enabled = false;
      series5.Legend = "Legend1";
      series5.Name = "BOGO";
      this.chart1.Series.Add(series1);
      this.chart1.Series.Add(series2);
      this.chart1.Series.Add(series3);
      this.chart1.Series.Add(series4);
      this.chart1.Series.Add(series5);
      this.chart1.Size = new System.Drawing.Size(430, 430);
      this.chart1.TabIndex = 4;
      this.chart1.Text = "Шейкер";
      this.chart1.Click += new System.EventHandler(this.chart1_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox1.Location = new System.Drawing.Point(15, 10);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(96, 28);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Пузыри";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox2.Location = new System.Drawing.Point(117, 10);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(102, 28);
      this.checkBox2.TabIndex = 6;
      this.checkBox2.Text = "Вставки";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox3.Location = new System.Drawing.Point(225, 10);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(96, 28);
      this.checkBox3.TabIndex = 7;
      this.checkBox3.Text = "Шейкер";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox4.Location = new System.Drawing.Point(10, 44);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(106, 28);
      this.checkBox4.TabIndex = 8;
      this.checkBox4.Text = "Быстрая";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // checkBox5
      // 
      this.checkBox5.AutoSize = true;
      this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox5.Location = new System.Drawing.Point(117, 44);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new System.Drawing.Size(85, 28);
      this.checkBox5.TabIndex = 9;
      this.checkBox5.Text = "BOGO";
      this.checkBox5.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel1.Controls.Add(this.OKbutton);
      this.panel1.Controls.Add(this.checkBox3);
      this.panel1.Controls.Add(this.checkBox5);
      this.panel1.Controls.Add(this.checkBox1);
      this.panel1.Controls.Add(this.checkBox4);
      this.panel1.Controls.Add(this.checkBox2);
      this.panel1.Location = new System.Drawing.Point(12, 72);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(435, 82);
      this.panel1.TabIndex = 10;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // OKbutton
      // 
      this.OKbutton.Location = new System.Drawing.Point(351, 10);
      this.OKbutton.Name = "OKbutton";
      this.OKbutton.Size = new System.Drawing.Size(76, 62);
      this.OKbutton.TabIndex = 10;
      this.OKbutton.Text = "OK";
      this.OKbutton.UseVisualStyleBackColor = true;
      this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(12, 160);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(435, 186);
      this.panel2.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(6, 159);
      this.label7.MaximumSize = new System.Drawing.Size(250, 20);
      this.label7.MinimumSize = new System.Drawing.Size(250, 20);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(250, 20);
      this.label7.TabIndex = 14;
      this.label7.Text = "BOGO";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(6, 125);
      this.label6.MaximumSize = new System.Drawing.Size(250, 20);
      this.label6.MinimumSize = new System.Drawing.Size(250, 20);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(250, 20);
      this.label6.TabIndex = 13;
      this.label6.Text = "Быстрая";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(6, 92);
      this.label5.MaximumSize = new System.Drawing.Size(250, 20);
      this.label5.MinimumSize = new System.Drawing.Size(250, 20);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(250, 20);
      this.label5.TabIndex = 12;
      this.label5.Text = "Шейкер";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(6, 59);
      this.label3.MaximumSize = new System.Drawing.Size(250, 20);
      this.label3.MinimumSize = new System.Drawing.Size(250, 20);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(250, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Вставки";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(6, 28);
      this.label2.MaximumSize = new System.Drawing.Size(250, 20);
      this.label2.MinimumSize = new System.Drawing.Size(250, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(250, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "Пузыри";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
      this.label1.Location = new System.Drawing.Point(1, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(318, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Скорость алгоритмов (тики  -  итерации)";
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox3.Location = new System.Drawing.Point(15, 23);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(185, 29);
      this.textBox3.TabIndex = 5;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(35, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(134, 20);
      this.label4.TabIndex = 4;
      this.label4.Text = "Рекорд времени";
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Checked = true;
      this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.radioButton1.Location = new System.Drawing.Point(15, 39);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(152, 24);
      this.radioButton1.TabIndex = 12;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "По возрастанию";
      this.radioButton1.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel3.Controls.Add(this.label8);
      this.panel3.Controls.Add(this.radioButton2);
      this.panel3.Controls.Add(this.radioButton1);
      this.panel3.Location = new System.Drawing.Point(229, 352);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(218, 114);
      this.panel3.TabIndex = 13;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.Location = new System.Drawing.Point(7, 7);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(203, 24);
      this.label8.TabIndex = 14;
      this.label8.Text = "Порядок сортировки:";
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.radioButton2.Location = new System.Drawing.Point(15, 71);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(127, 24);
      this.radioButton2.TabIndex = 13;
      this.radioButton2.Text = "По убыванию";
      this.radioButton2.UseVisualStyleBackColor = true;
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel4.Controls.Add(this.textBox2);
      this.panel4.Controls.Add(this.label9);
      this.panel4.Controls.Add(this.textBox3);
      this.panel4.Controls.Add(this.label4);
      this.panel4.Location = new System.Drawing.Point(12, 352);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(211, 114);
      this.panel4.TabIndex = 14;
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(15, 78);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(185, 29);
      this.textBox2.TabIndex = 7;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(35, 55);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(141, 20);
      this.label9.TabIndex = 6;
      this.label9.Text = "Рекорд итераций";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 476);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ToolStripMenuItem сгенерироватьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оКToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.CheckBox checkBox5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button OKbutton;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ToolStripMenuItem количествоЭлементовToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    private System.Windows.Forms.ToolStripMenuItem укажитеМинимумToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
    private System.Windows.Forms.ToolStripMenuItem укажитеМакимумToolStripMenuItem;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label9;
  }
}