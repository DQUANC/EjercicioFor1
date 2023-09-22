using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Numeros del 0 al 10

            for (int i = 0; i<= 10; i++)
            {
                if (i == 0)
                {
                    label3.Text = label3.Text + " " + i;
                }
                else
                {
                    label3.Text = label3.Text + ", " + i;
                }
            }

            // Numeros del 2 al 12

            for (int i = 2; i <= 12; i++)
            {
                if (i == 2)
                {
                    label5.Text = label5.Text + " " + i;
                }
                else
                {
                    label5.Text = label5.Text + ", " + i;
                }
            }

            // Numeros del 10 al 0

            for (int i = 10; i >= 0; i--)
            {
                if (i == 10)
                {
                    label7.Text = label7.Text + " " + i;
                } 
                else
                {
                    label7.Text = label7.Text + ", " + i;
                }
            }

        }
    }
}
