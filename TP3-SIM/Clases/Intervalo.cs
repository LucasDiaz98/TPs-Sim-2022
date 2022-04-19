using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3SIM.Clases
{
    class Intervalo
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


        //Esta funcion se encarga de comprobar que un numero rnd este dentro del intervalo
        public bool estaEnIntervalo(double rnd)
        {
            return (this.valor_inf <= rnd && rnd < this.valor_sup);
        }

        //Esta funcion toma ambos limites del intervalo para unirlos en un solo string
        public string intervaloString()
        {
            return valor_inf.ToString() + " - " + valor_sup.ToString();
        }
    }
}
