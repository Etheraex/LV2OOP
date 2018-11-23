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
    public partial class FormChart : Form,IUpdate
    {
        public Form LocalParent { get; set; }
        private List<double> _dataList = new List<double>();
        private List<DateTime> _timeList = new List<DateTime>();
        private String _type;
        private int _lastN;

        public List<double> LogList(List<double> data)
        {
                List<double> logDataList = new List<double>();
                foreach (double item in data)
                {
                    if(item > 0)
                        logDataList.Add(Math.Log10(item));
                }
                return logDataList;
        }

        public FormChart(String type, int lastN)
        {
            InitializeComponent();
            _type = type;
            _lastN = lastN;
            this.Text = type;
            dataChart.DataSource = _dataList;
            dataChart.DataBind();
            dataChart.Series[0].Name = _type;
            dataChart.Series[0].YValueMembers = "Value";
        }

        public void Update(double temperature, double pressure, double humidity)
        {
            if(_type == "Temperature" && temperature != double.NegativeInfinity)
            {
                _dataList.Add(temperature);
                _timeList.Add(DateTime.Now);
                this.Text = temperature.ToString();
            }
            else if (_type == "Pressure" && pressure != double.NegativeInfinity)
            {
                _dataList.Add(pressure);

                _timeList.Add(DateTime.Now);
                this.Text = pressure.ToString();
            }
            else if (_type == "Humidity" && humidity != double.NegativeInfinity)
            {
                _dataList.Add(humidity);

                _timeList.Add(DateTime.Now);
                this.Text = humidity.ToString();
            }
            RefreshChart();
        }

        private void RefreshChart()
        {
            List<double> forChartDataSource = new List<double>();
            int count = 0;
            if (_lastN < _dataList.Count)
                count = _dataList.Count - _lastN;
            for (int i = count; i < _dataList.Count; i++)
                forChartDataSource.Add(_dataList[i]);
            
            if (chkLog.Checked)
                dataChart.DataSource = LogList(forChartDataSource);
            else
                dataChart.DataSource = forChartDataSource;
            dataChart.DataBind();
        }

        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChart();
        }

        private void dataChart_DoubleClick(object sender, EventArgs e)
        {
            ListForm lf = new ListForm(_dataList, _timeList);
            lf.MdiParent = LocalParent;
            lf.Show();
        }
    }
}