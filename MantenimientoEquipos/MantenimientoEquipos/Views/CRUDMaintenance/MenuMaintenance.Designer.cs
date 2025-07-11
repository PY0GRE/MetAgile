namespace MantenimientoEquipos.Views.CRUDMaintenance
{
    partial class MenuMaintenance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.bttAdd = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttDelete = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttModify = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttReturn = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.dtView = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.txtId = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold);
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(41, 41);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(324, 51);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Mantenimientos ";
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAdd.BorderRadius = 20;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ForeColor = System.Drawing.Color.White;
            this.bttAdd.Location = new System.Drawing.Point(1240, 151);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(156, 43);
            this.bttAdd.TabIndex = 7;
            this.bttAdd.Text = "Agregar";
            this.bttAdd.UseVisualStyleBackColor = false;
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.IndianRed;
            this.bttDelete.BorderRadius = 20;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.ForeColor = System.Drawing.Color.White;
            this.bttDelete.Location = new System.Drawing.Point(1061, 151);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(156, 43);
            this.bttDelete.TabIndex = 8;
            this.bttDelete.Text = "Baja";
            this.bttDelete.UseVisualStyleBackColor = false;
            // 
            // bttModify
            // 
            this.bttModify.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttModify.BorderRadius = 20;
            this.bttModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModify.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttModify.ForeColor = System.Drawing.Color.White;
            this.bttModify.Location = new System.Drawing.Point(1240, 102);
            this.bttModify.Name = "bttModify";
            this.bttModify.Size = new System.Drawing.Size(156, 43);
            this.bttModify.TabIndex = 9;
            this.bttModify.Text = "Modificar";
            this.bttModify.UseVisualStyleBackColor = false;
            // 
            // bttReturn
            // 
            this.bttReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttReturn.BorderRadius = 20;
            this.bttReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttReturn.ForeColor = System.Drawing.Color.White;
            this.bttReturn.Location = new System.Drawing.Point(1240, 56);
            this.bttReturn.Name = "bttReturn";
            this.bttReturn.Size = new System.Drawing.Size(156, 43);
            this.bttReturn.TabIndex = 10;
            this.bttReturn.Text = "Regresar";
            this.bttReturn.UseVisualStyleBackColor = false;
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtView.EnableHeadersVisualStyles = false;
            this.dtView.GridColor = System.Drawing.Color.LightGray;
            this.dtView.Location = new System.Drawing.Point(50, 219);
            this.dtView.MultiSelect = false;
            this.dtView.Name = "dtView";
            this.dtView.ReadOnly = true;
            this.dtView.RowHeadersVisible = false;
            this.dtView.RowHeadersWidth = 51;
            this.dtView.RowTemplate.Height = 24;
            this.dtView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtView.Size = new System.Drawing.Size(1346, 387);
            this.dtView.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 20;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(69, 619);
            this.txtId.Margin = new System.Windows.Forms.Padding(10);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 32);
            this.txtId.TabIndex = 12;
            this.txtId.Visible = false;
            // 
            // MenuMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 694);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.bttReturn);
            this.Controls.Add(this.bttModify);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuMaintenance";
            this.Text = "MenuMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarButton bttAdd;
        private ModifierComponents.EstandarButton bttDelete;
        private ModifierComponents.EstandarButton bttModify;
        private ModifierComponents.EstandarButton bttReturn;
        private ModifierComponents.EstandarDataView dtView;
        private ModifierComponents.EstandarTextBox txtId;
    }
}