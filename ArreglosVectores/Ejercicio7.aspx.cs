using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            double[] vectorM = new double[5];
            double[] vectorN = new double[5];
            String mostrarVectorM = " ";
            String mostrarVectorN = " ";

            vectorM[0] = 11;
            vectorM[1] = 12;
            vectorM[2] = 13;
            vectorM[3] = 14;
            vectorM[4] = 15;

            vectorN[0] = 11;
            vectorN[1] = 12;
            vectorN[2] = 13;
            vectorN[3] = 14;
            vectorN[4] = 150;

            for (int i = 0; i < vectorM.Length; i++)
            {
                mostrarVectorM = mostrarVectorM + vectorM[i] + " ";
            }
            lblMostrarVectorM.Text = System.Convert.ToString(mostrarVectorM);

            for (int i = 0; i < vectorN.Length; i++)
            {
                mostrarVectorN = mostrarVectorN + vectorN[i] + " ";
            }
            lblMostrarVectorN.Text = System.Convert.ToString(mostrarVectorN);

            for (int i = 0; i < vectorN.Length; i++)
            {
                if (vectorM[i] == vectorN[i])
                {
                    lblIgualdadDiferencia.Text = System.Convert.ToString("Son iguales");
                }
                else
                {
                    lblIgualdadDiferencia.Text = System.Convert.ToString("Son diferentes");
                }
            }
        }
    }
}