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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.dgvRoles = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.btnNuevoRol = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.btnEditarRol = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttCancel = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(227, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestion de Roles ";
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRoles.EnableHeadersVisualStyles = false;
            this.dgvRoles.GridColor = System.Drawing.Color.LightGray;
            this.dgvRoles.Location = new System.Drawing.Point(267, 154);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersVisible = false;
            this.dgvRoles.Size = new System.Drawing.Size(240, 150);
            this.dgvRoles.TabIndex = 3;
            // 
            // btnNuevoRol
            // 
            this.btnNuevoRol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevoRol.BorderRadius = 20;
            this.btnNuevoRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRol.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRol.Location = new System.Drawing.Point(144, 396);
            this.btnNuevoRol.Name = "btnNuevoRol";
            this.btnNuevoRol.Size = new System.Drawing.Size(116, 35);
            this.btnNuevoRol.TabIndex = 6;
            this.btnNuevoRol.Text = "Nuevo Rol";
            this.btnNuevoRol.UseVisualStyleBackColor = false;
            
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEditarRol.BorderRadius = 20;
            this.btnEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRol.ForeColor = System.Drawing.Color.White;
            this.btnEditarRol.Location = new System.Drawing.Point(325, 396);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(120, 35);
            this.btnEditarRol.TabIndex = 8;
            this.btnEditarRol.Text = "Editar Rol";
            this.btnEditarRol.UseVisualStyleBackColor = false;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttCancel.BorderRadius = 20;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.Color.White;
            this.bttCancel.Location = new System.Drawing.Point(521, 396);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(116, 35);
            this.bttCancel.TabIndex = 14;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // MenuRolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.btnNuevoRol);
            this.Controls.Add(this.dgvRoles);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuRolesView";
            this.Text = "MenuRolesView";
            this.Load += new System.EventHandler(this.MenuRolesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel lblTitulo;
        private ModifierComponents.EstandarDataView dgvRoles;
        private ModifierComponents.EstandarButton btnNuevoRol;
        private ModifierComponents.EstandarButton btnEditarRol;
        private ModifierComponents.EstandarButton bttCancel;
    }
}