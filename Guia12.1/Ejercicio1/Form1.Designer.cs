namespace Ejercicio1
{
    partial class Form1
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
            this.btn_addCompetidor = new System.Windows.Forms.Button();
            this.btn_cargarTiempo = new System.Windows.Forms.Button();
            this.btn_verResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addCompetidor
            // 
            this.btn_addCompetidor.Location = new System.Drawing.Point(90, 40);
            this.btn_addCompetidor.Name = "btn_addCompetidor";
            this.btn_addCompetidor.Size = new System.Drawing.Size(137, 53);
            this.btn_addCompetidor.TabIndex = 0;
            this.btn_addCompetidor.Text = "Agregar Competidor";
            this.btn_addCompetidor.UseVisualStyleBackColor = true;
            this.btn_addCompetidor.Click += new System.EventHandler(this.btn_addCompetidor_Click);
            // 
            // btn_cargarTiempo
            // 
            this.btn_cargarTiempo.Location = new System.Drawing.Point(90, 110);
            this.btn_cargarTiempo.Name = "btn_cargarTiempo";
            this.btn_cargarTiempo.Size = new System.Drawing.Size(137, 53);
            this.btn_cargarTiempo.TabIndex = 1;
            this.btn_cargarTiempo.Text = "Cargar Tiempos de Competidores";
            this.btn_cargarTiempo.UseVisualStyleBackColor = true;
            // 
            // btn_verResultados
            // 
            this.btn_verResultados.Location = new System.Drawing.Point(90, 180);
            this.btn_verResultados.Name = "btn_verResultados";
            this.btn_verResultados.Size = new System.Drawing.Size(137, 53);
            this.btn_verResultados.TabIndex = 2;
            this.btn_verResultados.Text = "Ver Resultados";
            this.btn_verResultados.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 311);
            this.Controls.Add(this.btn_verResultados);
            this.Controls.Add(this.btn_cargarTiempo);
            this.Controls.Add(this.btn_addCompetidor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addCompetidor;
        private System.Windows.Forms.Button btn_cargarTiempo;
        private System.Windows.Forms.Button btn_verResultados;
    }
}

