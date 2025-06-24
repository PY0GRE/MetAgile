namespace MantenimientoEquipos
{
    partial class EstandarizacionComponentes
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
            if ( disposing && ( components != null ) )
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
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.estandarLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel2 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarTextBox2 = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarTextBox1 = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.Aceptar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(182, 49);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(120, 49);
            this.estandarTitleLabel1.TabIndex = 12;
            this.estandarTitleLabel1.Text = "Log in";
            // 
            // estandarLabel1
            // 
            this.estandarLabel1.AutoSize = true;
            this.estandarLabel1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel1.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel1.Location = new System.Drawing.Point(100, 133);
            this.estandarLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel1.Name = "estandarLabel1";
            this.estandarLabel1.Size = new System.Drawing.Size(67, 22);
            this.estandarLabel1.TabIndex = 11;
            this.estandarLabel1.Text = "Usuario";
            // 
            // estandarLabel2
            // 
            this.estandarLabel2.AutoSize = true;
            this.estandarLabel2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel2.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel2.Location = new System.Drawing.Point(100, 215);
            this.estandarLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel2.Name = "estandarLabel2";
            this.estandarLabel2.Size = new System.Drawing.Size(98, 23);
            this.estandarLabel2.TabIndex = 10;
            this.estandarLabel2.Text = "Contraseña";
            // 
            // estandarTextBox2
            // 
            this.estandarTextBox2.BorderRadius = 20;
            this.estandarTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTextBox2.Location = new System.Drawing.Point(100, 168);
            this.estandarTextBox2.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTextBox2.Name = "estandarTextBox2";
            this.estandarTextBox2.Size = new System.Drawing.Size(289, 27);
            this.estandarTextBox2.TabIndex = 6;
            // 
            // estandarTextBox1
            // 
            this.estandarTextBox1.BorderRadius = 20;
            this.estandarTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTextBox1.Location = new System.Drawing.Point(100, 241);
            this.estandarTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTextBox1.Name = "estandarTextBox1";
            this.estandarTextBox1.Size = new System.Drawing.Size(289, 27);
            this.estandarTextBox1.TabIndex = 5;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Aceptar.BorderRadius = 20;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.Color.White;
            this.Aceptar.Location = new System.Drawing.Point(100, 295);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(289, 38);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // EstandarizacionComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 500);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Controls.Add(this.estandarLabel1);
            this.Controls.Add(this.estandarLabel2);
            this.Controls.Add(this.estandarTextBox2);
            this.Controls.Add(this.estandarTextBox1);
            this.Controls.Add(this.Aceptar);
            this.Name = "EstandarizacionComponentes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ModifierComponents.EstandarButton Aceptar;
        private ModifierComponents.EstandarTextBox estandarTextBox1;
        private ModifierComponents.EstandarTextBox estandarTextBox2;
        private ModifierComponents.EstandarLabel estandarLabel2;
        private ModifierComponents.EstandarLabel estandarLabel1;
        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
    }
}

