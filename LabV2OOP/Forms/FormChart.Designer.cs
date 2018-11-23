namespace LabV2OOP
{
    partial class FormChart
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
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataChart
            // 
            this.dataChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataChart.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea1.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dataChart.Legends.Add(legend1);
            this.dataChart.Location = new System.Drawing.Point(12, 12);
            this.dataChart.Name = "dataChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.dataChart.Series.Add(series1);
            this.dataChart.Size = new System.Drawing.Size(616, 293);
            this.dataChart.TabIndex = 0;
            this.dataChart.Text = "chart1";
            this.dataChart.DoubleClick += new System.EventHandler(this.dataChart_DoubleClick);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(37, 320);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(116, 17);
            this.chkLog.TabIndex = 1;
            this.chkLog.Text = "Logaritamski prikaz";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(640, 349);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.dataChart);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(656, 349);
            this.Name = "FormChart";
            this.Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private System.Windows.Forms.CheckBox chkLog;
    }
}