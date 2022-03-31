
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Metodo = new System.Windows.Forms.GroupBox();
            this.txtMaxPeriodo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txt_numSimulaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Metodo = new System.Windows.Forms.ComboBox();
            this.listaNumeros = new System.Windows.Forms.ListBox();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnIntervalos = new System.Windows.Forms.Button();
            this.dgIntervalos = new System.Windows.Forms.DataGridView();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.btnLimpiarHistograma = new System.Windows.Forms.Button();
            this.cmbChi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChiCalc = new System.Windows.Forms.TextBox();
            this.txtChiTab = new System.Windows.Forms.TextBox();
            this.txtChiConclusion = new System.Windows.Forms.TextBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.Nro_Iteraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca_clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_observada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_relativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_relativa_acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_esperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // Metodo
            // 
            this.Metodo.Controls.Add(this.txtMaxPeriodo);
            this.Metodo.Controls.Add(this.label8);
            this.Metodo.Controls.Add(this.btnLimpiar);
            this.Metodo.Controls.Add(this.txtM);
            this.Metodo.Controls.Add(this.listaNumeros);
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
            this.Metodo.Location = new System.Drawing.Point(12, 41);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(691, 248);
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
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(276, 181);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 37);
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
            this.btnGenerar.Location = new System.Drawing.Point(166, 181);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 37);
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
            this.txt_numSimulaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numSimulaciones_KeyPress);
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
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(337, 69);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(86, 20);
            this.txtG.TabIndex = 6;
            this.txtG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtG_KeyPress);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(337, 44);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(86, 20);
            this.txtK.TabIndex = 5;
            this.txtK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtK_KeyPress);
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(337, 19);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(86, 20);
            this.txtSemilla.TabIndex = 4;
            this.txtSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla_KeyPress);
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
            // listaNumeros
            // 
            this.listaNumeros.FormattingEnabled = true;
            this.listaNumeros.Location = new System.Drawing.Point(452, 19);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Size = new System.Drawing.Size(215, 199);
            this.listaNumeros.TabIndex = 700;
            // 
            // btnHistograma
            // 
            this.btnHistograma.Location = new System.Drawing.Point(447, 320);
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
            this.chart1.Location = new System.Drawing.Point(91, 379);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "LabelStyle=Bottom";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series1.IsValueShownAsLabel = true;
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
            this.chart1.Size = new System.Drawing.Size(1181, 327);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Frecuencia observada";
            title1.Text = "Frecuencia observada";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title2.Name = "Frecuencia esperada";
            title2.Text = "Frecuencia esperada";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title3.Name = "Histograma de frecuencias";
            title3.Text = "Histograma de frecuencias";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Titles.Add(title3);
            // 
            // btnIntervalos
            // 
            this.btnIntervalos.Location = new System.Drawing.Point(1067, 40);
            this.btnIntervalos.Name = "btnIntervalos";
            this.btnIntervalos.Size = new System.Drawing.Size(110, 20);
            this.btnIntervalos.TabIndex = 12;
            this.btnIntervalos.Text = "Calcular intervalos";
            this.btnIntervalos.UseVisualStyleBackColor = true;
            this.btnIntervalos.Click += new System.EventHandler(this.btnIntervalos_Click);
            // 
            // dgIntervalos
            // 
            this.dgIntervalos.AllowUserToAddRows = false;
            this.dgIntervalos.AllowUserToDeleteRows = false;
            this.dgIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_Iteraciones,
            this.Valor_inf,
            this.Valor_sup,
            this.Marca_clase,
            this.Frecuencia_observada,
            this.Frecuencia_relativa,
            this.Frecuencia_acumulada,
            this.Frecuencia_relativa_acumulada,
            this.Frecuencia_esperada});
            this.dgIntervalos.Location = new System.Drawing.Point(736, 85);
            this.dgIntervalos.Name = "dgIntervalos";
            this.dgIntervalos.ReadOnly = true;
            this.dgIntervalos.RowTemplate.Height = 25;
            this.dgIntervalos.Size = new System.Drawing.Size(1006, 200);
            this.dgIntervalos.TabIndex = 4;
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Location = new System.Drawing.Point(922, 41);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(121, 21);
            this.cmbIntervalos.TabIndex = 11;
            this.cmbIntervalos.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalos_SelectedIndexChanged);
            // 
            // btnLimpiarHistograma
            // 
            this.btnLimpiarHistograma.Location = new System.Drawing.Point(586, 320);
            this.btnLimpiarHistograma.Name = "btnLimpiarHistograma";
            this.btnLimpiarHistograma.Size = new System.Drawing.Size(133, 36);
            this.btnLimpiarHistograma.TabIndex = 14;
            this.btnLimpiarHistograma.Text = "Limpiar histograma";
            this.btnLimpiarHistograma.UseVisualStyleBackColor = true;
            this.btnLimpiarHistograma.Click += new System.EventHandler(this.btnLimpiarHistograma_Click);
            // 
            // cmbChi
            // 
            this.cmbChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChi.FormattingEnabled = true;
            this.cmbChi.Location = new System.Drawing.Point(1390, 379);
            this.cmbChi.Name = "cmbChi";
            this.cmbChi.Size = new System.Drawing.Size(121, 21);
            this.cmbChi.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1289, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Prueba de bondad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1318, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Chi tabulado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1313, 415);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Chi calculado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1329, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Resultado";
            // 
            // txtChiCalc
            // 
            this.txtChiCalc.Enabled = false;
            this.txtChiCalc.Location = new System.Drawing.Point(1390, 412);
            this.txtChiCalc.Name = "txtChiCalc";
            this.txtChiCalc.Size = new System.Drawing.Size(100, 20);
            this.txtChiCalc.TabIndex = 21;
            // 
            // txtChiTab
            // 
            this.txtChiTab.Enabled = false;
            this.txtChiTab.Location = new System.Drawing.Point(1390, 445);
            this.txtChiTab.Name = "txtChiTab";
            this.txtChiTab.Size = new System.Drawing.Size(100, 20);
            this.txtChiTab.TabIndex = 22;
            // 
            // txtChiConclusion
            // 
            this.txtChiConclusion.Enabled = false;
            this.txtChiConclusion.Location = new System.Drawing.Point(1390, 481);
            this.txtChiConclusion.Name = "txtChiConclusion";
            this.txtChiConclusion.Size = new System.Drawing.Size(100, 20);
            this.txtChiConclusion.TabIndex = 23;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(1390, 525);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 24;
            this.btnPrueba.Text = "Probar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // Nro_Iteraciones
            // 
            this.Nro_Iteraciones.FillWeight = 50F;
            this.Nro_Iteraciones.HeaderText = "Nro_Iteraciones";
            this.Nro_Iteraciones.Name = "Nro_Iteraciones";
            this.Nro_Iteraciones.ReadOnly = true;
            // 
            // Valor_inf
            // 
            this.Valor_inf.HeaderText = "Valor_inf";
            this.Valor_inf.Name = "Valor_inf";
            this.Valor_inf.ReadOnly = true;
            this.Valor_inf.Width = 70;
            // 
            // Valor_sup
            // 
            this.Valor_sup.HeaderText = "Valor_sup";
            this.Valor_sup.Name = "Valor_sup";
            this.Valor_sup.ReadOnly = true;
            this.Valor_sup.Width = 70;
            // 
            // Marca_clase
            // 
            this.Marca_clase.HeaderText = "Marca_clase";
            this.Marca_clase.Name = "Marca_clase";
            this.Marca_clase.ReadOnly = true;
            this.Marca_clase.Width = 80;
            // 
            // Frecuencia_observada
            // 
            this.Frecuencia_observada.HeaderText = "Frecuencia_observada";
            this.Frecuencia_observada.Name = "Frecuencia_observada";
            this.Frecuencia_observada.ReadOnly = true;
            this.Frecuencia_observada.Width = 120;
            // 
            // Frecuencia_relativa
            // 
            this.Frecuencia_relativa.HeaderText = "Frecuencia_relativa";
            this.Frecuencia_relativa.Name = "Frecuencia_relativa";
            this.Frecuencia_relativa.ReadOnly = true;
            this.Frecuencia_relativa.Width = 110;
            // 
            // Frecuencia_acumulada
            // 
            this.Frecuencia_acumulada.HeaderText = "Frecuencia_acumulada";
            this.Frecuencia_acumulada.Name = "Frecuencia_acumulada";
            this.Frecuencia_acumulada.ReadOnly = true;
            this.Frecuencia_acumulada.Width = 122;
            // 
            // Frecuencia_relativa_acumulada
            // 
            this.Frecuencia_relativa_acumulada.HeaderText = "Frecuencia_relativa_acumulada";
            this.Frecuencia_relativa_acumulada.Name = "Frecuencia_relativa_acumulada";
            this.Frecuencia_relativa_acumulada.ReadOnly = true;
            this.Frecuencia_relativa_acumulada.Width = 173;
            // 
            // Frecuencia_esperada
            // 
            this.Frecuencia_esperada.HeaderText = "Frecuencia_esperada";
            this.Frecuencia_esperada.Name = "Frecuencia_esperada";
            this.Frecuencia_esperada.ReadOnly = true;
            this.Frecuencia_esperada.Width = 113;
            // 
            // TP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 838);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.txtChiConclusion);
            this.Controls.Add(this.txtChiTab);
            this.Controls.Add(this.txtChiCalc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbChi);
            this.Controls.Add(this.btnLimpiarHistograma);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.dgIntervalos);
            this.Controls.Add(this.Metodo);
            this.Controls.Add(this.btnIntervalos);
            this.Name = "TP1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 1 - Grupo 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Metodo.ResumeLayout(false);
            this.Metodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ListBox listaNumeros;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtMaxPeriodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIntervalos;
        private System.Windows.Forms.DataGridView dgIntervalos;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Button btnLimpiarHistograma;
        private System.Windows.Forms.ComboBox cmbChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChiCalc;
        private System.Windows.Forms.TextBox txtChiTab;
        private System.Windows.Forms.TextBox txtChiConclusion;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Iteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca_clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_observada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_relativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_relativa_acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_esperada;
    }
}

