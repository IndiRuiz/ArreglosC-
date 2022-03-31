using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            double[] vector = new double[5];
            double[] vectorInverso = new double[5];
            String mostrarVector = " ";
            String mostrarVectorInverso = " ";

            vector[0] = 11;
            vector[1] = 12;
            vector[2] = 13;
            vector[3] = 14;
            vector[4] = 15;

            //Cargar 
            for (int i = 0; i < vector.Length; i++)
            {
                mostrarVector = mostrarVector + vector[i] + " ";
            }


            int auxiliar = 0;
            for (int i = vector.Length-1; i >= 0; i--)
            {
                vectorInverso[auxiliar] = vector[i];
                mostrarVectorInverso = mostrarVectorInverso + vectorInverso[auxiliar] + " ";
                auxiliar = auxiliar + 1;

            }

            lblMostrarVector.Text = System.Convert.ToString(mostrarVector);
            lblMostrarInverso.Text = System.Convert.ToString(mostrarVectorInverso);
        }
    }
}