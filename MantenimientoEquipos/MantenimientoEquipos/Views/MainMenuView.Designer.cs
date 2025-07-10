namespace MantenimientoEquipos.Views
{
    partial class MainMenuView
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
            this.bttDevices = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttMenteinnance = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttAreas = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttUsers = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttRole = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.SuspendLayout();
            // 
            // estandarTitleLabel1
            // 
            this.estandarTitleLabel1.AutoSize = true;
            this.estandarTitleLabel1.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarTitleLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.estandarTitleLabel1.Location = new System.Drawing.Point(247, 19);
            this.estandarTitleLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarTitleLabel1.Name = "estandarTitleLabel1";
            this.estandarTitleLabel1.Size = new System.Drawing.Size(272, 49);
            this.estandarTitleLabel1.TabIndex = 0;
            this.estandarTitleLabel1.Text = "Menú Principal";
            // 
            // bttDevices
            // 
            this.bttDevices.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttDevices.BorderRadius = 20;
            this.bttDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDevices.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDevices.ForeColor = System.Drawing.Color.White;
            this.bttDevices.Location = new System.Drawing.Point(245, 104);
            this.bttDevices.Name = "bttDevices";
            this.bttDevices.Size = new System.Drawing.Size(274, 37);
            this.bttDevices.TabIndex = 1;
            this.bttDevices.Text = "Dispositivos";
            this.bttDevices.UseVisualStyleBackColor = false;
            this.bttDevices.Click += new System.EventHandler(this.bttDevices_Click);
            // 
            // bttMenteinnance
            // 
            this.bttMenteinnance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttMenteinnance.BorderRadius = 20;
            this.bttMenteinnance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttMenteinnance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttMenteinnance.ForeColor = System.Drawing.Color.White;
            this.bttMenteinnance.Location = new System.Drawing.Point(245, 159);
            this.bttMenteinnance.Name = "bttMenteinnance";
            this.bttMenteinnance.Size = new System.Drawing.Size(274, 37);
            this.bttMenteinnance.TabIndex = 2;
            this.bttMenteinnance.Text = "Reportes / Mantenimientos";
            this.bttMenteinnance.UseVisualStyleBackColor = false;
            this.bttMenteinnance.Click += new System.EventHandler(this.bttMenteinnance_Click);
            // 
            // bttAreas
            // 
            this.bttAreas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAreas.BorderRadius = 20;
            this.bttAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAreas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAreas.ForeColor = System.Drawing.Color.White;
            this.bttAreas.Location = new System.Drawing.Point(245, 214);
            this.bttAreas.Name = "bttAreas";
            this.bttAreas.Size = new System.Drawing.Size(274, 37);
            this.bttAreas.TabIndex = 3;
            this.bttAreas.Text = "Áreas";
            this.bttAreas.UseVisualStyleBackColor = false;
            this.bttAreas.Click += new System.EventHandler(this.bttAreas_Click);
            // 
            // bttUsers
            // 
            this.bttUsers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttUsers.BorderRadius = 20;
            this.bttUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttUsers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttUsers.ForeColor = System.Drawing.Color.White;
            this.bttUsers.Location = new System.Drawing.Point(245, 271);
            this.bttUsers.Name = "bttUsers";
            this.bttUsers.Size = new System.Drawing.Size(274, 37);
            this.bttUsers.TabIndex = 4;
            this.bttUsers.Text = "Usuarios";
            this.bttUsers.UseVisualStyleBackColor = false;
            // 
            // bttRole
            // 
            this.bttRole.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttRole.BorderRadius = 20;
            this.bttRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRole.ForeColor = System.Drawing.Color.White;
            this.bttRole.Location = new System.Drawing.Point(245, 329);
            this.bttRole.Name = "bttRole";
            this.bttRole.Size = new System.Drawing.Size(274, 37);
            this.bttRole.TabIndex = 5;
            this.bttRole.Text = "Roles";
            this.bttRole.UseVisualStyleBackColor = false;
            this.bttRole.Click += new System.EventHandler(this.bttRole_Click);
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttRole);
            this.Controls.Add(this.bttUsers);
            this.Controls.Add(this.bttAreas);
            this.Controls.Add(this.bttMenteinnance);
            this.Controls.Add(this.bttDevices);
            this.Controls.Add(this.estandarTitleLabel1);
            this.Name = "MainMenuView";
            this.Text = "MainMenuView";
            this.Load += new System.EventHandler(this.MainMenuView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel estandarTitleLabel1;
        private ModifierComponents.EstandarButton bttDevices;
        private ModifierComponents.EstandarButton bttMenteinnance;
        private ModifierComponents.EstandarButton bttAreas;
        private ModifierComponents.EstandarButton bttUsers;
        private ModifierComponents.EstandarButton bttRole;
    }
}