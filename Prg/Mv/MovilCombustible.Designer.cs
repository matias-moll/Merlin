namespace Mrln.Mv
{
    partial class MovilCombustible
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
            this.components = new System.ComponentModel.Container();
            this.xpnlPanel = new TNGS.NetControls.XPanel();
            this.cbGrabarKMs = new System.Windows.Forms.CheckBox();
            this.neKms = new TNGS.NetControls.NumberEdit();
            this.lblKilometros = new TNGS.NetControls.FullLabel();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.deImporte = new TNGS.NetControls.DecimalEdit();
            this.lblEstacion = new TNGS.NetControls.FullLabel();
            this.cdcEstacion = new TNGS.NetControls.CDCombo();
            this.neLitros = new TNGS.NetControls.NumberEdit();
            this.lblLitros = new TNGS.NetControls.FullLabel();
            this.lblImporte = new TNGS.NetControls.FullLabel();
            this.xpnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BorderColor = System.Drawing.Color.Black;
            this.xpnlPanel.Controls.Add(this.cbGrabarKMs);
            this.xpnlPanel.Controls.Add(this.neKms);
            this.xpnlPanel.Controls.Add(this.lblKilometros);
            this.xpnlPanel.Controls.Add(this.gbAceptar);
            this.xpnlPanel.Controls.Add(this.gbCancelar);
            this.xpnlPanel.Controls.Add(this.deImporte);
            this.xpnlPanel.Controls.Add(this.lblEstacion);
            this.xpnlPanel.Controls.Add(this.cdcEstacion);
            this.xpnlPanel.Controls.Add(this.neLitros);
            this.xpnlPanel.Controls.Add(this.lblLitros);
            this.xpnlPanel.Controls.Add(this.lblImporte);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(408, 236);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // cbGrabarKMs
            // 
            this.cbGrabarKMs.AutoSize = true;
            this.cbGrabarKMs.BackColor = System.Drawing.Color.Transparent;
            this.cbGrabarKMs.Location = new System.Drawing.Point(303, 144);
            this.cbGrabarKMs.Name = "cbGrabarKMs";
            this.cbGrabarKMs.Size = new System.Drawing.Size(91, 19);
            this.cbGrabarKMs.TabIndex = 4;
            this.cbGrabarKMs.Text = "Grabar KMs";
            this.cbGrabarKMs.UseVisualStyleBackColor = false;
            // 
            // neKms
            // 
            this.neKms.BackColor = System.Drawing.SystemColors.Window;
            this.neKms.Location = new System.Drawing.Point(171, 142);
            this.neKms.MaxLength = 7;
            this.neKms.Name = "neKms";
            this.neKms.NegativeValid = false;
            this.neKms.Size = new System.Drawing.Size(112, 21);
            this.neKms.TabIndex = 3;
            this.neKms.Text = "0";
            this.neKms.ZeroValid = false;
            // 
            // lblKilometros
            // 
            this.lblKilometros.BackColor = System.Drawing.Color.Transparent;
            this.lblKilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometros.Location = new System.Drawing.Point(16, 142);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(105, 27);
            this.lblKilometros.TabIndex = 10;
            this.lblKilometros.Text = "Kilómetros:";
            // 
            // gbAceptar
            // 
            this.gbAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAceptar.BlackBorder = true;
            this.gbAceptar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAceptar.CircleButton = false;
            this.gbAceptar.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAceptar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAceptar.FlatFontSize = 9;
            this.gbAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAceptar.Location = new System.Drawing.Point(299, 192);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(96, 31);
            this.gbAceptar.TabIndex = 5;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // gbCancelar
            // 
            this.gbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FlatColor = System.Drawing.Color.Red;
            this.gbCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbCancelar.Location = new System.Drawing.Point(197, 192);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(96, 31);
            this.gbCancelar.TabIndex = 6;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // deImporte
            // 
            this.deImporte.BackColor = System.Drawing.SystemColors.Window;
            this.deImporte.Location = new System.Drawing.Point(171, 104);
            this.deImporte.MaxLength = 13;
            this.deImporte.Name = "deImporte";
            this.deImporte.Size = new System.Drawing.Size(112, 21);
            this.deImporte.TabIndex = 2;
            this.deImporte.Text = "0.00";
            // 
            // lblEstacion
            // 
            this.lblEstacion.BackColor = System.Drawing.Color.Transparent;
            this.lblEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacion.Location = new System.Drawing.Point(17, 66);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(87, 27);
            this.lblEstacion.TabIndex = 5;
            this.lblEstacion.Text = "Estación:";
            // 
            // cdcEstacion
            // 
            this.cdcEstacion.BackColor = System.Drawing.SystemColors.Window;
            this.cdcEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcEstacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcEstacion.FormattingEnabled = true;
            this.cdcEstacion.Location = new System.Drawing.Point(171, 63);
            this.cdcEstacion.Name = "cdcEstacion";
            this.cdcEstacion.Size = new System.Drawing.Size(223, 23);
            this.cdcEstacion.Sorted = true;
            this.cdcEstacion.TabIndex = 1;
            // 
            // neLitros
            // 
            this.neLitros.BackColor = System.Drawing.SystemColors.Window;
            this.neLitros.Location = new System.Drawing.Point(171, 29);
            this.neLitros.MaxLength = 3;
            this.neLitros.Name = "neLitros";
            this.neLitros.Size = new System.Drawing.Size(112, 21);
            this.neLitros.TabIndex = 0;
            this.neLitros.Text = "0";
            // 
            // lblLitros
            // 
            this.lblLitros.BackColor = System.Drawing.Color.Transparent;
            this.lblLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(16, 28);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(136, 27);
            this.lblLitros.TabIndex = 0;
            this.lblLitros.Text = "Cantidad de Litros:";
            // 
            // lblImporte
            // 
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(17, 104);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(78, 27);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe:";
            // 
            // MovilCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 236);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovilCombustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.xpnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.NumberEdit neLitros;
        private TNGS.NetControls.FullLabel lblImporte;
        private TNGS.NetControls.FullLabel lblLitros;
        private TNGS.NetControls.FullLabel lblEstacion;
        private TNGS.NetControls.CDCombo cdcEstacion;
        private TNGS.NetControls.DecimalEdit deImporte;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.NumberEdit neKms;
        private TNGS.NetControls.FullLabel lblKilometros;
        private System.Windows.Forms.CheckBox cbGrabarKMs;
    }
}