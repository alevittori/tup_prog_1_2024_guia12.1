namespace Ejercicio1
{
    partial class FormTiempo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_numeroCompetidor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.tb_sec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Competidor";
            // 
            // lb_numeroCompetidor
            // 
            this.lb_numeroCompetidor.AutoSize = true;
            this.lb_numeroCompetidor.Location = new System.Drawing.Point(176, 36);
            this.lb_numeroCompetidor.Name = "lb_numeroCompetidor";
            this.lb_numeroCompetidor.Size = new System.Drawing.Size(19, 16);
            this.lb_numeroCompetidor.TabIndex = 1;
            this.lb_numeroCompetidor.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(101, 82);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(50, 22);
            this.tb_min.TabIndex = 3;
            // 
            // tb_sec
            // 
            this.tb_sec.Location = new System.Drawing.Point(179, 82);
            this.tb_sec.Name = "tb_sec";
            this.tb_sec.Size = new System.Drawing.Size(55, 22);
            this.tb_sec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(29, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_sec);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_numeroCompetidor);
            this.Controls.Add(this.label1);
            this.Name = "FormTiempo";
            this.Text = "FormTiempo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_numeroCompetidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tb_min;
        public System.Windows.Forms.TextBox tb_sec;
    }
}