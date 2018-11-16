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
    public partial class FormStatisticalData : Form, IChanges
    {

        List<double> acceptedTemp = new List<double>();
        List<double> acceptedPres = new List<double>();
        List<double> acceptedHumid = new List<double>();

        public FormStatisticalData()
        {
            InitializeComponent();
        }

        public void AcceptChanges(string temp, string pressure, string moisture)
        {
            txtBoxTemp.Text = temp;
            txtBoxPress.Text = pressure;
            txtBoxMoist.Text = moisture;
            acceptedTemp.Add(double.Parse(temp));
            acceptedPres.Add(double.Parse(pressure));
            acceptedHumid.Add(double.Parse(moisture));
            RefreshLabels();
        }

        private void RefreshLabels()
        {
            double avgTemp = CalculateAverage(acceptedTemp);
            double avgPres = CalculateAverage(acceptedPres);
            double avgHumid = CalculateAverage(acceptedHumid);

            lblTemp.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}",avgTemp, TemperatureValidator.TemperatureInstance.MinTemp, TemperatureValidator.TemperatureInstance.MaxTemp);
            lblPres.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", avgPres, PressureValidator.PressureInstance.MinPressure, PressureValidator.PressureInstance.MaxPressure);
            lblHumid.Text = String.Format("Avg: {0:0.00} Min: {1:0.00} Max: {2:0.00}", avgHumid, HumidityValidator.HumidityInstance.MinHumidity, HumidityValidator.HumidityInstance.MaxHumidity);
        }

        private double CalculateAverage(List<double> values)
        {
            double sum = 0;
            foreach (double val in values)
                sum += val;
            return sum / values.Count();
        }

    }
}
