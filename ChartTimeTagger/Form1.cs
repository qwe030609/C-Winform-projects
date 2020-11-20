using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace ChartTimeTagger
{
    public partial class Form1 : Form
    {
        public static List<double> ListData_X = new List<double>();
        public static List<double> ListData_Y = new List<double>();
        public static List<double> ListData_Z = new List<double>();
        public static List<Double> List_SelectedDataRange= new List<double>();
        public static List<DateTime> List_DateTime = new List<DateTime>();
        public static string DataName;
        public static string DataInsertType;
        public static bool DataLoaded;
        public static string[] DateTimeTypeList = {
                            "yyyy/MM/dd hh:mm:ss tt",
                            "yyyy/M/d hh:mm:ss tt",
                            "yyyy/MM/dd tt hh:mm:ss",
                            "yyyy/M/d tt hh:mm:ss",
                            "yyyy/MM/dd HH:mm:ss",
                            "yyyy/M/d HH:mm:ss",
                            "yyyy/MM/dd",
                            "yyyy/M/d"
                        };

        Series SeriesX = new Series();
        Series SeriesY = new Series();
        Series SeriesZ = new Series();
        Dictionary<int, StripLine> StripLineCollections = new Dictionary<int, StripLine>();

        public Form1()
        {
            InitializeComponent();
            ChartInit();
        }

        /// <summary>
        /// Initial Chart Settings
        /// </summary>
        private void ChartInit()
        {
            chartZoomable(chartX);
            chartZoomable(chartY);
            chartZoomable(chartZ);
            chartStyleSetting(chartX);
            chartStyleSetting(chartY);
            chartStyleSetting(chartZ);
            chartX.ChartAreas[0].AxisY.Title = "X";
            chartY.ChartAreas[0].AxisY.Title = "Y";
            chartZ.ChartAreas[0].AxisY.Title = "Z";
        }

        private void chartStyleSetting(Chart chart)
        {
            chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.DashDotDot;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.DashDotDot;
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = SystemColors.ControlText;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = SystemColors.ControlText;
        }

        private void ChartStyleInit()
        {
            chartX.Series.Clear();
            chartY.Series.Clear();
            chartZ.Series.Clear();

            SeriesX = chartX.Series.Add(DataName + "X");
            SeriesY = chartY.Series.Add(DataName + "Y");
            SeriesZ = chartZ.Series.Add(DataName + "Z");

            SeriesX.ChartArea = chartX.ChartAreas[0].Name;
            SeriesX.Name = DataName + "X";
            SeriesY.ChartArea = chartY.ChartAreas[0].Name;
            SeriesY.Name = DataName + "Y";
            SeriesZ.ChartArea = chartZ.ChartAreas[0].Name;
            SeriesZ.Name = DataName + "Z";

            // Series Style Setting
            SeriesX.ChartType = SeriesChartType.FastLine;
            SeriesX.XValueType = ChartValueType.Time;
            SeriesY.ChartType = SeriesChartType.FastLine;
            SeriesY.XValueType = ChartValueType.Time;
            SeriesZ.ChartType = SeriesChartType.FastLine;
            SeriesZ.XValueType = ChartValueType.Time;
            SeriesX.Color = Color.BlueViolet;
            SeriesY.Color = Color.BlueViolet;
            SeriesZ.Color = Color.BlueViolet;

            
            chartX.ChartAreas[0].Axes[0].IntervalType = DateTimeIntervalType.Seconds;
            chartY.ChartAreas[0].Axes[0].IntervalType = DateTimeIntervalType.Seconds;
            chartZ.ChartAreas[0].Axes[0].IntervalType = DateTimeIntervalType.Seconds;

            // Set X tick time format to hh:mm:ss
            chartX.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";         //毫秒格式： hh:mm:ss.fff ，後面幾個f則保留幾位毫秒小數，此時要注意軸的最大值和最小值不要差太大
            chartX.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Milliseconds;
            chartX.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Milliseconds;
            chartY.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";         //毫秒格式： hh:mm:ss.fff ，後面幾個f則保留幾位毫秒小數，此時要注意軸的最大值和最小值不要差太大
            chartY.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Milliseconds;
            chartY.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Milliseconds;
            chartZ.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";         //毫秒格式： hh:mm:ss.fff ，後面幾個f則保留幾位毫秒小數，此時要注意軸的最大值和最小值不要差太大
            chartZ.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Milliseconds;
            chartZ.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Milliseconds;

            // Customize a title's appearance.
            chartX.Titles["Title1"].Font = new Font("Tahoma", 12, FontStyle.Bold);
            chartY.Titles["Title1"].Font = new Font("Tahoma", 12, FontStyle.Bold);
            chartZ.Titles["Title1"].Font = new Font("Tahoma", 12, FontStyle.Bold);

            // Define the text for the titles.
            chartX.Titles["Title1"].Text = DataName + " X";
            chartY.Titles["Title1"].Text = DataName + " Y";
            chartZ.Titles["Title1"].Text = DataName + " Z";
        }

        private void chartZoomable(Chart chart)
        {
            chart.Cursor = Cursors.SizeAll;
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].CursorX.IntervalType = DateTimeIntervalType.Milliseconds;
            chart.ChartAreas[0].CursorX.Interval = 1D;

            chart.ChartAreas[0].AxisX.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Milliseconds;
            chart.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 1D;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chart.ChartAreas[0].AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Milliseconds;
            chart.ChartAreas[0].AxisX.ScaleView.MinSize = 2D;

            chart.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Milliseconds;
            chart.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 1D;

            chart.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].CursorY.IntervalType = DateTimeIntervalType.Auto;
            chart.ChartAreas[0].CursorY.Interval = 0.000001;

            chart.ChartAreas[0].AxisY.ScaleView.SmallScrollSizeType = DateTimeIntervalType.Auto;
            chart.ChartAreas[0].AxisY.ScaleView.SmallScrollSize = 0.000001;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart.ChartAreas[0].AxisY.ScaleView.MinSizeType = DateTimeIntervalType.Auto;
            chart.ChartAreas[0].AxisY.ScaleView.MinSize = 0.000001;

            chart.ChartAreas[0].AxisY.ScaleView.SmallScrollMinSizeType = DateTimeIntervalType.Auto;
            chart.ChartAreas[0].AxisY.ScaleView.SmallScrollMinSize = 0.000001;
        }

        private void DataList_Initial()  //初始化Data
        {
            ListData_X.Clear();
            ListData_Y.Clear();
            ListData_Z.Clear();
            List_SelectedDataRange.Clear();
            List_DateTime.Clear();
        }

        private void InsertDataIntoChart()
        {
            chartX.Series[DataName + "X"].Points.DataBindXY(List_DateTime, ListData_X);
            chartY.Series[DataName + "Y"].Points.DataBindXY(List_DateTime, ListData_Y);
            chartZ.Series[DataName + "Z"].Points.DataBindXY(List_DateTime, ListData_Z);
        }

        private void ReadFeatureData(string[] FilesArray)
        {
            try
            {
                foreach (string FileName in FilesArray)
                {
                    //StreamReader SR_RawDataFile = new StreamReader(FileName);
                    var SR_RawDataFile = new StreamReader(File.OpenRead(FileName));

                    while (!SR_RawDataFile.EndOfStream)
                    {
                        string DataLine = SR_RawDataFile.ReadLine();
                        string[] Str_DataArray = DataLine.Split(',');

                        //DateTime NewDateTime = DateTime.ParseExact(Str_DataArray[1], DateTimeTypeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces);
                        DateTime NewDateTime = Convert.ToDateTime(Str_DataArray[1]);
                        List_DateTime.Add(NewDateTime);

                        ListData_X.Add(Convert.ToDouble(Str_DataArray[2]));
                        ListData_Y.Add(Convert.ToDouble(Str_DataArray[3]));
                        ListData_Z.Add(Convert.ToDouble(Str_DataArray[4]));
                    }
                }
            }

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Wrong Raw data txt format!!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #region StripLine功能
        private void AddStripLine(StripLine stripLine, double XValue)
        {
            stripLine.IntervalOffset = XValue;
            chartX.ChartAreas[0].AxisX.StripLines.Add(stripLine);
            chartY.ChartAreas[0].AxisX.StripLines.Add(stripLine);
            chartZ.ChartAreas[0].AxisX.StripLines.Add(stripLine);
        }

        private void SetStripLineStyle(StripLine stripLine, Color color, double Width, ChartDashStyle StripLineDashStyle)
        {
            stripLine.BackColor = color;
            stripLine.StripWidth = Width;
            stripLine.BorderDashStyle = StripLineDashStyle;
        }

        private void RemoveStripLine(StripLine stripLine)
        {
            chartX.ChartAreas[0].AxisX.StripLines.Remove(stripLine);
            chartY.ChartAreas[0].AxisX.StripLines.Remove(stripLine);
            chartZ.ChartAreas[0].AxisX.StripLines.Remove(stripLine);
        }

        #endregion
        #region 擷取Chart圖功能
        private void SetClipRectangle(Form form, Chart chart)
        {
            Bitmap bmpCanvas = new Bitmap(chart.Size.Width - 50, chart.Size.Height + 550);
            //(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);

            //取得畫布的繪圖物件用以繪圖。     
            Graphics g = Graphics.FromImage(bmpCanvas);
            g.CopyFromScreen(new Point(form.Location.X + 50, form.Location.Y + 40), new Point(0, 0), new Size(chart.Size.Width - 50, chart.Size.Height + 550));
            //(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height));
            IntPtr dc1 = g.GetHdc();
            g.ReleaseHdc(dc1);

            //將裁切出的矩形存成JPG圖檔。   
            Image imgCanvas = (Image)bmpCanvas;
            string str = @"C:\Users\adamchen\Desktop\工作進度\圖檔";

            Clipboard.SetImage(imgCanvas);
            imgCanvas.Save(str + "\\" + List_DateTime.First().ToString("yyyyMMddHHmmss") + "From" + dtPkrFrom.Value.ToString("HHmmss") + "To" + dtPkrTo.Value.ToString("HHmmss") + ".jpg");
        }
        #endregion
        #region OADateConverter

        public double[] ConvertDateTimetoCorrectOADate(List<DateTime> dateTimes)
        {
            double[] OADate = new double[dateTimes.Count];
            int i = 0;
            foreach (DateTime dateTime in dateTimes)
            {
                OADate[i] = dateTime.ToOADate() - Math.Truncate(dateTime.ToOADate());
                i++;
            }
            return OADate;
        }

        public double ConvertDateTimetoCorrectOADate(DateTime dateTime)
        {
            double OADate;
            OADate = dateTime.ToOADate() - Math.Truncate(dateTime.ToOADate());
            return OADate;
        }

        #endregion
        #region Reset Chart Axes
        private void ResetChartAxes(Chart chart, string axis)
        {
            if (axis == "X")
            {
                Axis AxisX = chart.ChartAreas[0].AxisX;
                ChartArea chartArea = chart.ChartAreas[0];
                AxisX.Maximum = Double.NaN; // sets the Maximum to NaN
                AxisX.Minimum = Double.NaN; // sets the Minimum to NaN
                chartArea.RecalculateAxesScale();
            }
            else if (axis == "Y")
            {
                Axis AxisY = chart.ChartAreas[0].AxisY;
                ChartArea chartArea = chart.ChartAreas[0];
                AxisY.Maximum = Double.NaN; // sets the Maximum to NaN
                AxisY.Minimum = Double.NaN; // sets the Minimum to NaN
                chartArea.RecalculateAxesScale();
            }
        }
        #endregion
        private void SetDateTimePickerValue(DateTime date)
        {
            dtPkrFrom.Value = date;
            dtPkrTo.Value = date;
            dtPkrTag.Value = date;
        }

        private void btnLoadCSVData_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog_SelectData = new OpenFileDialog();
            FileDialog_SelectData.InitialDirectory = "D:\\my docu";
            FileDialog_SelectData.Title = "Select Your Data";
            FileDialog_SelectData.Filter = "Csv Files (.csv)|*.csv|All Files(*.*)|*.*";
            FileDialog_SelectData.Multiselect = true;
            if (FileDialog_SelectData.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // Data initialization
            DataList_Initial();

            string[] FilePathArray = FileDialog_SelectData.FileNames;
            string FileName = FileDialog_SelectData.SafeFileName;
            DataName = FileName.Replace(".CSV", "");
            Array.Sort(FilePathArray);

            try
            {
                ChartStyleInit();
                ReadFeatureData(FilePathArray);
                InsertDataIntoChart();
                SetDateTimePickerValue(List_DateTime.First());
                DataLoaded = true;
                btnRestoreAxes_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTagTime_Click(object sender, EventArgs e)
        {
            StripLine stripLine = new StripLine();
            int StripLineCounts = StripLineCollections.Count();
            if (StripLineCollections.Count != 0)
            {
                if (StripLineCounts - 1 >= StripLineCollections.Keys.Max())
                {
                    StripLineCollections.Add(StripLineCounts, stripLine);
                    cmbTagSelect.Items.Add(StripLineCounts);
                }
                else
                {
                    StripLineCollections.Add(StripLineCollections.Keys.Max() + 1, stripLine);
                    cmbTagSelect.Items.Add(StripLineCollections.Keys.Max() + 1);
                }
            }
            else
            {
                StripLineCollections.Add(StripLineCounts, stripLine);
                cmbTagSelect.Items.Add(StripLineCounts);
            }
            SetStripLineStyle(stripLine, Color.LightGoldenrodYellow, 0.000002, ChartDashStyle.Solid);
            AddStripLine(stripLine, ConvertDateTimetoCorrectOADate(dtPkrTag.Value));
        }

        private void btnRestoreAxes_Click(object sender, EventArgs e)
        {
            chartX.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chartX.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chartY.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chartY.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chartZ.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            chartZ.ChartAreas[0].AxisX.ScaleView.ZoomReset();
        }

        private void btnFilterRange_Click(object sender, EventArgs e)
        {
            //chartX.ChartAreas[0].AxisX.Minimum = ConvertDateTimetoCorrectOADate(dtPkrFrom.Value);
            //chartX.ChartAreas[0].AxisX.Maximum = ConvertDateTimetoCorrectOADate(dtPkrTo.Value);
            //chartY.ChartAreas[0].AxisX.Minimum = ConvertDateTimetoCorrectOADate(dtPkrFrom.Value);
            //chartY.ChartAreas[0].AxisX.Maximum = ConvertDateTimetoCorrectOADate(dtPkrTo.Value);
            //chartZ.ChartAreas[0].AxisX.Minimum = ConvertDateTimetoCorrectOADate(dtPkrFrom.Value);
            //chartZ.ChartAreas[0].AxisX.Maximum = ConvertDateTimetoCorrectOADate(dtPkrTo.Value);
            chartX.ChartAreas[0].AxisX.ScaleView.Zoom(ConvertDateTimetoCorrectOADate(dtPkrFrom.Value), ConvertDateTimetoCorrectOADate(dtPkrTo.Value));
            chartY.ChartAreas[0].AxisX.ScaleView.Zoom(ConvertDateTimetoCorrectOADate(dtPkrFrom.Value), ConvertDateTimetoCorrectOADate(dtPkrTo.Value));
            chartZ.ChartAreas[0].AxisX.ScaleView.Zoom(ConvertDateTimetoCorrectOADate(dtPkrFrom.Value), ConvertDateTimetoCorrectOADate(dtPkrTo.Value));
            var xRangeStart = ConvertDateTimetoCorrectOADate(dtPkrFrom.Value);
            var xRangeEnd = ConvertDateTimetoCorrectOADate(dtPkrTo.Value);
            AutoScaleYAxisWhenXAxisZoomed(chartX, xRangeStart, xRangeEnd);
            AutoScaleYAxisWhenXAxisZoomed(chartY, xRangeStart, xRangeEnd);
            AutoScaleYAxisWhenXAxisZoomed(chartZ, xRangeStart, xRangeEnd);
        }

        private void btnSavePlot_Click(object sender, EventArgs e)
        {
            this.SetClipRectangle(this, chartX);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (DataLoaded)
            {
                ResetChartAxes(chartX, "X");
                ResetChartAxes(chartY, "X");
                ResetChartAxes(chartZ, "X");
            }
        }

        private void btnClearTags_Click(object sender, EventArgs e)
        {
            if (DataLoaded)
            {
                chartX.ChartAreas[0].AxisX.StripLines.Clear();
                chartY.ChartAreas[0].AxisX.StripLines.Clear();
                chartZ.ChartAreas[0].AxisX.StripLines.Clear();
                
                StripLineCollections.Clear();
                cmbTagSelect.Items.Clear();
            }
        }

        private void btnShiftTag_Click(object sender, EventArgs e)
        {
            DateTime ShiftedTagDateTime = new DateTime(dtPkrTag.Value.Year, dtPkrTag.Value.Month, dtPkrTag.Value.Day, 
                                                       dtPkrTag.Value.Hour, (int) nudMinutes.Value, (int) nudSeconds.Value);
            if (DataLoaded)
            {
                try
                {
                    RemoveStripLine(StripLineCollections[(int)cmbTagSelect.SelectedItem]);
                    AddStripLine(StripLineCollections[(int)cmbTagSelect.SelectedItem], ConvertDateTimetoCorrectOADate(ShiftedTagDateTime));
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            try
            {
                if (StripLineCollections.ContainsKey((int)cmbTagSelect.SelectedItem))
                {
                    RemoveStripLine(StripLineCollections[(int)cmbTagSelect.SelectedItem]);
                    StripLineCollections.Remove((int)cmbTagSelect.SelectedItem);
                    cmbTagSelect.Items.Remove(cmbTagSelect.SelectedItem);
                }
            }

            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {

        }

        #region Auto Scale Y axis If X Axis is zoomed
        private void chartX_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            var xRangeStart = e.Axis.ScaleView.ViewMinimum;
            var xRangeEnd = e.Axis.ScaleView.ViewMaximum;
            AutoScaleYAxisWhenXAxisZoomed(chartX, xRangeStart, xRangeEnd);
        }

        private void chartY_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            var xRangeStart = e.Axis.ScaleView.ViewMinimum;
            var xRangeEnd = e.Axis.ScaleView.ViewMaximum;
            AutoScaleYAxisWhenXAxisZoomed(chartY, xRangeStart, xRangeEnd);
        }

        private void chartZ_SelectionRangeChanged(object sender, CursorEventArgs e)
        {
            var xRangeStart = e.Axis.ScaleView.ViewMinimum;
            var xRangeEnd = e.Axis.ScaleView.ViewMaximum;
            AutoScaleYAxisWhenXAxisZoomed(chartZ, xRangeStart, xRangeEnd);
        }

        public static void AutoScaleYAxisWhenXAxisZoomed(Chart chart, double xRangeStart, double xRangeEnd)
        {
            var axisY = chart.ChartAreas[0].AxisY;

            // compute the Y values for the points crossing the range edges
            double? yRangeStart = null;
            var pointBeforeRangeStart = chart.Series[0].Points.FirstOrDefault(x => x.XValue <= xRangeStart);
            var pointAfterRangeStart = chart.Series[0].Points.FirstOrDefault(x => x.XValue > xRangeStart);
            if (pointBeforeRangeStart != null && pointAfterRangeStart != null)
                yRangeStart = Interpolate2Points(pointBeforeRangeStart, pointAfterRangeStart, xRangeStart);

            double? yRangeEnd = null;
            var pointBeforeRangeEnd = chart.Series[0].Points.FirstOrDefault(x => x.XValue <= xRangeEnd);
            var pointAfterRangeEnd = chart.Series[0].Points.FirstOrDefault(x => x.XValue > xRangeEnd);
            if (pointBeforeRangeEnd != null && pointAfterRangeEnd != null)
                yRangeEnd = Interpolate2Points(pointBeforeRangeEnd, pointAfterRangeEnd, xRangeEnd);

            var edgeValues = new[] { yRangeStart, yRangeEnd }.Where(x => x.HasValue).Select(x => x.Value);

            // find the points inside the range
            var valuesInRange = chart.Series[0].Points
            .Where(p => p.XValue >= xRangeStart && p.XValue <= xRangeEnd)
            .Select(x => x.YValues[0]);

            // find the minimum and maximum Y values
            var values = valuesInRange.Concat(edgeValues);
            double yMin;
            double yMax;
            if (values.Any())
            {
                yMin = values.Min();
                yMax = values.Max();
            }
            else
            {
                yMin = chart.Series[0].Points.Min(x => x.YValues[0]);
                yMax = chart.Series[0].Points.Max(x => x.YValues[0]);
            }

            // zoom Y-axis to [yMin - yMax]
            axisY.ScaleView.Zoom(yMin, yMax);
        }
        #endregion

        // see: http://en.wikipedia.org/wiki/Linear_interpolation#Linear_interpolation_between_two_known_points
        public static double Interpolate2Points(DataPoint p1, DataPoint p2, double x)
        {
            var x0 = p1.XValue;
            var y0 = p1.YValues[0];
            var x1 = p2.XValue;
            var y1 = p2.YValues[0];
            return y0 + ((x - x0) * y1 - (x - x0) * y0) / (x1 - x0);
        }
    }
}
