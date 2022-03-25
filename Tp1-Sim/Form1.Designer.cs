
namespace Tp1_Sim
{
    partial class Form1
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
            this.Metodo = new System.Windows.Forms.GroupBox();
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
            this.btnIntervalos = new System.Windows.Forms.Button();
            this.txtIntervalos = new System.Windows.Forms.TextBox();
            this.dgIntervalos = new System.Windows.Forms.DataGridView();
            this.listaNumeros = new System.Windows.Forms.ListBox();
            this.Metodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // Metodo
            // 
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
            this.Metodo.Location = new System.Drawing.Point(12, 12);
            this.Metodo.Name = "Metodo";
            this.Metodo.Size = new System.Drawing.Size(427, 169);
            this.Metodo.TabIndex = 0;
            this.Metodo.TabStop = false;
            this.Metodo.Text = "Metodo";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(322, 140);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txt_numSimulaciones
            // 
            this.txt_numSimulaciones.Location = new System.Drawing.Point(121, 80);
            this.txt_numSimulaciones.Name = "txt_numSimulaciones";
            this.txt_numSimulaciones.Size = new System.Drawing.Size(72, 23);
            this.txt_numSimulaciones.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nº de simulaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Semilla";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(308, 109);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 23);
            this.txtC.TabIndex = 5;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(308, 80);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 23);
            this.txtG.TabIndex = 4;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(308, 51);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 23);
            this.txtK.TabIndex = 3;
            // 
            // txtSemilla
            // 
            this.txtSemilla.Location = new System.Drawing.Point(308, 22);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(100, 23);
            this.txtSemilla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo";
            // 
            // cmb_Metodo
            // 
            this.cmb_Metodo.FormattingEnabled = true;
            this.cmb_Metodo.Location = new System.Drawing.Point(72, 27);
            this.cmb_Metodo.Name = "cmb_Metodo";
            this.cmb_Metodo.Size = new System.Drawing.Size(121, 23);
            this.cmb_Metodo.TabIndex = 0;
            // 
            // btnIntervalos
            // 
            this.btnIntervalos.Location = new System.Drawing.Point(170, 229);
            this.btnIntervalos.Name = "btnIntervalos";
            this.btnIntervalos.Size = new System.Drawing.Size(75, 23);
            this.btnIntervalos.TabIndex = 1;
            this.btnIntervalos.Text = "intervalos";
            this.btnIntervalos.UseVisualStyleBackColor = true;
            this.btnIntervalos.Click += new System.EventHandler(this.btnIntervalos_Click);
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Location = new System.Drawing.Point(64, 229);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(100, 23);
            this.txtIntervalos.TabIndex = 3;
            // 
            // dgIntervalos
            // 
            this.dgIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIntervalos.Location = new System.Drawing.Point(53, 302);
            this.dgIntervalos.Name = "dgIntervalos";
            this.dgIntervalos.RowTemplate.Height = 25;
            this.dgIntervalos.Size = new System.Drawing.Size(356, 150);
            this.dgIntervalos.TabIndex = 4;
            // 
            // listaNumeros
            // 
            this.listaNumeros.FormattingEnabled = true;
            this.listaNumeros.ItemHeight = 15;
            this.listaNumeros.Location = new System.Drawing.Point(490, 12);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Size = new System.Drawing.Size(252, 139);
            this.listaNumeros.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 556);
            this.Controls.Add(this.listaNumeros);
            this.Controls.Add(this.dgIntervalos);
            this.Controls.Add(this.txtIntervalos);
            this.Controls.Add(this.btnIntervalos);
            this.Controls.Add(this.Metodo);
            this.Name = "Form1";
            this.Text = "TP 1 - Grupo 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Metodo.ResumeLayout(false);
            this.Metodo.PerformLayout();
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
        private System.Windows.Forms.Button btnIntervalos;
        private System.Windows.Forms.TextBox txtIntervalos;
        private System.Windows.Forms.DataGridView dgIntervalos;
        private System.Windows.Forms.ListBox listaNumeros;
    }
}

