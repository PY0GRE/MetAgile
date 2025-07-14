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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.estandarTitleLabel1.Location = new System.Drawing.Point(31, 33);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(8);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(261, 41);
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
            this.bttAdd.Location = new System.Drawing.Point(930, 123);
            this.bttAdd.Margin = new System.Windows.Forms.Padding(2);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(117, 35);
            this.bttAdd.TabIndex = 7;
            this.bttAdd.Text = "Agregar";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click_1);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.IndianRed;
            this.bttDelete.BorderRadius = 20;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.ForeColor = System.Drawing.Color.White;
            this.bttDelete.Location = new System.Drawing.Point(796, 123);
            this.bttDelete.Margin = new System.Windows.Forms.Padding(2);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(117, 35);
            this.bttDelete.TabIndex = 8;
            this.bttDelete.Text = "Baja";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Visible = false;
            // 
            // bttModify
            // 
            this.bttModify.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttModify.BorderRadius = 20;
            this.bttModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttModify.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttModify.ForeColor = System.Drawing.Color.White;
            this.bttModify.Location = new System.Drawing.Point(930, 83);
            this.bttModify.Margin = new System.Windows.Forms.Padding(2);
            this.bttModify.Name = "bttModify";
            this.bttModify.Size = new System.Drawing.Size(117, 35);
            this.bttModify.TabIndex = 9;
            this.bttModify.Text = "Modificar";
            this.bttModify.UseVisualStyleBackColor = false;
            this.bttModify.Click += new System.EventHandler(this.bttModify_Click);
            // 
            // bttReturn
            // 
            this.bttReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttReturn.BorderRadius = 20;
            this.bttReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttReturn.ForeColor = System.Drawing.Color.White;
            this.bttReturn.Location = new System.Drawing.Point(930, 46);
            this.bttReturn.Margin = new System.Windows.Forms.Padding(2);
            this.bttReturn.Name = "bttReturn";
            this.bttReturn.Size = new System.Drawing.Size(117, 35);
            this.bttReturn.TabIndex = 10;
            this.bttReturn.Text = "Regresar";
            this.bttReturn.UseVisualStyleBackColor = false;
            this.bttReturn.Click += new System.EventHandler(this.bttReturn_Click_1);
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtView.EnableHeadersVisualStyles = false;
            this.dtView.GridColor = System.Drawing.Color.LightGray;
            this.dtView.Location = new System.Drawing.Point(38, 178);
            this.dtView.Margin = new System.Windows.Forms.Padding(2);
            this.dtView.MultiSelect = false;
            this.dtView.Name = "dtView";
            this.dtView.ReadOnly = true;
            this.dtView.RowHeadersVisible = false;
            this.dtView.RowHeadersWidth = 51;
            this.dtView.RowTemplate.Height = 24;
            this.dtView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtView.Size = new System.Drawing.Size(1010, 314);
            this.dtView.TabIndex = 11;
            this.dtView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtView_CellClick_1);
            // 
            // txtId
            // 
            this.txtId.BorderRadius = 20;
            this.txtId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(52, 503);
            this.txtId.Margin = new System.Windows.Forms.Padding(8);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 27);
            this.txtId.TabIndex = 12;
            this.txtId.Visible = false;
            // 
            // MenuMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 564);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.bttReturn);
            this.Controls.Add(this.bttModify);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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