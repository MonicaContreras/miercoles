namespace App3
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(178, 49);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // cmbpais
            // 
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Items.AddRange(new object[] {
            "Colombia",
            "Venezuela",
            "Francia",
            "España"});
            this.cmbpais.Location = new System.Drawing.Point(178, 93);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(121, 21);
            this.cmbpais.TabIndex = 4;
            this.cmbpais.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(53, 52);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(82, 13);
            this.lblnombre.TabIndex = 5;
            this.lblnombre.Text = "Ingrese Nombre";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(98, 165);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(103, 23);
            this.btnactualizar.TabIndex = 6;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 324);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "NOMBRE Y PAIS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btnactualizar;
    }
}

