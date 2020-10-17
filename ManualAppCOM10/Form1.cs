using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualAppCOM10

{
    public partial class Form1 : Form
    
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //valve from mixing to motor
        {
            if (checkBox1.Checked)
            {
                serialPort1.Write("E");

                label1.Text = "OPEN";
            }
            else
            {
                serialPort1.Write("e");

                label1.Text = "CLOSED";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)   //valve from motor to cleaning
        {
            if (checkBox2.Checked)
            {
                serialPort1.Write("F");

                label2.Text = "OPEN";
            }
            else
            {
                serialPort1.Write("f");

                label2.Text = "CLOSED";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)   //valve from cleaning to motor
        {
            if (checkBox3.Checked)
            {
                serialPort1.Write("G");

                label3.Text = "OPEN";
            }
            else
            {
                serialPort1.Write("g");

                label3.Text = "CLOSED";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)   //valve from motor to recovery
        {
            if (checkBox4.Checked)
            {
                serialPort1.Write("H");

                label4.Text = "OPEN";
            }
            else
            {
                serialPort1.Write("h");

                label4.Text = "CLOSED";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)   //valve from recovery to motor
        {
            if (checkBox5.Checked)
            {
                serialPort1.Write("I");

                label5.Text = "OPEN";
            }
            else
            {
                serialPort1.Write("i");

                label5.Text = "CLOSED";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)   //valve from motor to mixing
        {
            if (checkBox6.Checked)
            {
                serialPort1.Write("J");

                label6.Text = "OPEN";
            }
            else
            {
                serialPort1.Write("j");

                label6.Text = "CLOSED";
            }
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                serialPort1.Write("A");

                label7.Text = "ON";
            }
            else
            {
                serialPort1.Write("a");

                label7.Text = "OFF";
            }

        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                serialPort1.Write("M");

                label8.Text = "ON";
            }
            else
            {
                serialPort1.Write("m");

                label8.Text = "OFF";
            }
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                serialPort1.Write("B");

                label9.Text = "ON";
            }
            else
            {
                serialPort1.Write("b");

                label9.Text = "OFF";
            }

        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                serialPort1.Write("C");

                label10.Text = "ON";
            }
            else
            {
                serialPort1.Write("c");

                label10.Text = "OFF";
            }
        }


        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                serialPort1.Write("D");

                label11.Text = "ON";
            }
            else
            {
                serialPort1.Write("d");

                label11.Text = "OFF";
            }
        }

        

        private void label11_Click(object sender, EventArgs e)
        {

        }

       
    }
}
