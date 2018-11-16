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
    public partial class StandardValueForm : Form
    {
        public StandardValueForm(IValidate val, String text)
        {
            InitializeComponent();
            Validator = val;
            this.Text = text;
            double min;
            double max;
            Validator.GetValues(out min, out max);
            textBox1.Text = min.ToString();
            textBox2.Text = max.ToString();
        }

        public IValidate Validator { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            Validator.SetValues(x, y);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
