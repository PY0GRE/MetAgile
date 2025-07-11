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
            this.bttCancel = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUpdate = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttAdd = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.dtView = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.lblTitulo = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttCancel.BorderRadius = 20;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.Color.White;
            this.bttCancel.Location = new System.Drawing.Point(529, 54);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(120, 35);
            this.bttCancel.TabIndex = 14;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttUpdate.BorderRadius = 20;
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUpdate.ForeColor = System.Drawing.Color.White;
            this.bttUpdate.Location = new System.Drawing.Point(529, 95);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(120, 35);
            this.bttUpdate.TabIndex = 8;
            this.bttUpdate.Text = "Editar Rol";
            this.bttUpdate.UseVisualStyleBackColor = false;
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAdd.BorderRadius = 20;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ForeColor = System.Drawing.Color.White;
            this.bttAdd.Location = new System.Drawing.Point(529, 136);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(120, 35);
            this.bttAdd.TabIndex = 6;
            this.bttAdd.Text = "Nuevo Rol";
            this.bttAdd.UseVisualStyleBackColor = false;
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView.BackgroundColor = System.Drawing.Color.White;
            this.dtView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtView.EnableHeadersVisualStyles = false;
            this.dtView.GridColor = System.Drawing.Color.LightGray;
            this.dtView.Location = new System.Drawing.Point(28, 183);
            this.dtView.MultiSelect = false;
            this.dtView.Name = "dtView";
            this.dtView.ReadOnly = true;
            this.dtView.RowHeadersVisible = false;
            this.dtView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtView.Size = new System.Drawing.Size(621, 302);
            this.dtView.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(19, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestion de Roles ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(28, 82);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Visible = false;
            // 
            // MenuRolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 524);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuRolesView";
            this.Text = "MenuRolesView";
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel lblTitulo;
        private ModifierComponents.EstandarDataView dtView;
        private ModifierComponents.EstandarButton bttAdd;
        private ModifierComponents.EstandarButton bttUpdate;
        private ModifierComponents.EstandarButton bttCancel;
        private System.Windows.Forms.TextBox txtId;
    }
}