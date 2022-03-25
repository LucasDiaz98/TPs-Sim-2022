using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Tp1_Sim.Form1;

namespace Tp1_Sim
{
    public partial class Histograma : Form
    {
        private List<Intervalo> intervalos;
        public Histograma()
        {
            InitializeComponent();
        }

        public Histograma(List<Intervalo> intervalos)
        {
            InitializeComponent();

        }

        private void Histograma_Load(object sender, EventArgs e)
        {

        }
    }
}
