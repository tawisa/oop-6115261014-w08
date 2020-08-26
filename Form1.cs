using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6115261019_w09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBMI_Click(object sender, EventArgs e)
        { }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtHeight.Text.ToString()) / 100;
            double weight = double.Parse(txtWeight.Text.ToString());
            double bmi = BMI.calculate(weight, height);
            lblBMI.Text = bmi.ToString();
        }

        private void btnTaxCalculate_Click(object sender, EventArgs e)
        {
            double salary = double.Parse(txtSalary.Text.ToString());
            double tex = Tex.calculate(salary);
            lblTex.Text = tex.ToString();
        }
    }
}
