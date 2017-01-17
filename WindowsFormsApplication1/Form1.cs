using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "+";
            textBox2.Text = "0";
            textBox8.Text = "+";
            textBox7.Text = "0";
        }

      
    



        private void button1_Click(object sender, EventArgs e)
        {
            Ulamek pierwszy = new Ulamek(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text));
            Ulamek drugi = new Ulamek(int.Parse(textBox6.Text), int.Parse(textBox5.Text), int.Parse(textBox7.Text));
            label1.Text = "+";

            Ulamek wynik = pierwszy.Dodaj(drugi);
            textBox10.Text = wynik.licznik.ToString();
            textBox9.Text = wynik.mianownik.ToString();
            textBox11.Text = wynik.cale.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ulamek pierwszy = new Ulamek(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text));
            Ulamek drugi = new Ulamek(int.Parse(textBox6.Text), int.Parse(textBox5.Text), int.Parse(textBox7.Text));
            label1.Text = "-";


            Ulamek wynik = pierwszy.Odejmij(drugi);
            textBox10.Text = wynik.licznik.ToString();
            textBox9.Text = wynik.mianownik.ToString();
            textBox11.Text = wynik.cale.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ulamek pierwszy = new Ulamek(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text));
            Ulamek drugi = new Ulamek(int.Parse(textBox6.Text), int.Parse(textBox5.Text), int.Parse(textBox7.Text));
            label1.Text = "*";


            Ulamek wynik = pierwszy.Pomnoz(drugi);
            textBox10.Text = wynik.licznik.ToString();
            textBox9.Text = wynik.mianownik.ToString();
            textBox11.Text = wynik.cale.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ulamek pierwszy = new Ulamek(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text));
            Ulamek drugi = new Ulamek(int.Parse(textBox6.Text), int.Parse(textBox5.Text), int.Parse(textBox7.Text));
            label1.Text = "/";


            Ulamek wynik = pierwszy.Podziel(drugi);
            textBox10.Text = wynik.licznik.ToString();
            textBox9.Text = wynik.mianownik.ToString();
            textBox11.Text = wynik.cale.ToString();
        }
    }
}
