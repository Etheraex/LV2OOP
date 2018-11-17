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

        #region Changes

        public void SendTemperatureChange(double par)
        {
            foreach (Form f in MdiChildren)
            {
                IUpdate upd = f as IUpdate;
                if (upd != null)
                {
                    upd.UpdateTemperature(par);
                }
            }
        }

        public void SendPressureChange(double par)
        {
            foreach (Form f in MdiChildren)
            {
                IUpdate upd = f as IUpdate;
                if (upd != null)
                {
                    upd.UpdatePressure(par);
                }
            }
        }

        public void SendHumidityChange(double par)
        {
            foreach (Form f in MdiChildren)
            {
                IUpdate upd = f as IUpdate;
                if (upd != null)
                {
                    upd.UpdateHumidity(par);
                }
            }
        }

        #endregion

        private void mmFormGenerator_Click(object sender, EventArgs e)
        {
            FormGenerator fm = new FormGenerator(this);
            fm.MdiParent = this;
            fm.Show();
        }

        private void mmFormChart_Click(object sender, EventArgs e)
        {
            FormChart fc = new FormChart();
            fc.MdiParent = this;
            fc.Show();
        }

        private void mmFormStatisticalData_Click(object sender, EventArgs e)
        {
            FormStatisticalData fsd = new FormStatisticalData();
            fsd.MdiParent = this;
            fsd.Show();
        }
    }
}
