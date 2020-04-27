namespace Practica_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdecision = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.Posiciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elementos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbelemento = new System.Windows.Forms.Label();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.btingresar = new System.Windows.Forms.Button();
            this.lbstop = new System.Windows.Forms.Label();
            this.lbpos = new System.Windows.Forms.Label();
            this.txtpos = new System.Windows.Forms.TextBox();
            this.Parar = new System.Windows.Forms.Button();
            this.lbcambio = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.lbchange = new System.Windows.Forms.Label();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.btchange = new System.Windows.Forms.Button();
            this.lbintercambio = new System.Windows.Forms.Label();
            this.txtintercambio1 = new System.Windows.Forms.TextBox();
            this.txtintercambio2 = new System.Windows.Forms.TextBox();
            this.btintercambio = new System.Windows.Forms.Button();
            this.lista2 = new System.Windows.Forms.DataGridView();
            this.Posiciones2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elementos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btinvert = new System.Windows.Forms.Button();
            this.lbinvert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchoice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el tamaño del vector:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese 0 si quiere que el vector se llene con numeros aleatorios";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(177, 19);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese 1 si quiere llenar el vector manualmente";
            // 
            // txtdecision
            // 
            this.txtdecision.Location = new System.Drawing.Point(257, 76);
            this.txtdecision.Name = "txtdecision";
            this.txtdecision.Size = new System.Drawing.Size(55, 20);
            this.txtdecision.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista
            // 
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posiciones,
            this.Elementos});
            this.lista.Location = new System.Drawing.Point(439, 19);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(321, 320);
            this.lista.TabIndex = 6;
            // 
            // Posiciones
            // 
            this.Posiciones.HeaderText = "Posicion";
            this.Posiciones.Name = "Posiciones";
            // 
            // Elementos
            // 
            this.Elementos.HeaderText = "Elemento";
            this.Elementos.Name = "Elementos";
            // 
            // lbelemento
            // 
            this.lbelemento.AutoSize = true;
            this.lbelemento.Location = new System.Drawing.Point(137, 126);
            this.lbelemento.Name = "lbelemento";
            this.lbelemento.Size = new System.Drawing.Size(54, 13);
            this.lbelemento.TabIndex = 8;
            this.lbelemento.Text = "Elemento:";
            this.lbelemento.Visible = false;
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(201, 124);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(46, 20);
            this.txtelemento.TabIndex = 10;
            this.txtelemento.Visible = false;
            // 
            // btingresar
            // 
            this.btingresar.Location = new System.Drawing.Point(259, 121);
            this.btingresar.Name = "btingresar";
            this.btingresar.Size = new System.Drawing.Size(75, 23);
            this.btingresar.TabIndex = 11;
            this.btingresar.Text = "Ingresar";
            this.btingresar.UseVisualStyleBackColor = true;
            this.btingresar.Visible = false;
            this.btingresar.Click += new System.EventHandler(this.btingresar_Click);
            // 
            // lbstop
            // 
            this.lbstop.AutoSize = true;
            this.lbstop.Location = new System.Drawing.Point(5, 160);
            this.lbstop.Name = "lbstop";
            this.lbstop.Size = new System.Drawing.Size(205, 13);
            this.lbstop.TabIndex = 12;
            this.lbstop.Text = "Presione para dejar de ingresar Elementos";
            this.lbstop.Visible = false;
            // 
            // lbpos
            // 
            this.lbpos.AutoSize = true;
            this.lbpos.Location = new System.Drawing.Point(12, 123);
            this.lbpos.Name = "lbpos";
            this.lbpos.Size = new System.Drawing.Size(47, 13);
            this.lbpos.TabIndex = 14;
            this.lbpos.Text = "Posicion";
            this.lbpos.Visible = false;
            // 
            // txtpos
            // 
            this.txtpos.Location = new System.Drawing.Point(65, 123);
            this.txtpos.Name = "txtpos";
            this.txtpos.Size = new System.Drawing.Size(54, 20);
            this.txtpos.TabIndex = 15;
            this.txtpos.Visible = false;
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(227, 155);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(75, 23);
            this.Parar.TabIndex = 16;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Visible = false;
            this.Parar.Click += new System.EventHandler(this.Parar_Click);
            // 
            // lbcambio
            // 
            this.lbcambio.AutoSize = true;
            this.lbcambio.Location = new System.Drawing.Point(8, 200);
            this.lbcambio.Name = "lbcambio";
            this.lbcambio.Size = new System.Drawing.Size(255, 13);
            this.lbcambio.TabIndex = 17;
            this.lbcambio.Text = "Ingrese la Posicion del elemento que quiere cambiar:";
            this.lbcambio.Visible = false;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(271, 197);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(61, 20);
            this.txtcambio.TabIndex = 18;
            this.txtcambio.Visible = false;
            this.txtcambio.WordWrap = false;
            // 
            // lbchange
            // 
            this.lbchange.AutoSize = true;
            this.lbchange.Location = new System.Drawing.Point(12, 261);
            this.lbchange.Name = "lbchange";
            this.lbchange.Size = new System.Drawing.Size(132, 13);
            this.lbchange.TabIndex = 19;
            this.lbchange.Text = "Ingrese el nuevo elemento";
            this.lbchange.Visible = false;
            // 
            // txtchange
            // 
            this.txtchange.Location = new System.Drawing.Point(150, 258);
            this.txtchange.Name = "txtchange";
            this.txtchange.Size = new System.Drawing.Size(70, 20);
            this.txtchange.TabIndex = 20;
            this.txtchange.Visible = false;
            // 
            // btchange
            // 
            this.btchange.Location = new System.Drawing.Point(358, 195);
            this.btchange.Name = "btchange";
            this.btchange.Size = new System.Drawing.Size(75, 23);
            this.btchange.TabIndex = 21;
            this.btchange.Text = "Ejecutar";
            this.btchange.UseVisualStyleBackColor = true;
            this.btchange.Visible = false;
            this.btchange.Click += new System.EventHandler(this.btchange_Click);
            // 
            // lbintercambio
            // 
            this.lbintercambio.AutoSize = true;
            this.lbintercambio.Location = new System.Drawing.Point(1, 300);
            this.lbintercambio.Name = "lbintercambio";
            this.lbintercambio.Size = new System.Drawing.Size(290, 13);
            this.lbintercambio.TabIndex = 22;
            this.lbintercambio.Text = "Ingrese la posicion de los elementos que quiere intercambiar";
            this.lbintercambio.Visible = false;
            // 
            // txtintercambio1
            // 
            this.txtintercambio1.Location = new System.Drawing.Point(15, 324);
            this.txtintercambio1.Name = "txtintercambio1";
            this.txtintercambio1.Size = new System.Drawing.Size(85, 20);
            this.txtintercambio1.TabIndex = 23;
            this.txtintercambio1.Visible = false;
            // 
            // txtintercambio2
            // 
            this.txtintercambio2.Location = new System.Drawing.Point(147, 324);
            this.txtintercambio2.Name = "txtintercambio2";
            this.txtintercambio2.Size = new System.Drawing.Size(100, 20);
            this.txtintercambio2.TabIndex = 24;
            this.txtintercambio2.Visible = false;
            // 
            // btintercambio
            // 
            this.btintercambio.Location = new System.Drawing.Point(306, 295);
            this.btintercambio.Name = "btintercambio";
            this.btintercambio.Size = new System.Drawing.Size(75, 23);
            this.btintercambio.TabIndex = 25;
            this.btintercambio.Text = "Intercambiar";
            this.btintercambio.UseVisualStyleBackColor = true;
            this.btintercambio.Visible = false;
            this.btintercambio.Click += new System.EventHandler(this.btintercambio_Click);
            // 
            // lista2
            // 
            this.lista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posiciones2,
            this.Elementos2});
            this.lista2.Location = new System.Drawing.Point(439, 19);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(321, 320);
            this.lista2.TabIndex = 26;
            this.lista2.Visible = false;
            // 
            // Posiciones2
            // 
            this.Posiciones2.HeaderText = "Posicion";
            this.Posiciones2.Name = "Posiciones2";
            // 
            // Elementos2
            // 
            this.Elementos2.HeaderText = "Elemento";
            this.Elementos2.Name = "Elementos2";
            // 
            // btinvert
            // 
            this.btinvert.Location = new System.Drawing.Point(271, 337);
            this.btinvert.Name = "btinvert";
            this.btinvert.Size = new System.Drawing.Size(75, 23);
            this.btinvert.TabIndex = 27;
            this.btinvert.Text = "Invertir";
            this.btinvert.UseVisualStyleBackColor = true;
            this.btinvert.Visible = false;
            this.btinvert.Click += new System.EventHandler(this.btinvert_Click);
            // 
            // lbinvert
            // 
            this.lbinvert.AutoSize = true;
            this.lbinvert.Location = new System.Drawing.Point(30, 347);
            this.lbinvert.Name = "lbinvert";
            this.lbinvert.Size = new System.Drawing.Size(208, 13);
            this.lbinvert.TabIndex = 28;
            this.lbinvert.Text = "Presione paraInvertir elementos del vector:";
            this.lbinvert.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Presione 0 para ingresar el numero, 1 para ingresarlo aleatoriamente";
            this.label4.Visible = false;
            // 
            // txtchoice
            // 
            this.txtchoice.Location = new System.Drawing.Point(340, 229);
            this.txtchoice.Name = "txtchoice";
            this.txtchoice.Size = new System.Drawing.Size(41, 20);
            this.txtchoice.TabIndex = 30;
            this.txtchoice.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtchoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbinvert);
            this.Controls.Add(this.btinvert);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.btintercambio);
            this.Controls.Add(this.txtintercambio2);
            this.Controls.Add(this.txtintercambio1);
            this.Controls.Add(this.lbintercambio);
            this.Controls.Add(this.btchange);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.lbchange);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.lbcambio);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.txtpos);
            this.Controls.Add(this.lbpos);
            this.Controls.Add(this.lbstop);
            this.Controls.Add(this.btingresar);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.lbelemento);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtdecision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdecision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elementos;
        private System.Windows.Forms.Label lbelemento;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Button btingresar;
        private System.Windows.Forms.Label lbstop;
        private System.Windows.Forms.Label lbpos;
        private System.Windows.Forms.TextBox txtpos;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.Label lbcambio;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label lbchange;
        private System.Windows.Forms.TextBox txtchange;
        private System.Windows.Forms.Button btchange;
        private System.Windows.Forms.Label lbintercambio;
        private System.Windows.Forms.TextBox txtintercambio1;
        private System.Windows.Forms.TextBox txtintercambio2;
        private System.Windows.Forms.Button btintercambio;
        private System.Windows.Forms.DataGridView lista2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posiciones2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Elementos2;
        private System.Windows.Forms.Button btinvert;
        private System.Windows.Forms.Label lbinvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchoice;
    }
}

