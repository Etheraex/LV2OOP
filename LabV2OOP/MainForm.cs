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

        public void SendChanges(String temp,String pressure, String humidity)
        {
            foreach (Form f in MdiChildren)
            {
                IChanges upd = f as IChanges;
                if (upd != null)
                    upd.AcceptChanges(temp,pressure,humidity);
            }
        }

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
