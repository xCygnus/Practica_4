using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4.Class
{
    class Vector
    {
        //Llena el vector con numeros aleatorios
        public int[] llenar_Aleatorios(int[] vector, int x)
        {
            Random aleatorio = new Random();

            for (int i = 0; i < x; i++)
            {

                int numero_aleatorio = aleatorio.Next(0, 100);
                vector[i] = numero_aleatorio;
            }
            return vector;
        }
        //invierte los elementos de un vector
        public int[] Invertir_vector(int[] vector, int x)
        {
            
            int aux;
            int auxiliar_invertir;
            int b = x;

            for (int i = 0; i <= b / 2; i++)
            {
                auxiliar_invertir = vector[i];
                vector[i] = vector[b - 1];
                vector[b - 1] = auxiliar_invertir;

                b--;
            }
            return vector;
        }
}
}
