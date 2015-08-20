namespace Rivn.Mv
{
    partial class AsigarOT
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
            this.lblEstados = new TNGS.NetControls.FullLabel();
            this.cdcEstados = new TNGS.NetControls.CDCombo();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
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
            this.xpnlPanel.Controls.Add(this.lblEstados);
            this.xpnlPanel.Controls.Add(this.cdcEstados);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(304, 117);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // lblEstados
            // 
            this.lblEstados.BackColor = System.Drawing.Color.Transparent;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(15, 20);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(85, 23);
            this.lblEstados.TabIndex = 5;
            this.lblEstados.Text = "Encargado:";
            // 
            // cdcEstados
            // 
            this.cdcEstados.BackColor = System.Drawing.SystemColors.Window;
            this.cdcEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcEstados.FormattingEnabled = true;
            this.cdcEstados.Location = new System.Drawing.Point(106, 21);
            this.cdcEstados.Name = "cdcEstados";
            this.cdcEstados.Size = new System.Drawing.Size(184, 21);
            this.cdcEstados.Sorted = true;
            this.cdcEstados.TabIndex = 4;
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
            this.gbAceptar.Location = new System.Drawing.Point(209, 77);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(82, 27);
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
            this.gbCancelar.Location = new System.Drawing.Point(121, 77);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(82, 27);
            this.gbCancelar.TabIndex = 9;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // AsigarOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 117);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsigarOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.FullLabel lblEstados;
        private TNGS.NetControls.CDCombo cdcEstados;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.GlassButton gbCancelar;
    }
}