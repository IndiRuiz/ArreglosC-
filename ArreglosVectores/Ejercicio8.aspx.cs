using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            double[] vector = new double[5];
            double mayor = vector[0];
            double menor = vector[0];
            String mostrarVector = " ";

            vector[0] = 11;
            vector[1] = 12;
            vector[2] = 13;
            vector[3] = 18;
            vector[4] = 19;


            for (int i = 0; i < vector.Length; i++)
            {
                mostrarVector = mostrarVector + vector[i] + " ";
            }
            lblMostrarElementos.Text = mostrarVector;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
                else
                {
                    mayor = vector[0];
                }


                if (vector[i] < menor)
                {
                    menor = vector[i];

                }
                else
                {
                    menor = vector[0];
                }


                if ((menor == vector[0]) && (mayor == vector[vector.Length - 1]))
                {
                    lblOrden.Text = System.Convert.ToString("Sí");
                }
                else
                {
                    lblOrden.Text = System.Convert.ToString("No");
                }

            }


        }
    }
}