using System.Windows.Forms;

namespace Lab2
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.StandardGeneratorChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MidpointSquareMethodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LinearCongruentialMethodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StandardGeneratorLabel = new System.Windows.Forms.Label();
            this.MidpointSquareMethodLabel = new System.Windows.Forms.Label();
            this.LinearCongruentialMethodLabel = new System.Windows.Forms.Label();
            this.StandardGeneratorListBox = new System.Windows.Forms.ListBox();
            this.MidpointSquareMethodListBox = new System.Windows.Forms.ListBox();
            this.LinearCongruentialMethodListBox = new System.Windows.Forms.ListBox();
            this.IntervalOfNumbersLabel = new System.Windows.Forms.Label();
            this.IntervalOfNumbersTextBox = new System.Windows.Forms.TextBox();
            this.StartOfIntervalLabel = new System.Windows.Forms.Label();
            this.NumberOfIntervalsLabel = new System.Windows.Forms.Label();
            this.NumberOfIntervalsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfTestsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfTestsLabel = new System.Windows.Forms.Label();
            this.GenerateNumbersButton = new System.Windows.Forms.Button();
            this.ExportToExcelButton = new System.Windows.Forms.Button();
            this.ImportFromExcelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.StandardGeneratorChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidpointSquareMethodChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearCongruentialMethodChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StandardGeneratorChart
            // 
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineWidth = 0;
            chartArea7.AxisY.MajorGrid.LineWidth = 0;
            chartArea7.Name = "ChartArea1";
            this.StandardGeneratorChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.StandardGeneratorChart.Legends.Add(legend7);
            this.StandardGeneratorChart.Location = new System.Drawing.Point(12, 25);
            this.StandardGeneratorChart.Name = "StandardGeneratorChart";
            this.StandardGeneratorChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.StandardGeneratorChart.Size = new System.Drawing.Size(538, 147);
            this.StandardGeneratorChart.TabIndex = 0;
            this.StandardGeneratorChart.Text = "StandardGenerator";
            // 
            // MidpointSquareMethodChart
            // 
            chartArea8.AxisX.MajorGrid.LineWidth = 0;
            chartArea8.AxisY.MajorGrid.LineWidth = 0;
            chartArea8.Name = "ChartArea1";
            this.MidpointSquareMethodChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.MidpointSquareMethodChart.Legends.Add(legend8);
            this.MidpointSquareMethodChart.Location = new System.Drawing.Point(12, 191);
            this.MidpointSquareMethodChart.Name = "MidpointSquareMethodChart";
            this.MidpointSquareMethodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.MidpointSquareMethodChart.Size = new System.Drawing.Size(538, 143);
            this.MidpointSquareMethodChart.TabIndex = 1;
            this.MidpointSquareMethodChart.Text = "MidpointSquareMethod";
            // 
            // LinearCongruentialMethodChart
            // 
            chartArea9.AxisX.MajorGrid.LineWidth = 0;
            chartArea9.AxisY.MajorGrid.LineWidth = 0;
            chartArea9.Name = "ChartArea1";
            this.LinearCongruentialMethodChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.LinearCongruentialMethodChart.Legends.Add(legend9);
            this.LinearCongruentialMethodChart.Location = new System.Drawing.Point(12, 359);
            this.LinearCongruentialMethodChart.Name = "LinearCongruentialMethodChart";
            this.LinearCongruentialMethodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.LinearCongruentialMethodChart.Size = new System.Drawing.Size(538, 147);
            this.LinearCongruentialMethodChart.TabIndex = 2;
            this.LinearCongruentialMethodChart.Text = "LinearCongruentialMethod";
            // 
            // StandardGeneratorLabel
            // 
            this.StandardGeneratorLabel.AutoSize = true;
            this.StandardGeneratorLabel.Location = new System.Drawing.Point(9, 9);
            this.StandardGeneratorLabel.Name = "StandardGeneratorLabel";
            this.StandardGeneratorLabel.Size = new System.Drawing.Size(127, 13);
            this.StandardGeneratorLabel.TabIndex = 3;
            this.StandardGeneratorLabel.Text = "Стандартний генератор";
            // 
            // MidpointSquareMethodLabel
            // 
            this.MidpointSquareMethodLabel.AutoSize = true;
            this.MidpointSquareMethodLabel.Location = new System.Drawing.Point(222, 175);
            this.MidpointSquareMethodLabel.Name = "MidpointSquareMethodLabel";
            this.MidpointSquareMethodLabel.Size = new System.Drawing.Size(139, 13);
            this.MidpointSquareMethodLabel.TabIndex = 4;
            this.MidpointSquareMethodLabel.Text = "Метод середини квадрату";
            // 
            // LinearCongruentialMethodLabel
            // 
            this.LinearCongruentialMethodLabel.AutoSize = true;
            this.LinearCongruentialMethodLabel.Location = new System.Drawing.Point(222, 337);
            this.LinearCongruentialMethodLabel.Name = "LinearCongruentialMethodLabel";
            this.LinearCongruentialMethodLabel.Size = new System.Drawing.Size(155, 13);
            this.LinearCongruentialMethodLabel.TabIndex = 5;
            this.LinearCongruentialMethodLabel.Text = "Лінійний конгруентний метод";
            // 
            // StandardGeneratorListBox
            // 
            this.StandardGeneratorListBox.FormattingEnabled = true;
            this.StandardGeneratorListBox.Location = new System.Drawing.Point(556, 25);
            this.StandardGeneratorListBox.Name = "StandardGeneratorListBox";
            this.StandardGeneratorListBox.Size = new System.Drawing.Size(120, 147);
            this.StandardGeneratorListBox.TabIndex = 6;
            // 
            // MidpointSquareMethodListBox
            // 
            this.MidpointSquareMethodListBox.FormattingEnabled = true;
            this.MidpointSquareMethodListBox.Location = new System.Drawing.Point(556, 187);
            this.MidpointSquareMethodListBox.Name = "MidpointSquareMethodListBox";
            this.MidpointSquareMethodListBox.Size = new System.Drawing.Size(120, 147);
            this.MidpointSquareMethodListBox.TabIndex = 7;
            // 
            // LinearCongruentialMethodListBox
            // 
            this.LinearCongruentialMethodListBox.FormattingEnabled = true;
            this.LinearCongruentialMethodListBox.Location = new System.Drawing.Point(556, 359);
            this.LinearCongruentialMethodListBox.Name = "LinearCongruentialMethodListBox";
            this.LinearCongruentialMethodListBox.Size = new System.Drawing.Size(120, 147);
            this.LinearCongruentialMethodListBox.TabIndex = 8;
            // 
            // IntervalOfNumbersLabel
            // 
            this.IntervalOfNumbersLabel.AutoSize = true;
            this.IntervalOfNumbersLabel.Location = new System.Drawing.Point(742, 25);
            this.IntervalOfNumbersLabel.Name = "IntervalOfNumbersLabel";
            this.IntervalOfNumbersLabel.Size = new System.Drawing.Size(132, 13);
            this.IntervalOfNumbersLabel.TabIndex = 9;
            this.IntervalOfNumbersLabel.Text = "Інтервал генерації чисел";
            // 
            // IntervalOfNumbersTextBox
            // 
            this.IntervalOfNumbersTextBox.Location = new System.Drawing.Point(800, 41);
            this.IntervalOfNumbersTextBox.Name = "IntervalOfNumbersTextBox";
            this.IntervalOfNumbersTextBox.Size = new System.Drawing.Size(63, 20);
            this.IntervalOfNumbersTextBox.TabIndex = 10;
            this.IntervalOfNumbersTextBox.Text = "100";
            // 
            // StartOfIntervalLabel
            // 
            this.StartOfIntervalLabel.AutoSize = true;
            this.StartOfIntervalLabel.Location = new System.Drawing.Point(749, 44);
            this.StartOfIntervalLabel.Name = "StartOfIntervalLabel";
            this.StartOfIntervalLabel.Size = new System.Drawing.Size(45, 13);
            this.StartOfIntervalLabel.TabIndex = 11;
            this.StartOfIntervalLabel.Text = "від 0 до";
            // 
            // NumberOfIntervalsLabel
            // 
            this.NumberOfIntervalsLabel.AutoSize = true;
            this.NumberOfIntervalsLabel.Location = new System.Drawing.Point(738, 103);
            this.NumberOfIntervalsLabel.Name = "NumberOfIntervalsLabel";
            this.NumberOfIntervalsLabel.Size = new System.Drawing.Size(106, 13);
            this.NumberOfIntervalsLabel.TabIndex = 12;
            this.NumberOfIntervalsLabel.Text = "Кількість проміжків";
            // 
            // NumberOfIntervalsTextBox
            // 
            this.NumberOfIntervalsTextBox.Location = new System.Drawing.Point(781, 130);
            this.NumberOfIntervalsTextBox.Name = "NumberOfIntervalsTextBox";
            this.NumberOfIntervalsTextBox.Size = new System.Drawing.Size(63, 20);
            this.NumberOfIntervalsTextBox.TabIndex = 13;
            this.NumberOfIntervalsTextBox.Text = "5";
            // 
            // NumberOfTestsTextBox
            // 
            this.NumberOfTestsTextBox.Location = new System.Drawing.Point(781, 187);
            this.NumberOfTestsTextBox.Name = "NumberOfTestsTextBox";
            this.NumberOfTestsTextBox.Size = new System.Drawing.Size(63, 20);
            this.NumberOfTestsTextBox.TabIndex = 14;
            this.NumberOfTestsTextBox.Text = "100";
            // 
            // NumberOfTestsLabel
            // 
            this.NumberOfTestsLabel.AutoSize = true;
            this.NumberOfTestsLabel.Location = new System.Drawing.Point(742, 159);
            this.NumberOfTestsLabel.Name = "NumberOfTestsLabel";
            this.NumberOfTestsLabel.Size = new System.Drawing.Size(121, 13);
            this.NumberOfTestsLabel.TabIndex = 15;
            this.NumberOfTestsLabel.Text = "Кількість випробувань";
            // 
            // GenerateNumbersButton
            // 
            this.GenerateNumbersButton.Location = new System.Drawing.Point(741, 251);
            this.GenerateNumbersButton.Name = "GenerateNumbersButton";
            this.GenerateNumbersButton.Size = new System.Drawing.Size(131, 23);
            this.GenerateNumbersButton.TabIndex = 16;
            this.GenerateNumbersButton.Text = "Згенерувати";
            this.GenerateNumbersButton.UseVisualStyleBackColor = true;
            this.GenerateNumbersButton.Click += new System.EventHandler(this.GenerateNumbersButton_Click);
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.Location = new System.Drawing.Point(741, 280);
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(131, 23);
            this.ExportToExcelButton.TabIndex = 17;
            this.ExportToExcelButton.Text = "Експортувати в Excel";
            this.ExportToExcelButton.UseVisualStyleBackColor = true;
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // ImportFromExcelButton
            // 
            this.ImportFromExcelButton.Location = new System.Drawing.Point(741, 309);
            this.ImportFromExcelButton.Name = "ImportFromExcelButton";
            this.ImportFromExcelButton.Size = new System.Drawing.Size(131, 23);
            this.ImportFromExcelButton.TabIndex = 18;
            this.ImportFromExcelButton.Text = "Імпортувати з Excel";
            this.ImportFromExcelButton.UseVisualStyleBackColor = true;
            this.ImportFromExcelButton.Click += new System.EventHandler(this.ImportFromExcelButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.ImportFromExcelButton);
            this.Controls.Add(this.ExportToExcelButton);
            this.Controls.Add(this.GenerateNumbersButton);
            this.Controls.Add(this.NumberOfTestsLabel);
            this.Controls.Add(this.NumberOfTestsTextBox);
            this.Controls.Add(this.NumberOfIntervalsTextBox);
            this.Controls.Add(this.NumberOfIntervalsLabel);
            this.Controls.Add(this.StartOfIntervalLabel);
            this.Controls.Add(this.IntervalOfNumbersTextBox);
            this.Controls.Add(this.IntervalOfNumbersLabel);
            this.Controls.Add(this.LinearCongruentialMethodListBox);
            this.Controls.Add(this.MidpointSquareMethodListBox);
            this.Controls.Add(this.StandardGeneratorListBox);
            this.Controls.Add(this.LinearCongruentialMethodLabel);
            this.Controls.Add(this.MidpointSquareMethodLabel);
            this.Controls.Add(this.StandardGeneratorLabel);
            this.Controls.Add(this.LinearCongruentialMethodChart);
            this.Controls.Add(this.MidpointSquareMethodChart);
            this.Controls.Add(this.StandardGeneratorChart);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.StandardGeneratorChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidpointSquareMethodChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinearCongruentialMethodChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart StandardGeneratorChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MidpointSquareMethodChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LinearCongruentialMethodChart;
        private Label StandardGeneratorLabel;
        private Label MidpointSquareMethodLabel;
        private Label LinearCongruentialMethodLabel;
        private ListBox StandardGeneratorListBox;
        private ListBox MidpointSquareMethodListBox;
        private ListBox LinearCongruentialMethodListBox;
        private Label IntervalOfNumbersLabel;
        private TextBox IntervalOfNumbersTextBox;
        private Label StartOfIntervalLabel;
        private Label NumberOfIntervalsLabel;
        private TextBox NumberOfIntervalsTextBox;
        private TextBox NumberOfTestsTextBox;
        private Label NumberOfTestsLabel;
        private Button GenerateNumbersButton;
        private Button ExportToExcelButton;
        private Button ImportFromExcelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

