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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            /*Ir al Form de Matrices Manueles*/
            this.Hide();
            matricesManuales formManual = new matricesManuales();
            formManual.Show();
        }

        private void btnAleatoria_Click(object sender, EventArgs e)
        {
            /*Ir al Form de Matrices Aleatorias*/
            this.Hide();
            matricesAleatorias formAleatorias = new matricesAleatorias();
            formAleatorias.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            mensaje = "\r\nTALLER SOBRE MATRICES \r\n\r\n";
            mensaje += "\r\n \r\n";
            mensaje += "La aplicación genera aleatoriamente datos almacenados.";
            mensaje += "\r\n";
            mensaje += "La aplicación tiene tambien como objetivo que generes manualmente datos.";
            mensaje += "\r\n";
            mensaje += "\r\n \r\n";

            mensaje += "Elaborado por: ";
            mensaje += "Lina Maria Montaño Ramirez - @calypso_bronte,";
            mensaje += "\r\n";
            mensaje += " Wilmar Berrio,";
            mensaje += "\r\n2018";
            MessageBox.Show(mensaje, "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
