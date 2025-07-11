namespace MantenimientoEquipos.Views.CRUDRoles
{
    partial class RolesView
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
            this.lblTitle = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            this.lblNombre = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.lblDescripcion = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.txtName = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.txtDescription = new MantenimientoEquipos.ModifierComponents.EstandarRichTextBox();
            this.bttSave = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttCancel = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Crear Rol";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(24, 88);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Rol";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(24, 177);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(10);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(95, 22);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 20;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(28, 130);
            this.txtName.Margin = new System.Windows.Forms.Padding(10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 20;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(28, 219);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 96);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "";
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttSave.BorderRadius = 20;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.White;
            this.bttSave.Location = new System.Drawing.Point(166, 369);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(84, 35);
            this.bttSave.TabIndex = 5;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttCancel.BorderRadius = 20;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.Color.White;
            this.bttCancel.Location = new System.Drawing.Point(64, 369);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(84, 35);
            this.bttCancel.TabIndex = 6;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // RolesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitle);
            this.Name = "RolesView";
            this.Text = "RolesView";
            this.Load += new System.EventHandler(this.RolesView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModifierComponents.EstandarTitleLabel lblTitle;
        private ModifierComponents.EstandarLabel lblNombre;
        private ModifierComponents.EstandarLabel lblDescripcion;
        private ModifierComponents.EstandarTextBox txtName;
        private ModifierComponents.EstandarRichTextBox txtDescription;
        private ModifierComponents.EstandarButton bttSave;
        private ModifierComponents.EstandarButton bttCancel;
    }
}