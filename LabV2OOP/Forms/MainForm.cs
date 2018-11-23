using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabV2OOP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void SendChanges(double temperature, double pressure, double humidity)
        {
            foreach(Form f in MdiChildren)
            {
                IUpdate upd = f as IUpdate;
                if(upd != null)
                    upd.Update(temperature, pressure,humidity);
            }
        }

        private void mmFormGenerator_Click(object sender, EventArgs e)
        {
            FormGenerator fm = new FormGenerator(this);
            fm.MdiParent = this;
            fm.Show();
        }

        private void CreateChart(String type)
        {
            FormN fn = new FormN(type);
            fn.MdiParent = this;
            fn.LocalParent = this;
            fn.Show();
        }

        private void mmFormStatisticalData_Click(object sender, EventArgs e)
        {
            FormStatisticalData fsd = new FormStatisticalData();
            fsd.MdiParent = this;
            fsd.Show();
        }

        public void EnablePressureTextBoxes()
        {
            foreach(Form f in MdiChildren)
            {
                FormGenerator fg = f as FormGenerator;
                if(fg != null)
                    fg.EnableTextBoxPressure();
            }
        }

        public void EnableTemperatureTextBoxes()
        {
            foreach (Form f in MdiChildren)
            {
                FormGenerator fg = f as FormGenerator;
                if(fg != null)
                    fg.EnableTextBoxTemperature();
            }
        }

        public void EnableHumidityTextBoxes()
        {
            foreach (Form f in MdiChildren)
            {
                FormGenerator fg = f as FormGenerator;
                if(fg != null)
                    fg.EnableTextBoxHumidity();
            }
        }

        private void formChartTemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateChart("Temperature");
        }

        private void formChartPressureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateChart("Pressure");
        }

        private void formChartHumidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateChart("Humidity");
        }
    }
}
