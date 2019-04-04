namespace WindowsFormsApplication1
{
    partial class frmIndicaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.bntAbrir = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntAbrir
            // 
            this.bntAbrir.BackColor = System.Drawing.Color.PaleGreen;
            this.bntAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAbrir.Location = new System.Drawing.Point(66, 134);
            this.bntAbrir.Name = "bntAbrir";
            this.bntAbrir.Size = new System.Drawing.Size(266, 69);
            this.bntAbrir.TabIndex = 0;
            this.bntAbrir.Text = "Elije archivo de mandos para extraer indicaciones";
            this.bntAbrir.UseVisualStyleBackColor = false;
            this.bntAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblLabel
            // 
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(27, 35);
            this.lblLabel.MaximumSize = new System.Drawing.Size(356, 67);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(356, 67);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Esta app extraer todas las _QL de un archivo de mando y las coloca por orden alfa" +
                "bético en otro archivo";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmIndicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 235);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.bntAbrir);
            this.MaximizeBox = false;
            this.Name = "frmIndicaciones";
            this.Text = "Extraer indicaciones de mandos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntAbrir;
        private System.Windows.Forms.Label lblLabel;
    }
}

