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
    public partial class FormN : Form
    {
        public Form LocalParent { get; set; }
        private String _type;
        public FormN(String type)
        {
            InitializeComponent();
            _type = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lastN = int.MaxValue;
            if (checkBox1.Checked)
                lastN = int.Parse(textBox1.Text);
            FormChart fc = new FormChart(_type, lastN);
            fc.LocalParent = LocalParent;
            fc.MdiParent = LocalParent;
            fc.Show();
            this.Close();
        }
    }
}
