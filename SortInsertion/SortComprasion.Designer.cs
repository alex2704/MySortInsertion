namespace SortInsertion
{
    partial class SortComprasion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu_File_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.operationsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.operationsGroupBox = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.shuffleBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.demonstrateBtn = new System.Windows.Forms.Button();
            this.SortBtn = new System.Windows.Forms.Button();
            this.BinSortRadioBtn = new System.Windows.Forms.RadioButton();
            this.SimplySirtRadioBtn = new System.Windows.Forms.RadioButton();
            this.comparisonGroupBox = new System.Windows.Forms.GroupBox();
            this.fromSource = new System.Windows.Forms.CheckBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.comparisonCountRadioBtn = new System.Windows.Forms.RadioButton();
            this.swapsCountRadioBtn = new System.Windows.Forms.RadioButton();
            this.demonstration = new System.Windows.Forms.TabControl();
            this.comparisonTab = new System.Windows.Forms.TabPage();
            this.comparisonChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.demostrationTab = new System.Windows.Forms.TabPage();
            this.demonstrarionCanvasPanel = new System.Windows.Forms.Panel();
            this.sourceArrayPanel = new System.Windows.Forms.Panel();
            this.sourceArrayDGV = new System.Windows.Forms.DataGridView();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu.SuspendLayout();
            this.mainWindowLayout.SuspendLayout();
            this.operationsLayout.SuspendLayout();
            this.operationsGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.comparisonGroupBox.SuspendLayout();
            this.demonstration.SuspendLayout();
            this.comparisonTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonChart)).BeginInit();
            this.demostrationTab.SuspendLayout();
            this.sourceArrayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceArrayDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_File});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1157, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainMenu_File
            // 
            this.mainMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu_File_Open,
            this.mainMenu_File_Separator1,
            this.mainMenu_File_Exit});
            this.mainMenu_File.Name = "mainMenu_File";
            this.mainMenu_File.Size = new System.Drawing.Size(57, 24);
            this.mainMenu_File.Text = "Файл";
            // 
            // mainMenu_File_Open
            // 
            this.mainMenu_File_Open.Name = "mainMenu_File_Open";
            this.mainMenu_File_Open.Size = new System.Drawing.Size(142, 26);
            this.mainMenu_File_Open.Text = "Открыть";
            this.mainMenu_File_Open.Click += new System.EventHandler(this.mainMenu_File_Open_Click);
            // 
            // mainMenu_File_Separator1
            // 
            this.mainMenu_File_Separator1.Name = "mainMenu_File_Separator1";
            this.mainMenu_File_Separator1.Size = new System.Drawing.Size(139, 6);
            // 
            // mainMenu_File_Exit
            // 
            this.mainMenu_File_Exit.Name = "mainMenu_File_Exit";
            this.mainMenu_File_Exit.Size = new System.Drawing.Size(142, 26);
            this.mainMenu_File_Exit.Text = "Выход";
            this.mainMenu_File_Exit.Click += new System.EventHandler(this.mainMenu_File_Exit_Click);
            // 
            // mainWindowLayout
            // 
            this.mainWindowLayout.ColumnCount = 3;
            this.mainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.72067F));
            this.mainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.27933F));
            this.mainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 593F));
            this.mainWindowLayout.Controls.Add(this.operationsLayout, 1, 0);
            this.mainWindowLayout.Controls.Add(this.demonstration, 2, 0);
            this.mainWindowLayout.Controls.Add(this.sourceArrayPanel, 0, 0);
            this.mainWindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowLayout.Location = new System.Drawing.Point(0, 28);
            this.mainWindowLayout.Name = "mainWindowLayout";
            this.mainWindowLayout.RowCount = 1;
            this.mainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainWindowLayout.Size = new System.Drawing.Size(1157, 490);
            this.mainWindowLayout.TabIndex = 1;
            // 
            // operationsLayout
            // 
            this.operationsLayout.ColumnCount = 1;
            this.operationsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationsLayout.Controls.Add(this.operationsGroupBox, 0, 0);
            this.operationsLayout.Controls.Add(this.sortGroupBox, 0, 1);
            this.operationsLayout.Controls.Add(this.comparisonGroupBox, 0, 2);
            this.operationsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsLayout.Location = new System.Drawing.Point(283, 3);
            this.operationsLayout.Name = "operationsLayout";
            this.operationsLayout.RowCount = 3;
            this.operationsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.operationsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.operationsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.operationsLayout.Size = new System.Drawing.Size(277, 484);
            this.operationsLayout.TabIndex = 1;
            // 
            // operationsGroupBox
            // 
            this.operationsGroupBox.Controls.Add(this.clearBtn);
            this.operationsGroupBox.Controls.Add(this.shuffleBtn);
            this.operationsGroupBox.Controls.Add(this.fillBtn);
            this.operationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.operationsGroupBox.Name = "operationsGroupBox";
            this.operationsGroupBox.Size = new System.Drawing.Size(271, 144);
            this.operationsGroupBox.TabIndex = 0;
            this.operationsGroupBox.TabStop = false;
            this.operationsGroupBox.Text = "Операции";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(6, 106);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(250, 32);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // shuffleBtn
            // 
            this.shuffleBtn.Location = new System.Drawing.Point(6, 64);
            this.shuffleBtn.Name = "shuffleBtn";
            this.shuffleBtn.Size = new System.Drawing.Size(250, 36);
            this.shuffleBtn.TabIndex = 1;
            this.shuffleBtn.Text = "Перемешать";
            this.shuffleBtn.UseVisualStyleBackColor = true;
            this.shuffleBtn.Click += new System.EventHandler(this.shuffleBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(6, 25);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(250, 33);
            this.fillBtn.TabIndex = 0;
            this.fillBtn.Text = "Заполнить";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.demonstrateBtn);
            this.sortGroupBox.Controls.Add(this.SortBtn);
            this.sortGroupBox.Controls.Add(this.BinSortRadioBtn);
            this.sortGroupBox.Controls.Add(this.SimplySirtRadioBtn);
            this.sortGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortGroupBox.Location = new System.Drawing.Point(3, 153);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(271, 153);
            this.sortGroupBox.TabIndex = 1;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Сортировка";
            // 
            // demonstrateBtn
            // 
            this.demonstrateBtn.Location = new System.Drawing.Point(7, 112);
            this.demonstrateBtn.Name = "demonstrateBtn";
            this.demonstrateBtn.Size = new System.Drawing.Size(249, 34);
            this.demonstrateBtn.TabIndex = 3;
            this.demonstrateBtn.Text = "Демонстрация";
            this.demonstrateBtn.UseVisualStyleBackColor = true;
            this.demonstrateBtn.Click += new System.EventHandler(this.demonstrateBtn_Click);
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(6, 76);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(250, 30);
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Отсортировать";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // BinSortRadioBtn
            // 
            this.BinSortRadioBtn.AutoSize = true;
            this.BinSortRadioBtn.Location = new System.Drawing.Point(7, 49);
            this.BinSortRadioBtn.Name = "BinSortRadioBtn";
            this.BinSortRadioBtn.Size = new System.Drawing.Size(177, 21);
            this.BinSortRadioBtn.TabIndex = 1;
            this.BinSortRadioBtn.Text = "Бинарными вставками";
            this.BinSortRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SimplySirtRadioBtn
            // 
            this.SimplySirtRadioBtn.AutoSize = true;
            this.SimplySirtRadioBtn.Checked = true;
            this.SimplySirtRadioBtn.Location = new System.Drawing.Point(7, 22);
            this.SimplySirtRadioBtn.Name = "SimplySirtRadioBtn";
            this.SimplySirtRadioBtn.Size = new System.Drawing.Size(168, 21);
            this.SimplySirtRadioBtn.TabIndex = 0;
            this.SimplySirtRadioBtn.TabStop = true;
            this.SimplySirtRadioBtn.Text = "Простыми вставками";
            this.SimplySirtRadioBtn.UseVisualStyleBackColor = true;
            // 
            // comparisonGroupBox
            // 
            this.comparisonGroupBox.Controls.Add(this.fromSource);
            this.comparisonGroupBox.Controls.Add(this.compareBtn);
            this.comparisonGroupBox.Controls.Add(this.comparisonCountRadioBtn);
            this.comparisonGroupBox.Controls.Add(this.swapsCountRadioBtn);
            this.comparisonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparisonGroupBox.Location = new System.Drawing.Point(3, 312);
            this.comparisonGroupBox.Name = "comparisonGroupBox";
            this.comparisonGroupBox.Size = new System.Drawing.Size(271, 169);
            this.comparisonGroupBox.TabIndex = 2;
            this.comparisonGroupBox.TabStop = false;
            this.comparisonGroupBox.Text = "Сравнение";
            // 
            // fromSource
            // 
            this.fromSource.AutoSize = true;
            this.fromSource.Location = new System.Drawing.Point(7, 85);
            this.fromSource.Name = "fromSource";
            this.fromSource.Size = new System.Drawing.Size(164, 21);
            this.fromSource.TabIndex = 5;
            this.fromSource.Text = "Из исходных данных";
            this.fromSource.UseVisualStyleBackColor = true;
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(7, 129);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(249, 34);
            this.compareBtn.TabIndex = 4;
            this.compareBtn.Text = "Сравнить";
            this.compareBtn.UseVisualStyleBackColor = true;
            // 
            // comparisonCountRadioBtn
            // 
            this.comparisonCountRadioBtn.AutoSize = true;
            this.comparisonCountRadioBtn.Location = new System.Drawing.Point(6, 48);
            this.comparisonCountRadioBtn.Name = "comparisonCountRadioBtn";
            this.comparisonCountRadioBtn.Size = new System.Drawing.Size(181, 21);
            this.comparisonCountRadioBtn.TabIndex = 1;
            this.comparisonCountRadioBtn.TabStop = true;
            this.comparisonCountRadioBtn.Text = "Количество сравнений";
            this.comparisonCountRadioBtn.UseVisualStyleBackColor = true;
            // 
            // swapsCountRadioBtn
            // 
            this.swapsCountRadioBtn.AutoSize = true;
            this.swapsCountRadioBtn.Location = new System.Drawing.Point(7, 21);
            this.swapsCountRadioBtn.Name = "swapsCountRadioBtn";
            this.swapsCountRadioBtn.Size = new System.Drawing.Size(167, 21);
            this.swapsCountRadioBtn.TabIndex = 0;
            this.swapsCountRadioBtn.TabStop = true;
            this.swapsCountRadioBtn.Text = "Количество обменов";
            this.swapsCountRadioBtn.UseVisualStyleBackColor = true;
            // 
            // demonstration
            // 
            this.demonstration.Controls.Add(this.comparisonTab);
            this.demonstration.Controls.Add(this.demostrationTab);
            this.demonstration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demonstration.Location = new System.Drawing.Point(566, 3);
            this.demonstration.Name = "demonstration";
            this.demonstration.SelectedIndex = 0;
            this.demonstration.Size = new System.Drawing.Size(588, 484);
            this.demonstration.TabIndex = 2;
            // 
            // comparisonTab
            // 
            this.comparisonTab.Controls.Add(this.comparisonChart);
            this.comparisonTab.Location = new System.Drawing.Point(4, 25);
            this.comparisonTab.Name = "comparisonTab";
            this.comparisonTab.Padding = new System.Windows.Forms.Padding(3);
            this.comparisonTab.Size = new System.Drawing.Size(580, 455);
            this.comparisonTab.TabIndex = 0;
            this.comparisonTab.Text = "Сравнение";
            this.comparisonTab.UseVisualStyleBackColor = true;
            // 
            // comparisonChart
            // 
            chartArea3.Name = "ChartArea1";
            this.comparisonChart.ChartAreas.Add(chartArea3);
            this.comparisonChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "comparisonChartLegend";
            this.comparisonChart.Legends.Add(legend3);
            this.comparisonChart.Location = new System.Drawing.Point(3, 3);
            this.comparisonChart.Name = "comparisonChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "comparisonChartLegend";
            series5.LegendText = "Сортировка бинарными вставками";
            series5.Name = "binSortInsertion";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "comparisonChartLegend";
            series6.LegendText = "Сортировка простыми вставками";
            series6.Name = "simplySortInsertion";
            this.comparisonChart.Series.Add(series5);
            this.comparisonChart.Series.Add(series6);
            this.comparisonChart.Size = new System.Drawing.Size(574, 449);
            this.comparisonChart.TabIndex = 0;
            this.comparisonChart.Text = "chart1";
            // 
            // demostrationTab
            // 
            this.demostrationTab.Controls.Add(this.demonstrarionCanvasPanel);
            this.demostrationTab.Location = new System.Drawing.Point(4, 25);
            this.demostrationTab.Name = "demostrationTab";
            this.demostrationTab.Padding = new System.Windows.Forms.Padding(3);
            this.demostrationTab.Size = new System.Drawing.Size(580, 455);
            this.demostrationTab.TabIndex = 1;
            this.demostrationTab.Text = "Демонстрация";
            this.demostrationTab.UseVisualStyleBackColor = true;
            // 
            // demonstrarionCanvasPanel
            // 
            this.demonstrarionCanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demonstrarionCanvasPanel.Location = new System.Drawing.Point(3, 3);
            this.demonstrarionCanvasPanel.Name = "demonstrarionCanvasPanel";
            this.demonstrarionCanvasPanel.Size = new System.Drawing.Size(574, 449);
            this.demonstrarionCanvasPanel.TabIndex = 0;
            // 
            // sourceArrayPanel
            // 
            this.sourceArrayPanel.Controls.Add(this.sourceArrayDGV);
            this.sourceArrayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceArrayPanel.Location = new System.Drawing.Point(3, 3);
            this.sourceArrayPanel.Name = "sourceArrayPanel";
            this.sourceArrayPanel.Size = new System.Drawing.Size(274, 484);
            this.sourceArrayPanel.TabIndex = 3;
            // 
            // sourceArrayDGV
            // 
            this.sourceArrayDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceArrayDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceArrayDGV.Location = new System.Drawing.Point(9, 3);
            this.sourceArrayDGV.Name = "sourceArrayDGV";
            this.sourceArrayDGV.RowTemplate.Height = 24;
            this.sourceArrayDGV.Size = new System.Drawing.Size(257, 458);
            this.sourceArrayDGV.TabIndex = 0;
            // 
            // SortComprasion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 518);
            this.Controls.Add(this.mainWindowLayout);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "SortComprasion";
            this.Text = "Сравнение сортировок";
            this.Load += new System.EventHandler(this.SortComprasion_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainWindowLayout.ResumeLayout(false);
            this.operationsLayout.ResumeLayout(false);
            this.operationsGroupBox.ResumeLayout(false);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            this.comparisonGroupBox.ResumeLayout(false);
            this.comparisonGroupBox.PerformLayout();
            this.demonstration.ResumeLayout(false);
            this.comparisonTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comparisonChart)).EndInit();
            this.demostrationTab.ResumeLayout(false);
            this.sourceArrayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceArrayDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_File;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_File_Open;
        private System.Windows.Forms.TableLayoutPanel mainWindowLayout;
        private System.Windows.Forms.DataGridView sourceArrayDGV;
        private System.Windows.Forms.TableLayoutPanel operationsLayout;
        private System.Windows.Forms.GroupBox operationsGroupBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button shuffleBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Button demonstrateBtn;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.RadioButton BinSortRadioBtn;
        private System.Windows.Forms.RadioButton SimplySirtRadioBtn;
        private System.Windows.Forms.GroupBox comparisonGroupBox;
        private System.Windows.Forms.CheckBox fromSource;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.RadioButton comparisonCountRadioBtn;
        private System.Windows.Forms.RadioButton swapsCountRadioBtn;
        private System.Windows.Forms.TabControl demonstration;
        private System.Windows.Forms.TabPage comparisonTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart comparisonChart;
        private System.Windows.Forms.TabPage demostrationTab;
        private System.Windows.Forms.Panel demonstrarionCanvasPanel;
        private System.Windows.Forms.ToolStripSeparator mainMenu_File_Separator1;
        private System.Windows.Forms.ToolStripMenuItem mainMenu_File_Exit;
        private System.Windows.Forms.Panel sourceArrayPanel;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
    }
}

