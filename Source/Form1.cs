using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A3
{


    public partial class Form1 : Form
    {
        Dictionary<string, double> Listprice = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum=0;
            foreach (KeyValuePair<string, double> Listprice1 in Listprice) {

                sum = sum + Listprice1.Value;
            }
            textBox3.Text= Convert.ToString("$"+sum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Listprice.Add(textBox1.Text, Convert.ToDouble(textBox2.Text));
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add("$" + textBox2.Text);
            }

            catch { MessageBox.Show("Inccorect Input"); }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Listprice.Clear();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          textBox4.Text=Convert.ToString(listBox1.Items.Count);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == listBox2.SelectedIndex)
            {

                listBox1.Items.Remove(textBox1.Text);
                listBox2.Items.Remove("$" + textBox2.Text);
                Listprice.Remove(textBox1.Text);

            }
            else return;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
