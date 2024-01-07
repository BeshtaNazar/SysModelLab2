using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Main : Form
    {
        
            
            
            
        
        public Main()
        {
            InitializeComponent();
        }

        private void ChangeFormLayout()
        {
            StandardGeneratorChart.Size = new Size(Convert.ToInt32(this.Width * 0.6), Convert.ToInt32(this.Height * 0.25));
            MidpointSquareMethodChart.Size = new Size(Convert.ToInt32(this.Width * 0.6), Convert.ToInt32(this.Height * 0.25));
            LinearCongruentialMethodChart.Size = new Size(Convert.ToInt32(this.Width * 0.6), Convert.ToInt32(this.Height * 0.25));
            StandardGeneratorLabel.Location = new Point(StandardGeneratorChart.Size.Width / 2 - StandardGeneratorLabel.Size.Width / 2, 5);
            StandardGeneratorChart.Location = new Point(10, StandardGeneratorLabel.Location.Y + StandardGeneratorLabel.Size.Height + 6);
            MidpointSquareMethodLabel.Location = new Point(MidpointSquareMethodChart.Size.Width / 2 - MidpointSquareMethodLabel.Size.Width / 2, StandardGeneratorChart.Location.Y + StandardGeneratorChart.Size.Height + 6);
            MidpointSquareMethodChart.Location = new Point(10, MidpointSquareMethodLabel.Location.Y + MidpointSquareMethodLabel.Size.Height + 6);
            LinearCongruentialMethodLabel.Location = new Point(LinearCongruentialMethodChart.Size.Width / 2 - LinearCongruentialMethodLabel.Size.Width / 2, MidpointSquareMethodChart.Location.Y + MidpointSquareMethodChart.Size.Height + 6);
            LinearCongruentialMethodChart.Location = new Point(10, LinearCongruentialMethodLabel.Location.Y + LinearCongruentialMethodLabel.Size.Height + 6);
            StandardGeneratorListBox.Size = new Size(Convert.ToInt32(this.Width * 0.1), StandardGeneratorChart.Size.Height);
            StandardGeneratorListBox.Location = new Point(StandardGeneratorChart.Location.X + StandardGeneratorChart.Size.Width + 5, StandardGeneratorChart.Location.Y);
            MidpointSquareMethodListBox.Size = new Size(Convert.ToInt32(this.Width * 0.1), MidpointSquareMethodChart.Size.Height);
            MidpointSquareMethodListBox.Location = new Point(MidpointSquareMethodChart.Location.X + MidpointSquareMethodChart.Size.Width + 5, MidpointSquareMethodChart.Location.Y);
            LinearCongruentialMethodListBox.Size = new Size(Convert.ToInt32(this.Width * 0.1), LinearCongruentialMethodChart.Size.Height);
            LinearCongruentialMethodListBox.Location = new Point(LinearCongruentialMethodChart.Location.X + LinearCongruentialMethodChart.Size.Width + 5, LinearCongruentialMethodChart.Location.Y);
            IntervalOfNumbersLabel.Location = new Point(this.Size.Width - IntervalOfNumbersLabel.Size.Width - 20, 20);
            StartOfIntervalLabel.Location = new Point(IntervalOfNumbersLabel.Location.X + 5, IntervalOfNumbersLabel.Location.Y + IntervalOfNumbersLabel.Size.Height + 10);
            IntervalOfNumbersTextBox.Size = new Size(IntervalOfNumbersLabel.Width / 2, Height);
            IntervalOfNumbersTextBox.Location = new Point(StartOfIntervalLabel.Location.X + StartOfIntervalLabel.Size.Width + 4, StartOfIntervalLabel.Location.Y);
            NumberOfIntervalsLabel.Location = new Point(IntervalOfNumbersLabel.Location.X, StartOfIntervalLabel.Location.Y + StartOfIntervalLabel.Size.Height + 40);
            NumberOfIntervalsTextBox.Size = new Size(NumberOfIntervalsLabel.Size.Width / 2, Height);
            NumberOfIntervalsTextBox.Location = new Point(NumberOfIntervalsLabel.Location.X + NumberOfIntervalsLabel.Size.Width / 2 - NumberOfIntervalsTextBox.Size.Width / 2, NumberOfIntervalsLabel.Location.Y + NumberOfIntervalsLabel.Size.Height + 4);
            NumberOfTestsLabel.Location = new Point(NumberOfIntervalsLabel.Location.X, NumberOfIntervalsTextBox.Location.Y + NumberOfIntervalsTextBox.Size.Height + 40);
            NumberOfTestsTextBox.Size = new Size(NumberOfTestsLabel.Width / 2, Height);
            NumberOfTestsTextBox.Location = new Point(NumberOfTestsLabel.Location.X + NumberOfTestsLabel.Width / 2 - NumberOfTestsTextBox.Width / 2, NumberOfTestsLabel.Location.Y + NumberOfTestsLabel.Height + 4);
            GenerateNumbersButton.Location = new Point(NumberOfTestsLabel.Location.X, NumberOfTestsTextBox.Location.Y + NumberOfTestsTextBox.Height + 50);
            ExportToExcelButton.Location = new Point(GenerateNumbersButton.Location.X, GenerateNumbersButton.Location.Y + GenerateNumbersButton.Height + 10);
            ImportFromExcelButton.Location = new Point(ExportToExcelButton.Location.X, ExportToExcelButton.Location.Y + ExportToExcelButton.Height + 10);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ChangeFormLayout();
        }        

        private void Main_Resize(object sender, EventArgs e)
        {
            ChangeFormLayout();
        }

        private void StandardGenerator(int endOfInterval, int numberOfIntervals, int numberOfTests )
        {
            CheckForValidInputs();                     
            Random random = new Random();
            StandardGeneratorChart.Series.Clear();
            List<int> numbers = new List<int>();
            int[] results = new int[numberOfIntervals];
            StandardGeneratorChart.Series.Add(Name);

            for (int i = 0; i < numberOfTests; i++)
            {
                numbers.Add(random.Next(0, endOfInterval));
            }

            StandardGeneratorListBox.DataSource = numbers;

            for (int i = 0; i < results.Length; i++)
            {
                foreach (int item in numbers)
                {
                    if (item >= endOfInterval / numberOfIntervals * i && item <= endOfInterval / numberOfIntervals * (i + 1))
                    {
                        results[i]++;
                    }
                }
            }
            StandardGeneratorChart.Series[0].IsVisibleInLegend = false;
            for (int i = 0; i < results.Length; i++)
            {
                string intervalStart = (endOfInterval / numberOfIntervals * i).ToString();
                string intervalEnd = (endOfInterval / numberOfIntervals * (i + 1)).ToString();
                StandardGeneratorChart.Series[0].Points.AddXY($"{intervalStart}-{intervalEnd}", results[i]);
                StandardGeneratorChart.Series[0].Points[i].Label = results[i].ToString();
            }
            
        }

        private void SetDataFromExcel(ISheet sheet)
        {
            int numberOfIntervals = sheet.PhysicalNumberOfRows;            
            for (int i = 0; i < numberOfIntervals; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (String.IsNullOrEmpty(sheet.GetRow(i).GetCell(j).ToString()))
                    {
                        MessageBox.Show("Не кожна комірка має відповідне значення");
                        return;
                    }                    
                }
            }
            StandardGeneratorChart.Series.Clear();
            MidpointSquareMethodChart.Series.Clear();
            LinearCongruentialMethodChart.Series.Clear();
            StandardGeneratorChart.Series.Add("Series");
            MidpointSquareMethodChart.Series.Add("Series");
            LinearCongruentialMethodChart.Series.Add("Series");
            StandardGeneratorChart.Series[0].IsVisibleInLegend = false;
            MidpointSquareMethodChart.Series[0].IsVisibleInLegend = false;
            LinearCongruentialMethodChart.Series[0].IsVisibleInLegend = false;

            for (int i = 0; i < numberOfIntervals; i++)
            {
                string xValue = sheet.GetRow(i).GetCell(0).ToString();
                string yValue = sheet.GetRow(i).GetCell(1).ToString();
                if(int.TryParse(yValue,out int res)==false)
                {
                    MessageBox.Show($"Значення комірки ({i}; 1) має неправильний формат");
                    return;
                }    
                StandardGeneratorChart.Series[0].Points.AddXY(xValue,yValue);
                StandardGeneratorChart.Series[0].Points[i].Label = yValue.ToString();
            }
            for (int i = 0; i < numberOfIntervals; i++)
            {
                string xValue = sheet.GetRow(i).GetCell(2).ToString();
                string yValue = sheet.GetRow(i).GetCell(3).ToString();
                if (int.TryParse(yValue, out int res) == false)
                {
                    MessageBox.Show($"Значення комірки ({i}; 3) має неправильний формат");
                    return;
                }
                MidpointSquareMethodChart.Series[0].Points.AddXY(xValue, yValue);
                MidpointSquareMethodChart.Series[0].Points[i].Label = yValue.ToString();
            }
            for (int i = 0; i < numberOfIntervals; i++)
            {
                string xValue = sheet.GetRow(i).GetCell(4).ToString();
                string yValue = sheet.GetRow(i).GetCell(5).ToString();
                if (int.TryParse(yValue, out int res) == false)
                {
                    MessageBox.Show($"Значення комірки ({i}; 5) має неправильний формат");
                    return;
                }
                LinearCongruentialMethodChart.Series[0].Points.AddXY(xValue, yValue);
                LinearCongruentialMethodChart.Series[0].Points[i].Label = yValue.ToString();
            }
        }

        private void CheckForValidInputs()
        {
            int endOfInterval = 0;
            int numberOfIntervals = 0;
            int numberOfTests = 0;
            Random random = new Random();
            try
            {
                endOfInterval = Convert.ToInt32(IntervalOfNumbersTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Неправильно введений інтервал");
                return;
            }
            try
            {
                numberOfIntervals = Convert.ToInt32(NumberOfIntervalsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Неправильно введена кількість проміжків");
                return;
            }
            try
            {
                numberOfTests = Convert.ToInt32(NumberOfTestsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Неправильно введена кількість проміжків");
                return;
            }
        }

        private void MidpointSquareMethod(int endOfInterval, int numberOfIntervals, int numberOfTests)
        {
            CheckForValidInputs();
            int[] numbers = new int[numberOfTests];
            int seed = (int)DateTime.Now.Ticks % 10000;
            if (seed < 0)
                seed *= -1;
            while (seed < 1111 || seed == 10000)
            {
                seed = (int)DateTime.Now.Ticks % 10000;
                if (seed < 0)
                    seed *= -1;
            }
            numbers[0] = seed;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                string squaredString = Math.Pow(numbers[i], 2).ToString();
                while (squaredString.Length != 8)
                    squaredString = "0" + squaredString;
                int middleIndex = (squaredString.Length - 4) / 2;
                string middleString = squaredString.Substring(middleIndex, 4);
                int middleNum = int.Parse(middleString);
                numbers[i + 1] = middleNum;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)((numbers[i] / 9999.0) * endOfInterval);
            }
            MidpointSquareMethodListBox.DataSource = numbers;
            MidpointSquareMethodChart.Series.Clear();
            MidpointSquareMethodChart.Series.Add("Series");
            MidpointSquareMethodChart.Series[0].IsVisibleInLegend = false;
            int[] results = new int[numberOfIntervals];
            for (int i = 0; i < results.Length; i++)
            {
                foreach (int num in numbers)
                {
                    if (num >= endOfInterval / numberOfIntervals * i && num <= endOfInterval / numberOfIntervals * (i + 1))
                        results[i]++;
                }
            }

            for (int i = 0; i < results.Length; i++)
            {
                string intervalStart = (endOfInterval / numberOfIntervals * i).ToString();
                string intervalEnd = (endOfInterval / numberOfIntervals * (i + 1)).ToString();
                MidpointSquareMethodChart.Series[0].Points.AddXY($"{intervalStart}-{intervalEnd}", results[i]);
                MidpointSquareMethodChart.Series[0].Points[i].Label = results[i].ToString();
            }
            
        }

        private void LinearCongruentinalMethod(int endOfInterval, int numberOfIntervals, int numberOfTests)
        {
            CheckForValidInputs();            
            int[] numbers = new int[numberOfTests];
            LinearCongruentialMethodChart.Series.Clear();
            LinearCongruentialMethodChart.Series.Add("Series");
            LinearCongruentialMethodChart.Series[0].IsVisibleInLegend = false;
            int seed = (int)DateTime.Now.Millisecond;
            while (seed > endOfInterval)
            {
                seed = DateTime.Now.Millisecond;
            }
            numbers[0] = seed;
            int k = 1231943;
            int c = 1213123;
            int m = int.MaxValue;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i + 1] = ((k * numbers[i] + c) % m)%(endOfInterval+1);
                
            }
            LinearCongruentialMethodListBox.DataSource = numbers;
            int[] results = new int[numberOfIntervals];
            for (int i = 0; i < results.Length; i++)
            {
                foreach (var num in numbers)
                {
                    if (num >= endOfInterval / numberOfIntervals * i && num <= endOfInterval / numberOfIntervals * (i + 1))
                        results[i]++;
                }
            }
            for (int i = 0; i < results.Length; i++)
            {
                string intervalStart = (endOfInterval / numberOfIntervals * i).ToString();
                string intervalEnd = (endOfInterval / numberOfIntervals * (i + 1)).ToString();
                LinearCongruentialMethodChart.Series[0].Points.AddXY($"{intervalStart}-{intervalEnd}", results[i]);
                LinearCongruentialMethodChart.Series[0].Points[i].Label = results[i].ToString();
            }
        }

        private void GenerateNumbersButton_Click(object sender, EventArgs e)
        {
            StandardGenerator(int.Parse(IntervalOfNumbersTextBox.Text),int.Parse(NumberOfIntervalsTextBox.Text),int.Parse(NumberOfTestsTextBox.Text));
            MidpointSquareMethod(int.Parse(IntervalOfNumbersTextBox.Text), int.Parse(NumberOfIntervalsTextBox.Text), int.Parse(NumberOfTestsTextBox.Text));
            LinearCongruentinalMethod(int.Parse(IntervalOfNumbersTextBox.Text), int.Parse(NumberOfIntervalsTextBox.Text), int.Parse(NumberOfTestsTextBox.Text));
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".xlsx";
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";            
            var sel = sfd.ShowDialog();
            if (sel == DialogResult.Cancel)
                return;

            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");
            int[] inputData = new int[3];            
            for (int i = 0; i < StandardGeneratorChart.Series[0].Points.Count; i++)
            {                
                sheet.CreateRow(i).CreateCell(0).SetCellValue(StandardGeneratorChart.Series[0].Points[i].AxisLabel.ToString());
                sheet.GetRow(i).CreateCell(1).SetCellValue(StandardGeneratorChart.Series[0].Points[i].YValues[0]);
                sheet.GetRow(i).CreateCell(2).SetCellValue(MidpointSquareMethodChart.Series[0].Points[i].AxisLabel.ToString());
                sheet.GetRow(i).CreateCell(3).SetCellValue(MidpointSquareMethodChart.Series[0].Points[i].YValues[0]);
                sheet.GetRow(i).CreateCell(4).SetCellValue(LinearCongruentialMethodChart.Series[0].Points[i].AxisLabel.ToString());
                sheet.GetRow(i).CreateCell(5).SetCellValue(LinearCongruentialMethodChart.Series[0].Points[i].YValues[0]);               
            }            
            
            using (FileStream fileStream = new FileStream(Path.GetFullPath(sfd.FileName), FileMode.Create))
            {
                workbook.Write(fileStream,false);                
            }
            
        }

        private void ImportFromExcelButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.DefaultExt = ".xlsx";
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            var sel = sfd.ShowDialog();
            if (sel == DialogResult.Cancel)
                return;
            IWorkbook workbook;
            using (FileStream fileStream = new FileStream(Path.GetFullPath(sfd.FileName), FileMode.Open))
            {
                workbook = new XSSFWorkbook(fileStream);
            }
            ISheet sheet = workbook.GetSheetAt(0);
            SetDataFromExcel(sheet);
        }
    }
}
