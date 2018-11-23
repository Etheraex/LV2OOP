namespace LabV2OOP
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFormGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFormChart = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFormStatisticalData = new System.Windows.Forms.ToolStripMenuItem();
            this.formChartTemperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formChartPressureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formChartHumidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(819, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFormGenerator,
            this.mmFormChart,
            this.mmFormStatisticalData});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mmFormGenerator
            // 
            this.mmFormGenerator.Name = "mmFormGenerator";
            this.mmFormGenerator.Size = new System.Drawing.Size(180, 22);
            this.mmFormGenerator.Text = "FormGenerator";
            this.mmFormGenerator.Click += new System.EventHandler(this.mmFormGenerator_Click);
            // 
            // mmFormChart
            // 
            this.mmFormChart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formChartTemperatureToolStripMenuItem,
            this.formChartPressureToolStripMenuItem,
            this.formChartHumidityToolStripMenuItem});
            this.mmFormChart.Name = "mmFormChart";
            this.mmFormChart.Size = new System.Drawing.Size(180, 22);
            this.mmFormChart.Text = "FormChart";
            // 
            // mmFormStatisticalData
            // 
            this.mmFormStatisticalData.Name = "mmFormStatisticalData";
            this.mmFormStatisticalData.Size = new System.Drawing.Size(180, 22);
            this.mmFormStatisticalData.Text = "FormStatisticalData";
            this.mmFormStatisticalData.Click += new System.EventHandler(this.mmFormStatisticalData_Click);
            // 
            // formChartTemperatureToolStripMenuItem
            // 
            this.formChartTemperatureToolStripMenuItem.Name = "formChartTemperatureToolStripMenuItem";
            this.formChartTemperatureToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.formChartTemperatureToolStripMenuItem.Text = "FormChart Temperature";
            this.formChartTemperatureToolStripMenuItem.Click += new System.EventHandler(this.formChartTemperatureToolStripMenuItem_Click);
            // 
            // formChartPressureToolStripMenuItem
            // 
            this.formChartPressureToolStripMenuItem.Name = "formChartPressureToolStripMenuItem";
            this.formChartPressureToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.formChartPressureToolStripMenuItem.Text = "FormChart Pressure";
            this.formChartPressureToolStripMenuItem.Click += new System.EventHandler(this.formChartPressureToolStripMenuItem_Click);
            // 
            // formChartHumidityToolStripMenuItem
            // 
            this.formChartHumidityToolStripMenuItem.Name = "formChartHumidityToolStripMenuItem";
            this.formChartHumidityToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.formChartHumidityToolStripMenuItem.Text = "FormChart Pressure";
            this.formChartHumidityToolStripMenuItem.Click += new System.EventHandler(this.formChartHumidityToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmFormGenerator;
        private System.Windows.Forms.ToolStripMenuItem mmFormChart;
        private System.Windows.Forms.ToolStripMenuItem mmFormStatisticalData;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem formChartTemperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formChartPressureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formChartHumidityToolStripMenuItem;
    }
}

