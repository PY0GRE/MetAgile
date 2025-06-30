namespace MantenimientoEquipos.Views.CRUDMaintenance
{
    partial class MaintenanceDelete
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
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.estandarDataView1 = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.ColumnNombreDlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUsuarioDlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaFinDlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoMantDlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturalezaMantDlt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estandarButton1 = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.estandarButton2 = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.estandarLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            ((System.ComponentModel.ISupportInitialize)(this.estandarDataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(194, 0);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(424, 51);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Elimiar mantenimiento";
            // 
            // estandarDataView1
            // 
            this.estandarDataView1.AllowUserToAddRows = false;
            this.estandarDataView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.estandarDataView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.estandarDataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estandarDataView1.BackgroundColor = System.Drawing.Color.White;
            this.estandarDataView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.estandarDataView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.estandarDataView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.estandarDataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estandarDataView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombreDlt,
            this.ColumnUsuarioDlt,
            this.ColumnFechaInicio,
            this.ColumnFechaFinDlt,
            this.ColumnTipoMantDlt,
            this.NaturalezaMantDlt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.estandarDataView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.estandarDataView1.EnableHeadersVisualStyles = false;
            this.estandarDataView1.GridColor = System.Drawing.Color.LightGray;
            this.estandarDataView1.Location = new System.Drawing.Point(43, 125);
            this.estandarDataView1.Name = "estandarDataView1";
            this.estandarDataView1.RowHeadersVisible = false;
            this.estandarDataView1.RowHeadersWidth = 51;
            this.estandarDataView1.RowTemplate.Height = 24;
            this.estandarDataView1.Size = new System.Drawing.Size(739, 237);
            this.estandarDataView1.TabIndex = 1;
            // 
            // ColumnNombreDlt
            // 
            this.ColumnNombreDlt.HeaderText = "Nombre";
            this.ColumnNombreDlt.MinimumWidth = 6;
            this.ColumnNombreDlt.Name = "ColumnNombreDlt";
            // 
            // ColumnUsuarioDlt
            // 
            this.ColumnUsuarioDlt.HeaderText = "Usuario";
            this.ColumnUsuarioDlt.MinimumWidth = 6;
            this.ColumnUsuarioDlt.Name = "ColumnUsuarioDlt";
            // 
            // ColumnFechaInicio
            // 
            this.ColumnFechaInicio.HeaderText = "Fecha Inicio";
            this.ColumnFechaInicio.MinimumWidth = 6;
            this.ColumnFechaInicio.Name = "ColumnFechaInicio";
            // 
            // ColumnFechaFinDlt
            // 
            this.ColumnFechaFinDlt.HeaderText = "Fecha Fin";
            this.ColumnFechaFinDlt.MinimumWidth = 6;
            this.ColumnFechaFinDlt.Name = "ColumnFechaFinDlt";
            // 
            // ColumnTipoMantDlt
            // 
            this.ColumnTipoMantDlt.HeaderText = "Tipo";
            this.ColumnTipoMantDlt.MinimumWidth = 6;
            this.ColumnTipoMantDlt.Name = "ColumnTipoMantDlt";
            // 
            // NaturalezaMantDlt
            // 
            this.NaturalezaMantDlt.HeaderText = "Naturaleza";
            this.NaturalezaMantDlt.MinimumWidth = 6;
            this.NaturalezaMantDlt.Name = "NaturalezaMantDlt";
            // 
            // estandarButton1
            // 
            this.estandarButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarButton1.BorderRadius = 20;
            this.estandarButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estandarButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarButton1.ForeColor = System.Drawing.Color.White;
            this.estandarButton1.Location = new System.Drawing.Point(444, 388);
            this.estandarButton1.Name = "estandarButton1";
            this.estandarButton1.Size = new System.Drawing.Size(203, 35);
            this.estandarButton1.TabIndex = 2;
            this.estandarButton1.Text = "Eliminar sleccionado";
            this.estandarButton1.UseVisualStyleBackColor = false;
            // 
            // estandarButton2
            // 
            this.estandarButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarButton2.BorderRadius = 20;
            this.estandarButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estandarButton2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarButton2.ForeColor = System.Drawing.Color.White;
            this.estandarButton2.Location = new System.Drawing.Point(662, 388);
            this.estandarButton2.Name = "estandarButton2";
            this.estandarButton2.Size = new System.Drawing.Size(92, 35);
            this.estandarButton2.TabIndex = 3;
            this.estandarButton2.Text = "Cancelar";
            this.estandarButton2.UseVisualStyleBackColor = false;
            // 
            // estandarLabel1
            // 
            this.estandarLabel1.AutoSize = true;
            this.estandarLabel1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel1.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel1.Location = new System.Drawing.Point(43, 85);
            this.estandarLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel1.Name = "estandarLabel1";
            this.estandarLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.estandarLabel1.Size = new System.Drawing.Size(462, 27);
            this.estandarLabel1.TabIndex = 4;
            this.estandarLabel1.Text = "Selecciona el mantenimiento que deseas eliminar";
            this.estandarLabel1.Click += new System.EventHandler(this.estandarLabel1_Click);
            // 
            // MaintenanceDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estandarLabel1);
            this.Controls.Add(this.estandarButton2);
            this.Controls.Add(this.estandarButton1);
            this.Controls.Add(this.estandarDataView1);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MaintenanceDelete";
            this.Text = "MaintenanceDelete";
            ((System.ComponentModel.ISupportInitialize)(this.estandarDataView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarDataView estandarDataView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombreDlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsuarioDlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaFinDlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoMantDlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaturalezaMantDlt;
        private ModifierComponents.EstandarButton estandarButton1;
        private ModifierComponents.EstandarButton estandarButton2;
        private ModifierComponents.EstandarLabel estandarLabel1;
    }
}