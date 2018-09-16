namespace matrices
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnAleatoria = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblAutorApodo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel Principal";
            // 
            // btnAcerca
            // 
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.Location = new System.Drawing.Point(659, 384);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(111, 41);
            this.btnAcerca.TabIndex = 1;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnAleatoria
            // 
            this.btnAleatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatoria.Location = new System.Drawing.Point(473, 187);
            this.btnAleatoria.Name = "btnAleatoria";
            this.btnAleatoria.Size = new System.Drawing.Size(185, 56);
            this.btnAleatoria.TabIndex = 2;
            this.btnAleatoria.Text = "Matrices Aleatorias";
            this.btnAleatoria.UseVisualStyleBackColor = true;
            this.btnAleatoria.Click += new System.EventHandler(this.btnAleatoria_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(150, 187);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(182, 56);
            this.btnManual.TabIndex = 3;
            this.btnManual.Text = "Matrices Manueles";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // lblAutorApodo
            // 
            this.lblAutorApodo.AutoSize = true;
            this.lblAutorApodo.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorApodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAutorApodo.Location = new System.Drawing.Point(12, 412);
            this.lblAutorApodo.Name = "lblAutorApodo";
            this.lblAutorApodo.Size = new System.Drawing.Size(90, 13);
            this.lblAutorApodo.TabIndex = 5;
            this.lblAutorApodo.Text = "@calypso_bronte";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAutor.Location = new System.Drawing.Point(10, 384);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(238, 20);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Lina María Montaño Ramírez";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAutorApodo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnAleatoria);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Main ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnAleatoria;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label lblAutorApodo;
        private System.Windows.Forms.Label lblAutor;
    }
}

