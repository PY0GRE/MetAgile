namespace MantenimientoEquipos.Views.CRUDRoles
{
    partial class MenuRolesView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.lblUsuarios = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.lblRoles = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.dgvRolesAsignados = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.cbUsuarios = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.cbRoles = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.btnAsignarRol = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.btnQuitarRol = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.lblRolesAsignados = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesAsignados)).BeginInit();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(141, 19);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(486, 49);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Gestion de Roles de Usuario";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarios.Location = new System.Drawing.Point(354, 88);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(10);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(67, 22);
            this.lblUsuarios.TabIndex = 1;
            this.lblUsuarios.Text = "Usuario";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.ForeColor = System.Drawing.Color.Black;
            this.lblRoles.Location = new System.Drawing.Point(376, 176);
            this.lblRoles.Margin = new System.Windows.Forms.Padding(10);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(34, 22);
            this.lblRoles.TabIndex = 2;
            this.lblRoles.Text = "Rol";
            // 
            // dgvRolesAsignados
            // 
            this.dgvRolesAsignados.AllowUserToAddRows = false;
            this.dgvRolesAsignados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvRolesAsignados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRolesAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRolesAsignados.BackgroundColor = System.Drawing.Color.White;
            this.dgvRolesAsignados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRolesAsignados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRolesAsignados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRolesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRolesAsignados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRolesAsignados.EnableHeadersVisualStyles = false;
            this.dgvRolesAsignados.GridColor = System.Drawing.Color.LightGray;
            this.dgvRolesAsignados.Location = new System.Drawing.Point(272, 384);
            this.dgvRolesAsignados.Name = "dgvRolesAsignados";
            this.dgvRolesAsignados.RowHeadersVisible = false;
            this.dgvRolesAsignados.Size = new System.Drawing.Size(240, 150);
            this.dgvRolesAsignados.TabIndex = 3;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(329, 123);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(121, 27);
            this.cbUsuarios.TabIndex = 4;
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(329, 211);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(121, 27);
            this.cbRoles.TabIndex = 5;
            // 
            // btnAsignarRol
            // 
            this.btnAsignarRol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAsignarRol.BorderRadius = 20;
            this.btnAsignarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarRol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRol.ForeColor = System.Drawing.Color.White;
            this.btnAsignarRol.Location = new System.Drawing.Point(257, 278);
            this.btnAsignarRol.Name = "btnAsignarRol";
            this.btnAsignarRol.Size = new System.Drawing.Size(116, 35);
            this.btnAsignarRol.TabIndex = 6;
            this.btnAsignarRol.Text = "Asignar Rol";
            this.btnAsignarRol.UseVisualStyleBackColor = false;
            // 
            // btnQuitarRol
            // 
            this.btnQuitarRol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnQuitarRol.BorderRadius = 20;
            this.btnQuitarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarRol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarRol.ForeColor = System.Drawing.Color.White;
            this.btnQuitarRol.Location = new System.Drawing.Point(410, 278);
            this.btnQuitarRol.Name = "btnQuitarRol";
            this.btnQuitarRol.Size = new System.Drawing.Size(120, 35);
            this.btnQuitarRol.TabIndex = 7;
            this.btnQuitarRol.Text = "Quitar Rol";
            this.btnQuitarRol.UseVisualStyleBackColor = false;
            // 
            // lblRolesAsignados
            // 
            this.lblRolesAsignados.AutoSize = true;
            this.lblRolesAsignados.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolesAsignados.ForeColor = System.Drawing.Color.Black;
            this.lblRolesAsignados.Location = new System.Drawing.Point(288, 349);
            this.lblRolesAsignados.Margin = new System.Windows.Forms.Padding(10);
            this.lblRolesAsignados.Name = "lblRolesAsignados";
            this.lblRolesAsignados.Size = new System.Drawing.Size(201, 22);
            this.lblRolesAsignados.TabIndex = 8;
            this.lblRolesAsignados.Text = "Roles asignados al usuario";
            // 
            // MenuRolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lblRolesAsignados);
            this.Controls.Add(this.btnQuitarRol);
            this.Controls.Add(this.btnAsignarRol);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.dgvRolesAsignados);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MenuRolesView";
            this.Text = "MenuRolesView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesAsignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarLabel lblUsuarios;
        private ModifierComponents.EstandarLabel lblRoles;
        private ModifierComponents.EstandarDataView dgvRolesAsignados;
        private ModifierComponents.EstadarComboBox cbUsuarios;
        private ModifierComponents.EstadarComboBox cbRoles;
        private ModifierComponents.EstandarButton btnAsignarRol;
        private ModifierComponents.EstandarButton btnQuitarRol;
        private ModifierComponents.EstandarLabel lblRolesAsignados;
    }
}