using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbopcion2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (rbopcion1.Checked == true)
            {
                Width = 640;
                Height = 480;

            }
            else if (rbopcion2.Checked == true)
            {
                Width = 800;
                Height = 600;
            }
            else if (rbopcion3.Checked == true)
            {
                Width = 1024;
                Height = 768;

            }

        }
    }
}
