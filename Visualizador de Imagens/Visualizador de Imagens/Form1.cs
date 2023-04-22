using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog1 = new OpenFileDialog();
            opendialog1.InitialDirectory = "E:/API/C#/Fotos";
            opendialog1.Multiselect = true; //seleciona imagens

            if(opendialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string imagem in opendialog1.FileNames)
                    listView1.Items.Add(imagem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                pictureBox1.ImageLocation = listView1.SelectedItems[0].Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (int indeximagem in listView1.SelectedIndices)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    pictureBox1.ImageLocation = "";
            }
        }
    }
}
