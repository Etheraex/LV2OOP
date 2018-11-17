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
            bool chkBox = chkBoxGranice.Checked;
            if (ValidateTemperature())
            {
                if (txtBoxTemp.Text != "" && ( chkBox || TemperatureValidator.TemperatureInstance.Validate(double.Parse(txtBoxTemp.Text))))
                    LocalParent.SendTemperatureChange(double.Parse(txtBoxTemp.Text));
            }

            if (ValidatePressure())
            {
                if (txtBoxPressure.Text != "" && (chkBox || PressureValidator.PressureInstance.Validate(double.Parse(txtBoxPressure.Text))))
                    LocalParent.SendPressureChange(double.Parse(txtBoxPressure.Text));
            }

            if (ValidateHumidity())
            {
                if (txtBoxHumidity.Text != "" && (chkBox || HumidityValidator.HumidityInstance.Validate(double.Parse(txtBoxHumidity.Text))))
                    LocalParent.SendHumidityChange(double.Parse(txtBoxHumidity.Text));
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

        public bool ValidateHumidity()
        {
            double tmp;
            if (String.IsNullOrEmpty(txtBoxHumidity.Text))
            {
                errorProvider.SetError(txtBoxHumidity, "Unesite vlaznost");
                return false;
            }
            else if (!double.TryParse(txtBoxHumidity.Text, out tmp))
            {
                errorProvider.SetError(txtBoxHumidity, "Unesite vlaznost pravilno");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxHumidity, null);
                return true;
            }
        }

        public bool ValidatePressure()
        {
            double tmp;
            if (String.IsNullOrEmpty(txtBoxPressure.Text))
            {
                errorProvider.SetError(txtBoxPressure, "Unesite Pressure");
                return false;
            }
            else if (!double.TryParse(txtBoxPressure.Text, out tmp))
            {
                errorProvider.SetError(txtBoxPressure, "Unesite Pressure pravilno");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxPressure, null);
                return true;
            }
        }

        public bool ValidateTemperature()
        {
            double tmp;
            if (String.IsNullOrEmpty(txtBoxTemp.Text))
            {
                errorProvider.SetError(txtBoxTemp, "Unesite Temperature");
                return false;
            }
            else if (!double.TryParse(txtBoxTemp.Text, out tmp))
            {
                errorProvider.SetError(txtBoxTemp, "Unesite Temperature pravilno");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxTemp, null);
                return true;
            }
        }

        #endregion
    }
}
