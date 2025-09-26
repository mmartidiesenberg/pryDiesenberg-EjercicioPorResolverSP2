namespace pryDiesenberg_EjercicioPorResolverSP2
{
    partial class frmAplicacion
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
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.mskDistancia = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(28, 74);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(210, 16);
            this.lblDistancia.TabIndex = 0;
            this.lblDistancia.Text = "Ingrese la Distancia del Recorrido";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(28, 171);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(173, 16);
            this.lblCant.TabIndex = 1;
            this.lblCant.Text = "Ingrese la Cantidad de Días";
            // 
            // mskDistancia
            // 
            this.mskDistancia.Location = new System.Drawing.Point(304, 74);
            this.mskDistancia.Mask = "99999";
            this.mskDistancia.Name = "mskDistancia";
            this.mskDistancia.Size = new System.Drawing.Size(87, 20);
            this.mskDistancia.TabIndex = 2;
            this.mskDistancia.ValidatingType = typeof(int);
            this.mskDistancia.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(343, 167);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcular.Location = new System.Drawing.Point(118, 27);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(292, 24);
            this.lblCalcular.TabIndex = 4;
            this.lblCalcular.Text = "Calcule el Precio de su Boleto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(335, 225);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(397, 77);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(22, 13);
            this.lblKilometros.TabIndex = 6;
            this.lblKilometros.Text = "Km";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(28, 329);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(134, 16);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio Total a Pagar:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(240, 331);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(44, 16);
            this.lblPrecioTotal.TabIndex = 8;
            this.lblPrecioTotal.Text = "label1";
            this.lblPrecioTotal.Visible = false;
            // 
            // frmAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.mskDistancia);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblDistancia);
            this.Name = "frmAplicacion";
            this.Text = "Aplicación Ferro";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.MaskedTextBox mskDistancia;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPrecioTotal;
    }
}

