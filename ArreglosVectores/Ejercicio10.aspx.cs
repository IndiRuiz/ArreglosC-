using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            double[] vectorA = new double[5];
            double[] vectorB = new double[5];
            double[] vectorInverso = new double[5];
            double[] vectorMultiplicacion = new double[5];
            String mostrarVectorA = " ";
            String mostrarVectorB = " ";
            String mostrarVectorInverso = " ";
            String mostrarMultiplicacion = " ";
             
            vectorA[0] = 1;
            vectorA[1] = 2;
            vectorA[2] = 3;
            vectorA[3] = 4;
            vectorA[4] = 5;

            vectorB[0] = 10;
            vectorB[1] = 9;
            vectorB[2] = 7;
            vectorB[3] = 8;
            vectorB[4] = 9;

            for (int i = 0; i < vectorA.Length; i++)
            {
                mostrarVectorA = mostrarVectorA + vectorA[i] + " ";
            }

            for (int i = 0; i < vectorB.Length; i++)
            {
                mostrarVectorB = mostrarVectorB + vectorB[i] + " ";
            }

            int auxiliar = 0;
            for (int i = vectorB.Length - 1; i >= 0; i--)
            {
                vectorInverso[auxiliar] = vectorB[i];
                mostrarVectorInverso = mostrarVectorInverso + vectorInverso[auxiliar] + " ";
                auxiliar = auxiliar + 1;

            }

            for (int i = 0; i < vectorB.Length; i++)
            {
                vectorMultiplicacion[i] = vectorInverso[i] * vectorA[i];
                mostrarMultiplicacion = mostrarMultiplicacion + vectorMultiplicacion[i] + " ";
            }

            lblMostrarVectorA.Text = System.Convert.ToString(mostrarVectorA);
            lblMostrarVectorB.Text = System.Convert.ToString(mostrarVectorB);
            lblMostrarMultiplicacion.Text = System.Convert.ToString(mostrarMultiplicacion);





        }
    }
}