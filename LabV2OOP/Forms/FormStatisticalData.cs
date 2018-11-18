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
    public partial class FormStatisticalData : Form, IUpdate
    {

        List<double> acceptedTemp = new List<double>();
        List<double> acceptedPres = new List<double>();
        List<double> acceptedHumid = new List<double>();

        public FormStatisticalData()
        {
            InitializeComponent();
            chkBoxStats.Checked = false;
            txtBoxStats.Enabled = false;
        }

        private void RefreshLabels()
        {
            double avgTemp = CalculateAverage(acceptedTemp);
            double avgPres = CalculateAverage(acceptedPres);
            double avgHumid = CalculateAverage(acceptedHumid);

            lblTemp.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}",avgTemp, TemperatureChecker.TemperatureInstance.MinTemp, TemperatureChecker.TemperatureInstance.MaxTemp);
            lblPres.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", avgPres, PressureChecker.PressureInstance.MinPressure, PressureChecker.PressureInstance.MaxPressure);
            lblHumid.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", avgHumid, HumidityChecker.HumidityInstance.MinHumidity, HumidityChecker.HumidityInstance.MaxHumidity);
        }

        private double CalculateAverage(List<double> values)
        {
            int i = 0;
            int divisor = values.Count;
            if (chkBoxStats.Checked && values.Count > int.Parse(txtBoxStats.Text))
            {
                i = values.Count - int.Parse(txtBoxStats.Text);
                divisor = int.Parse(txtBoxStats.Text);
            }

            double sum = 0;

            for(; i<values.Count; i++)
                sum += values[i];
            return sum / divisor;
        }

        public void UpdateTemperature(double temp)
        {
            if (TemperatureChecker.TemperatureInstance.Check(temp))
            {
                txtBoxTemp.Text = temp.ToString();
                acceptedTemp.Add(temp);
                RefreshLabels();
            }
        }

        public void UpdatePressure(double press)
        {
            if (PressureChecker.PressureInstance.Check(press))
            {
                txtBoxPress.Text = press.ToString();
                acceptedPres.Add(press);
                RefreshLabels();
            }
        }

        public void UpdateHumidity(double humid)
        {
            if (HumidityChecker.HumidityInstance.Check(humid))
            {
                txtBoxMoist.Text = humid.ToString();
                acceptedHumid.Add(humid);
                RefreshLabels();
            }
        }

        private void txtBoxStats_TextChanged(object sender, EventArgs e)
        {
            if(ValidateStatCount())
                RefreshLabels();   
        }

        private void chkBoxStats_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxStats.Checked == false)
                RefreshLabels();
            else
                txtBoxStats.Enabled = true;
        }

        private bool ValidateStatCount()
        {
            int tmp;
            if (!int.TryParse(txtBoxStats.Text, out tmp))
            {
                errorStats.SetError(lblVrednost, "Unesite celobrojnu vrednost");
                return false;
            }
            else
            {
                errorStats.SetError(lblVrednost, null);
                return true;
            }
        }


        public void UpdateStandardValues()
        {
            RefreshLabels();
        }

    }
}
