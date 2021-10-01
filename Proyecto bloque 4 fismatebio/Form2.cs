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
    

    public partial class Form2 : Form
    {
        int puntaje=0;

        public Form2(int o)
        {
            puntaje = o;
            InitializeComponent();
            label6.Text = Convert.ToString(puntaje);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 b = new Form3("Existen… endócrinas y exocrinas.","GLANDULAS", 100,puntaje);
            b.Show();
            this.Hide();
          
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Tipo de efecto en las hormonas cuando provoca disminución de la actividad en un tejido.", "INHIBITORIO", 100, puntaje);
            b.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Tipo de reproducción que es común en hongos, musgos y helechos.", "ESPORULACION", 200, puntaje);
            b.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Es el principio de la existencia de la materia que existe en el universo y todo en cuanto existe:", "ENERGIA", 100, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Es todo aquello que ocupa un lugar en el espacio:", "MATERIA", 100, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("La energía que permite crear todo cuanto existe en el universo es llamada energía...", "CINETICA", 200, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("¿Qué teoría indica : La velocidad con la que sale un líquido por el orificio de un recipiente, es igual a la adquirida un cuerpo que se deja caer?", "TORRICELLI", 200, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("¿Qué nombre recibe la relación existente entre el volumen de un líquido que fluye por un conducto y el tiempo que tarda en fluir?","GASTO", 300, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("La materia que toma la forma del recipiente que la contiene y en la que sus moléculas tienen una alta cinética (energía) se encuentra en el estado de agregación...","GASEOSO", 300, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("¿Cómo se le llama a la cantidad de masa del líquido que fluye a través de una tubería en 1 segundo", "FLUJO", 400, puntaje);
            b.Show();
            this.Hide();
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("¿Qué nombre recibe la relación existente entre la fuerza aplicada en un área determinada a un fluido?", "PRESION", 400, puntaje);
            b.Show();
            this.Hide();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("La materia que es expulsada por los agujeros negros es energía, la cuál es el resultado de la acción de la...", "ANTIMATERIA", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Es el estado de la materia que requiere de una temperatura superior a los 500 C° y un voltaje de 72,000 V.", "PLASMA", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Estructura protegida por vértebras:", "MEDULA ESPINAL", 200, puntaje);
            b.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Estructura protegida por el cráneo:", "ENCEFALO", 300, puntaje);
            b.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("En el Sistema Nervioso, este se encarga del equilibrio:", "CEREBELO", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Conjunto de características físicas visibles en un organismo vivo:", "FENOTIPO", 400, puntaje);
            b.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Alteración repentina en la secuencia del ADN:", "MUTACION", 400, puntaje);
            b.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Posición que tiene  cada gen en 1 cromosoma:", "LOCUS", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Nombre del reino de los hongos:", "FUNGI", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("El … de un número N en una base a, es el exponente al que se eleva dicha base para obtener ese número o resultado.", "LOGARITMO", 100, puntaje);
            b.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Responde con VERDADERO O FALSO: Para graficar una función logaritmica se deben utilizar valores iguales o menores a 0.","FALSO", 100, puntaje);
            b.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("En las propiedades de los logaritmos; 1=", "0", 200, puntaje);
            b.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("En las propiedades de los logaritmos; log (A) (B) =", "LOG A + LOG B", 200, puntaje);
            b.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3(" Determina : log_2⁡(32) ", "5", 300, puntaje);
            b.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("Según las propiedades de los logaritmos;  log (a/b) =", "LOG A - LOG B", 300, puntaje);
            b.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Form3 b = new Form3("¿Qué representa el intervalo ( 0 , ∞) en una función exponencial?", "RANGO", 400, puntaje);
            b.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("Es la  gráfica de la función exponencial si: 0 < a < 1 , es una función…", "DECRECIENTE", 400, puntaje);
            b.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("En la gráfica de la función  exponencial si:  a < 1 , es una función...", "CRECIENTE", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3("¿El intervalo (- ∞, ∞) en una función exponencial que representa?", "DOMINIO", 500, puntaje);
            b.Show();
            this.Hide();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int color = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (color == 0)
            {
                label2.BackColor = Color.LightGreen;
                label3.BackColor = Color.LightPink;
                label4.BackColor = Color.LightYellow;
                button31.BackColor = Color.MediumPurple;
                color++;

            }
            else
            {

                label2.BackColor = Color.LightSeaGreen;
                label3.BackColor = Color.LightSalmon;
                label4.BackColor = Color.Yellow;
                button31.BackColor = Color.Orange;
                color--;
            }

        }
    }
}
