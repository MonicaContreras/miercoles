namespace AppRadio
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
            this.rbopcion1 = new System.Windows.Forms.RadioButton();
            this.rbopcion2 = new System.Windows.Forms.RadioButton();
            this.rbopcion3 = new System.Windows.Forms.RadioButton();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbopcion1
            // 
            this.rbopcion1.AutoSize = true;
            this.rbopcion1.Location = new System.Drawing.Point(152, 57);
            this.rbopcion1.Name = "rbopcion1";
            this.rbopcion1.Size = new System.Drawing.Size(65, 17);
            this.rbopcion1.TabIndex = 0;
            this.rbopcion1.TabStop = true;
            this.rbopcion1.Text = "640*480";
            this.rbopcion1.UseVisualStyleBackColor = true;
            // 
            // rbopcion2
            // 
            this.rbopcion2.AutoSize = true;
            this.rbopcion2.Location = new System.Drawing.Point(152, 110);
            this.rbopcion2.Name = "rbopcion2";
            this.rbopcion2.Size = new System.Drawing.Size(65, 17);
            this.rbopcion2.TabIndex = 1;
            this.rbopcion2.TabStop = true;
            this.rbopcion2.Text = "800*600";
            this.rbopcion2.UseVisualStyleBackColor = true;
            this.rbopcion2.CheckedChanged += new System.EventHandler(this.rbopcion2_CheckedChanged);
            // 
            // rbopcion3
            // 
            this.rbopcion3.AutoSize = true;
            this.rbopcion3.Location = new System.Drawing.Point(152, 164);
            this.rbopcion3.Name = "rbopcion3";
            this.rbopcion3.Size = new System.Drawing.Size(71, 17);
            this.rbopcion3.TabIndex = 2;
            this.rbopcion3.TabStop = true;
            this.rbopcion3.Text = "1024*768";
            this.rbopcion3.UseVisualStyleBackColor = true;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(148, 216);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnconfirmar.TabIndex = 3;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 326);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.rbopcion3);
            this.Controls.Add(this.rbopcion2);
            this.Controls.Add(this.rbopcion1);
            this.Name = "Form1";
            this.Text = "Programa Resolución";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbopcion1;
        private System.Windows.Forms.RadioButton rbopcion2;
        private System.Windows.Forms.RadioButton rbopcion3;
        private System.Windows.Forms.Button btnconfirmar;
    }
}

