using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JG_Saldumi_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            double sk1 = Convert.ToDouble(daudzums.Text);
            double sk2 = 9.88;
            double rezultats = sk1 / sk2;
            daudzums_kg.Text = rezultats.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ievadijat ne tos datus!!!");
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Button2.BackColor = (Button.BackColor == Color.Green);
            }
        }
    }
}
