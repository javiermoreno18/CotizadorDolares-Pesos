namespace Convertidor_Dolares
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
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.rbPesosDolares = new System.Windows.Forms.RadioButton();
            this.rbDolaresPesos = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(65, 211);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(208, 20);
            this.tbMonto.TabIndex = 0;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(65, 346);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(208, 20);
            this.tbResultado.TabIndex = 1;
            // 
            // rbPesosDolares
            // 
            this.rbPesosDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesosDolares.Location = new System.Drawing.Point(31, 27);
            this.rbPesosDolares.Name = "rbPesosDolares";
            this.rbPesosDolares.Size = new System.Drawing.Size(205, 27);
            this.rbPesosDolares.TabIndex = 2;
            this.rbPesosDolares.TabStop = true;
            this.rbPesosDolares.Text = "Conversion de pesos a dolares ";
            this.rbPesosDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPesosDolares.UseVisualStyleBackColor = true;
            this.rbPesosDolares.CheckedChanged += new System.EventHandler(this.rbPesosDolares_CheckedChanged);
            // 
            // rbDolaresPesos
            // 
            this.rbDolaresPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDolaresPesos.Location = new System.Drawing.Point(31, 2);
            this.rbDolaresPesos.Name = "rbDolaresPesos";
            this.rbDolaresPesos.Size = new System.Drawing.Size(205, 27);
            this.rbDolaresPesos.TabIndex = 3;
            this.rbDolaresPesos.TabStop = true;
            this.rbDolaresPesos.Text = "Conversion de dolares a pesos ";
            this.rbDolaresPesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbDolaresPesos.UseVisualStyleBackColor = true;
            this.rbDolaresPesos.CheckedChanged += new System.EventHandler(this.rbDolaresPesos_CheckedChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(65, 248);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(208, 41);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione la opcion que desee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el monto que desea convertir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cotizador de cambio pesos-dolares";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "CALCULADORA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDolaresPesos);
            this.groupBox1.Controls.Add(this.rbPesosDolares);
            this.groupBox1.Location = new System.Drawing.Point(37, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(64, 378);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(209, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 410);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbMonto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.RadioButton rbPesosDolares;
        private System.Windows.Forms.RadioButton rbDolaresPesos;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
    }
}

