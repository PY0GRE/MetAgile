namespace MantenimientoEquipos.Views.CRUDDevices
{
    partial class MenuDevicesView
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
            this.bttReturn = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttAdd = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.bttUpdate = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttDelete = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttActive = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.dtView = new MantenimientoEquipos.ModifierComponents.EstandarDataView();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.SuspendLayout();
            // 
            // bttReturn
            // 
            this.bttReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttReturn.BorderRadius = 20;
            this.bttReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttReturn.ForeColor = System.Drawing.Color.White;
            this.bttReturn.Location = new System.Drawing.Point(930, 39);
            this.bttReturn.Name = "bttReturn";
            this.bttReturn.Size = new System.Drawing.Size(117, 35);
            this.bttReturn.TabIndex = 3;
            this.bttReturn.Text = "Regresar";
            this.bttReturn.UseVisualStyleBackColor = false;
            this.bttReturn.Click += new System.EventHandler(this.bttReturn_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAdd.BorderRadius = 20;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ForeColor = System.Drawing.Color.White;
            this.bttAdd.Location = new System.Drawing.Point(930, 121);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(117, 35);
            this.bttAdd.TabIndex = 2;
            this.bttAdd.Text = "+ Agregar";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(31, 33);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(222, 49);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Dispositivos";
            // 
            // bttUpdate
            // 
            this.bttUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttUpdate.BorderRadius = 20;
            this.bttUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUpdate.ForeColor = System.Drawing.Color.White;
            this.bttUpdate.Location = new System.Drawing.Point(930, 80);
            this.bttUpdate.Name = "bttUpdate";
            this.bttUpdate.Size = new System.Drawing.Size(117, 35);
            this.bttUpdate.TabIndex = 4;
            this.bttUpdate.Text = "Modificar";
            this.bttUpdate.UseVisualStyleBackColor = false;
            this.bttUpdate.Click += new System.EventHandler(this.bttUpdate_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.BackColor = System.Drawing.Color.IndianRed;
            this.bttDelete.BorderRadius = 20;
            this.bttDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.ForeColor = System.Drawing.Color.White;
            this.bttDelete.Location = new System.Drawing.Point(807, 121);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(117, 35);
            this.bttDelete.TabIndex = 5;
            this.bttDelete.Text = "Dar de Baja";
            this.bttDelete.UseVisualStyleBackColor = false;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttActive
            // 
            this.bttActive.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bttActive.BorderRadius = 20;
            this.bttActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttActive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttActive.ForeColor = System.Drawing.Color.White;
            this.bttActive.Location = new System.Drawing.Point(684, 121);
            this.bttActive.Name = "bttActive";
            this.bttActive.Size = new System.Drawing.Size(117, 35);
            this.bttActive.TabIndex = 6;
            this.bttActive.Text = "Activar";
            this.bttActive.UseVisualStyleBackColor = false;
            this.bttActive.Click += new System.EventHandler(this.bttActive_Click);
            // 
            // dtView
            // 
            this.dtView.AllowUserToAddRows = false;
            this.dtView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dtView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtView.BackgroundColor = System.Drawing.Color.White;
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
            this.dtView.Location = new System.Drawing.Point(40, 182);
            this.dtView.MultiSelect = false;
            this.dtView.Name = "dtView";
            this.dtView.ReadOnly = true;
            this.dtView.RowHeadersVisible = false;
            this.dtView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtView.Size = new System.Drawing.Size(1007, 305);
            this.dtView.TabIndex = 7;
            this.dtView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtView_CellClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(40, 89);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            this.txtId.Visible = false;
            // 
            // MenuDevicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 523);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.bttActive);
            this.Controls.Add(this.bttDelete);
            this.Controls.Add(this.bttUpdate);
            this.Controls.Add(this.bttReturn);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MenuDevicesView";
            this.Text = "MenuDevicesView";
            this.Load += new System.EventHandler(this.MenuDevicesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarButton bttAdd;
        private ModifierComponents.EstandarButton bttReturn;
        private ModifierComponents.EstandarButton bttUpdate;
        private ModifierComponents.EstandarButton bttDelete;
        private ModifierComponents.EstandarButton bttActive;
        private ModifierComponents.EstandarDataView dtView;
        private System.Windows.Forms.TextBox txtId;
    }
}