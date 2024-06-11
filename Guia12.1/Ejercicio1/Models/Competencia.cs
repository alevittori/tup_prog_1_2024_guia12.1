using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Competencia
    {
        public string[] listaNombre = new string[100];
        public int[] listaTiempo = new int[100];
        public int contador = 0;

        public void AgregarCompetidor(string nombre)
        {
            listaNombre[contador] = nombre;
            contador++;
        }
        public void CargarTiempo(int numCompetidor, int HH, int MM)
        {
            int hora = HH + (MM * 60);
            listaTiempo[numCompetidor] = hora; 

        }

        public void OrderListadoPorTiempo()
        {
            int aux;
            string auxNom;
            for (int i = 0; i < contador; i++)
            {
                for (int j = 0; j < contador; j++)
                {
                    if (listaTiempo[i] > listaTiempo[j])
                    {
                        aux = listaTiempo[j];
                        listaTiempo[j] = listaTiempo[i];
                        listaTiempo[i]= aux;

                        auxNom = listaNombre[j];
                        listaNombre[j] = listaNombre[i];
                        listaNombre[i]= auxNom;

                    }
                }
            }
        }
    }
}
