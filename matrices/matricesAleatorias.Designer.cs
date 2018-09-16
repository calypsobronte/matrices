namespace matrices
{
    partial class matricesAleatorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(matricesAleatorias));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "En esta App podras encontra, ya datos almacenados, lo unico que tienes que hacer\r" +
    "\n es darle en el boton Crear y el aleatoriamente coge los datos trasformandolos " +
    "en Cedula,\r\n Nombre, Apellido y Edad.\r\n";
            // 
            // dgvMatriz
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatriz.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(24, 106);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(680, 332);
            this.dgvMatriz.TabIndex = 1;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Transparent;
            this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
            this.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrear.Location = new System.Drawing.Point(720, 117);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(68, 82);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrar.BackgroundImage")));
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrar.Location = new System.Drawing.Point(720, 233);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(68, 73);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMain.BackgroundImage")));
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMain.Location = new System.Drawing.Point(742, 394);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(46, 44);
            this.btnMain.TabIndex = 4;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // matricesAleatorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.label1);
            this.Name = "matricesAleatorias";
            this.Text = "Matrices Aleatorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMain;
    }
}