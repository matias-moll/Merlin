namespace Mrln.Mv
{
    partial class NuevoKm
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
            this.neKms = new TNGS.NetControls.NumberEdit();
            this.lblKilometros = new TNGS.NetControls.FullLabel();
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
            this.xpnlPanel.Controls.Add(this.neKms);
            this.xpnlPanel.Controls.Add(this.lblKilometros);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(317, 133);
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
            this.gbAceptar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAceptar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAceptar.Location = new System.Drawing.Point(206, 88);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(96, 31);
            this.gbAceptar.TabIndex = 10;
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
            this.gbCancelar.Location = new System.Drawing.Point(104, 88);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(96, 31);
            this.gbCancelar.TabIndex = 11;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // neKms
            // 
            this.neKms.BackColor = System.Drawing.SystemColors.Window;
            this.neKms.Location = new System.Drawing.Point(129, 25);
            this.neKms.MaxLength = 7;
            this.neKms.Name = "neKms";
            this.neKms.NegativeValid = false;
            this.neKms.Size = new System.Drawing.Size(137, 21);
            this.neKms.TabIndex = 2;
            this.neKms.Text = "0";
            this.neKms.ZeroValid = false;
            // 
            // lblKilometros
            // 
            this.lblKilometros.BackColor = System.Drawing.Color.Transparent;
            this.lblKilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometros.Location = new System.Drawing.Point(20, 24);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(170, 27);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilómetros:";
            // 
            // NuevoKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 133);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoKm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.xpnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.NumberEdit neKms;
        private TNGS.NetControls.FullLabel lblKilometros;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.GlassButton gbCancelar;
    }
}