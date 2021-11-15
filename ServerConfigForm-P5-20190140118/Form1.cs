using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using ServiceMtk_P1_20190140118;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_20190140118
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            labelOnOrOff.Text = "Server OFF";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
