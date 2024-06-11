namespace Ejercicio1
{
    partial class FormResultado
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
            this.lbx_resultados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_resultados
            // 
            this.lbx_resultados.FormattingEnabled = true;
            this.lbx_resultados.ItemHeight = 16;
            this.lbx_resultados.Location = new System.Drawing.Point(6, 21);
            this.lbx_resultados.Name = "lbx_resultados";
            this.lbx_resultados.Size = new System.Drawing.Size(410, 340);
            this.lbx_resultados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_resultados);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormResultado";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lbx_resultados;
        private System.Windows.Forms.Button button1;
    }
}