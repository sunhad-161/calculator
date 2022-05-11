using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Do_operation()
        {
            double a = Convert.ToDouble(tmp);
            switch (oper)
            {
                case "plus": value += a; break;
                case "minus": value -= a; break;
                case "multiply": value *= a; break;
                case "divide":
                    if (a != 0) value /= a;
                    else err = true; break;
            }
        }
        public double value;
        public string tmp = "";
        public string oper;
        public bool err = false;
        public bool neg = false;
        public bool dec = false;
        private void button1_Click(object sender, EventArgs e)
        {
            tmp += "1";
            textBox1.Text = tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmp += "2";
            textBox1.Text = tmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmp += "3";
            textBox1.Text = tmp;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tmp += "4";
            textBox1.Text = tmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tmp += "5";
            textBox1.Text = tmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tmp += "6";
            textBox1.Text = tmp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tmp += "7";
            textBox1.Text = tmp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tmp += "8";
            textBox1.Text = tmp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tmp += "9";
            textBox1.Text = tmp;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tmp += "0";
            textBox1.Text = tmp;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (oper == null)
            {
                oper = "plus";
                if (tmp != "") value = Convert.ToDouble(tmp);
            }
            else
            {
                if (tmp != "") Do_operation();
                oper = "plus";
            }
            tmp = "";
            textBox1.Text = Convert.ToString(value);
            neg = false;
            dec = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (oper == null)
            {
                oper = "minus";
                if (tmp != "") value = Convert.ToDouble(tmp);
            }
            else
            {
                if (tmp != "") Do_operation();
                oper = "minus";
            }
            tmp = "";
            textBox1.Text = Convert.ToString(value);
            neg = false;
            dec = false;
        }
        //кнопка равно
        private void button13_Click(object sender, EventArgs e)
        {
            if (tmp != "") Do_operation();
            if (err) textBox1.Text = "ERROR";
            else textBox1.Text = Convert.ToString(value);
            tmp = "";
            oper = null;
            neg = false;
            dec = false;
            err = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (oper == null)
            {
                oper = "multiply";
                if (tmp != "") value = Convert.ToDouble(tmp);
            }
            else
            {
                if (tmp != "") Do_operation();
                oper = "multiply";
            }
            tmp = "";
            textBox1.Text = Convert.ToString(value);
            neg = false;
            dec = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (oper == null)
            {
                oper = "divide";
                if (tmp != "") value = Convert.ToDouble(tmp);
            }
            else
            {
                if (tmp != "") Do_operation();
                oper = "divide";
            }
            tmp = "";
            textBox1.Text = Convert.ToString(value);
            neg = false;
            dec = false;
        }
        //кнопка десятичной дроби
        private void button16_Click(object sender, EventArgs e)
        {
            if (!dec)
            {
                tmp += ",";
                dec = true;
                textBox1.Text = tmp;
            }
        }
        //кнопка смены знака
        private void button17_Click(object sender, EventArgs e)
        {
            if (neg)
            {
                neg = false;
                tmp = tmp.Remove(0, 1);
            }
            else
            {
                neg = true;
                tmp = "-" + tmp;
            }
            textBox1.Text = tmp;
        }
        //кнопка C
        private void button18_Click(object sender, EventArgs e)
        {
            value = new double();
            tmp = "";
            oper = null;
            neg = false;
            dec = false;
            textBox1.Text = tmp;
        }
        //кнопка CE
        private void button19_Click(object sender, EventArgs e)
        {
            tmp = "";
            neg = false;
            dec = false;
            textBox1.Text = tmp;
        }
        //кнопка стирать
        private void button20_Click(object sender, EventArgs e)
        {
            if (tmp.Remove(0, tmp.Length - 1) == ",") dec = false;
            tmp = tmp.Remove(tmp.Length - 1, 1);
            textBox1.Text = tmp;
        }
    }
}
