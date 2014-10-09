namespace AppTrabajo
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblprofesion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtprofesion = new System.Windows.Forms.TextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(22, 36);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(92, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre y Apellido";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(25, 76);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 1;
            this.lbledad.Text = "Edad";
            this.lbledad.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblprofesion
            // 
            this.lblprofesion.AutoSize = true;
            this.lblprofesion.Location = new System.Drawing.Point(25, 118);
            this.lblprofesion.Name = "lblprofesion";
            this.lblprofesion.Size = new System.Drawing.Size(51, 13);
            this.lblprofesion.TabIndex = 2;
            this.lblprofesion.Text = "Profesión";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(143, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(143, 76);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 4;
            // 
            // txtprofesion
            // 
            this.txtprofesion.Location = new System.Drawing.Point(143, 118);
            this.txtprofesion.Name = "txtprofesion";
            this.txtprofesion.Size = new System.Drawing.Size(100, 20);
            this.txtprofesion.TabIndex = 5;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(86, 180);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(88, 23);
            this.btnconfirmar.TabIndex = 6;
            this.btnconfirmar.Text = "CONFIRMAR";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.txtprofesion);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblprofesion);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblprofesion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtprofesion;
        private System.Windows.Forms.Button btnconfirmar;
    }
}

