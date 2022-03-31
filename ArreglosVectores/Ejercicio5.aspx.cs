using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            double[] vector = new double[5];
            double sumaNegativos = 0;
            double sumaPositivos = 0;
            double contarCero = 0;
            double contarNegativo = 0;
            double contarPositivo = 0;
            String mostrarVector = " ";
            String mostrarCeros = " ";
            String mostrarNegativos = " ";
            String mostrarPositivos = " ";

            vector[0] = 1;
            vector[1] = 0;
            vector[2] = 0;
            vector[3] = 3;
            vector[4] = -5;

            //Cargar vector
            for (int i = 0; i < vector.Length; i++)
            {
                mostrarVector = mostrarVector + vector[i] + " ";
            }

            //Cuantos son cero
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < 1 && vector[i] > -1)
                {
                    contarCero = contarCero + 1;
                    mostrarCeros = mostrarCeros + vector[i] + " ";
                }
            }

            //Negativos
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < 0)
                {
                    //Contar
                    contarNegativo = contarNegativo + 1;
                    //Mostrar
                    mostrarNegativos = mostrarNegativos + vector[i] + " ";
                    //Suma
                    sumaNegativos = sumaNegativos + vector[i];
                }
            }

            //Positivos
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    //Contar
                    contarPositivo = contarPositivo + 1;
                    //Mostrar
                    mostrarPositivos = mostrarPositivos + vector[i] + " ";
                    //Suma
                    sumaPositivos = sumaPositivos + vector[i];
                }
            }


            lblMostrarVector.Text = System.Convert.ToString(mostrarVector);
            lblMostrarCuantosCeros.Text = System.Convert.ToString(contarCero);
            lblCuantosNegativos.Text = System.Convert.ToString(contarNegativo);
            lblCualesNegativos.Text = System.Convert.ToString(mostrarNegativos);
            lblSumaNegativos.Text = System.Convert.ToString(sumaNegativos);
            lblCuantosPositivos.Text = System.Convert.ToString(contarPositivo);
            lblCualesPositivos.Text = System.Convert.ToString(mostrarPositivos);
            lblSumaPositivos.Text = System.Convert.ToString(sumaPositivos);
        }
    }
}