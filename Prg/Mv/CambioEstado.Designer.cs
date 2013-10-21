namespace Rivn.Mv
{
    partial class CambioEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambioEstado));
            this.xpnlPanel = new TNGS.NetControls.XPanel();
            this.igMoviles = new TNGS.NetControls.ImgGroup();
            this.cdcMoviles = new TNGS.NetControls.CDCombo();
            this.lblMoviles = new TNGS.NetControls.FullLabel();
            this.igEstado = new TNGS.NetControls.ImgGroup();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.cdCombo1 = new TNGS.NetControls.CDCombo();
            this.gbGrabar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.xpnlPanel.SuspendLayout();
            this.igMoviles.SuspendLayout();
            this.igEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel.Controls.Add(this.igEstado);
            this.xpnlPanel.Controls.Add(this.igMoviles);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(451, 346);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // igMoviles
            // 
            this.igMoviles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igMoviles.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igMoviles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igMoviles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igMoviles.BorderThickness = 1F;
            this.igMoviles.Controls.Add(this.lblMoviles);
            this.igMoviles.Controls.Add(this.cdcMoviles);
            this.igMoviles.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igMoviles.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igMoviles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igMoviles.GroupImage = ((System.Drawing.Image)(resources.GetObject("igMoviles.GroupImage")));
            this.igMoviles.GroupTitle = "Moviles";
            this.igMoviles.Location = new System.Drawing.Point(13, 13);
            this.igMoviles.Name = "igMoviles";
            this.igMoviles.Padding = new System.Windows.Forms.Padding(20);
            this.igMoviles.PaintGroupBox = true;
            this.igMoviles.RoundCorners = 10;
            this.igMoviles.ShadowColor = System.Drawing.Color.DarkGray;
            this.igMoviles.ShadowControl = true;
            this.igMoviles.ShadowThickness = 3;
            this.igMoviles.Size = new System.Drawing.Size(427, 169);
            this.igMoviles.SkinFixed = true;
            this.igMoviles.SkinFullFixed = true;
            this.igMoviles.TabIndex = 0;
            // 
            // cdcMoviles
            // 
            this.cdcMoviles.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMoviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMoviles.FormattingEnabled = true;
            this.cdcMoviles.Location = new System.Drawing.Point(60, 63);
            this.cdcMoviles.Name = "cdcMoviles";
            this.cdcMoviles.Size = new System.Drawing.Size(297, 21);
            this.cdcMoviles.Sorted = true;
            this.cdcMoviles.TabIndex = 0;
            // 
            // lblMoviles
            // 
            this.lblMoviles.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoviles.Location = new System.Drawing.Point(56, 37);
            this.lblMoviles.Name = "lblMoviles";
            this.lblMoviles.Size = new System.Drawing.Size(100, 23);
            this.lblMoviles.TabIndex = 1;
            this.lblMoviles.Text = "Movil:";
            // 
            // igEstado
            // 
            this.igEstado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igEstado.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEstado.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEstado.BorderThickness = 1F;
            this.igEstado.Controls.Add(this.gbCancelar);
            this.igEstado.Controls.Add(this.gbGrabar);
            this.igEstado.Controls.Add(this.fullLabel1);
            this.igEstado.Controls.Add(this.cdCombo1);
            this.igEstado.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEstado.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEstado.GroupImage = null;
            this.igEstado.GroupTitle = "Cambio Estado";
            this.igEstado.Location = new System.Drawing.Point(13, 185);
            this.igEstado.Name = "igEstado";
            this.igEstado.Padding = new System.Windows.Forms.Padding(20);
            this.igEstado.PaintGroupBox = true;
            this.igEstado.RoundCorners = 10;
            this.igEstado.ShadowColor = System.Drawing.Color.DarkGray;
            this.igEstado.ShadowControl = true;
            this.igEstado.ShadowThickness = 3;
            this.igEstado.Size = new System.Drawing.Size(427, 149);
            this.igEstado.SkinFixed = true;
            this.igEstado.SkinFullFixed = true;
            this.igEstado.TabIndex = 2;
            // 
            // fullLabel1
            // 
            this.fullLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(56, 37);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(100, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Estado:";
            // 
            // cdCombo1
            // 
            this.cdCombo1.BackColor = System.Drawing.SystemColors.Window;
            this.cdCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdCombo1.FormattingEnabled = true;
            this.cdCombo1.Location = new System.Drawing.Point(60, 63);
            this.cdCombo1.Name = "cdCombo1";
            this.cdCombo1.Size = new System.Drawing.Size(297, 21);
            this.cdCombo1.Sorted = true;
            this.cdCombo1.TabIndex = 0;
            // 
            // gbGrabar
            // 
            this.gbGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.gbGrabar.Location = new System.Drawing.Point(92, 103);
            this.gbGrabar.Name = "gbGrabar";
            this.gbGrabar.Size = new System.Drawing.Size(104, 26);
            this.gbGrabar.TabIndex = 2;
            this.gbGrabar.Text = "Modificar";
            this.gbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCancelar
            // 
            this.gbCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.Cancel;
            this.gbCancelar.Location = new System.Drawing.Point(213, 103);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(104, 26);
            this.gbCancelar.TabIndex = 3;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CambioEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 346);
            this.Controls.Add(this.xpnlPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CambioEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.xpnlPanel.ResumeLayout(false);
            this.igMoviles.ResumeLayout(false);
            this.igEstado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.ImgGroup igMoviles;
        private TNGS.NetControls.FullLabel lblMoviles;
        private TNGS.NetControls.CDCombo cdcMoviles;
        private TNGS.NetControls.ImgGroup igEstado;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbGrabar;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.CDCombo cdCombo1;
    }
}