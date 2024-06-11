using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Competencia miControlador = new Competencia();
        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Ejercicio 1";
        }

        private void btn_addCompetidor_Click(object sender, EventArgs e)
        {
            FormInscripcion VentaInscripcion = new FormInscripcion();
            string loquesea = "hola Tonfa";
            loquesea = VentaInscripcion.tb_nombreCompetidor.Text;
            miControlador.AgregarCompetidor(loquesea);
        }
    }
}
