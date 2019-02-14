namespace Mrln.Mv
{
    partial class HistorialUnificado
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
            this.xpnlPanel = new TNGS.NetControls.XPanel();
            this.mrHistorialUnificado = new TNGS.NetControls.MiniReport();
            this.lblPatenteValue = new TNGS.NetControls.FullLabel();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.xpnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BorderColor = System.Drawing.Color.Black;
            this.xpnlPanel.Controls.Add(this.mrHistorialUnificado);
            this.xpnlPanel.Controls.Add(this.lblPatenteValue);
            this.xpnlPanel.Controls.Add(this.lblPatente);
            this.xpnlPanel.Controls.Add(this.gbAceptar);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Font = new System.Drawing.Font("Arial", 9F);
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(717, 561);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // mrHistorialUnificado
            // 
            this.mrHistorialUnificado.Font = new System.Drawing.Font("Arial", 9F);
            this.mrHistorialUnificado.Location = new System.Drawing.Point(11, 44);
            this.mrHistorialUnificado.Name = "mrHistorialUnificado";
            this.mrHistorialUnificado.ShowPrtOne = false;
            this.mrHistorialUnificado.ShowZoom = false;
            this.mrHistorialUnificado.Size = new System.Drawing.Size(693, 461);
            this.mrHistorialUnificado.SkinFixed = true;
            this.mrHistorialUnificado.TabIndex = 0;
            // 
            // lblPatenteValue
            // 
            this.lblPatenteValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPatenteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatenteValue.ForeColor = System.Drawing.Color.Black;
            this.lblPatenteValue.Location = new System.Drawing.Point(351, 15);
            this.lblPatenteValue.Name = "lblPatenteValue";
            this.lblPatenteValue.Size = new System.Drawing.Size(135, 19);
            this.lblPatenteValue.TabIndex = 12;
            this.lblPatenteValue.Text = "Patente";
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(236, 13);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(121, 18);
            this.lblPatente.TabIndex = 11;
            this.lblPatente.Text = "Móvil Patente:";
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
            this.gbAceptar.Location = new System.Drawing.Point(624, 523);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(82, 27);
            this.gbAceptar.TabIndex = 1;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // HistorialUnificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 561);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialUnificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.FullLabel lblPatenteValue;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.MiniReport mrHistorialUnificado;
    }
}