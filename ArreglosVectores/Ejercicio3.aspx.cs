using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArreglosVectores
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double[] vector = new double[3];
            String mostrarVector = " ";
            double mayor = 0;
            

            vector[0] = 10;
            vector[1] = 50;
            vector[2] = 3;

            //Cargar vector
            for (int i = 0; i < vector.Length; i++)
            {
                mostrarVector = mostrarVector + vector[i] + " ";
            }

            //Mostrar mayor
            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                    lblMostrarPosicion.Text = System.Convert.ToString(i);
                }
                
            }
            lblMostrarValores.Text = System.Convert.ToString(mostrarVector);
            lblMostrarMayor.Text = System.Convert.ToString(mayor);


        }
    }
}