using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] vector = new double[3];
            double cuadrado;
            String mostrarVector = " ";
            String mostrarCuadrado = " ";

            vector[0] = 1;
            vector[1] = 2;
            vector[2] = 3;

            //Cargar vector
            for (int i = 0; i < vector.Length; i++)
            {
                mostrarVector = mostrarVector + vector[i] + " ";
            }

            for (int i = 0; i < vector.Length; i++)
            {
                cuadrado = vector[i] * vector[i];
                mostrarCuadrado = mostrarCuadrado + cuadrado + " ";
            }
            lblMostaraValores.Text = System.Convert.ToString(mostrarVector);
            lblMostrarCuadrado.Text = System.Convert.ToString(mostrarCuadrado);
        }
    }
}