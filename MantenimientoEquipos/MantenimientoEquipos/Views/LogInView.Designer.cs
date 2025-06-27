namespace MantenimientoEquipos.Views
{
    partial class LogInView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.estandarLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel2 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.txtUser = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.txtPassword = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.bttAccept = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(196, 57);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(120, 49);
            this.estandarTitleLabel1.TabIndex = 18;
            this.estandarTitleLabel1.Text = "Log in";
            // 
            // estandarLabel1
            // 
            this.estandarLabel1.AutoSize = true;
            this.estandarLabel1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel1.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel1.Location = new System.Drawing.Point(114, 141);
            this.estandarLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel1.Name = "estandarLabel1";
            this.estandarLabel1.Size = new System.Drawing.Size(67, 22);
            this.estandarLabel1.TabIndex = 17;
            this.estandarLabel1.Text = "Usuario";
            // 
            // estandarLabel2
            // 
            this.estandarLabel2.AutoSize = true;
            this.estandarLabel2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel2.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel2.Location = new System.Drawing.Point(114, 223);
            this.estandarLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel2.Name = "estandarLabel2";
            this.estandarLabel2.Size = new System.Drawing.Size(98, 23);
            this.estandarLabel2.TabIndex = 16;
            this.estandarLabel2.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.BorderRadius = 20;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(114, 176);
            this.txtUser.Margin = new System.Windows.Forms.Padding(10);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(289, 27);
            this.txtUser.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(114, 249);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(289, 27);
            this.txtPassword.TabIndex = 14;
            // 
            // bttAccept
            // 
            this.bttAccept.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAccept.BorderRadius = 20;
            this.bttAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAccept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAccept.ForeColor = System.Drawing.Color.White;
            this.bttAccept.Location = new System.Drawing.Point(114, 303);
            this.bttAccept.Name = "bttAccept";
            this.bttAccept.Size = new System.Drawing.Size(289, 38);
            this.bttAccept.TabIndex = 13;
            this.bttAccept.Text = "Aceptar";
            this.bttAccept.UseVisualStyleBackColor = false;
            this.bttAccept.Click += new System.EventHandler(this.bttAccept_Click);
            // 
            // LogInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Controls.Add(this.estandarLabel1);
            this.Controls.Add(this.estandarLabel2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bttAccept);
            this.Name = "LogInView";
            this.Text = "LogInView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarLabel estandarLabel1;
        private ModifierComponents.EstandarLabel estandarLabel2;
        private ModifierComponents.EstandarTextBox txtUser;
        private ModifierComponents.EstandarTextBox txtPassword;
        private ModifierComponents.EstandarButton bttAccept;
    }
}