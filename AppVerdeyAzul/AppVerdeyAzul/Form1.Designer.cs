namespace AppVerdeyAzul
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
            this.lblroja = new System.Windows.Forms.Label();
            this.lblverde = new System.Windows.Forms.Label();
            this.lblazul = new System.Windows.Forms.Label();
            this.cmbrojo = new System.Windows.Forms.ComboBox();
            this.cmbverde = new System.Windows.Forms.ComboBox();
            this.cmbazul = new System.Windows.Forms.ComboBox();
            this.bntactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblroja
            // 
            this.lblroja.AutoSize = true;
            this.lblroja.Location = new System.Drawing.Point(41, 41);
            this.lblroja.Name = "lblroja";
            this.lblroja.Size = new System.Drawing.Size(29, 13);
            this.lblroja.TabIndex = 0;
            this.lblroja.Text = "Rojo";
            // 
            // lblverde
            // 
            this.lblverde.AutoSize = true;
            this.lblverde.Location = new System.Drawing.Point(41, 95);
            this.lblverde.Name = "lblverde";
            this.lblverde.Size = new System.Drawing.Size(35, 13);
            this.lblverde.TabIndex = 1;
            this.lblverde.Text = "Verde";
            // 
            // lblazul
            // 
            this.lblazul.AutoSize = true;
            this.lblazul.Location = new System.Drawing.Point(44, 149);
            this.lblazul.Name = "lblazul";
            this.lblazul.Size = new System.Drawing.Size(27, 13);
            this.lblazul.TabIndex = 2;
            this.lblazul.Text = "Azul";
            // 
            // cmbrojo
            // 
            this.cmbrojo.FormattingEnabled = true;
            this.cmbrojo.Location = new System.Drawing.Point(138, 41);
            this.cmbrojo.Name = "cmbrojo";
            this.cmbrojo.Size = new System.Drawing.Size(121, 21);
            this.cmbrojo.TabIndex = 3;
            // 
            // cmbverde
            // 
            this.cmbverde.FormattingEnabled = true;
            this.cmbverde.Location = new System.Drawing.Point(138, 95);
            this.cmbverde.Name = "cmbverde";
            this.cmbverde.Size = new System.Drawing.Size(121, 21);
            this.cmbverde.TabIndex = 4;
            // 
            // cmbazul
            // 
            this.cmbazul.FormattingEnabled = true;
            this.cmbazul.Location = new System.Drawing.Point(138, 149);
            this.cmbazul.Name = "cmbazul";
            this.cmbazul.Size = new System.Drawing.Size(121, 21);
            this.cmbazul.TabIndex = 5;
            // 
            // bntactualizar
            // 
            this.bntactualizar.Location = new System.Drawing.Point(113, 203);
            this.bntactualizar.Name = "bntactualizar";
            this.bntactualizar.Size = new System.Drawing.Size(75, 23);
            this.bntactualizar.TabIndex = 6;
            this.bntactualizar.Text = "Actualizar";
            this.bntactualizar.UseVisualStyleBackColor = true;
            this.bntactualizar.Click += new System.EventHandler(this.bntactualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntactualizar);
            this.Controls.Add(this.cmbazul);
            this.Controls.Add(this.cmbverde);
            this.Controls.Add(this.cmbrojo);
            this.Controls.Add(this.lblazul);
            this.Controls.Add(this.lblverde);
            this.Controls.Add(this.lblroja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblroja;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.Label lblazul;
        private System.Windows.Forms.ComboBox cmbrojo;
        private System.Windows.Forms.ComboBox cmbverde;
        private System.Windows.Forms.ComboBox cmbazul;
        private System.Windows.Forms.Button bntactualizar;
    }
}

