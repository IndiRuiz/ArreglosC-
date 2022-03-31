using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] vectorA = new double[3];
            double[] vectorB = new double[3];
            double[] vectorC = new double[3];
            String mostrarVectorA = " ";
            String mostrarVectorB = " ";
            String mostrarVectorC = " ";
            
            double suma;
            suma = 0;

            //Cargar vector A
            for (int i = 0; i < vectorA.Length; i++)
            {
                vectorA[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Valores del vector A:"));
                mostrarVectorA = mostrarVectorA + vectorA[i] + " ";
            }

            //Cargar vector B
            for (int i = 0; i < vectorB.Length; i++)
            {
                vectorB[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Valores del vector B:"));
                mostrarVectorB = mostrarVectorB + vectorB[i] + " ";
            }

            //Suma entre vectores A y B
            for (int i=0; i < vectorC.Length;i++)
            {
                vectorC[i] = vectorA[i] + vectorB[i];
                mostrarVectorC = mostrarVectorC + vectorC[i] + " ";
            }



            lblMostrarVectorA.Text = System.Convert.ToString(mostrarVectorA);
            lblMostrarVectorB.Text = System.Convert.ToString(mostrarVectorB);
            lblMostrarVectorC.Text = System.Convert.ToString(mostrarVectorC);
        }
    }
}