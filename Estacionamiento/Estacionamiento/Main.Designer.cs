namespace Estacionamiento
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha_ingreso = new System.Windows.Forms.DateTimePicker();
            this.txt_nombre_estacionamiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo_vehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtpatente = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.txtcant_puertas = new System.Windows.Forms.TextBox();
            this.txtcant_ruedas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.datagrid);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grilla de entradas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(8, 48);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(444, 472);
            this.datagrid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancelar);
            this.groupBox3.Controls.Add(this.btn_nuevo);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(464, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 526);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva Entrada";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(308, 486);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 38);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(414, 486);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(108, 38);
            this.btn_nuevo.TabIndex = 20;
            this.btn_nuevo.Text = "Guardar";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Fecha_ingreso);
            this.groupBox4.Controls.Add(this.txt_nombre_estacionamiento);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtnombre);
            this.groupBox4.Controls.Add(this.txtapellido);
            this.groupBox4.Controls.Add(this.txtdni);
            this.groupBox4.Controls.Add(this.txtdomicilio);
            this.groupBox4.Location = new System.Drawing.Point(9, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(513, 202);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ticket";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Dueño del Vehiculo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(191, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Domicilio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "DNI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre del establecimiento";
            // 
            // Fecha_ingreso
            // 
            this.Fecha_ingreso.Location = new System.Drawing.Point(12, 45);
            this.Fecha_ingreso.Name = "Fecha_ingreso";
            this.Fecha_ingreso.Size = new System.Drawing.Size(200, 20);
            this.Fecha_ingreso.TabIndex = 16;
            // 
            // txt_nombre_estacionamiento
            // 
            this.txt_nombre_estacionamiento.Location = new System.Drawing.Point(218, 45);
            this.txt_nombre_estacionamiento.Name = "txt_nombre_estacionamiento";
            this.txt_nombre_estacionamiento.Size = new System.Drawing.Size(207, 20);
            this.txt_nombre_estacionamiento.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de ingreso";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 120);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(168, 20);
            this.txtnombre.TabIndex = 11;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(12, 159);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(167, 20);
            this.txtapellido.TabIndex = 4;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(194, 120);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(159, 20);
            this.txtdni.TabIndex = 0;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(194, 159);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(203, 20);
            this.txtdomicilio.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tipo_vehiculo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtmodelo);
            this.groupBox2.Controls.Add(this.txtmarca);
            this.groupBox2.Controls.Add(this.txtpatente);
            this.groupBox2.Controls.Add(this.txtaño);
            this.groupBox2.Controls.Add(this.txtcant_puertas);
            this.groupBox2.Controls.Add(this.txtcant_ruedas);
            this.groupBox2.Location = new System.Drawing.Point(9, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 253);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehiculo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cantidad de Ruedas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad de Puertas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Patente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo de Vehiculo";
            // 
            // tipo_vehiculo
            // 
            this.tipo_vehiculo.FormattingEnabled = true;
            this.tipo_vehiculo.Location = new System.Drawing.Point(11, 40);
            this.tipo_vehiculo.Name = "tipo_vehiculo";
            this.tipo_vehiculo.Size = new System.Drawing.Size(121, 21);
            this.tipo_vehiculo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Modelo";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(11, 90);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(178, 20);
            this.txtmodelo.TabIndex = 8;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(12, 145);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(177, 20);
            this.txtmarca.TabIndex = 9;
            // 
            // txtpatente
            // 
            this.txtpatente.Location = new System.Drawing.Point(276, 90);
            this.txtpatente.Name = "txtpatente";
            this.txtpatente.Size = new System.Drawing.Size(152, 20);
            this.txtpatente.TabIndex = 10;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(12, 195);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(100, 20);
            this.txtaño.TabIndex = 6;
            // 
            // txtcant_puertas
            // 
            this.txtcant_puertas.Location = new System.Drawing.Point(276, 195);
            this.txtcant_puertas.Name = "txtcant_puertas";
            this.txtcant_puertas.Size = new System.Drawing.Size(129, 20);
            this.txtcant_puertas.TabIndex = 7;
            // 
            // txtcant_ruedas
            // 
            this.txtcant_ruedas.Location = new System.Drawing.Point(276, 145);
            this.txtcant_ruedas.Name = "txtcant_ruedas";
            this.txtcant_ruedas.Size = new System.Drawing.Size(129, 20);
            this.txtcant_ruedas.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 539);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "APP ESTACIONAMIENTO";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtcant_ruedas;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtcant_puertas;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpatente;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txt_nombre_estacionamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha_ingreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipo_vehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Label label14;
    }
}

