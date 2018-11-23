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
    public partial class ListForm : Form
    {
        public ListForm(List<double> data, List<DateTime> time)
        {
            InitializeComponent();
            for (int i = 0; i < data.Count; i++)
            {
                listBox1.Items.Add(data[i].ToString() + " " + time[i].ToString());
            }
        }
    }
}