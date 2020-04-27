using Practica_4.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        Vector arreglo;
        public Form1()
        {
            InitializeComponent();
            arreglo = new Vector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "") // Muestra un mensaje si no se ingresa un valor en la longitud
            {
                MessageBox.Show("Por favor ingrese el tamaño del vector");
                textbox.Focus();
                return;
            }

            int x; // variable donde se almacena la longitud del vector

            //Controla la excepcion de que el usuario no ingrese valores numericos
            try
            {
                x = Int32.Parse(textbox.Text);
            }
            catch (Exception d)
            {
                MessageBox.Show("Ingreso un valor invalido");
                textbox.Focus();
                return;
            }

            // Controla la excepcion de que el usuario ingrese un valor negativo
            if (x <= 0)
            {
                MessageBox.Show("No se puede ingresar un tamaño negativo para el vector");
                textbox.Focus();
                return;
            }


            int[] v = new int[x];
            int[] vector = v; // creamos el vector que va almacenar la informacion

            //Determinar si el usuario quiere ingresar los elementos del vector
            // o quiere que el programa los genere aleatoriamente

            //Controlamos que el usuario no ingrese valor alguno en el textbox
            if (txtdecision.Text == "")
            {
                MessageBox.Show("Por favor ingrese como quiere que el vector se llene");
                txtdecision.Focus();
                return;
            }

            int decision; // variable donde se almacena la longitud del vector

            //Controla la excepcion de que el usuario no ingrese un valor numerico
            try
            {
                decision = Int32.Parse(txtdecision.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Las posibilidades no incluyen letras o numeros diferentes de enteros");
                txtdecision.Focus();
                return;
            }

            // Controlamos si el usuario ingresa un valor distinto de 0  o 1
            if (decision < 0 || decision > 1)
            {
                MessageBox.Show("El valor ingresado esta por fuera de las posibilidades");
                txtdecision.Focus();
                return;
            }
            //Si el usuario escoge la primera opcion, el vector se llena aleatoriamente
            if (decision == 0)
            {

                lista.Rows.Add(x - 1);

                arreglo.llenar_Aleatorios(vector, x); // Llenamos el vector con numeros aleatorios

                for (int i = 0; i < x; i++)
                {
                    //agregamos los elementos de la primer columna

                    lista.Rows[i].Cells[0].Value = i + 1;
                    lista.Rows[i].Cells[1].Value = vector[i];
                }
            }
            //Algoritmo que se implementa si el usuario decide ingresar los valores manualmente
            else if (decision == 1)
            {
                // Mostramos los forms correspondientes a esta opcion

                lbelemento.Visible = true;
                txtelemento.Visible = true;
                btingresar.Visible = true;
                lbpos.Visible = true;
                txtpos.Visible = true;
                lbstop.Visible = true;
                Parar.Visible = true;
                lbintercambio.Visible = true;
                txtintercambio1.Visible = true;
                txtintercambio2.Visible = true;
                btintercambio.Visible = true;
                btinvert.Visible = true;
                lbinvert.Visible = true;
                lbcambio.Visible = true;
                txtcambio.Visible = true;
                txtchoice.Visible = true;
                label4.Visible = true;


                lista.Rows.Add(x - 1);

                for (int i = 0; i < x; i++)
                {
                    lista.Rows[i].Cells[0].Value = i + 1;

                }

            }
            //Mostramos los controles en caso de que el usuario escoga la primera opcion
            lbcambio.Visible = true;
            lbchange.Visible = true;
            txtcambio.Visible = true;
            txtchange.Visible = true;
            btchange.Visible = true;
            lbintercambio.Visible = true;
            txtintercambio1.Visible = true;
            txtintercambio2.Visible = true;
            btintercambio.Visible = true;
            btinvert.Visible = true;
            lbinvert.Visible = true;
            lbcambio.Visible = true;
            txtcambio.Visible = true;
            txtchoice.Visible = true;
            label4.Visible = true;

            }  

        public void btingresar_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textbox.Text);
            int posicion;
            int elemento;

            if (txtpos.Text == "") // controlamos la excepcion de que no ingrese un valor
            {
                MessageBox.Show("Ingrese por favor una posicion");
                txtpos.Focus();
                return;
            }
            else
            {
                try
                {
                    posicion = Int32.Parse(txtpos.Text); // intentamos convertirlo a tipo int
                }
                catch (Exception d)
                {
                    MessageBox.Show("Por favor ingrese un valor numerico entero");
                    txtpos.Focus();
                    return;

                }
            }

            if (txtelemento.Text == "") // controlamos la excepcion de que no ingrese un valor
            {
                MessageBox.Show("Ingrese por favor un elemento");
                txtelemento.Focus();
                return;
            }
            else
            {
                try
                {
                    elemento = Int32.Parse(txtelemento.Text); // intentamos convertirlo a tipo int
                }
                catch (Exception d)
                {
                    MessageBox.Show("Por favor ingrese un valor numerico entero");
                    txtelemento.Focus();
                    return;

                }
            }

            if (posicion > x || posicion < 0)
            {
                MessageBox.Show("La posicion ingresada no existe en el vector");
            }
            else
            {
                lista.Rows[posicion - 1].Cells[1].Value = elemento;
            }

        }


        private void Parar_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textbox.Text);


            int[] vector = new int[x];

            //LLena el vector de ceros en caso de que el usuario no quiera seguir llenandolo
            for (int j = 0; j < x; j++)
            {
                if (lista.Rows[j].Cells[1].Value == null)
                {
                    lista.Rows[j].Cells[1].Value = 0;
                }
            }

        }

        private void txtparar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btchange_Click(object sender, EventArgs e)
        {
            int posicion_cambio;
            int x = Int32.Parse(textbox.Text);

            //Evaluamos si la posicion ingresada no genera excepciones

            if (txtcambio.Text == "")
            {
                MessageBox.Show("Por favor ingresar una posicion para cambiarle el valor");
                txtcambio.Focus();
                return;
            }
            else
            {
                try
                {
                    posicion_cambio = Int32.Parse(txtcambio.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor ingrese un numero entero");
                    txtcambio.Focus();
                    return;
                }

            }

            //evaluamos si la posicion si se encuentra dentro del vector
            if (posicion_cambio > x || posicion_cambio < 0)
            {
                MessageBox.Show("La posicion no existe dentro del vector");
                txtcambio.Focus();
                return;
            }


            // ahora evaluamos la decision tomada por el usuario de si ingresar un numero aleatorio
            // o que el mismo lo ingrese

            int choice;

            if (txtchoice.Text == "")
            {
                MessageBox.Show("Por favor escoga una opcion");
                txtchoice.Focus();
                return;
            }
            else
            {
                try
                {
                    choice = Int32.Parse(txtchoice.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor ingrese un numero entero");
                    txtchoice.Focus();
                    return;

                }

            }
            if (choice < 0 || choice > 1)
            {
                MessageBox.Show("Escogio una posibilidad invalidad");
                txtchoice.Focus();
                return;

            }
            else if (choice == 0)
            {
                int elemento;

                if (txtchange.Text == "")
                {
                    MessageBox.Show("Por favor ingres un elemento");
                    txtchange.Focus();
                    return;
                }
                else
                {
                    elemento = Int32.Parse(txtchange.Text);
                    lista.Rows[posicion_cambio - 1].Cells[1].Value = elemento;
                }
            }
            else if (choice == 1)
            {
                int elemento;

                Random aleatorio = new Random();
                elemento = aleatorio.Next(0, 100);

               lista.Rows[posicion_cambio - 1].Cells[1].Value = elemento;

                
            }
        }

        private void btintercambio_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textbox.Text);
            int posicion1;
            int posicion2;



            //Cubrimos las excepciones que pueda generar el usuario al momento de ingresar valores
            if (txtintercambio1.Text == "")
            {
                MessageBox.Show("Por favor ingrese una posicion para intercambiar");
                txtintercambio1.Focus();
                return;

            }
            else
            {
                try
                {
                    posicion1 = Int32.Parse(txtintercambio1.Text);
                }
                catch (Exception d)
                {
                    MessageBox.Show("Por favor ingrese un numero entero");
                    txtintercambio1.Focus();
                    return;
                }
            }
            if (txtintercambio2.Text == "")
            {
                MessageBox.Show("Por favor ingrese una posicion para intercambiar al vector");
                txtintercambio2.Focus();
                return;

            }
            else
            {
                try
                {
                    posicion2 = Int32.Parse(txtintercambio2.Text);
                }
                catch (Exception d)
                {
                    MessageBox.Show("Por favor ingrese un numero entero");
                    txtintercambio2.Focus();
                    return;
                }

                //Aplicamos el algoritmo que intercambia las posiciones
            }
            //Controlamos si el usuario ingresa una posicion que no existe en el vector
            if (posicion1 > x || posicion1 <= 0)
            {
                MessageBox.Show("La posicion ingresada no existe en el vector");
            }
            else if (posicion2 > x || posicion2 < 0)
            {
                MessageBox.Show("La posicion ingresada no existe en el vector");
            }

            //Realizamos el intercambio si la posicion ingresada es valida
            else

            {
                int auxiliar;

                auxiliar = Int32.Parse(lista.Rows[posicion1 - 1].Cells[1].Value.ToString());
                lista.Rows[posicion1 - 1].Cells[1].Value = lista.Rows[posicion2 - 1].Cells[1].Value;

                lista.Rows[posicion2 - 1].Cells[1].Value = auxiliar;
            }


        }

        private void btinvert_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textbox.Text); //almacenamos la longitud del vector

            int[] vector = new int[x]; // creamos un vector que almacena la segunda columna del datagrid
            int aux;
            int auxiliar_invertir;
            int b = x;

            //creamos el bucle for que recorre los elementos de la segunda columna 
            //y los almacena en un arreglo

            for (int i = 0; i < x; i++)
            {
                aux = Int32.Parse(lista.Rows[i].Cells[1].Value.ToString());
                vector[i] = aux;
            }


            arreglo.Invertir_vector(vector, x);

            //agregamos una columna al nuevo datagrid
            lista2.Rows.Add(x - 1);

            //hacemos visible en el form el nuevo datagrid que muestra el vector invertido
            lista2.Visible = true;

            for (int j = 0; j < x; j++)
            {
                lista2.Rows[j].Cells[0].Value = j + 1; //mostramos el nuevo vector con sus posiciones
                lista2.Rows[j].Cells[1].Value = vector[j];
            }

        }
    }
}







