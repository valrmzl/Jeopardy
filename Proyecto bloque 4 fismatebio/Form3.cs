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
    public partial class Form3 : Form
    {
        public string pregunta, respuesta;
        public string error;
        public int valor, cuenta;

        public Form3(string p, string r, int v, int c)
        {
           
            InitializeComponent();
            pregunta = p;
            respuesta= r;
            valor = v;
            cuenta = c;
            label1.Text = p;
            
        }
        SoundPlayer bien = new SoundPlayer();
        SoundPlayer mal = new SoundPlayer();
        int contador = 90;
        
       

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == respuesta)
            {
                
                bien.SoundLocation = "Destape.wav";
                bien.Play();
                label2.Text = "CORRECTO! :)";
                MessageBox.Show("Respuesta Correcta!! Ahora se suman a tu cuenta los puntos equivalentes a la pregunta!! Sigue así.");
                Form2 a =new Form2(cuenta+valor);
                //a.cuenta(valor);
                a.Show();
   
                this.Hide();

            }
            else
            {
                mal.SoundLocation = "error.wav";
                mal.Play();
                label3.Text = "X";
                MessageBox.Show("Respuesta incorrecta :(");
                Form2 a = new Form2(cuenta);
                a.Show();
                this.Hide();

            }
            timer2.Stop();
        }
        int color = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                button1.BackColor = Color.Aquamarine;
                color++;
            }
            else
            {
                button1.BackColor = Color.Lavender;
                color--;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            contador--;
            textBox2.Text = contador.ToString();
            int t = contador / 60;
            int y = contador - (t * 60);
            if (y < 10)
            {
                label5.Text = (t.ToString() + ":0" + y.ToString());
            }
            else
            {
                label5.Text = (t.ToString() + ":" + y.ToString());
            }
            
            if (contador == 0)
                
            {
                timer2.Stop();
                MessageBox.Show("El tiempo para esta pregunta acabo :( ");
                Form2 a = new Form2(cuenta);
                a.Show();
                this.Hide();
            }

        }

 
    }
}
