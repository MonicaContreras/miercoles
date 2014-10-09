using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadiodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int numero1, numero2, suma, resta;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);
            if (rdsuma.Checked == true)
            {
                suma = numero1 + numero2;
                txtresultado.Text=suma.ToString();
            }
            else
            {
                resta = numero1 - numero2;
                txtresultado.Text=resta.ToString();
            }
        }
    }
}
