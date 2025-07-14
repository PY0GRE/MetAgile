namespace MantenimientoEquipos.Views.CRUDUsers
{
    partial class MenuUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttAgregar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUsuariosModificar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUsuariosRegresar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.dgvUsuarios = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAgregar.BorderRadius = 20;
            this.bttAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAgregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregar.ForeColor = System.Drawing.Color.White;
            this.bttAgregar.Location = new System.Drawing.Point(653, 59);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(92, 40);
            this.bttAgregar.TabIndex = 4;
            this.bttAgregar.Text = "+ Agregar";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttUsuariosModificar
            // 
            this.bttUsuariosModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttUsuariosModificar.BorderRadius = 20;
            this.bttUsuariosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsuariosModificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUsuariosModificar.ForeColor = System.Drawing.Color.White;
            this.bttUsuariosModificar.Location = new System.Drawing.Point(528, 59);
            this.bttUsuariosModificar.Name = "bttUsuariosModificar";
            this.bttUsuariosModificar.Size = new System.Drawing.Size(102, 40);
            this.bttUsuariosModificar.TabIndex = 3;
            this.bttUsuariosModificar.Text = "Modificar";
            this.bttUsuariosModificar.UseVisualStyleBackColor = false;
            this.bttUsuariosModificar.Click += new System.EventHandler(this.bttUsuariosModificar_Click);
            // 
            // bttUsuariosRegresar
            // 
            this.bttUsuariosRegresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttUsuariosRegresar.BorderRadius = 20;
            this.bttUsuariosRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsuariosRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUsuariosRegresar.ForeColor = System.Drawing.Color.White;
            this.bttUsuariosRegresar.Location = new System.Drawing.Point(403, 59);
            this.bttUsuariosRegresar.Name = "bttUsuariosRegresar";
            this.bttUsuariosRegresar.Size = new System.Drawing.Size(96, 37);
            this.bttUsuariosRegresar.TabIndex = 2;
            this.bttUsuariosRegresar.Text = "Regresar";
            this.bttUsuariosRegresar.UseVisualStyleBackColor = false;
            this.bttUsuariosRegresar.Click += new System.EventHandler(this.bttUsuariosRegresar_Click);
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(44, 45);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(167, 49);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Usuarios";
            this.estandarTitleLabel1.Click += new System.EventHandler(this.estandarTitleLabel1_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.LightGray;
            this.dgvUsuarios.Location = new System.Drawing.Point(53, 143);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(692, 265);
            this.dgvUsuarios.TabIndex = 5;
            // 
            // MenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.bttUsuariosModificar);
            this.Controls.Add(this.bttUsuariosRegresar);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MenuUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarButton bttUsuariosRegresar;
        private ModifierComponents.EstandarButton bttUsuariosModificar;
        private ModifierComponents.EstandarButton bttAgregar;
        private ModifierComponents.EstandarDataView dgvUsuarios;
    }
}