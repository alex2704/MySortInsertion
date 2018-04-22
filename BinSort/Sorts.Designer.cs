namespace BinSort
{
    partial class SortSolution
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ReadBox = new System.Windows.Forms.TextBox();
            this.SortButtonBin = new System.Windows.Forms.Button();
            this.SortButtonSimple = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadChart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadBox
            // 
            this.ReadBox.Location = new System.Drawing.Point(427, 44);
            this.ReadBox.Name = "ReadBox";
            this.ReadBox.Size = new System.Drawing.Size(514, 22);
            this.ReadBox.TabIndex = 0;
            // 
            // SortButtonBin
            // 
            this.SortButtonBin.BackColor = System.Drawing.Color.Olive;
            this.SortButtonBin.Location = new System.Drawing.Point(807, 302);
            this.SortButtonBin.Name = "SortButtonBin";
            this.SortButtonBin.Size = new System.Drawing.Size(134, 77);
            this.SortButtonBin.TabIndex = 1;
            this.SortButtonBin.Text = "Сортировка бинарными вставками";
            this.SortButtonBin.UseVisualStyleBackColor = false;
            this.SortButtonBin.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortButtonSimple
            // 
            this.SortButtonSimple.BackColor = System.Drawing.Color.Maroon;
            this.SortButtonSimple.Location = new System.Drawing.Point(634, 302);
            this.SortButtonSimple.Name = "SortButtonSimple";
            this.SortButtonSimple.Size = new System.Drawing.Size(147, 77);
            this.SortButtonSimple.TabIndex = 2;
            this.SortButtonSimple.Text = "Сортировка простыми вставками";
            this.SortButtonSimple.UseVisualStyleBackColor = false;
            this.SortButtonSimple.Click += new System.EventHandler(this.SortButtonSimple_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(427, 89);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(514, 22);
            this.ResultBox.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 44);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SimplySortInsertion";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SortBinInsertion";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(409, 385);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // LoadChart
            // 
            this.LoadChart.Location = new System.Drawing.Point(454, 291);
            this.LoadChart.Name = "LoadChart";
            this.LoadChart.Size = new System.Drawing.Size(75, 23);
            this.LoadChart.TabIndex = 6;
            this.LoadChart.Text = "LoadChart";
            this.LoadChart.UseVisualStyleBackColor = true;
            this.LoadChart.Click += new System.EventHandler(this.LoadChart_Click);
            // 
            // SortSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 441);
            this.Controls.Add(this.LoadChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SortButtonSimple);
            this.Controls.Add(this.SortButtonBin);
            this.Controls.Add(this.ReadBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SortSolution";
            this.Text = "Сортировки";
            this.Load += new System.EventHandler(this.Sort_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReadBox;
        private System.Windows.Forms.Button SortButtonBin;
        private System.Windows.Forms.Button SortButtonSimple;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button LoadChart;
    }
}

