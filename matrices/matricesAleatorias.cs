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
    public partial class matricesAleatorias : Form
    {
        public matricesAleatorias() => InitializeComponent();
        // Definición de variables
        Random rnd = new Random();
        private int  filas=10, columnas=4;
        int[] cedula = new int[10];
        string[] nombres = new string[10];
        string[] apellidos = new string[10];
        int[] edad = new int[10];

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //
            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = rnd.Next(10000000, 99999999);
                nombres[i] = nombres1[rnd.Next(0, nombres1.Length)];
                apellidos[i] = apellidos1[rnd.Next(0, apellidos1.Length)];
                edad[i] = rnd.Next(20, 50);
            }

            btnMostrar.Enabled = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Cuando le demos crear el arrojara los datos que cogio aleatoriamente.
            dgvMatriz.ColumnCount = columnas;
            dgvMatriz.RowCount = filas;
            dgvMatriz.Columns[0].HeaderText = "Cedula";
            dgvMatriz.Columns[1].HeaderText = "Nombres";
            dgvMatriz.Columns[2].HeaderText = "Apellidos";
            dgvMatriz.Columns[3].HeaderText = "Edad";
            dgvMatriz.Rows.Add();

            for (int i = 0; i <= filas - 1; i++)
            {
                for (int j = 0; j <= columnas - 1; j++)
                {

                    switch (j)
                    {
                        case 0:
                            dgvMatriz.Rows[i].Cells[j].Value = cedula[i].ToString();
                            break;
                        case 1:
                            dgvMatriz.Rows[i].Cells[j].Value = nombres[i].ToString();
                            break;
                        case 2:
                            dgvMatriz.Rows[i].Cells[j].Value = apellidos[i].ToString();
                            break;
                        case 3:
                            dgvMatriz.Rows[i].Cells[j].Value = edad[i].ToString();
                            break;
                        default:
                            break;
                    }
                }


            }

            dgvMatriz.Sort(dgvMatriz.Columns[1], ListSortDirection.Ascending);
        }

        // Datos que cogera aleatoriamente.
        string[] apellidos1 = { "ROMAN", "GALLARDO", "MADRID", "MIRANDA", "SANCHEZ", "RODRIGUEZ", "REY", "SANCHEZ FERNANDEZ", "PARDO",
                "FERNANDEZ SANCHEZ", "VELASCO", "GONZALEZ MARTINEZ", "GARCIA MORENO", "RIVAS", "RODRIGUEZ MARTINEZ", "CASAS", "GONZALEZ SANCHEZ",
                "RUIZ GARCIA", "GONZALEZ MARTIN", "MARTINEZ GONZALEZ", "PALACIOS" };

        private void btnMain_Click(object sender, EventArgs e)
        {
            /*Volver a nuestra pagina principal*/
            this.Hide();
            main main = new main();
            main.Show();
        }

        string[] nombres1 = {"JUAN MANUEL","SANTIAGO","EDUARDO","VICTOR","MARIO","ROBERTO","JAIME","FRANCISCO JOSE","IGNACIO","MARCOS","ALFONSO","JORDI",
                "SALVADOR","RICARDO","EMILIO","HUGO","GUILLERMO","GABRIEL","JULIAN","JULIO","MARC","TOMAS","JOSE MIGUEL","GONZALO","MARIA CARMEN","MARIA",
                "CARMEN","JOSEFA","ANA MARIA","ISABEL","MARIA PILAR","MARIA DOLORES","LAURA","MARIA TERESA","CRISTINA","MARIA ANGELES","MARTA","FRANCISCA",
                "ANTONIA","MARIA ISABEL","MARIA JOSE","DOLORES","LUCIA"};


    }
}
