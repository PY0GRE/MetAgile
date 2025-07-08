namespace MantenimientoEquipos.Views.CRUDDevices
{
    partial class DevicesView
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
            this.metAgileDataSet = new MantenimientoEquipos.MetAgileDataSet();
            this.bttCancel = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.bttAccept = new MantenimientoEquipos.ModifierComponents.EstandarButton();
            this.txtModel = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarLabel5 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cmbBrand = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.txtSerieNum = new MantenimientoEquipos.ModifierComponents.EstandarTextBox();
            this.estandarLabel4 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cmbDeviceType = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel3 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.cmbArea = new MantenimientoEquipos.ModifierComponents.EstadarComboBox();
            this.estandarLabel2 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.estandarLabel1 = new MantenimientoEquipos.ModifierComponents.EstandarLabel();
            this.lblTitle = new MantenimientoEquipos.ModifierComponents.EstandarTitleLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metAgileDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metAgileDataSet
            // 
            this.metAgileDataSet.DataSetName = "MetAgileDataSet";
            this.metAgileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttCancel.BorderRadius = 20;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.Color.White;
            this.bttCancel.Location = new System.Drawing.Point(89, 487);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(116, 35);
            this.bttCancel.TabIndex = 39;
            this.bttCancel.Text = "Cancelar";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttAccept
            // 
            this.bttAccept.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bttAccept.BorderRadius = 20;
            this.bttAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAccept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAccept.ForeColor = System.Drawing.Color.White;
            this.bttAccept.Location = new System.Drawing.Point(217, 487);
            this.bttAccept.Name = "bttAccept";
            this.bttAccept.Size = new System.Drawing.Size(116, 35);
            this.bttAccept.TabIndex = 38;
            this.bttAccept.Text = "Aceptar";
            this.bttAccept.UseVisualStyleBackColor = false;
            this.bttAccept.Click += new System.EventHandler(this.bttAccept_Click);
            // 
            // txtModel
            // 
            this.txtModel.BorderRadius = 20;
            this.txtModel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(217, 228);
            this.txtModel.Margin = new System.Windows.Forms.Padding(10);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(154, 27);
            this.txtModel.TabIndex = 37;
            // 
            // estandarLabel5
            // 
            this.estandarLabel5.AutoSize = true;
            this.estandarLabel5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel5.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel5.Location = new System.Drawing.Point(213, 193);
            this.estandarLabel5.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel5.Name = "estandarLabel5";
            this.estandarLabel5.Size = new System.Drawing.Size(67, 22);
            this.estandarLabel5.TabIndex = 36;
            this.estandarLabel5.Text = "Modelo";
            // 
            // cmbBrand
            // 
            this.cmbBrand.DisplayMember = "name";
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(24, 228);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(167, 27);
            this.cmbBrand.TabIndex = 35;
            this.cmbBrand.ValueMember = "idBrand";
            // 
            // txtSerieNum
            // 
            this.txtSerieNum.BorderRadius = 20;
            this.txtSerieNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerieNum.Location = new System.Drawing.Point(24, 146);
            this.txtSerieNum.Margin = new System.Windows.Forms.Padding(10);
            this.txtSerieNum.Name = "txtSerieNum";
            this.txtSerieNum.Size = new System.Drawing.Size(347, 27);
            this.txtSerieNum.TabIndex = 34;
            // 
            // estandarLabel4
            // 
            this.estandarLabel4.AutoSize = true;
            this.estandarLabel4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel4.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel4.Location = new System.Drawing.Point(20, 104);
            this.estandarLabel4.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel4.Name = "estandarLabel4";
            this.estandarLabel4.Size = new System.Drawing.Size(132, 22);
            this.estandarLabel4.TabIndex = 33;
            this.estandarLabel4.Text = "Número de Serie";
            // 
            // cmbDeviceType
            // 
            this.cmbDeviceType.DisplayMember = "name";
            this.cmbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeviceType.FormattingEnabled = true;
            this.cmbDeviceType.Location = new System.Drawing.Point(24, 314);
            this.cmbDeviceType.Name = "cmbDeviceType";
            this.cmbDeviceType.Size = new System.Drawing.Size(181, 27);
            this.cmbDeviceType.TabIndex = 32;
            this.cmbDeviceType.ValueMember = "idDeviceType";
            // 
            // estandarLabel3
            // 
            this.estandarLabel3.AutoSize = true;
            this.estandarLabel3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel3.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel3.Location = new System.Drawing.Point(20, 279);
            this.estandarLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel3.Name = "estandarLabel3";
            this.estandarLabel3.Size = new System.Drawing.Size(126, 22);
            this.estandarLabel3.TabIndex = 31;
            this.estandarLabel3.Text = "Tipo Dispositivo";
            // 
            // cmbArea
            // 
            this.cmbArea.DisplayMember = "name";
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(24, 391);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(173, 27);
            this.cmbArea.TabIndex = 30;
            this.cmbArea.ValueMember = "idArea";
            // 
            // estandarLabel2
            // 
            this.estandarLabel2.AutoSize = true;
            this.estandarLabel2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel2.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel2.Location = new System.Drawing.Point(20, 356);
            this.estandarLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel2.Name = "estandarLabel2";
            this.estandarLabel2.Size = new System.Drawing.Size(44, 22);
            this.estandarLabel2.TabIndex = 29;
            this.estandarLabel2.Text = "Área";
            // 
            // estandarLabel1
            // 
            this.estandarLabel1.AutoSize = true;
            this.estandarLabel1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estandarLabel1.ForeColor = System.Drawing.Color.Black;
            this.estandarLabel1.Location = new System.Drawing.Point(20, 193);
            this.estandarLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.estandarLabel1.Name = "estandarLabel1";
            this.estandarLabel1.Size = new System.Drawing.Size(57, 22);
            this.estandarLabel1.TabIndex = 28;
            this.estandarLabel1.Text = "Marca";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 49);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Agregar Dispositivo";
            // 
            // DevicesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 561);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttAccept);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.estandarLabel5);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.txtSerieNum);
            this.Controls.Add(this.estandarLabel4);
            this.Controls.Add(this.cmbDeviceType);
            this.Controls.Add(this.estandarLabel3);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.estandarLabel2);
            this.Controls.Add(this.estandarLabel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "DevicesView";
            this.Text = "DevicesView";
            this.Load += new System.EventHandler(this.DevicesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metAgileDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetAgileDataSet metAgileDataSet;
        private ModifierComponents.EstandarButton bttCancel;
        private ModifierComponents.EstandarButton bttAccept;
        private ModifierComponents.EstandarTextBox txtModel;
        private ModifierComponents.EstandarLabel estandarLabel5;
        private ModifierComponents.EstadarComboBox cmbBrand;
        private ModifierComponents.EstandarTextBox txtSerieNum;
        private ModifierComponents.EstandarLabel estandarLabel4;
        private ModifierComponents.EstadarComboBox cmbDeviceType;
        private ModifierComponents.EstandarLabel estandarLabel3;
        private ModifierComponents.EstadarComboBox cmbArea;
        private ModifierComponents.EstandarLabel estandarLabel2;
        private ModifierComponents.EstandarLabel estandarLabel1;
        private ModifierComponents.EstandarTitleLabel lblTitle;
    }
}