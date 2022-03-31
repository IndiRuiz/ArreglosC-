using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] vector = new double[5];
            String mostrarVector = " ";
            String mostrarMayor = " ";
            double suma, promedio, mayor;
            suma = 0;
            promedio = 0;
            mayor = 0;

            //Cargar vector
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese elementos del vector A :"));
                mostrarVector = mostrarVector + vector[i] + " ";
            }
            lblMostrarValores.Text = mostrarVector;
            
            //Suma
            for(int i = 0; i < vector.Length; i++)
            {
                suma = suma + vector[i];
            }

            //Promedio
            promedio = suma / 5;
            lblMostrarPromedio.Text = System.Convert.ToString(promedio);

            //Mayores que el promedio
            for(int i=0; i < vector.Length; i++)
            {
                if(vector[i]>promedio)
                {
                    mayor = mayor + 1;
                    mostrarMayor = mostrarMayor + vector[i] + " ";
                    lblMostrarMayores.Text = mostrarMayor;

                }
            }
            lblCuantosMayores.Text = System.Convert.ToString(mayor);





        }
    }
}