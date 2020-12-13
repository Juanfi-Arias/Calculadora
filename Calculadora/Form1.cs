using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClassSuma obj = new Clases.ClassSuma();
        Clases.ClassResta obj2 = new Clases.ClassResta();
        Clases.ClassMultiplicación obj3 = new Clases.ClassMultiplicación();
        Clases.ClassDivición obj4 = new Clases.ClassDivición();
        
        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero += double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '3';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '0';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '1';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '4';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '5';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '6';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '7';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '8';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '9';
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text += '.';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operador = "X";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = "÷";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    textBox1.Text = Sum.ToString();
                    break;

                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    textBox1.Text = Res.ToString();
                    break;

                case "X":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    textBox1.Text = Mul.ToString();
                    break;

                case "÷":
                    Div = obj4.Dividir((primero), (segundo));
                    textBox1.Text = Div.ToString();
                    break;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = "";
            }
            else
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }

        }
    }
}
