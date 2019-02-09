namespace Mrln.Mv
{
    partial class ModificarEstado
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
            this.teContingencia = new TNGS.NetControls.TextEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.lblEstados = new TNGS.NetControls.FullLabel();
            this.cdcEstados = new TNGS.NetControls.CDCombo();
            this.xpnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel.BorderColor = System.Drawing.Color.Black;
            this.xpnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpnlPanel.Controls.Add(this.teContingencia);
            this.xpnlPanel.Controls.Add(this.fullLabel1);
            this.xpnlPanel.Controls.Add(this.gbAceptar);
            this.xpnlPanel.Controls.Add(this.gbCancelar);
            this.xpnlPanel.Controls.Add(this.lblEstados);
            this.xpnlPanel.Controls.Add(this.cdcEstados);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(433, 303);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // teContingencia
            // 
            this.teContingencia.BackColor = System.Drawing.SystemColors.Window;
            this.teContingencia.Location = new System.Drawing.Point(16, 112);
            this.teContingencia.Multiline = true;
            this.teContingencia.Name = "teContingencia";
            this.teContingencia.ReadOnly = true;
            this.teContingencia.Size = new System.Drawing.Size(401, 123);
            this.teContingencia.TabIndex = 10;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(13, 82);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(128, 27);
            this.fullLabel1.TabIndex = 8;
            this.fullLabel1.Text = "Contingencia:";
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
            this.gbAceptar.Location = new System.Drawing.Point(323, 257);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(96, 31);
            this.gbAceptar.TabIndex = 6;
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
            this.gbCancelar.Location = new System.Drawing.Point(220, 257);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(96, 31);
            this.gbCancelar.TabIndex = 7;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // lblEstados
            // 
            this.lblEstados.BackColor = System.Drawing.Color.Transparent;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(72, 30);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(69, 27);
            this.lblEstados.TabIndex = 5;
            this.lblEstados.Text = "Estado:";
            // 
            // cdcEstados
            // 
            this.cdcEstados.BackColor = System.Drawing.SystemColors.Window;
            this.cdcEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcEstados.FormattingEnabled = true;
            this.cdcEstados.Location = new System.Drawing.Point(148, 31);
            this.cdcEstados.Name = "cdcEstados";
            this.cdcEstados.Size = new System.Drawing.Size(214, 23);
            this.cdcEstados.Sorted = true;
            this.cdcEstados.TabIndex = 4;
            this.cdcEstados.SelectedIndexChanged += new System.EventHandler(this.cdcEstados_SelectedIndexChanged);
            // 
            // ModificarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 303);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.xpnlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.FullLabel lblEstados;
        private TNGS.NetControls.CDCombo cdcEstados;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TextEdit teContingencia;
    }
}