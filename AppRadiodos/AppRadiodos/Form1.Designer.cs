namespace AppRadiodos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.rdsuma = new System.Windows.Forms.RadioButton();
            this.rdresta = new System.Windows.Forms.RadioButton();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(24, 44);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(64, 13);
            this.lblnumero1.TabIndex = 0;
            this.lblnumero1.Text = "NUMERO 1";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(27, 90);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(64, 13);
            this.lblnumero2.TabIndex = 1;
            this.lblnumero2.Text = "NUMERO 2";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(27, 149);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(73, 13);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "RESULTADO";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(162, 213);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // rdsuma
            // 
            this.rdsuma.AutoSize = true;
            this.rdsuma.Location = new System.Drawing.Point(249, 66);
            this.rdsuma.Name = "rdsuma";
            this.rdsuma.Size = new System.Drawing.Size(56, 17);
            this.rdsuma.TabIndex = 4;
            this.rdsuma.TabStop = true;
            this.rdsuma.Text = "SUMA";
            this.rdsuma.UseVisualStyleBackColor = true;
            // 
            // rdresta
            // 
            this.rdresta.AutoSize = true;
            this.rdresta.Location = new System.Drawing.Point(249, 133);
            this.rdresta.Name = "rdresta";
            this.rdresta.Size = new System.Drawing.Size(61, 17);
            this.rdresta.TabIndex = 5;
            this.rdresta.TabStop = true;
            this.rdresta.Text = "RESTA";
            this.rdresta.UseVisualStyleBackColor = true;
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(114, 44);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 6;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(114, 90);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 7;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(114, 149);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 287);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.rdresta);
            this.Controls.Add(this.rdsuma);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.RadioButton rdsuma;
        private System.Windows.Forms.RadioButton rdresta;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

