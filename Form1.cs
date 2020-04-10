using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMIJO_KLEE
{
    public partial class Form1 : Form
    {
        double primer_num;
        double segundo_num;
        double resultado;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Size = new Size(250, 375);
            textBox1.Size = new Size(225, 43);
            button38.Visible = false;
            button11.Visible = false;
            button23.Visible = false;
            button31.Visible = false;
            button16.Visible = false;
            button27.Visible = false;
            button32.Visible = false;
            button23.Visible = false;
            button28.Visible = false;
            button33.Visible = false;
            button24.Visible = false;
            button29.Visible = false;
            button34.Visible = false;
            button25.Visible = false;
            button30.Visible = false;
            button35.Visible = false;
            button26.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(250, 375);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Size = new Size(420, 375);
            textBox1.Size = new Size(395, 43);
            button38.Visible = true;
            button11.Visible = true;
            button23.Visible = true;
            button31.Visible = true;
            button16.Visible = true;
            button27.Visible = true;
            button32.Visible = true;
            button23.Visible = true;
            button28.Visible = true;
            button33.Visible = true;
            button24.Visible = true;
            button29.Visible = true;
            button34.Visible = true;
            button25.Visible = true;
            button30.Visible = true;
            button35.Visible = true;
            button26.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "/";
            primer_num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operador = "*";
            primer_num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operador = "-";
            primer_num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operador = "+";
            primer_num = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            segundo_num = double.Parse(textBox1.Text);
            switch(operador)
            {
                case "+":
                    resultado = primer_num + segundo_num;
                    textBox1.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primer_num - segundo_num;
                    textBox1.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primer_num * segundo_num;
                    textBox1.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primer_num / segundo_num;
                    textBox1.Text = resultado.ToString();
                    break;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
    }
}
