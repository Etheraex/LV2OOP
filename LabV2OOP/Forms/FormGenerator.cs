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

        #region Init

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

        #endregion

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                LocalParent.SendChanges(txtBoxTemp.Text, txtBoxPressure.Text, txtBoxHumidity.Text);
            }
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

        public MainForm LocalParent { get; set; }

        #region Errorproviders

        private void txtBoxTemp_Validating(object sender, CancelEventArgs e)
        {
            double tmp;
            if (String.IsNullOrEmpty(txtBoxTemp.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxTemp, "Unesite temperaturu");
            }
            else if(!double.TryParse(txtBoxTemp.Text, out tmp))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxTemp, "Unesite temperaturu pravilno");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxTemp, null);
            }

        }

        private void txtBoxPressure_Validating(object sender, CancelEventArgs e)
        {
            double tmp;
            if (String.IsNullOrEmpty(txtBoxPressure.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxPressure, "Unesite pritisak");
            }
            else if (!double.TryParse(txtBoxPressure.Text, out tmp))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxPressure, "Unesite pritisak pravilno");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxPressure, null);
            }
        }

        private void txtBoxHumidity_Validating(object sender, CancelEventArgs e)
        {
            double tmp;
            if (String.IsNullOrEmpty(txtBoxHumidity.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxHumidity, "Unesite vlaznost");
            }
            else if (!double.TryParse(txtBoxHumidity.Text, out tmp))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxHumidity, "Unesite vlaznost pravilno");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxHumidity, null);
            }
        }

        #endregion
    }
}
