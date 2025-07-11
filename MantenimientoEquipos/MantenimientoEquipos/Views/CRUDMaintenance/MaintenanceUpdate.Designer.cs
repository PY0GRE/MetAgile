namespace MantenimientoEquipos.Views.CRUDMaintenance
{
    partial class MaintenanceUpdate
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
            if (disposing && (components != null))
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.bttCancel = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttAccept = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.cmbNature = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.cmbType = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel6 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel5 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel4 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel3 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cmbDevice = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel2 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.cmbUser = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(27, 249);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(151, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(218, 248);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(151, 20);
            this.dtpEndDate.TabIndex = 8;
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttCancel.BorderRadius = 20;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.Color.White;
            this.bttCancel.Location = new System.Drawing.Point(75, 425);
            this.bttCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(117, 35);
            this.bttCancel.TabIndex = 14;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click_1);
            // 
            // bttAccept
            // 
            this.bttAccept.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAccept.BorderRadius = 20;
            this.bttAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAccept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAccept.ForeColor = System.Drawing.Color.White;
            this.bttAccept.Location = new System.Drawing.Point(206, 425);
            this.bttAccept.Margin = new System.Windows.Forms.Padding(2);
            this.bttAccept.Name = "bttAccept";
            this.bttAccept.Size = new System.Drawing.Size(117, 35);
            this.bttAccept.TabIndex = 13;
            this.bttAccept.Text = "Aceptar";
            this.bttAccept.UseVisualStyleBackColor = false;
            this.bttAccept.Click += new System.EventHandler(this.bttAccept_Click_1);
            // 
            // cmbNature
            // 
            this.cmbNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNature.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNature.FormattingEnabled = true;
            this.cmbNature.Location = new System.Drawing.Point(218, 338);
            this.cmbNature.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNature.Name = "cmbNature";
            this.cmbNature.Size = new System.Drawing.Size(126, 27);
            this.cmbNature.TabIndex = 12;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(27, 338);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(144, 27);
            this.cmbType.TabIndex = 11;
            // 
            // estandarLabel6
            // 
            this.estandarLabel6.AutoSize = true;
            this.estandarLabel6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel6.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel6.Location = new System.Drawing.Point(214, 306);
            this.estandarLabel6.Margin = new System.Windows.Forms.Padding(8);
            this.estandarLabel6.Name = "estandarLabel6";
            this.estandarLabel6.Size = new System.Drawing.Size(90, 22);
            this.estandarLabel6.TabIndex = 10;
            this.estandarLabel6.Text = "Naturaleza";
            // 
            // estandarLabel5
            // 
            this.estandarLabel5.AutoSize = true;
            this.estandarLabel5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel5.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel5.Location = new System.Drawing.Point(23, 306);
            this.estandarLabel5.Margin = new System.Windows.Forms.Padding(8);
            this.estandarLabel5.Name = "estandarLabel5";
            this.estandarLabel5.Size = new System.Drawing.Size(42, 22);
            this.estandarLabel5.TabIndex = 9;
            this.estandarLabel5.Text = "Tipo";
            // 
            // estandarLabel4
            // 
            this.estandarLabel4.AutoSize = true;
            this.estandarLabel4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel4.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel4.Location = new System.Drawing.Point(214, 215);
            this.estandarLabel4.Margin = new System.Windows.Forms.Padding(8);
            this.estandarLabel4.Name = "estandarLabel4";
            this.estandarLabel4.Size = new System.Drawing.Size(78, 22);
            this.estandarLabel4.TabIndex = 6;
            this.estandarLabel4.Text = "Fecha Fin";
            // 
            // estandarLabel3
            // 
            this.estandarLabel3.AutoSize = true;
            this.estandarLabel3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel3.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel3.Location = new System.Drawing.Point(23, 215);
            this.estandarLabel3.Margin = new System.Windows.Forms.Padding(8);
            this.estandarLabel3.Name = "estandarLabel3";
            this.estandarLabel3.Size = new System.Drawing.Size(97, 22);
            this.estandarLabel3.TabIndex = 5;
            this.estandarLabel3.Text = "Fecha Inicio";
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(27, 136);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(149, 27);
            this.cmbDevice.TabIndex = 4;
            // 
            // estandarLabel2
            // 
            this.estandarLabel2.AutoSize = true;
            this.estandarLabel2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel2.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel2.Location = new System.Drawing.Point(214, 103);
            this.estandarLabel2.Margin = new System.Windows.Forms.Padding(8);
            this.estandarLabel2.Name = "estandarLabel2";
            this.estandarLabel2.Size = new System.Drawing.Size(67, 22);
            this.estandarLabel2.TabIndex = 2;
            this.estandarLabel2.Text = "Usuario";
            // 
            // estandarLabel1
            // 
            this.estandarLabel1.AutoSize = true;
            this.estandarLabel1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel1.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel1.Location = new System.Drawing.Point(23, 103);
            this.estandarLabel1.Margin = new System.Windows.Forms.Padding(8);
            this.estandarLabel1.Name = "estandarLabel1";
            this.estandarLabel1.Size = new System.Drawing.Size(90, 22);
            this.estandarLabel1.TabIndex = 1;
            this.estandarLabel1.Text = "Dispositivo";
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(14, 15);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(8);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(428, 49);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Actualizar mantenientos";
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(218, 136);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(149, 27);
            this.cmbUser.TabIndex = 15;
            // 
            // MaintenanceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 507);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttAccept);
            this.Controls.Add(this.cmbNature);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.estandarLabel6);
            this.Controls.Add(this.estandarLabel5);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.estandarLabel4);
            this.Controls.Add(this.estandarLabel3);
            this.Controls.Add(this.cmbDevice);
            this.Controls.Add(this.estandarLabel2);
            this.Controls.Add(this.estandarLabel1);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaintenanceUpdate";
            this.Text = "MaintenanceUpdate";
            this.Load += new System.EventHandler(this.MaintenanceUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarLabel estandarLabel1;
        private ModifierComponents.EstandarLabel estandarLabel2;
        private ModifierComponents.EstadarComboBox cmbDevice;
        private ModifierComponents.EstandarLabel estandarLabel3;
        private ModifierComponents.EstandarLabel estandarLabel4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private ModifierComponents.EstandarLabel estandarLabel5;
        private ModifierComponents.EstandarLabel estandarLabel6;
        private ModifierComponents.EstadarComboBox cmbType;
        private ModifierComponents.EstadarComboBox cmbNature;
        private ModifierComponents.EstandarButton bttAccept;
        private ModifierComponents.EstandarButton bttCancel;
        private ModifierComponents.EstadarComboBox cmbUser;
    }
}