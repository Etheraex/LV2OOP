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
            RefreshLabels();
        }

        private void RefreshLabels()
        {
            CheckArrays();
            lblTemp.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", CalculateAverage(acceptedTemp), findMin(acceptedTemp), findMax(acceptedTemp));
            lblPres.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", CalculateAverage(acceptedPres), findMin(acceptedPres), findMax(acceptedPres));
            lblHumid.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", CalculateAverage(acceptedHumid), findMin(acceptedHumid), findMax(acceptedHumid));
        }

        private void CheckArrays()
        {
            for (int i = 0; i < acceptedTemp.Count(); i++)
                if (!TemperatureChecker.TemperatureInstance.Check(acceptedTemp[i]))
                {
                    acceptedTemp.RemoveAt(i);
                    i--;
                }
            for (int i = 0; i < acceptedPres.Count(); i++)
                if (!PressureChecker.PressureInstance.Check(acceptedPres[i]))
                {
                    acceptedPres.RemoveAt(i);
                    i--;
                }
            for (int i = 0; i < acceptedHumid.Count(); i++)
                if (!HumidityChecker.HumidityInstance.Check(acceptedHumid[i]))
                {
                    acceptedHumid.RemoveAt(i);
                    i--;
                }
        }

        private double CalculateAverage(List<double> values)
        {
            if (values.Any())
            {
                int i = 0;
                int divisor = values.Count;
                if (chkBoxStats.Checked && values.Count > int.Parse(txtBoxStats.Text))
                {
                    i = values.Count - int.Parse(txtBoxStats.Text);
                    divisor = int.Parse(txtBoxStats.Text);
                }

                double sum = 0;

                for (; i < values.Count; i++)
                    sum += values[i];
                return sum / divisor;
            }
            return 0.00;
        }

        private double findMin(List<double> values)
        {
            if (values.Any())
            {
                int i = 0;
                if (chkBoxStats.Checked && values.Count > int.Parse(txtBoxStats.Text))
                    i = values.Count() - int.Parse(txtBoxStats.Text);
                double min = values[i];
                for (; i < values.Count; i++)
                {
                    if (min > values[i])
                        min = values[i];
                }
                return min;
            }
            return 0.00;
        }

        private double findMax(List<double> values)
        {
            if (values.Any())
            {
                int i = 0;
                if (chkBoxStats.Checked && values.Count > int.Parse(txtBoxStats.Text))
                    i = values.Count() - int.Parse(txtBoxStats.Text);
                double max = values[i];
                for (; i < values.Count; i++)
                {
                    if (max < values[i])
                        max = values[i];
                }
                return max;
            }
            return 0.00;
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
            {
                RefreshLabels();
                txtBoxStats.Enabled = false;
                txtBoxStats.Text = "";
            }
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
