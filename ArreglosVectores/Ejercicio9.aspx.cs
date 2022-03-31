using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            double[] vector = new double[10];
            double numero = 0;
            double numeroExistente = 0;
            numero = Convert.ToInt32(txtNumero.Text);
            String mostrarVector = " ";

            vector[0] = 11;
            vector[1] = 12;
            vector[2] = 13;
            vector[3] = 14;
            vector[4] = 15;
            vector[5] = 16;
            vector[6] = 17;
            vector[7] = 18;
            vector[8] = 19;
            vector[9] = 20;

            for (int i = 0; i < vector.Length; i++)
            {
                mostrarVector = mostrarVector + vector[i] + " ";
            }
            lblMostrarVector.Text = System.Convert.ToString(mostrarVector);
            
            
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numero)
                {
                    numero = vector[i];
                    lblMostrarPosicion.Text = System.Convert.ToString(i);
                    numeroExistente = 1;
                    break;
                }
            }

            if (numeroExistente == 0)
            {
                lblMostrarPosicion.Text = System.Convert.ToString("No.");
            }




        }
    }
}