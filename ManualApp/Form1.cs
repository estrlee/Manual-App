using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManualApp

{
    public partial class Form1 : Form
    
    {
        bool connected = false;
        SerialPort sp;
        public Form1()
        {
           
            InitializeComponent();
            var ports = SerialPort.GetPortNames();
            comboBox1.DataSource = ports;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sp = new SerialPort(comboBox1.SelectedItem.ToString(), 9600);

                if (!connected)
                {
                    sp.Open();
                    connected = true;
                    MessageBox.Show("Serial port connected");
                }
                else
                {
                    sp.Close();
                    sp.Dispose();

                    connected = false;

                    MessageBox.Show("Serial port disconnected");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Serial port cannot connect");
            }


        }


        



        private void checkBox1_CheckedChanged(object sender, EventArgs e)   //valve from mixing to motor
        {
            if (checkBox1.Checked)
            {
                sp.Write("E");

                label1.Text = "OPEN";
            }
            else
            {
                sp.Write("e");

                label1.Text = "CLOSED";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)   //valve from motor to cleaning
        {
            if (checkBox2.Checked)
            {
                sp.Write("F");

                label2.Text = "OPEN";
            }
            else
            {
                sp.Write("f");

                label2.Text = "CLOSED";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)   //valve from cleaning to motor
        {
            if (checkBox3.Checked)
            {
                sp.Write("G");

                label3.Text = "OPEN";
            }
            else
            {
                sp.Write("g");

                label3.Text = "CLOSED";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)   //valve from motor to recovery
        {
            if (checkBox4.Checked)
            {
                sp.Write("H");

                label4.Text = "OPEN";
            }
            else
            {
                sp.Write("h");

                label4.Text = "CLOSED";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)   //valve from recovery to motor
        {
            if (checkBox5.Checked)
            {
                sp.Write("I");

                label5.Text = "OPEN";
            }
            else
            {
                sp.Write("i");

                label5.Text = "CLOSED";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)   //valve from motor to mixing
        {
            if (checkBox6.Checked)
            {
                sp.Write("J");

                label6.Text = "OPEN";
            }
            else
            {
                sp.Write("j");

                label6.Text = "CLOSED";
            }
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                sp.Write("A");

                label7.Text = "ON";
            }
            else
            {
                sp.Write("a");

                label7.Text = "OFF";
            }

        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                sp.Write("M");

                label8.Text = "ON";
            }
            else
            {
                sp.Write("m");

                label8.Text = "OFF";
            }
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                sp.Write("B");

                label9.Text = "ON";
            }
            else
            {
                sp.Write("b");

                label9.Text = "OFF";
            }

        }

        private void checkBox10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                sp.Write("C");

                label10.Text = "ON";
            }
            else
            {
                sp.Write("c");

                label10.Text = "OFF";
            }
        }


        private void checkBox11_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                sp.Write("D");

                label11.Text = "ON";
            }
            else
            {
                sp.Write("d");

                label11.Text = "OFF";
            }
        }

        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


    }
}
