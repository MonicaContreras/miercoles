using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("seguro", "confirmar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                txtnombre.Text =" ";
                txtedad.Text = " ";
                txtprofesion.Text = " ";
            }
            else if (dialogResult == DialogResult.No)
            { 

            }
        }
    }
}
