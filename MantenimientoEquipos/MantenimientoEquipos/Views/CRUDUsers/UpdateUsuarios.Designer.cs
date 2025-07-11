namespace MantenimientoEquipos.Views.CRUDUsers
{
    partial class UpdateUsuarios
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
            this.txtNombreCompleto = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarLabel2 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.txtCorreo = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.Contraseña = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.txtContraseña = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.cbRol = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel3 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.Status = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cbStatus = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.bttGuardarCambios = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttRegresar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(19, 31);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(330, 49);
            this.estandarTitleLabel1.TabIndex = 15;
            this.estandarTitleLabel1.Text = "Modificar Usuario ";
            this.estandarTitleLabel1.Click += new System.EventHandler(this.estandarTitleLabel1_Click);
            // 
            // estandarLabel1
            // 
            this.estandarLabel1.AutoSize = true;
            this.estandarLabel1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel1.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel1.Location = new System.Drawing.Point(24, 100);
            this.estandarLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel1.Name = "estandarLabel1";
            this.estandarLabel1.Size = new System.Drawing.Size(146, 22);
            this.estandarLabel1.TabIndex = 16;
            this.estandarLabel1.Text = "Nombre Completo";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BorderRadius = 20;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(19, 142);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(282, 27);
            this.txtNombreCompleto.TabIndex = 17;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // estandarLabel2
            // 
            this.estandarLabel2.AutoSize = true;
            this.estandarLabel2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel2.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel2.Location = new System.Drawing.Point(24, 189);
            this.estandarLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel2.Name = "estandarLabel2";
            this.estandarLabel2.Size = new System.Drawing.Size(148, 22);
            this.estandarLabel2.TabIndex = 18;
            this.estandarLabel2.Text = "Correo electrónico";
            this.estandarLabel2.Click += new System.EventHandler(this.estandarLabel2_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderRadius = 20;
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(19, 231);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(10);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(282, 27);
            this.txtCorreo.TabIndex = 19;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.Color.Black;
            this.Contraseña.Location = new System.Drawing.Point(24, 278);
            this.Contraseña.Margin = new System.Windows.Forms.Padding(10);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(94, 22);
            this.Contraseña.TabIndex = 20;
            this.Contraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderRadius = 20;
            this.txtContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(19, 320);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(10);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(282, 27);
            this.txtContraseña.TabIndex = 21;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(355, 142);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(230, 27);
            this.cbRol.TabIndex = 22;
            this.cbRol.SelectedIndexChanged += new System.EventHandler(this.cbRol_SelectedIndexChanged);
            // 
            // estandarLabel3
            // 
            this.estandarLabel3.AutoSize = true;
            this.estandarLabel3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel3.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel3.Location = new System.Drawing.Point(351, 100);
            this.estandarLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel3.Name = "estandarLabel3";
            this.estandarLabel3.Size = new System.Drawing.Size(34, 22);
            this.estandarLabel3.TabIndex = 23;
            this.estandarLabel3.Text = "Rol";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Black;
            this.Status.Location = new System.Drawing.Point(351, 189);
            this.Status.Margin = new System.Windows.Forms.Padding(10);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(55, 22);
            this.Status.TabIndex = 24;
            this.Status.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(355, 231);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(230, 27);
            this.cbStatus.TabIndex = 25;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // bttGuardarCambios
            // 
            this.bttGuardarCambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttGuardarCambios.BorderRadius = 20;
            this.bttGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardarCambios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.bttGuardarCambios.Location = new System.Drawing.Point(355, 363);
            this.bttGuardarCambios.Name = "bttGuardarCambios";
            this.bttGuardarCambios.Size = new System.Drawing.Size(123, 35);
            this.bttGuardarCambios.TabIndex = 28;
            this.bttGuardarCambios.Text = "Aceptar Cambio";
            this.bttGuardarCambios.UseVisualStyleBackColor = false;
            this.bttGuardarCambios.Click += new System.EventHandler(this.bttGuardarCambios_Click);
            // 
            // bttRegresar
            // 
            this.bttRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttRegresar.BorderRadius = 20;
            this.bttRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRegresar.ForeColor = System.Drawing.Color.White;
            this.bttRegresar.Location = new System.Drawing.Point(534, 363);
            this.bttRegresar.Name = "bttRegresar";
            this.bttRegresar.Size = new System.Drawing.Size(103, 35);
            this.bttRegresar.TabIndex = 29;
            this.bttRegresar.Text = "Regresar";
            this.bttRegresar.UseVisualStyleBackColor = false;
            this.bttRegresar.Click += new System.EventHandler(this.bttRegresar_Click);
            // 
            // UpdateUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttRegresar);
            this.Controls.Add(this.bttGuardarCambios);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.estandarLabel3);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.estandarLabel2);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.estandarLabel1);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "UpdateUsuarios";
            this.Text = "MenuUsersView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarLabel estandarLabel1;
        private ModifierComponents.EstandarTextBox txtNombreCompleto;
        private ModifierComponents.EstandarLabel estandarLabel2;
        private ModifierComponents.EstandarTextBox txtCorreo;
        private ModifierComponents.EstandarLabel Contraseña;
        private ModifierComponents.EstandarTextBox txtContraseña;
        private ModifierComponents.EstadarComboBox cbRol;
        private ModifierComponents.EstandarLabel estandarLabel3;
        private ModifierComponents.EstandarLabel Status;
        private ModifierComponents.EstadarComboBox cbStatus;
        private ModifierComponents.EstandarButton bttGuardarCambios;
        private ModifierComponents.EstandarButton bttRegresar;
    }
}