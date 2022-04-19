using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3SIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string distribucion = cmbDistribucion.Text;
            double n = Convert.ToDouble(txtN.Text);
            switch (distribucion)
            {
                case "Uniforme A-B":
                    double a = Convert.ToDouble(txtA.Text);
                    double b = Convert.ToDouble(txtB.Text);
                    if(a == 0 && b == 1)
                    {
                        MessageBox.Show("El intervalo ingresado no es valido");
                    }
                    else
                    {
                        generarNumerosUniformeAB(n, a, b);
                    }
                    break;
                case "Exponencial negativa":
                    double lambda = Convert.ToDouble(txtLambda.Text);
                    generarNumerosExponencialNegativa(lambda, n);
                    break;
                case "Normal":
                    double media = Convert.ToDouble(txtMedia.Text);
                    double desvEstandar = Convert.ToDouble(txtDesvEstandar.Text);
                    generarNumerosNormalBM(n, media, desvEstandar);
                    break;
            }
        }
        private void validarIngresoNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoNumero(sender, e);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoNumero(sender, e); 
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarIngresoNumero(sender, e);
        }


        private double generarRandom()
        {
            Random random = new Random();
            double rnd = random.NextDouble();
            return rnd;
        }
        private List<double> generarNumerosUniformeAB(double n, double a, double b)
        {
            List<double> listaNumerosUniforme = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double rnd = generarRandom();
                double x = a + rnd * (b - a);
                listaNumerosUniforme.Add(x);
            }
            return listaNumerosUniforme;
        }

        private List<double> generarNumerosExponencialNegativa(double lambda, double n)
        {
            List<double> listaNumerosEN = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double rnd = generarRandom();
                double x = (-1 / lambda) * Math.Log(1 - rnd);
                listaNumerosEN.Add(x);
            }
            return listaNumerosEN;
        }

        private List<double> generarNumerosNormalBM(double n, double media, double desviacion)
        {
            double pi = Math.PI;
            List<double> listaNumerosNormalBM = new List<double>();

            for (int i = 0; i < n/2; i++)
            {
                double rnd1 = generarRandom();
                double rnd2 = generarRandom();
                double N1 = Math.Sqrt(-2 * Math.Log(rnd1)) * (Math.Cos(2 * pi * rnd2)) * desviacion + media;
                double N2 = Math.Sqrt(-2 * Math.Log(rnd1)) * (Math.Sin(2 * pi * rnd2)) * desviacion + media;
                listaNumerosNormalBM.Add(N1);
                if (listaNumerosNormalBM.Count == n)
                {
                    break;
                }
                else
                {
                    listaNumerosNormalBM.Add(N2);
                }
            }
            return listaNumerosNormalBM;
        }
    }
}
