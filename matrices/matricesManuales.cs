using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrices
{
    public partial class matricesManuales : Form
    {
        public matricesManuales() => InitializeComponent();

        private const int V = 10;

        //Se declara la matriz
        private string[,] matrizDatos;
        //se declara contador para repetir el ingreso de los registros
        int c = 0;
        //Se declara la cantidad de filas y columnas de la matriz
        private void matricesManuales_Load(object sender, EventArgs e) => matrizDatos = new string[10, 4];
        private void btnResultado_Click(object sender, EventArgs e)
        {
            // utilizaremos una condicional para limitar la cantidad de registros que se van a ingresar
            if(c < V)
            {
                matrizDatos[c, 0] = txtCedula.Text;
                matrizDatos[c, 1] = txtNombre.Text;
                matrizDatos[c, 2] = txtApellido.Text;
                matrizDatos[c, 3] = txtEdad.Text;
                //
                c+=1;

            }
            // Cuando se ya se ingresen los datos las cajas de texto se limpien para un nuevo ingreso
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";

            //Le haremos focuos en la primera casilla.
            this.txtCedula.Focus();
            dvgDatos.Rows.Clear();

            //En este paso visualizaremos los datos ingresados para cargarlos en el DataGridView
            for(int c2=0; c2 < c; c2++)
            {
                dvgDatos.Rows.Add(
                    matrizDatos[c2, 0],
                    matrizDatos[c2, 1],
                    matrizDatos[c2, 2],
                    matrizDatos[c2, 3]);
            }
            
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            /*Volver a nuestra pagina principal*/
            this.Hide();
            main main = new main();
            main.Show();
        }
    }
}
