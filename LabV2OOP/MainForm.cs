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

        private void mmFormGenerator_Click(object sender, EventArgs e)
        {
            FormGenerator fm = new FormGenerator();
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
