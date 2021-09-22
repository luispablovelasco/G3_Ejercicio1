namespace G3_Ejercicio01
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgvcuentas = new System.Windows.Forms.DataGridView();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txtncuenta = new System.Windows.Forms.TextBox();
            this.txtmontocuenta = new System.Windows.Forms.TextBox();
            this.cmbtcuenta = new System.Windows.Forms.ComboBox();
            this.cmbsucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de cuenta de apertura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NIT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de cuenta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto disponible en la cuenta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sucursal de inscripción;";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsucursal);
            this.groupBox1.Controls.Add(this.cmbtcuenta);
            this.groupBox1.Controls.Add(this.txtmontocuenta);
            this.groupBox1.Controls.Add(this.txtncuenta);
            this.groupBox1.Controls.Add(this.txtnit);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.txtdui);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva cuenta:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(524, 181);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar ";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(443, 181);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // dgvcuentas
            // 
            this.dgvcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuentas.Location = new System.Drawing.Point(16, 215);
            this.dgvcuentas.Name = "dgvcuentas";
            this.dgvcuentas.Size = new System.Drawing.Size(583, 134);
            this.dgvcuentas.TabIndex = 11;
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(59, 20);
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(262, 20);
            this.txtdui.TabIndex = 8;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(59, 54);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(262, 20);
            this.txtnombres.TabIndex = 9;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(60, 88);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(261, 20);
            this.txtapellidos.TabIndex = 10;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(362, 23);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(224, 20);
            this.txtnit.TabIndex = 11;
            // 
            // txtncuenta
            // 
            this.txtncuenta.Location = new System.Drawing.Point(431, 54);
            this.txtncuenta.Name = "txtncuenta";
            this.txtncuenta.Size = new System.Drawing.Size(155, 20);
            this.txtncuenta.TabIndex = 12;
            // 
            // txtmontocuenta
            // 
            this.txtmontocuenta.Location = new System.Drawing.Point(485, 93);
            this.txtmontocuenta.Name = "txtmontocuenta";
            this.txtmontocuenta.Size = new System.Drawing.Size(101, 20);
            this.txtmontocuenta.TabIndex = 13;
            // 
            // cmbtcuenta
            // 
            this.cmbtcuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtcuenta.FormattingEnabled = true;
            this.cmbtcuenta.Items.AddRange(new object[] {
            "Cuenta Corriente",
            "Cuenta de Ahorros",
            "Cuenta a Plazos"});
            this.cmbtcuenta.Location = new System.Drawing.Point(146, 128);
            this.cmbtcuenta.Name = "cmbtcuenta";
            this.cmbtcuenta.Size = new System.Drawing.Size(175, 21);
            this.cmbtcuenta.TabIndex = 14;
            // 
            // cmbsucursal
            // 
            this.cmbsucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsucursal.FormattingEnabled = true;
            this.cmbsucursal.Items.AddRange(new object[] {
            "San Salvador",
            "Soyapango",
            "San Miguel",
            "San Vicente",
            "Santa Ana"});
            this.cmbsucursal.Location = new System.Drawing.Point(452, 128);
            this.cmbsucursal.Name = "cmbsucursal";
            this.cmbsucursal.Size = new System.Drawing.Size(134, 21);
            this.cmbsucursal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 361);
            this.Controls.Add(this.dgvcuentas);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbsucursal;
        private System.Windows.Forms.ComboBox cmbtcuenta;
        private System.Windows.Forms.TextBox txtmontocuenta;
        private System.Windows.Forms.TextBox txtncuenta;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView dgvcuentas;
    }
}

