using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Proyecto_bloque_4_fismatebio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer inicio = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text == "proyecto") && (this.textBox2.Text == "info12345"))
            {
                inicio.SoundLocation = "Introduccion.wav";
                inicio.Play();
                Form2 a = new Form2(0);
                a.Show();
                this.Hide();
                MessageBox.Show("Bienvenido a las preguntas, selecciona una, cada una tendra el valor que representa, contesta todo con mayusculas y sin ningun acento. Tendras 1:30 s para cada pregunta. Disfruta del juego!!");
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña son incorrectos.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int color = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                button1.BackColor = Color.Pink;
                button2.BackColor = Color.Pink;
                color++;
            }
            else
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                color--;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
