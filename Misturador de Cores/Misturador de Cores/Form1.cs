using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misturador_de_Cores
{
    public partial class Form1 : Form
    {
        int cred, cgreen, cblue;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarr_Scroll(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void trackBarg_Scroll(object sender, EventArgs e)
        {
            AtualizarCor();
        }

        private void trackBarb_Scroll(object sender, EventArgs e)
        {
            AtualizarCor();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBarr.Minimum = 0;
            trackBarr.Maximum = 255;

            trackBarg.Minimum = 0;
            trackBarg.Maximum = 255;

            trackBarb.Minimum = 0;
            trackBarb.Maximum = 255;

            trackBarr.Value = 0;
            trackBarg.Value = 0;
            trackBarb.Value = 0;

            labelRGB.Text = "Cor atual(0,0,0)";
            labelcorhexa.Text = "#000000";

            Color cor = Color.FromArgb(cred, cgreen, cblue);
            pictureBox1.BackColor = cor;
        }
        private void AtualizarCor()
        {
            cred = trackBarr.Value;
            labelr.Text = cred.ToString();

            cgreen = trackBarg.Value;
            labelg.Text = cgreen.ToString();

            cblue = trackBarb.Value;
            labelb.Text = cblue.ToString();

            Color cor = Color.FromArgb(cred, cgreen, cblue);
            pictureBox1.BackColor = cor;

            labelRGB.Text = "Cor atual(" + cred + "," + cgreen + "," + cblue + ")";

            string Cor_red = cred.ToString();
            string Cor_green = cgreen.ToString();
            string Cor_blue = cblue.ToString();

            labelcorhexa.Text = "#" + Cor_red + Cor_green + Cor_blue; 
        }
    }
}
