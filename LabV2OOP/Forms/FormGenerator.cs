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
            if (!TemperatureChecker.TemperatureInstance.ValuesSet())
                txtBoxTemp.Enabled = false;
            if (!PressureChecker.PressureInstance.ValuesSet())
                txtBoxPressure.Enabled = false;
            if (!HumidityChecker.HumidityInstance.ValuesSet())
                txtBoxHumidity.Enabled = false;
            txtBoxInterval.Enabled = false;
        }

        #endregion

        #region OtherFormsInit

        private DialogResult CreateStandardValueForm(ICheckStandard val, String text)
        {
            StandardValueForm stf = new StandardValueForm(val, text);
            return stf.ShowDialog();
        }

        private void btnPressure_Click(object sender, EventArgs e)
        {
            DialogResult dr = CreateStandardValueForm(PressureChecker.PressureInstance, "Standardne vrednosti pritiska");
            if (dr == DialogResult.OK)
            {
                LocalParent.EnablePressureTextBoxes();
                LocalParent.SendChanges(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            DialogResult dr = CreateStandardValueForm(TemperatureChecker.TemperatureInstance, "Standardne vrednosti temperature");
            if (dr == DialogResult.OK)
            {
                LocalParent.EnableTemperatureTextBoxes();
                LocalParent.SendChanges(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
            }
        }

        private void btnHumidity_Click(object sender, EventArgs e)
        {
            DialogResult dr = CreateStandardValueForm(HumidityChecker.HumidityInstance, "Standardne vrednosti vlaznosti");
            if (dr == DialogResult.OK)
            {
                LocalParent.EnableHumidityTextBoxes();
                LocalParent.SendChanges(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
            }
        }

        #endregion

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            Prosledi();
        }

        private void Prosledi()
        {
            double temperature = double.NegativeInfinity;
            double pressure = double.NegativeInfinity;
            double humidity = double.NegativeInfinity;
            
            bool chkBox = chkBoxGranice.Checked;
            if (ValidateTemperature())
            {
                if (txtBoxTemp.Text != "" && (chkBox || TemperatureChecker.TemperatureInstance.Check(double.Parse(txtBoxTemp.Text))))
                    temperature = double.Parse(txtBoxTemp.Text);
            }

            if (ValidatePressure())
            {
                if (txtBoxPressure.Text != "" && (chkBox || PressureChecker.PressureInstance.Check(double.Parse(txtBoxPressure.Text))))
                    pressure = double.Parse(txtBoxPressure.Text);
            }

            if (ValidateHumidity())
            {
                if (txtBoxHumidity.Text != "" && (chkBox || HumidityChecker.HumidityInstance.Check(double.Parse(txtBoxHumidity.Text))))
                    humidity = double.Parse(txtBoxHumidity.Text);
            }
            LocalParent.SendChanges(temperature, pressure, humidity);
        }

        public MainForm LocalParent { get; set; }

        #region Errorproviders

        public bool ValidateHumidity()
        {
            double tmp;
            if (!txtBoxHumidity.Enabled)
            {
                errorProvider.SetError(txtBoxHumidity, null);
                return false;
            }
            else if (String.IsNullOrEmpty(txtBoxHumidity.Text))
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
            if (!txtBoxPressure.Enabled)
            {
                errorProvider.SetError(txtBoxPressure, null);
                return false;
            }
            else if (String.IsNullOrEmpty(txtBoxPressure.Text))
            {
                errorProvider.SetError(txtBoxPressure, "Unesite pritisak");
                return false;
            }
            else if (!double.TryParse(txtBoxPressure.Text, out tmp))
            {
                errorProvider.SetError(txtBoxPressure, "Unesite pritisak pravilno");
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
            if (!txtBoxTemp.Enabled)
            {
                errorProvider.SetError(txtBoxTemp, null);
                return false;
            }
            else if (String.IsNullOrEmpty(txtBoxTemp.Text))
            {
                errorProvider.SetError(txtBoxTemp, "Unesite temperaturu");
                return false;
            }
            else if (!double.TryParse(txtBoxTemp.Text, out tmp))
            {
                errorProvider.SetError(txtBoxTemp, "Unesite temperaturu pravilno");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxTemp, null);
                return true;
            }
        }

        private bool ValidateInterval()
        {
            int interval;
            if(!int.TryParse(txtBoxInterval.Text,out interval))
            {
                errorProvider.SetError(txtBoxInterval, "Vreme u sekundama 1-9");
                return false;
            }
            else if(interval < 1 || interval > 9)
            {
                errorProvider.SetError(txtBoxInterval, "Samo izmedju 1-9");
                return false;
            }
            else
            {
                errorProvider.SetError(txtBoxInterval, null);
                return true;
            }
        }

        #endregion

        private void chkBoxAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAutomatic.Checked)
            {
                btnProsledi.Enabled = false;
                txtBoxInterval.Enabled = true;
            }
            else
            {
                timer.Stop();
                btnProsledi.Enabled = true;
                txtBoxInterval.Text = "";
                txtBoxInterval.Enabled = false;
            }
        }

        private void timerInit(int x)
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = x * 1000;
        }

        private void txtBoxInterval_TextChanged(object sender, EventArgs e)
        {
            if (chkBoxAutomatic.Checked && ValidateInterval())
            {
                timerInit(int.Parse(txtBoxInterval.Text));
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Prosledi();
        }

        public void EnableTextBoxPressure()
        {
            txtBoxPressure.Enabled = true;
        }

        public void EnableTextBoxTemperature()
        {
            txtBoxTemp.Enabled = true;
        }

        public void EnableTextBoxHumidity()
        {
            txtBoxHumidity.Enabled = true;
        }
    }
}
