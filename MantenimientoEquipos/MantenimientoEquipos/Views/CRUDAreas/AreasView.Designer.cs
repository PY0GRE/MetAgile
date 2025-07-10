namespace MantenimientoEquipos.Views.CRUDAreas
{
    partial class AreasView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.estandarDataView1 = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.estandarButton1 = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUsuariosModificar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUsuariosRegresar = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            ((System.ComponentModel.ISupportInitialize)(this.estandarDataView1)).BeginInit();
            this.SuspendLayout();
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
            // estandarDataView1
            // 
            this.estandarDataView1.AllowUserToAddRows = false;
            this.estandarDataView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.estandarDataView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.estandarDataView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.estandarDataView1.BackgroundColor = System.Drawing.Color.Silver;
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
            this.estandarDataView1.Location = new System.Drawing.Point(90, 95);
            this.estandarDataView1.MultiSelect = false;
            this.estandarDataView1.Name = "estandarDataView1";
            this.estandarDataView1.ReadOnly = true;
            this.estandarDataView1.RowHeadersVisible = false;
            this.estandarDataView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.estandarDataView1.Size = new System.Drawing.Size(597, 303);
            this.estandarDataView1.TabIndex = 4;
            // 
            // estandarButton1
            // 
            this.estandarButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.estandarButton1.BorderRadius = 20;
            this.estandarButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.estandarButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarButton1.ForeColor = System.Drawing.Color.White;
            this.estandarButton1.Location = new System.Drawing.Point(683, 29);
            this.estandarButton1.Name = "estandarButton1";
            this.estandarButton1.Size = new System.Drawing.Size(92, 40);
            this.estandarButton1.TabIndex = 7;
            this.estandarButton1.Text = "+ Agregar";
            this.estandarButton1.UseVisualStyleBackColor = false;
            // 
            // bttUsuariosModificar
            // 
            this.bttUsuariosModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bttUsuariosModificar.BorderRadius = 20;
            this.bttUsuariosModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsuariosModificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUsuariosModificar.ForeColor = System.Drawing.Color.White;
            this.bttUsuariosModificar.Location = new System.Drawing.Point(558, 29);
            this.bttUsuariosModificar.Name = "bttUsuariosModificar";
            this.bttUsuariosModificar.Size = new System.Drawing.Size(102, 40);
            this.bttUsuariosModificar.TabIndex = 6;
            this.bttUsuariosModificar.Text = "Modificar";
            this.bttUsuariosModificar.UseVisualStyleBackColor = false;
            // 
            // bttUsuariosRegresar
            // 
            this.bttUsuariosRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttUsuariosRegresar.BorderRadius = 20;
            this.bttUsuariosRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsuariosRegresar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUsuariosRegresar.ForeColor = System.Drawing.Color.White;
            this.bttUsuariosRegresar.Location = new System.Drawing.Point(433, 29);
            this.bttUsuariosRegresar.Name = "bttUsuariosRegresar";
            this.bttUsuariosRegresar.Size = new System.Drawing.Size(96, 37);
            this.bttUsuariosRegresar.TabIndex = 5;
            this.bttUsuariosRegresar.Text = "Regresar";
            this.bttUsuariosRegresar.UseVisualStyleBackColor = false;
            // 
            // AreasView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estandarButton1);
            this.Controls.Add(this.bttUsuariosModificar);
            this.Controls.Add(this.bttUsuariosRegresar);
            this.Controls.Add(this.estandarDataView1);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "AreasView";
            this.Text = "AreasView";
            ((System.ComponentModel.ISupportInitialize)(this.estandarDataView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarDataView estandarDataView1;
        private ModifierComponents.EstandarButton estandarButton1;
        private ModifierComponents.EstandarButton bttUsuariosModificar;
        private ModifierComponents.EstandarButton bttUsuariosRegresar;
    }
}