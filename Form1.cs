using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosEjercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double calif = double.Parse(txtCalificacion.Text);
            string mensaje = "";
            string error = "";

            /*
                90-100: A
                80-89: B
                70-79: C
                60-69: D
                0-59: F

             */

            if (calif < 0 || calif > 100)
            {
                error = "La calificacion no puede estar fuera del rango de 0 a 100";
            }
            else if (calif >= 90)
            {
                mensaje = "A";
            }
            else if (calif >= 80)
            {
                mensaje = "B";
            }
            else if (calif >= 70)
            {
                mensaje = "C";
            }
            else if (calif >= 60)
            {
                mensaje = "D";
            }
            else
            {
                mensaje = "F";
            }

            //lblMensaje.Text = mensaje;

            if (error != "")
            {
                lblMensaje.Text = error;
            }
            else
            {
                lblMensaje.Text = String.Format("El valor literal para la calificacion {0} es {1}", calif, mensaje);
            }
           
           




        }
    }
}
