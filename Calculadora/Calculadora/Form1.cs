using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Form1 : Form
    {
        static Operaciones operaciones = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonResul_Click(object sender, EventArgs e)
        {
            if (cbxOp.Text == "Suma")
            {
                lblres.Text = (operaciones.Suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOp.Text == "Resta")
            {
                lblres.Text = (operaciones.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOp.Text == "Multiplicación")
            {
                lblres.Text = (operaciones.Multiplicación(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
            else if (cbxOp.Text == "División")
            {
                lblres.Text = (operaciones.División(double.Parse(txtv1.Text), double.Parse(txtv2.Text))).ToString();
            }
        }
    }
}
