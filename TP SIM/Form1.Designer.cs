
namespace TP_SIM
{
    partial class TP1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Metodo = new System.Windows.Forms.GroupBox();
            this.txtMaxPeriodo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txt_numSimulaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIntervalos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Metodo = new System.Windows.Forms.ComboBox();
            this.dgIntervalos = new System.Windows.Forms.DataGridView();
            this.listaNumeros = new System.Windows.Forms.ListBox();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Metodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Metodo
            // 
            this.Metodo.Controls.Add(this.txtMaxPeriodo);
            this.Metodo.Controls.Add(this.label8);
            this.Metodo.Controls.Add(this.btnLimpiar);
            this.Metodo.Controls.Add(this.txtM);
            this.Metodo.Controls.Add(this.label7);
            this.Metodo.Controls.Add(this.btnGenerar);
            this.Metodo.Controls.Add(this.txt_numSimulaciones);
            this.Metodo.Controls.Add(this.label6);
            this.Metodo.Controls.Add(this.label5);
            this.Metodo.Controls.Add(this.label4);
            this.Metodo.Controls.Add(this.label3);
            this.Metodo.Controls.Add(this.label2);
            this.Metodo.Controls.Add(this.txtC);
            this.Metodo.Controls.Add(this.txtG);
            this.Metodo.Controls.Add(this.txtK);
            this.Metodo.Controls.Add(this.txtSemilla);
            this.Metodo.Controls.Add(this.label1);
            this.Metodo.Controls.Add(this.cmb_Metodo);
            this.Metodo.Location = new System.Drawing.Point(12, 33);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(429, 248);
            this.Metodo.TabIndex = 0;
            this.Metodo.TabStop = false;
            // 
            // txtMaxPeriodo
            // 
            this.txtMaxPeriodo.Enabled = false;
            this.txtMaxPeriodo.Location = new System.Drawing.Point(104, 124);
            this.txtMaxPeriodo.Name = "txtMaxPeriodo";
            this.txtMaxPeriodo.Size = new System.Drawing.Size(62, 20);
            this.txtMaxPeriodo.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Periodo máximo";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Location = new System.Drawing.Point(857, 9);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(121, 21);
            this.cmbIntervalos.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(131, 169);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 20);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(337, 120);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(86, 20);
            this.txtM.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "m";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(219, 169);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(64, 20);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txt_numSimulaciones
            // 
            this.txt_numSimulaciones.Location = new System.Drawing.Point(104, 69);
            this.txt_numSimulaciones.Name = "txt_numSimulaciones";
            this.txt_numSimulaciones.Size = new System.Drawing.Size(62, 20);
            this.txt_numSimulaciones.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nº de simulaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "c";
            // 
            // btnIntervalos
            // 
            this.btnIntervalos.Location = new System.Drawing.Point(992, 10);
            this.btnIntervalos.Name = "btnIntervalos";
            this.btnIntervalos.Size = new System.Drawing.Size(110, 20);
            this.btnIntervalos.TabIndex = 12;
            this.btnIntervalos.Text = "Calcular intervalos";
            this.btnIntervalos.UseVisualStyleBackColor = true;
            this.btnIntervalos.Click += new System.EventHandler(this.btnIntervalos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semilla";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(337, 94);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(86, 20);
            this.txtC.TabIndex = 7;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(337, 69);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(86, 20);
            this.txtG.TabIndex = 6;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(337, 44);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(86, 20);
            this.txtK.TabIndex = 5;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(337, 19);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(86, 20);
            this.txtSemilla.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo";
            // 
            // cmb_Metodo
            // 
            this.cmb_Metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Metodo.FormattingEnabled = true;
            this.cmb_Metodo.Location = new System.Drawing.Point(62, 23);
            this.cmb_Metodo.Name = "cmb_Metodo";
            this.cmb_Metodo.Size = new System.Drawing.Size(200, 21);
            this.cmb_Metodo.TabIndex = 1;
            this.cmb_Metodo.SelectedIndexChanged += new System.EventHandler(this.cmb_Metodo_SelectedIndexChanged);
            // 
            // dgIntervalos
            // 
            this.dgIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIntervalos.Location = new System.Drawing.Point(700, 33);
            this.dgIntervalos.Name = "dgIntervalos";
            this.dgIntervalos.RowTemplate.Height = 25;
            this.dgIntervalos.Size = new System.Drawing.Size(650, 200);
            this.dgIntervalos.TabIndex = 4;
            // 
            // listaNumeros
            // 
            this.listaNumeros.FormattingEnabled = true;
            this.listaNumeros.Location = new System.Drawing.Point(469, 33);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Size = new System.Drawing.Size(215, 199);
            this.listaNumeros.TabIndex = 5;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(532, 245);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(133, 36);
            this.btnHistograma.TabIndex = 13;
            this.btnHistograma.Text = "Generar histograma";
            this.btnHistograma.UseVisualStyleBackColor = true;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1, 302);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Frecuencia observada";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Frecuencia esperada";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1146, 255);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 609);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.listaNumeros);
            this.Controls.Add(this.dgIntervalos);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.btnIntervalos);
            this.Name = "TP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 1 - Grupo 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Metodo.ResumeLayout(false);
            this.Metodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Metodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Metodo;
        private System.Windows.Forms.TextBox txt_numSimulaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnIntervalos;
        private System.Windows.Forms.DataGridView dgIntervalos;
        private System.Windows.Forms.ListBox listaNumeros;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.TextBox txtMaxPeriodo;
        private System.Windows.Forms.Label label8;
    }
}

