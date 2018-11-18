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
        public StandardValueForm(ICheckStandard val, String text)
        {
            InitializeComponent();
            Checker = val;
            this.Text = text;
            double min;
            double max;
            Checker.GetValues(out min, out max);
            txtBoxMin.Text = min.ToString();
            txtBoxMax.Text = max.ToString();
        }

        public ICheckStandard Checker { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateMin() && ValidateMax())
            {
                double x = double.Parse(txtBoxMin.Text);
                double y = double.Parse(txtBoxMax.Text);
                Checker.SetValues(x, y);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #region Errorprovider

        private bool ValidateMin()
        {
            double tmp;
            if(!double.TryParse(txtBoxMin.Text,out tmp))
            {
                errorStandardValue.SetError(txtBoxMin,"Lepo unesite min vrednost");
                return false;
            }
            else
            {
                errorStandardValue.SetError(txtBoxMin, null);
                return true;
            }
        }

        private bool ValidateMax()
        {
            double tmp;
            if (!double.TryParse(txtBoxMax.Text, out tmp))
            {
                errorStandardValue.SetError(txtBoxMax, "Lepo unesite max vrednost");
                return false;
            }
            else if (double.Parse(txtBoxMin.Text) > double.Parse(txtBoxMax.Text))
            {
                errorStandardValue.SetError(txtBoxMax, "Max mora biti vece od min");
                return false;
            }
            else
            {
                errorStandardValue.SetError(txtBoxMin, null);
                return true;
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
