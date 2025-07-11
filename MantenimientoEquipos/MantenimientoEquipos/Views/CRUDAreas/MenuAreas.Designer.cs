namespace MantenimientoEquipos.Views.CRUDAreas
{
    partial class MenuAreas
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
            this.txtId = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.DataMenuAreas = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.bttAreasModificar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUsuariosRegresar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataMenuAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 20;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(26, 84);
            this.txtId.Margin = new System.Windows.Forms.Padding(10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(289, 27);
            this.txtId.TabIndex = 17;
            // 
            // DataMenuAreas
            // 
            this.DataMenuAreas.AllowUserToAddRows = false;
            this.DataMenuAreas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.DataMenuAreas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataMenuAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataMenuAreas.BackgroundColor = System.Drawing.Color.Silver;
            this.DataMenuAreas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataMenuAreas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataMenuAreas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataMenuAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataMenuAreas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataMenuAreas.EnableHeadersVisualStyles = false;
            this.DataMenuAreas.GridColor = System.Drawing.Color.LightGray;
            this.DataMenuAreas.Location = new System.Drawing.Point(84, 131);
            this.DataMenuAreas.MultiSelect = false;
            this.DataMenuAreas.Name = "DataMenuAreas";
            this.DataMenuAreas.ReadOnly = true;
            this.DataMenuAreas.RowHeadersVisible = false;
            this.DataMenuAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataMenuAreas.Size = new System.Drawing.Size(617, 288);
            this.DataMenuAreas.TabIndex = 7;
            this.DataMenuAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMenuAreas_CellContentClick);
            // 
            // bttAreasModificar
            // 
            this.bttAreasModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttAreasModificar.BorderRadius = 20;
            this.bttAreasModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAreasModificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAreasModificar.ForeColor = System.Drawing.Color.White;
            this.bttAreasModificar.Location = new System.Drawing.Point(686, 29);
            this.bttAreasModificar.Name = "bttAreasModificar";
            this.bttAreasModificar.Size = new System.Drawing.Size(102, 40);
            this.bttAreasModificar.TabIndex = 6;
            this.bttAreasModificar.Text = "Modificar";
            this.bttAreasModificar.UseVisualStyleBackColor = false;
            this.bttAreasModificar.Click += new System.EventHandler(this.bttAreasModificar_Click);
            // 
            // bttUsuariosRegresar
            // 
            this.bttUsuariosRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttUsuariosRegresar.BorderRadius = 20;
            this.bttUsuariosRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsuariosRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUsuariosRegresar.ForeColor = System.Drawing.Color.White;
            this.bttUsuariosRegresar.Location = new System.Drawing.Point(560, 29);
            this.bttUsuariosRegresar.Name = "bttUsuariosRegresar";
            this.bttUsuariosRegresar.Size = new System.Drawing.Size(96, 37);
            this.bttUsuariosRegresar.TabIndex = 5;
            this.bttUsuariosRegresar.Text = "Regresar";
            this.bttUsuariosRegresar.UseVisualStyleBackColor = false;
            this.bttUsuariosRegresar.Click += new System.EventHandler(this.bttUsuariosRegresar_Click);
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(17, 17);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(8);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(222, 49);
            this.estandarTitleLabel1.TabIndex = 3;
            this.estandarTitleLabel1.Text = "Menú Areas";
            // 
            // MenuAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.DataMenuAreas);
            this.Controls.Add(this.bttAreasModificar);
            this.Controls.Add(this.bttUsuariosRegresar);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MenuAreas";
            this.Text = "AreasView";
            this.Load += new System.EventHandler(this.AreasView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMenuAreas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarButton bttAreasModificar;
        private ModifierComponents.EstandarButton bttUsuariosRegresar;
        private ModifierComponents.EstandarDataView DataMenuAreas;
        private ModifierComponents.EstandarTextBox txtId;
    }
}