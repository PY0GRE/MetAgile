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
            this.estandarTitleLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttAdd = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttReturn = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1007, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAdd.BorderRadius = 20;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ForeColor = System.Drawing.Color.White;
            this.bttAdd.Location = new System.Drawing.Point(930, 103);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(117, 35);
            this.bttAdd.TabIndex = 2;
            this.bttAdd.Text = "+ Agregar";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttReturn
            // 
            this.bttReturn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttReturn.BorderRadius = 20;
            this.bttReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttReturn.ForeColor = System.Drawing.Color.White;
            this.bttReturn.Location = new System.Drawing.Point(930, 33);
            this.bttReturn.Name = "bttReturn";
            this.bttReturn.Size = new System.Drawing.Size(117, 35);
            this.bttReturn.TabIndex = 3;
            this.bttReturn.Text = "Regresar";
            this.bttReturn.UseVisualStyleBackColor = false;
            this.bttReturn.Click += new System.EventHandler(this.bttReturn_Click);
            // 
            // MenuDevicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 523);
            this.Controls.Add(this.bttReturn);
            this.Controls.Add(this.bttAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MenuDevicesView";
            this.Text = "MenuDevicesView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ModifierComponents.EstandarButton bttAdd;
        private ModifierComponents.EstandarButton bttReturn;
    }
}