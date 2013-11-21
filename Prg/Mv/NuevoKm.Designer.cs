namespace Rivn.Mv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoKm));
            this.xpnlPanel = new TNGS.NetControls.XPanel();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.igKilometros = new TNGS.NetControls.ImgGroup();
            this.neKms = new TNGS.NetControls.NumberEdit();
            this.lblKilometros = new TNGS.NetControls.FullLabel();
            this.xpnlPanel.SuspendLayout();
            this.igKilometros.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpnlPanel.Controls.Add(this.gbCancelar);
            this.xpnlPanel.Controls.Add(this.gbAceptar);
            this.xpnlPanel.Controls.Add(this.igKilometros);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(337, 217);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // gbCancelar
            // 
            this.gbCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.Cancel;
            this.gbCancelar.Location = new System.Drawing.Point(229, 180);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(96, 28);
            this.gbCancelar.TabIndex = 1;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // gbAceptar
            // 
            this.gbAceptar.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbAceptar.Location = new System.Drawing.Point(128, 180);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(90, 28);
            this.gbAceptar.TabIndex = 0;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // igKilometros
            // 
            this.igKilometros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igKilometros.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igKilometros.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igKilometros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igKilometros.BorderThickness = 1F;
            this.igKilometros.Controls.Add(this.neKms);
            this.igKilometros.Controls.Add(this.lblKilometros);
            this.igKilometros.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igKilometros.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igKilometros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igKilometros.GroupImage = ((System.Drawing.Image)(resources.GetObject("igKilometros.GroupImage")));
            this.igKilometros.GroupTitle = "Nueva Carga Kilometraje";
            this.igKilometros.Location = new System.Drawing.Point(12, 12);
            this.igKilometros.Name = "igKilometros";
            this.igKilometros.Padding = new System.Windows.Forms.Padding(20);
            this.igKilometros.PaintGroupBox = true;
            this.igKilometros.RoundCorners = 10;
            this.igKilometros.ShadowColor = System.Drawing.Color.DarkGray;
            this.igKilometros.ShadowControl = true;
            this.igKilometros.ShadowThickness = 3;
            this.igKilometros.Size = new System.Drawing.Size(313, 164);
            this.igKilometros.SkinFixed = true;
            this.igKilometros.SkinFullFixed = true;
            this.igKilometros.TabIndex = 0;
            // 
            // neKms
            // 
            this.neKms.BackColor = System.Drawing.SystemColors.Window;
            this.neKms.Location = new System.Drawing.Point(144, 77);
            this.neKms.MaxLength = 7;
            this.neKms.Name = "neKms";
            this.neKms.NegativeValid = false;
            this.neKms.Size = new System.Drawing.Size(118, 20);
            this.neKms.TabIndex = 2;
            this.neKms.Text = "0";
            this.neKms.ZeroValid = false;
            // 
            // lblKilometros
            // 
            this.lblKilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilometros.Location = new System.Drawing.Point(42, 76);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(146, 23);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilometros:";
            // 
            // NuevoKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 217);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoKm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.igKilometros.ResumeLayout(false);
            this.igKilometros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.ImgGroup igKilometros;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.NumberEdit neKms;
        private TNGS.NetControls.FullLabel lblKilometros;
    }
}