using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Login_e_Password
{
    public partial class Form1 : Form
    {
        Thread NovoForm, NovoForm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Amogus" && textBox2.Text == "pushinp")
            {
                MessageBox.Show("Olá, bem-vindo!");
            }
            else
            {
                MessageBox.Show("ERRO!!! ATIVAR PROTOCOLO DE SEGURANÇA 420");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Amogus" && textBox2.Text == "pushinp")
            {
                this.Close();
                NovoForm = new Thread(Abrir_Form);
                NovoForm.SetApartmentState(ApartmentState.STA); //definir o estado que vai assumir a thread antes de ser iniciada,
                //o STA, porque estamos a trabalhar com Threads Simples

                NovoForm.Start();

            }
            else
            {
                this.Close();
                NovoForm2 = new Thread(Abrir_Form3);
                NovoForm2.SetApartmentState(ApartmentState.STA);

                NovoForm2.Start();
            }
        }
        private void Abrir_Form()
        {
            Application.Run(new Form2());
        }
        private void Abrir_Form3()
        {
            Application.Run(new Form3());
        }
    }
}
