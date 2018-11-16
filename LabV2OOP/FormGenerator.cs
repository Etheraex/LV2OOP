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
    public partial class FormGenerator : Form
    {
        public FormGenerator(MainForm parent)
        {
            InitializeComponent();
            LocalParent = parent;
            if (!TemperatureValidator.TemperatureInstance.ValuesSet())
                txtBoxTemp.Enabled = false;
            if (!PressureValidator.PressureInstance.ValuesSet())
                txtBoxPressure.Enabled = false;
            if (!HumidityValidator.HumidityInstance.ValuesSet())
                txtBoxHumidity.Enabled = false;

        }

        public MainForm LocalParent { get; set; }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtBoxHumidity.Text);
            if(HumidityValidator.HumidityInstance.Validate(x))
                LocalParent.SendChanges(txtBoxTemp.Text,txtBoxPressure.Text,txtBoxHumidity.Text);
        }

        private DialogResult CreateStandardValueForm(IValidate val, String text)
        {
            StandardValueForm stf = new StandardValueForm(val, text);
            return stf.ShowDialog();
        }

        private void btnPressure_Click(object sender, EventArgs e)
        {
            DialogResult dr = CreateStandardValueForm(PressureValidator.PressureInstance, "Standardne vrednosti pritiska");
            if (dr == DialogResult.OK)
                txtBoxPressure.Enabled = true;
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            DialogResult dr = CreateStandardValueForm(TemperatureValidator.TemperatureInstance, "Standardne vrednosti temperature");
            if (dr == DialogResult.OK)
                txtBoxTemp.Enabled = true;
        }

        private void btnHumidity_Click(object sender, EventArgs e)
        {
            DialogResult dr = CreateStandardValueForm(HumidityValidator.HumidityInstance, "Standardne vrednosti vlaznosti");
            if (dr == DialogResult.OK)
                txtBoxHumidity.Enabled = true;
        }
    }
}
