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
            txtBoxMin.Text = min.ToString();
            txtBoxMax.Text = max.ToString();
        }

        public IValidate Validator { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                double x = double.Parse(txtBoxMin.Text);
                double y = double.Parse(txtBoxMax.Text);

                Validator.SetValues(x, y);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #region Errorprovider

        private void txtBoxMin_Validating(object sender, CancelEventArgs e)
        {
            double tmp;
            if(!double.TryParse(txtBoxMin.Text,out tmp))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxMin, "Unesite minimalnu vrednost pravilno");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxMin, null);
            }
        }

        private void txtBoxMax_Validating(object sender, CancelEventArgs e)
        {
            double tmp;
            if (!double.TryParse(txtBoxMax.Text, out tmp))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBoxMax, "Unesite maximalnu vrednost pravilno");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBoxMax, null);
            }
        }

        #endregion

    }
}
