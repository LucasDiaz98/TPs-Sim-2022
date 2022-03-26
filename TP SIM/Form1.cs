using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP_SIM
{
    public partial class TP1 : Form
    {
        //Variables.
        double k = 0;
        double c = 0;
        double g = 0;
        double semilla = 0;
        double numSimulaciones = 0;
        string mensajeError = "";
        List<double> numerosRND;
        List<Intervalo> intervalos;

        public TP1()
        {
            InitializeComponent();
        }


        //Aca se hace la carga de datos del formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            btnIntervalos.Enabled = false;
            btnHistograma.Enabled = false;
            btnGenerar.Enabled = false;
            cmb_Metodo.Items.Add("Metodo lineal congruente mixto");
            cmb_Metodo.Items.Add("Metodo lineal congruente multiplicativo");
            cmbIntervalos.Items.Add("5");
            cmbIntervalos.Items.Add("8");
            cmbIntervalos.Items.Add("10");
            cmbIntervalos.Items.Add("12");
        }


        //Esta funcion es la que se encarga de ...
        private List<Intervalo> generarIntervalos(double n)
        {
            List<Intervalo> intervalos = new List<Intervalo>();
            double valor = Math.Round(1 / n, 4);
            double valor_ant = 0;
            int iteracion = 0;
            for (int i = 0; i < n; i++)
            {
                double valor_act = Math.Round(valor * (i + 1), 4);
                intervalos.Add(generarObjetoIntervalo(valor_ant, valor_act,iteracion));
                valor_ant = valor_act;
                iteracion += 1; 
                
            }
            return intervalos;
        }


        //Esta funcion se encarga de ...
        private Intervalo generarObjetoIntervalo(double inf, double sup,int iteracion)
        {
            Intervalo intervalo = new Intervalo()
            {
                Valor_inf = inf,
                Valor_sup = sup,
                Marca_clase = Math.Round(((inf + sup) / 2),2),
                Frecuencia_observada = 0,
                Num_iteracion = iteracion
            };
        return intervalo;

        }


        //Esta funcion calcula las frecuencias que posteriormente van a ser usadas en el evento que genera el boton "Calcular intervalos".
        private void calcularFrecuencias(List<double> listrnd, List<Intervalo> intervalos)
        {
            foreach (Intervalo intervalo in intervalos)
            {
                intervalo.Frecuencia_esperada = listrnd.Count / intervalos.Count;
            }

            foreach (double rnd in listrnd)
            {
                foreach (Intervalo intervalo in intervalos)
                {
                    
                    if (intervalo.estaEnIntervalo(rnd))
                    {
                        intervalo.Frecuencia_observada += 1;
                        break;
                    }
                }
            }
        }


        //Esta funcion es la que se encarga de generar los numeros aleatorios, recibe como parametros la semilla,
        //una constante g, una constante k, el incremento c y el numero de simulaciones. Todos estos numeros
        //aleatorios generados son guardados dentro de una lista.
        private List<double> generadorNumerosAleatorios(double semilla, double g, double k, double c, double n)
        {
            double multiplicador = 1 + 4 * k;
            double modulo = Math.Pow(2, g);
            double x;
            double rnd;
            List<double> numerosRandom = new List<double>();

            for (int i = 0; i < n; i++)
            {
                //Esta ecuacion recursiva es la que se encarga de ir generando los numeros aleatorios.
                x = (multiplicador * semilla + c) % modulo;
                rnd = Math.Round((x) / (modulo), 4);
                numerosRandom.Add(rnd);
                semilla = x;
            }
            return numerosRandom;
        }


        //Esta funcion se encarga de tomar todos los datos ingresados por el usuario y muestra la lista generada de numeros aleatorios.
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //if (Double.TryParse(txtK.Text, out k)) ;
            //else
            //{
            //    mensajeError += "-El valor ingresado para k no es valido \n";
            //}
            k = Convert.ToDouble(txtK.Text);
            c = Convert.ToDouble(txtC.Text);
            g = Convert.ToDouble(txtG.Text);
            semilla = Convert.ToDouble(txtSemilla.Text);
            numSimulaciones = Convert.ToDouble(txt_numSimulaciones.Text);
            numerosRND = generadorNumerosAleatorios(semilla, g, k, c, numSimulaciones);
            listaNumeros.DataSource = numerosRND;
            txtM.Text = Math.Pow(2, g).ToString();

            if (cmbIntervalos.SelectedIndex == 0)
            {
                txtMaxPeriodo.Text = txtM.Text;
            }
            else 
            {
                var calculo = int.Parse(txtM.Text) / 4;
                txtMaxPeriodo.Text = calculo.ToString();
            }
        }


        //Esta funcion toma la seleccion que se hace del numero de intervalos que se quiere y genera la grilla
        //con los datos correspondientes.
        private void btnIntervalos_Click(object sender, EventArgs e)
        {
            //List<Intervalo> intervalos = generarIntervalos(Convert.ToDouble(txtIntervalos.Text));
            //List<Intervalo> intervalos = Convert.ToDouble(cmbIntervalos.SelectedItem.ToString());
            btnHistograma.Enabled = true;
            int numeroIntervalos = int.Parse(cmbIntervalos.SelectedItem.ToString());
            List<Intervalo> intervalos = generarIntervalos(numeroIntervalos);
            calcularFrecuencias(numerosRND, intervalos);
            dgIntervalos.DataSource = intervalos;
            this.intervalos = intervalos;
            intervalos = new List<Intervalo>();
        }


        //En esta funcion creamos la clase Intervalo e inicializamos sus valores.
        public class Intervalo
        {
            private int numIteracion;
            private double valor_inf;
            private double valor_sup;
            private double marca_clase;
            private int frecuencia_observada;
            private int frecuencia_esperada;
            private int frecuencia_relativa;
            private int frecuencia_acumulada;
            private int frecuencia_relativa_acumulada;

            public int Num_iteracion { get => numIteracion; set => numIteracion = value; }
            public double Valor_inf { get => valor_inf; set => valor_inf = value; }
            public double Valor_sup { get => valor_sup; set => valor_sup = value; }
            public double Marca_clase { get => marca_clase; set => marca_clase = value; }
            public int Frecuencia_observada { get => frecuencia_observada; set => frecuencia_observada = value; }
            public int Frecuencia_esperada { get => frecuencia_esperada; set => frecuencia_esperada = value; }
            public int Frecuencia_relativa { get => frecuencia_relativa; set => frecuencia_relativa = value; }
            public int Frecuencia_acumulada { get => frecuencia_acumulada; set => frecuencia_acumulada = value; }
            public int Frecuencia_relativa_acumulada { get => frecuencia_relativa_acumulada; set => frecuencia_relativa_acumulada = value; }

            public bool estaEnIntervalo(double rnd)
            {
                return (this.valor_inf <= rnd && rnd < this.valor_sup);
            }

            public string intervaloString()
            {
                return valor_inf.ToString() + " - " + valor_sup.ToString();
            }

        }


        //Esta funcion es la que se encarga de generar el histograma.
        private void btnHistograma_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < intervalos.Count; i++)
            {
                chart1.Series["Frecuencia observada"].Points.AddXY(intervalos[i].intervaloString(), intervalos[i].Frecuencia_observada);
                chart1.Series["Frecuencia esperada"].Points.AddY(intervalos[i].Frecuencia_esperada);
            }
        }


        //Esta funcion nos permite validar que segun el metodo que se elija, estara habilitada o no la opcion de agregar un valor a "c".
        private void cmb_Metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
            if (cmb_Metodo.SelectedIndex == 1)
            {
                txtC.Text = 0.ToString();
                txtC.Enabled = false;
            }
            else 
            {
                txtC.Enabled = true;
                txtC.Text = "";
            }
        }


        //Esta funcion se encarga de limpiar los campos.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_numSimulaciones.Text = "";
            txtSemilla.Text = "";
            txtG.Text = "";
            txtK.Text = "";
            txtM.Text = "";
            txtC.Text = "";
            txtMaxPeriodo.Text = "";
            cmb_Metodo.SelectedIndex = -1;
            listaNumeros.DataSource = null;
            listaNumeros.Items.Clear();
        }


        //Esta funcion cambia el estado del boton "Calcular intervalos" al elegir una cantidad de intervalos.
        private void cmbIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIntervalos.Enabled = true;
        }
    }
}
