namespace ChartTimeTagger
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadCSVData = new System.Windows.Forms.Button();
            this.grpbTimeTagger = new System.Windows.Forms.GroupBox();
            this.cmbTagSelect = new System.Windows.Forms.ComboBox();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.dtPkrTag = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnShiftTag = new System.Windows.Forms.Button();
            this.btnClearTags = new System.Windows.Forms.Button();
            this.btnTagTime = new System.Windows.Forms.Button();
            this.btnRestoreAxes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpbDataRangeSelector = new System.Windows.Forms.GroupBox();
            this.dtPkrTo = new System.Windows.Forms.DateTimePicker();
            this.dtPkrFrom = new System.Windows.Forms.DateTimePicker();
            this.btnFilterRange = new System.Windows.Forms.Button();
            this.btnSavePlot = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            this.grpbTimeTagger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpbDataRangeSelector.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartX);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 409);
            this.panel1.TabIndex = 0;
            // 
            // chartX
            // 
            this.chartX.BackColor = System.Drawing.Color.Silver;
            this.chartX.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartX.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartX.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.chartX.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartX.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartX.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.LabelStyle.Format = "N1";
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.SystemColors.ControlDark;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Silver;
            this.chartX.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartX.Legends.Add(legend1);
            this.chartX.Location = new System.Drawing.Point(3, 3);
            this.chartX.Name = "chartX";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chartX.Series.Add(series1);
            this.chartX.Size = new System.Drawing.Size(1308, 402);
            this.chartX.TabIndex = 0;
            this.chartX.Text = "chartX";
            title1.Name = "Title1";
            this.chartX.Titles.Add(title1);
            this.chartX.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartX_SelectionRangeChanged);
            // 
            // btnLoadCSVData
            // 
            this.btnLoadCSVData.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoadCSVData.Location = new System.Drawing.Point(5, 10);
            this.btnLoadCSVData.Name = "btnLoadCSVData";
            this.btnLoadCSVData.Size = new System.Drawing.Size(307, 43);
            this.btnLoadCSVData.TabIndex = 1;
            this.btnLoadCSVData.Text = "選取CSV Data";
            this.btnLoadCSVData.UseVisualStyleBackColor = true;
            this.btnLoadCSVData.Click += new System.EventHandler(this.btnLoadCSVData_Click);
            // 
            // grpbTimeTagger
            // 
            this.grpbTimeTagger.Controls.Add(this.cmbTagSelect);
            this.grpbTimeTagger.Controls.Add(this.lblMinute);
            this.grpbTimeTagger.Controls.Add(this.lblSeconds);
            this.grpbTimeTagger.Controls.Add(this.nudSeconds);
            this.grpbTimeTagger.Controls.Add(this.nudMinutes);
            this.grpbTimeTagger.Controls.Add(this.dtPkrTag);
            this.grpbTimeTagger.Controls.Add(this.btnRemoveTag);
            this.grpbTimeTagger.Controls.Add(this.btnShiftTag);
            this.grpbTimeTagger.Controls.Add(this.btnClearTags);
            this.grpbTimeTagger.Controls.Add(this.btnTagTime);
            this.grpbTimeTagger.Location = new System.Drawing.Point(331, 10);
            this.grpbTimeTagger.Name = "grpbTimeTagger";
            this.grpbTimeTagger.Size = new System.Drawing.Size(490, 137);
            this.grpbTimeTagger.TabIndex = 2;
            this.grpbTimeTagger.TabStop = false;
            this.grpbTimeTagger.Text = "Time Tagger";
            // 
            // cmbTagSelect
            // 
            this.cmbTagSelect.FormattingEnabled = true;
            this.cmbTagSelect.Location = new System.Drawing.Point(309, 86);
            this.cmbTagSelect.Name = "cmbTagSelect";
            this.cmbTagSelect.Size = new System.Drawing.Size(62, 26);
            this.cmbTagSelect.TabIndex = 4;
            this.cmbTagSelect.Text = "Tag";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(16, 89);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(31, 18);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "分:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(119, 89);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(31, 18);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "秒:";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(151, 85);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(60, 29);
            this.nudSeconds.TabIndex = 2;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(50, 85);
            this.nudMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(60, 29);
            this.nudMinutes.TabIndex = 2;
            this.nudMinutes.ValueChanged += new System.EventHandler(this.nudMinutes_ValueChanged);
            // 
            // dtPkrTag
            // 
            this.dtPkrTag.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPkrTag.Location = new System.Drawing.Point(20, 34);
            this.dtPkrTag.Name = "dtPkrTag";
            this.dtPkrTag.Size = new System.Drawing.Size(191, 29);
            this.dtPkrTag.TabIndex = 0;
            this.dtPkrTag.Value = new System.DateTime(2020, 10, 14, 0, 0, 0, 0);
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnRemoveTag.Location = new System.Drawing.Point(380, 82);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(92, 36);
            this.btnRemoveTag.TabIndex = 1;
            this.btnRemoveTag.Text = "Remove";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.Click += new System.EventHandler(this.btnRemoveTag_Click);
            // 
            // btnShiftTag
            // 
            this.btnShiftTag.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnShiftTag.Location = new System.Drawing.Point(221, 82);
            this.btnShiftTag.Name = "btnShiftTag";
            this.btnShiftTag.Size = new System.Drawing.Size(77, 36);
            this.btnShiftTag.TabIndex = 1;
            this.btnShiftTag.Text = "Shift";
            this.btnShiftTag.UseVisualStyleBackColor = true;
            this.btnShiftTag.Click += new System.EventHandler(this.btnShiftTag_Click);
            // 
            // btnClearTags
            // 
            this.btnClearTags.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnClearTags.Location = new System.Drawing.Point(309, 31);
            this.btnClearTags.Name = "btnClearTags";
            this.btnClearTags.Size = new System.Drawing.Size(163, 36);
            this.btnClearTags.TabIndex = 1;
            this.btnClearTags.Text = "Clear";
            this.btnClearTags.UseVisualStyleBackColor = true;
            this.btnClearTags.Click += new System.EventHandler(this.btnClearTags_Click);
            // 
            // btnTagTime
            // 
            this.btnTagTime.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnTagTime.Location = new System.Drawing.Point(221, 31);
            this.btnTagTime.Name = "btnTagTime";
            this.btnTagTime.Size = new System.Drawing.Size(77, 36);
            this.btnTagTime.TabIndex = 1;
            this.btnTagTime.Text = "Tag";
            this.btnTagTime.UseVisualStyleBackColor = true;
            this.btnTagTime.Click += new System.EventHandler(this.btnTagTime_Click);
            // 
            // btnRestoreAxes
            // 
            this.btnRestoreAxes.Location = new System.Drawing.Point(5, 64);
            this.btnRestoreAxes.Name = "btnRestoreAxes";
            this.btnRestoreAxes.Size = new System.Drawing.Size(142, 39);
            this.btnRestoreAxes.TabIndex = 1;
            this.btnRestoreAxes.Text = "Restore Axes";
            this.btnRestoreAxes.UseVisualStyleBackColor = true;
            this.btnRestoreAxes.Click += new System.EventHandler(this.btnRestoreAxes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpbDataRangeSelector);
            this.panel2.Controls.Add(this.grpbTimeTagger);
            this.panel2.Controls.Add(this.btnSavePlot);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnRestoreAxes);
            this.panel2.Controls.Add(this.btnLoadCSVData);
            this.panel2.Location = new System.Drawing.Point(12, 1253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 150);
            this.panel2.TabIndex = 3;
            // 
            // grpbDataRangeSelector
            // 
            this.grpbDataRangeSelector.Controls.Add(this.dtPkrTo);
            this.grpbDataRangeSelector.Controls.Add(this.dtPkrFrom);
            this.grpbDataRangeSelector.Controls.Add(this.btnFilterRange);
            this.grpbDataRangeSelector.Location = new System.Drawing.Point(833, 10);
            this.grpbDataRangeSelector.Name = "grpbDataRangeSelector";
            this.grpbDataRangeSelector.Size = new System.Drawing.Size(480, 129);
            this.grpbDataRangeSelector.TabIndex = 3;
            this.grpbDataRangeSelector.TabStop = false;
            this.grpbDataRangeSelector.Text = "Data Range Selector";
            // 
            // dtPkrTo
            // 
            this.dtPkrTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPkrTo.Location = new System.Drawing.Point(22, 82);
            this.dtPkrTo.Name = "dtPkrTo";
            this.dtPkrTo.Size = new System.Drawing.Size(272, 29);
            this.dtPkrTo.TabIndex = 2;
            this.dtPkrTo.Value = new System.DateTime(2020, 10, 14, 0, 0, 0, 0);
            // 
            // dtPkrFrom
            // 
            this.dtPkrFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPkrFrom.Location = new System.Drawing.Point(22, 35);
            this.dtPkrFrom.Name = "dtPkrFrom";
            this.dtPkrFrom.Size = new System.Drawing.Size(272, 29);
            this.dtPkrFrom.TabIndex = 0;
            this.dtPkrFrom.Value = new System.DateTime(2020, 10, 14, 0, 0, 0, 0);
            // 
            // btnFilterRange
            // 
            this.btnFilterRange.Font = new System.Drawing.Font("新細明體", 10F);
            this.btnFilterRange.Location = new System.Drawing.Point(316, 34);
            this.btnFilterRange.Name = "btnFilterRange";
            this.btnFilterRange.Size = new System.Drawing.Size(140, 77);
            this.btnFilterRange.TabIndex = 1;
            this.btnFilterRange.Text = "Filter";
            this.btnFilterRange.UseVisualStyleBackColor = true;
            this.btnFilterRange.Click += new System.EventHandler(this.btnFilterRange_Click);
            // 
            // btnSavePlot
            // 
            this.btnSavePlot.Location = new System.Drawing.Point(5, 108);
            this.btnSavePlot.Name = "btnSavePlot";
            this.btnSavePlot.Size = new System.Drawing.Size(307, 39);
            this.btnSavePlot.TabIndex = 1;
            this.btnSavePlot.Text = "Save Plot";
            this.btnSavePlot.UseVisualStyleBackColor = true;
            this.btnSavePlot.Click += new System.EventHandler(this.btnSavePlot_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(170, 64);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(142, 39);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartY);
            this.panel3.Location = new System.Drawing.Point(12, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1314, 409);
            this.panel3.TabIndex = 4;
            // 
            // chartY
            // 
            this.chartY.BackColor = System.Drawing.Color.Silver;
            this.chartY.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartY.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartY.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.chartY.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartY.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartY.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.LabelStyle.Format = "N1";
            chartArea2.BackColor = System.Drawing.Color.Silver;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.SystemColors.ControlDark;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Silver;
            this.chartY.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartY.Legends.Add(legend2);
            this.chartY.Location = new System.Drawing.Point(3, 3);
            this.chartY.Name = "chartY";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chartY.Series.Add(series2);
            this.chartY.Size = new System.Drawing.Size(1308, 402);
            this.chartY.TabIndex = 0;
            this.chartY.Text = "chartY";
            title2.Name = "Title1";
            this.chartY.Titles.Add(title2);
            this.chartY.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartY_SelectionRangeChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chartZ);
            this.panel4.Location = new System.Drawing.Point(12, 838);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1314, 409);
            this.panel4.TabIndex = 5;
            // 
            // chartZ
            // 
            this.chartZ.BackColor = System.Drawing.Color.Silver;
            this.chartZ.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartZ.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            this.chartZ.BorderSkin.BackColor = System.Drawing.Color.Silver;
            this.chartZ.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartZ.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartZ.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisY.LabelStyle.Format = "N1";
            chartArea3.BackColor = System.Drawing.Color.Silver;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.SystemColors.ControlDark;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Silver;
            this.chartZ.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chartZ.Legends.Add(legend3);
            this.chartZ.Location = new System.Drawing.Point(3, 3);
            this.chartZ.Name = "chartZ";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chartZ.Series.Add(series3);
            this.chartZ.Size = new System.Drawing.Size(1308, 402);
            this.chartZ.TabIndex = 0;
            this.chartZ.Text = "chartZ";
            title3.Name = "Title1";
            this.chartZ.Titles.Add(title3);
            this.chartZ.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartZ_SelectionRangeChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1411);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            this.grpbTimeTagger.ResumeLayout(false);
            this.grpbTimeTagger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpbDataRangeSelector.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.Button btnLoadCSVData;
        private System.Windows.Forms.GroupBox grpbTimeTagger;
        private System.Windows.Forms.DateTimePicker dtPkrTag;
        private System.Windows.Forms.Button btnTagTime;
        private System.Windows.Forms.Button btnRestoreAxes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpbDataRangeSelector;
        private System.Windows.Forms.DateTimePicker dtPkrTo;
        private System.Windows.Forms.DateTimePicker dtPkrFrom;
        private System.Windows.Forms.Button btnFilterRange;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZ;
        private System.Windows.Forms.Button btnSavePlot;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Button btnShiftTag;
        private System.Windows.Forms.Button btnClearTags;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbTagSelect;
        private System.Windows.Forms.Button btnRemoveTag;
    }
}

