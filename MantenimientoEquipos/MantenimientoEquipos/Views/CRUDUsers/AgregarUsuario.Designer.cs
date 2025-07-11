namespace MantenimientoEquipos.Views.CRUDUsers
{
    partial class AgregarUsuario
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
            this.txtCorreo = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarLabel5 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.txtNombreCompleto = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarLabel4 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cbStatus = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel3 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cbRol = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel2 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.lblTitle = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.txtContraseña = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarLabel6 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.bttGuardar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.BttMenuUsuario = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.BttRegresar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderRadius = 20;
            this.txtCorreo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(52, 261);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(10);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(347, 27);
            this.txtCorreo.TabIndex = 22;
            // 
            // estandarLabel5
            // 
            this.estandarLabel5.AutoSize = true;
            this.estandarLabel5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel5.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel5.Location = new System.Drawing.Point(52, 222);
            this.estandarLabel5.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel5.Name = "estandarLabel5";
            this.estandarLabel5.Size = new System.Drawing.Size(142, 22);
            this.estandarLabel5.TabIndex = 21;
            this.estandarLabel5.Text = "Correo electónico";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.BorderRadius = 20;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(52, 175);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(347, 27);
            this.txtNombreCompleto.TabIndex = 19;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // estandarLabel4
            // 
            this.estandarLabel4.AutoSize = true;
            this.estandarLabel4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel4.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel4.Location = new System.Drawing.Point(48, 133);
            this.estandarLabel4.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel4.Name = "estandarLabel4";
            this.estandarLabel4.Size = new System.Drawing.Size(144, 22);
            this.estandarLabel4.TabIndex = 18;
            this.estandarLabel4.Text = "Nombre completo";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(52, 343);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(181, 27);
            this.cbStatus.TabIndex = 17;
            // 
            // estandarLabel3
            // 
            this.estandarLabel3.AutoSize = true;
            this.estandarLabel3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel3.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel3.Location = new System.Drawing.Point(48, 308);
            this.estandarLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel3.Name = "estandarLabel3";
            this.estandarLabel3.Size = new System.Drawing.Size(63, 22);
            this.estandarLabel3.TabIndex = 16;
            this.estandarLabel3.Text = "Estatus";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(52, 420);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(173, 27);
            this.cbRol.TabIndex = 15;
            // 
            // estandarLabel2
            // 
            this.estandarLabel2.AutoSize = true;
            this.estandarLabel2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel2.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel2.Location = new System.Drawing.Point(48, 385);
            this.estandarLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel2.Name = "estandarLabel2";
            this.estandarLabel2.Size = new System.Drawing.Size(34, 22);
            this.estandarLabel2.TabIndex = 14;
            this.estandarLabel2.Text = "Rol";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(47, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 49);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Creación Usuario";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderRadius = 20;
            this.txtContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(52, 505);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(10);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(154, 27);
            this.txtContraseña.TabIndex = 24;
            // 
            // estandarLabel6
            // 
            this.estandarLabel6.AutoSize = true;
            this.estandarLabel6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel6.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel6.Location = new System.Drawing.Point(48, 470);
            this.estandarLabel6.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel6.Name = "estandarLabel6";
            this.estandarLabel6.Size = new System.Drawing.Size(94, 22);
            this.estandarLabel6.TabIndex = 23;
            this.estandarLabel6.Text = "Contraseña";
            // 
            // bttGuardar
            // 
            this.bttGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttGuardar.BorderRadius = 20;
            this.bttGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGuardar.ForeColor = System.Drawing.Color.White;
            this.bttGuardar.Location = new System.Drawing.Point(354, 567);
            this.bttGuardar.Name = "bttGuardar";
            this.bttGuardar.Size = new System.Drawing.Size(112, 36);
            this.bttGuardar.TabIndex = 25;
            this.bttGuardar.Text = "Guardar";
            this.bttGuardar.UseVisualStyleBackColor = false;
            this.bttGuardar.Click += new System.EventHandler(this.bttGuardar_Click);
            // 
            // BttMenuUsuario
            // 
            this.BttMenuUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BttMenuUsuario.BorderRadius = 20;
            this.BttMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttMenuUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttMenuUsuario.ForeColor = System.Drawing.Color.White;
            this.BttMenuUsuario.Location = new System.Drawing.Point(530, 568);
            this.BttMenuUsuario.Name = "BttMenuUsuario";
            this.BttMenuUsuario.Size = new System.Drawing.Size(122, 35);
            this.BttMenuUsuario.TabIndex = 26;
            this.BttMenuUsuario.Text = "Menu Usuarios";
            this.BttMenuUsuario.UseVisualStyleBackColor = false;
            this.BttMenuUsuario.Click += new System.EventHandler(this.BttMenuUsuario_Click);
            // 
            // BttRegresar
            // 
            this.BttRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BttRegresar.BorderRadius = 20;
            this.BttRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttRegresar.ForeColor = System.Drawing.Color.White;
            this.BttRegresar.Location = new System.Drawing.Point(212, 568);
            this.BttRegresar.Name = "BttRegresar";
            this.BttRegresar.Size = new System.Drawing.Size(91, 35);
            this.BttRegresar.TabIndex = 27;
            this.BttRegresar.Text = "Regresar";
            this.BttRegresar.UseVisualStyleBackColor = false;
            this.BttRegresar.Click += new System.EventHandler(this.BttRegresar_Click);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 646);
            this.Controls.Add(this.BttRegresar);
            this.Controls.Add(this.BttMenuUsuario);
            this.Controls.Add(this.bttGuardar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.estandarLabel6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.estandarLabel5);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.estandarLabel4);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.estandarLabel3);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.estandarLabel2);
            this.Controls.Add(this.lblTitle);
            this.Name = "AgregarUsuario";
            this.Text = "UsersView";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTextBox txtCorreo;
        private ModifierComponents.EstandarLabel estandarLabel5;
        private ModifierComponents.EstandarTextBox txtNombreCompleto;
        private ModifierComponents.EstandarLabel estandarLabel4;
        private ModifierComponents.EstadarComboBox cbStatus;
        private ModifierComponents.EstandarLabel estandarLabel3;
        private ModifierComponents.EstadarComboBox cbRol;
        private ModifierComponents.EstandarLabel estandarLabel2;
        private ModifierComponents.EstandarTitleLabel lblTitle;
        private ModifierComponents.EstandarTextBox txtContraseña;
        private ModifierComponents.EstandarLabel estandarLabel6;
        private ModifierComponents.EstandarButton bttGuardar;
        private ModifierComponents.EstandarButton BttMenuUsuario;
        private ModifierComponents.EstandarButton BttRegresar;
    }
}