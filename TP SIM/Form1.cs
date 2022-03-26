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
    public partial class Form1 : Form
    {
        double k = 0;
        double c = 0;
        double g = 0;
        double semilla = 0;
        double numSimulaciones = 0;
        string mensajeError = "";
        List<double> numerosRND;
        List<Intervalo> intervalos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        
        private List<Intervalo> generarIntervalos(double n)
        {
            List<Intervalo> intervalos = new List<Intervalo>();
            double valor = Math.Round(1 / n, 4);
            double valor_ant = 0;
            for (int i = 0; i < n; i++)
            {
                double valor_act = Math.Round(valor * (i + 1), 4);
                intervalos.Add(generarObjetoIntervalo(valor_ant, valor_act));
                valor_ant = valor_act;
            }
            return intervalos;
        }

        private Intervalo generarObjetoIntervalo(double inf, double sup)
        {
            Intervalo intervalo = new Intervalo()
            {
                Valor_inf = inf,
                Valor_sup = sup,
                Frecuencia_observada = 0
            };
        return intervalo;

        }

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



        private List<double> generadorNumerosAleatorios(double semilla, double g, double k, double c, double n)
        {
            double multiplicador = 1 + 4 * k;
            double modulo = Math.Pow(2, g);
            double x;
            double rnd;
            List<double> numerosRandom = new List<double>();

            for (int i = 0; i < n; i++)
            {
                x = (multiplicador * semilla + c) % modulo;
                rnd = Math.Round((x) / (modulo), 4);
                numerosRandom.Add(rnd);
                semilla = x;
            }
            return numerosRandom;
        }

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

        }

        private void btnIntervalos_Click(object sender, EventArgs e)
        {
            List<Intervalo> intervalos = generarIntervalos(Convert.ToDouble(txtIntervalos.Text));
            calcularFrecuencias(numerosRND, intervalos);
            dgIntervalos.DataSource = intervalos;
            this.intervalos = intervalos;
            
        
        }

        public class Intervalo
        {
            private double valor_inf;
            private double valor_sup;
            private int frecuencia_observada;
            private int frecuencia_esperada;

            
            public double Valor_sup { get => valor_sup; set => valor_sup = value; }
            public double Valor_inf { get => valor_inf; set => valor_inf = value; }
            public int Frecuencia_observada { get => frecuencia_observada; set => frecuencia_observada = value; }
            public int Frecuencia_esperada { get => frecuencia_esperada; set => frecuencia_esperada = value; }

            public bool estaEnIntervalo(double rnd)
            {
                return (this.valor_inf <= rnd && rnd < this.valor_sup);
            }

            public string intervaloString()
            {
                return valor_inf.ToString() + " - " + valor_sup.ToString();
            }

        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < intervalos.Count; i++)
            {
                chart1.Series["Frecuencia observada"].Points.AddXY(intervalos[i].intervaloString(), intervalos[i].Frecuencia_observada);
                chart1.Series["Frecuencia esperada"].Points.AddY(intervalos[i].Frecuencia_esperada);

            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
