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
        List<double> numerosRND = new List<double>();
        List<Intervalo> intervalos = new List<Intervalo>();
        double[] valores_chi = { 3.84, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7 };
        double[] valores_ks = { 0.9750, 0.8418, 0.7076, 0.6239, 0.5632, 0.5192, 0.4834, 0.4542, 0.4300, 0.4092
                , 0.3912, 0.3754, 0.3614, 0.3489, 0.3375, 0.3273, 0.3179, 0.3093, 0.3014, 0.2940
                , 0.2872, 0.2808, 0.2749, 0.2693, 0.2640, 0.2590, 0.2543, 0.2499, 0.2457, 0.2417 };


        public TP1()
        {
            InitializeComponent();
        }


        //Aca se hace la carga de datos del formulario en el load.
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_numSimulaciones.Enabled = false;
            btnIntervalos.Enabled = false;
            btnHistograma.Enabled = false;
            btnGenerar.Enabled = false;
            cmbIntervalos.Enabled = false;
            cmb_Metodo.Items.Add("Metodo lineal congruente mixto");
            cmb_Metodo.Items.Add("Metodo lineal congruente multiplicativo");
            cmb_Metodo.Items.Add("Metodo generador del lenguaje");
            cmbIntervalos.Items.Add("5");
            cmbIntervalos.Items.Add("8");
            cmbIntervalos.Items.Add("10");
            cmbIntervalos.Items.Add("12");
            btnLimpiarHistograma.Enabled = false;
            cmbChi.Items.Add("Prueba de chi-cuadrado");
            cmbChi.Items.Add("Prueba de Ks");
            chart1.Titles["Frecuencia observada"].Visible = false;
            chart1.Titles["Frecuencia esperada"].Visible = false;
            chart1.Titles["Histograma de frecuencias"].Visible = false;
        }


        //Esta funcion es la que se encarga de crear los intervalos. (VER)
        private List<Intervalo> generarIntervalos(double n)
        {
            List<Intervalo> intervalos = new List<Intervalo>();
            double valor = Math.Round(1 / n, 4);
            double valor_ant = 0;
            for (int i = 0; i < n; i++)
            {
                double valor_act = Math.Round(valor * (i + 1), 4);
                intervalos.Add(generarObjetoIntervalo(valor_ant, valor_act, i + 1));
                valor_ant = valor_act;
            };
            
            if (n == 12)
            {
                intervalos.Last().Valor_sup = 1;
            }
            
            return intervalos;
        }


        //Esta funcion se encarga de la creacion de un objeto definiendo el valor que van a
        //tener sus variables y los agrega a una lista de intervalos. (VER)
        private Intervalo generarObjetoIntervalo(double inf, double sup, int iteracion)
        {
            Intervalo intervalo = new Intervalo()
            {
                Valor_inf = inf,
                Valor_sup = sup,
                Marca_clase = Math.Round(((inf + sup) / 2), 4),
                Frecuencia_observada = 0,
                Num_iteracion = iteracion,
                Frecuencia_esperada = 0,
                Frecuencia_relativa = 0,
                Frecuencia_acumulada = 0,
                Frecuencia_relativa_acumulada = 0
            };
            return intervalo;
        }


        //Esta funcion calcula las frecuencias que posteriormente van a ser usadas en el evento que genera el boton "Calcular intervalos".
        private void calcularFrecuencias(List<double> listrnd, List<Intervalo> intervalos)
        {
            double acumulador = 0;
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
                        intervalo.Frecuencia_relativa += Math.Round(1 / Convert.ToDouble(listrnd.Count), 4);

                        break;
                    }
                }
            }
            for (int i = 0; i < intervalos.Count; i++)
            {
                if (i != 0)
                {
                    intervalos[i].Frecuencia_relativa_acumulada = Math.Round(intervalos[i - 1].Frecuencia_relativa_acumulada + intervalos[i].Frecuencia_relativa, 4);
                    intervalos[i].Frecuencia_acumulada = intervalos[i - 1].Frecuencia_acumulada + intervalos[i].Frecuencia_observada;
                }
                else
                {
                    intervalos[i].Frecuencia_relativa_acumulada = intervalos[i].Frecuencia_relativa;
                    intervalos[i].Frecuencia_acumulada = intervalos[i].Frecuencia_observada;
                }
            }
        }


        //Esta funcion es la que se encarga de generar los numeros aleatorios, recibe como parametros la semilla,
        //una constante g, una constante k, el incremento c y el numero de simulaciones. Todos estos numeros
        //aleatorios generados son guardados dentro de una grilla.
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
            cmbIntervalos.Enabled = true;
            numerosRND.Clear();
            dgRND.Rows.Clear();

            //double media = calculoMedia(dgIntervalos, intervalos.Count);
            //lblMedia.Text

            if (cmb_Metodo.SelectedIndex == 2)
            {
                if (txt_numSimulaciones.Text == "")
                {
                    MessageBox.Show("Por favor asegurese de llenar todos los campos disponibles", "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    numSimulaciones = Convert.ToDouble(txt_numSimulaciones.Text);
                    numerosRND = generadorLenguajeNumerosAleatorios(numSimulaciones);
                    llenarGrillaRND(numerosRND);
                    //listaNumeros.DataSource = numerosRND;
                }
                
            }
            else
            {
                if (txt_numSimulaciones.Text == "" || txtSemilla.Text == "" || txtK.Text == "" || txtG.Text == "" || txtC.Text == "")
                {
                    MessageBox.Show("Por favor asegurese de llenar todos los campos disponibles", "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    k = Convert.ToDouble(txtK.Text);
                    c = Convert.ToDouble(txtC.Text);
                    g = Convert.ToDouble(txtG.Text);
                    semilla = Convert.ToDouble(txtSemilla.Text);
                    numSimulaciones = Convert.ToDouble(txt_numSimulaciones.Text);
                    numerosRND = generadorNumerosAleatorios(semilla, g, k, c, numSimulaciones);
                    llenarGrillaRND(numerosRND);
                    //listaNumeros.DataSource = numerosRND;
                    txtM.Text = Math.Pow(2, g).ToString();
                    if (cmb_Metodo.SelectedIndex == 0)
                    {
                        txtMaxPeriodo.Text = txtM.Text;
                    }
                    else
                    {
                        var calculo = int.Parse(txtM.Text) / 4;
                        txtMaxPeriodo.Text = calculo.ToString();
                    }

                }
                                
            }
            
        }


        //Esta funcion se encarga de generar los numeros aleatorios con el generador del lenguaje.
        private List<double> generadorLenguajeNumerosAleatorios(double nroSim)
        {
            List<double> numerosRandom = new List<double>();
            var random = new Random((int)nroSim);
            double rand;
            for (int i = 0; i < nroSim; i++)
            {
                rand = Math.Round((random.NextDouble()), 4);
                numerosRandom.Add(rand);
            }
            return numerosRandom;
        }


        //Esta funcion se encarga de ir llenando la grilla con los valores que le son asignados. (VER ESTE COMENTARIO)
        private void llenarGrillaIntervalos(List<Intervalo> intervalos)
        {
            foreach (Intervalo intervalo in intervalos)
            {
                dgIntervalos.Rows.Add(intervalo.Num_iteracion, intervalo.Valor_inf, intervalo.Valor_sup, intervalo.Marca_clase, intervalo.Frecuencia_observada,
                    intervalo.Frecuencia_relativa, intervalo.Frecuencia_acumulada, intervalo.Frecuencia_relativa_acumulada, intervalo.Frecuencia_esperada);
            }
        }

        private void llenarGrillaRND(List<double> randoms)
        {
            for (int i = 0; i < randoms.Count; i++)
            {
                dgRND.Rows.Add(i + 1, randoms[i]);
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
            llenarGrillaIntervalos(intervalos);
            this.intervalos = intervalos;
            intervalos = new List<Intervalo>();
            btnIntervalos.Enabled = false;
            btnPrueba.Enabled = true;
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
            private double frecuencia_relativa;
            private int frecuencia_acumulada;
            private double frecuencia_relativa_acumulada;

            public int Num_iteracion { get => numIteracion; set => numIteracion = value; }
            public double Valor_inf { get => valor_inf; set => valor_inf = value; }
            public double Valor_sup { get => valor_sup; set => valor_sup = value; }
            public double Marca_clase { get => marca_clase; set => marca_clase = value; }
            public int Frecuencia_observada { get => frecuencia_observada; set => frecuencia_observada = value; }
            public int Frecuencia_acumulada { get => frecuencia_acumulada; set => frecuencia_acumulada = value; }
            public double Frecuencia_relativa { get => frecuencia_relativa; set => frecuencia_relativa = value; }
            public double Frecuencia_relativa_acumulada { get => frecuencia_relativa_acumulada; set => frecuencia_relativa_acumulada = value; }
            public int Frecuencia_esperada { get => frecuencia_esperada; set => frecuencia_esperada = value; }


            //Esta funcion se encarga de ..
            public bool estaEnIntervalo(double rnd)
            {
                return (this.valor_inf <= rnd && rnd < this.valor_sup);
            }

            public string intervaloString()
            {
                return valor_inf.ToString() + " - " + valor_sup.ToString();
            }

        }


        //Esta funcion se encarga de generar el histograma.
        private void btnHistograma_Click(object sender, EventArgs e)
        {
            cmbIntervalos.Enabled = false;
            btnLimpiarHistograma.Enabled = true;
            limpiarHistograma();
            //chart1.AlignDataPointsByAxisLabel();
            for (int i = 0; i < intervalos.Count; i++)
            {
                chart1.Series["Frecuencia observada"].Points.AddXY(intervalos[i].intervaloString(), intervalos[i].Frecuencia_observada);
                chart1.Series["Frecuencia esperada"].Points.AddY(intervalos[i].Frecuencia_esperada);
            }
            chart1.Series[0]["PointWidth"] = "1";
            btnHistograma.Enabled = false;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = intervalos.Count + 1;
            chart1.Titles["Frecuencia observada"].Visible = true;
            chart1.Titles["Frecuencia esperada"].Visible = true;
            chart1.Titles["Histograma de frecuencias"].Visible = true;
        }


        //Esta funcion nos permite validar que segun el metodo que se elija, estara habilitada o no la opcion de agregar un valor a "c" y los demas textbox.
        private void cmb_Metodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_numSimulaciones.Enabled = true;
            btnGenerar.Enabled = true;
            if (cmb_Metodo.SelectedIndex == 2)
            {
                txtG.Enabled = false;
                txtK.Enabled = false;
                txtM.Enabled = false;
                txtSemilla.Enabled = false;
                txtC.Enabled = false;
                txtC.Text = "";
                txtSemilla.Text = "";
                txtK.Text = "";
                txtG.Text = "";
            }
            else
            {
                if (cmb_Metodo.SelectedIndex == 1)
                {
                    txtC.Text = 0.ToString();
                    txtC.Enabled = false;
                    txtG.Enabled = true;
                    txtK.Enabled = true;
                    txtSemilla.Enabled = true;
                    txtC.Text = "0";
                    txtSemilla.Text = "";
                    txtK.Text = "";
                    txtG.Text = "";
                }
                else
                {
                    txtG.Enabled = true;
                    txtK.Enabled = true;
                    txtSemilla.Enabled = true;
                    txtC.Enabled = true;
                    txtC.Text = "";
                    txtC.Text = "";
                    txtSemilla.Text = "";
                    txtK.Text = "";
                    txtG.Text = "";
                }
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
            dgRND.Rows.Clear();
            numerosRND.Clear();
            //listaNumeros.DataSource = null;
            //listaNumeros.Items.Clear();
        }


        //Esta funcion cambia el estado (habilitado/desabilitado) del boton "Calcular intervalos" al elegir una cantidad de intervalos.
        private void cmbIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIntervalos.Enabled = true;
            dgIntervalos.Rows.Clear();
            btnHistograma.Enabled = false;
            btnPrueba.Enabled = false;
            if (intervalos.Count != 0)
            {
                intervalos.Clear();
            }
        }


        private double calculoChiTAB(int cant_intervalos)
        {
            //grados de libertad
            int v = cant_intervalos - 1;
            return valores_chi[v-1];
        }


        private double calculoChiCALC(List<Intervalo> intervalos)
        {
            double acumulador = 0;
            double c = 0;
            foreach (Intervalo interv in intervalos)
            {
                c = Math.Round(Math.Pow((interv.Frecuencia_esperada - interv.Frecuencia_observada), 2) / interv.Frecuencia_esperada, 4);
                acumulador += c;
            }
            return acumulador;
        }

        public double calculoKSTAB(int cant_intervalos)
        {
            //grados de libertad
            int v = cant_intervalos;
            return valores_ks[v-1];
        }


        //public double calculoKSCAL(List<Intervalo> intervalos)
        //{
        //    double acum = 0;
        //    foreach (Intervalo interv in intervalos)
        //    {
        //        var prob = (interv.Frecuencia_observada / int.Parse(txt_numSimulaciones.Text));
        //        acum += prob;
        //    }
        //    return acum;
        //}



        //private double calculoMedia(List<Intervalo> intervalos, int n)
        //{
        //    double media = 0;
        //    double suma = 0;
        //    foreach (Intervalo interv in intervalos)
        //    {
        //        suma = suma + (interv.Frecuencia_observada * interv.Marca_clase);
        //    }
        //    return suma;
        //}

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            double media;
            double varianza;
            if (cmbChi.SelectedIndex == 0)
            {
                double chi_calc = calculoChiCALC(intervalos);
                double chi_tab = calculoChiTAB(intervalos.Count);

                lblChiCalc.Text = chi_calc.ToString();
                lblChiTab.Text = chi_tab.ToString();
                if (chi_calc <= chi_tab)
                {
                    lblChiConclusion.ForeColor = Color.Green;
                    lblChiConclusion.Text = "No rechazada";
                }
                else
                {
                    lblChiConclusion.ForeColor = Color.Red;
                    lblChiConclusion.Text = "Rechazada";
                }
            }
            else
            {
                double ks_cal = KSCalculado(intervalos, Convert.ToDouble(numerosRND.Count));
                double ks_tab = calculoKSTAB(numerosRND.Count);
                media = calcularMedia(intervalos, numerosRND.Count);
                varianza = calcularVarianza(intervalos, numerosRND.Count, media);
                lblMedia.Text = media.ToString();
                lblVarianza.Text = varianza.ToString();
                lblKsCal.Text = ks_cal.ToString();
                lblKsTab.Text = ks_tab.ToString();
                if (ks_cal <= ks_tab)
                {
                    lblKsConclusion.ForeColor = Color.Green;
                    lblKsConclusion.Text = "No rechazada";
                }
                else
                {
                    lblKsConclusion.ForeColor = Color.Red;
                    lblKsConclusion.Text = "Rechazada";
                }
            }
            
        }


        //Esta funcion se encarga de limpiar el chart donde esta el grafico del histograma.
        private void btnLimpiarHistograma_Click(object sender, EventArgs e)
        {
            limpiarHistograma();
        }

        private void limpiarHistograma()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            btnHistograma.Enabled = true;
            cmbIntervalos.Enabled = true;
            chart1.Titles["Frecuencia observada"].Visible = false;
            chart1.Titles["Frecuencia esperada"].Visible = false;
            chart1.Titles["Histograma de frecuencias"].Visible = false;
        }


        //Estas funciones validan que solo se pueda colocar numeros enteros dentro de los textbox.
        private void txt_numSimulaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void txtSemilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private double KSCalculado(List<Intervalo> intervalos, double n)
        {
            double mayor = 0;
            double pfo_ac = 0;
            double pfe_ac = 0;
            double c = 0;
            foreach (Intervalo intervalo in intervalos)
            {
                pfo_ac += Math.Round(intervalo.Frecuencia_observada / n, 4);
                pfe_ac += Math.Round(intervalo.Frecuencia_esperada / n, 4);
                c = Math.Abs(pfo_ac - pfe_ac);
                if(c> mayor)
                {
                    mayor = c;
                }
            }
            return mayor;
        }

        private double calcularMedia(List <Intervalo> intervalos, double n)
        {
            double x = 0;
            foreach (Intervalo intervalo in intervalos)
            {
                x += Math.Round(intervalo.Marca_clase * intervalo.Frecuencia_observada, 4);
            }
            return Math.Round(x / n, 4);
        }

        private double calcularVarianza(List<Intervalo> intervalos, double n, double media)
        {
            double varianza = 0;
            foreach (Intervalo intervalo in intervalos)
            {
                varianza += Math.Round(Math.Pow(intervalo.Marca_clase, 2) * intervalo.Frecuencia_observada, 4);
            }
            
            return Math.Round((varianza - n * Math.Pow(media, 2)) / (n - 1), 4);
        }

    }
}