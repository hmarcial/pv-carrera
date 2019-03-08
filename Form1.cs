using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libetruga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea Tortuga 
        /// </summary>
        Tortuga t1 = new Tortuga(10);
        /// <summary>
        /// Crea liebre
        /// </summary>
        Liebre l1 = new Liebre(11);
        private void btndale_Click(object sender, EventArgs e)
        {
            do
            {
               ///llama a correr
                t1.correr();
                l1.correr();
                textBox1.Text = "";
                /// manda al textbox1 la info de t1 y l1
                textBox1.Text = t1.ToString() + " , " + Environment.NewLine + l1.ToString();
            } while (t1.posicion < 100 && l1.posicion < 100);
            ///Crea comparacion de empate
            if(t1.posicion >=100 && l1.posicion >= 100)
            {
                lblr.Text = "Empate";
            }
            else
            {///Se busca al mayor
                if(t1.posicion > l1.posicion)
                {
                    lblr.Text = " Tortuga gana";
                }
                else
                {
                    lblr.Text = "Liebre gana";
                }
            }
        }
    }
}
