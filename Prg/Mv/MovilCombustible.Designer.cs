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
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.xpnlPanel.Size = new System.Drawing.Size(393, 205);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
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
            this.gbAceptar.FlatTextColor = System.Drawing.Color.White;
            this.gbAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAceptar.Location = new System.Drawing.Point(282, 159);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(96, 31);
            this.gbAceptar.TabIndex = 8;
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
            this.gbCancelar.FlatTextColor = System.Drawing.Color.White;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbCancelar.Location = new System.Drawing.Point(180, 159);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(96, 31);
            this.gbCancelar.TabIndex = 9;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // deImporte
            // 
            this.deImporte.BackColor = System.Drawing.SystemColors.Window;
            this.deImporte.Location = new System.Drawing.Point(180, 104);
            this.deImporte.MaxLength = 13;
            this.deImporte.Name = "deImporte";
            this.deImporte.Size = new System.Drawing.Size(178, 21);
            this.deImporte.TabIndex = 6;
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
            this.cdcEstacion.Location = new System.Drawing.Point(180, 63);
            this.cdcEstacion.Name = "cdcEstacion";
            this.cdcEstacion.Size = new System.Drawing.Size(178, 23);
            this.cdcEstacion.Sorted = true;
            this.cdcEstacion.TabIndex = 4;
            // 
            // neLitros
            // 
            this.neLitros.BackColor = System.Drawing.SystemColors.Window;
            this.neLitros.Location = new System.Drawing.Point(180, 29);
            this.neLitros.MaxLength = 3;
            this.neLitros.Name = "neLitros";
            this.neLitros.Size = new System.Drawing.Size(84, 21);
            this.neLitros.TabIndex = 2;
            this.neLitros.Text = "0";
            // 
            // lblLitros
            // 
            this.lblLitros.BackColor = System.Drawing.Color.Transparent;
            this.lblLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(16, 28);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(170, 27);
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
            this.ClientSize = new System.Drawing.Size(393, 205);
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
    }
}