namespace Rivn.Mv
{
    partial class AgregarKilometros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarKilometros));
            this.xpnlPanel = new TNGS.NetControls.XPanel();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.igCombustible = new TNGS.NetControls.ImgGroup();
            this.numberEdit1 = new TNGS.NetControls.NumberEdit();
            this.lblImporte = new TNGS.NetControls.FullLabel();
            this.xpnlPanel.SuspendLayout();
            this.igCombustible.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpnlPanel.Controls.Add(this.gbCancelar);
            this.xpnlPanel.Controls.Add(this.gbAceptar);
            this.xpnlPanel.Controls.Add(this.igCombustible);
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
            // igCombustible
            // 
            this.igCombustible.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igCombustible.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igCombustible.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igCombustible.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igCombustible.BorderThickness = 1F;
            this.igCombustible.Controls.Add(this.numberEdit1);
            this.igCombustible.Controls.Add(this.lblImporte);
            this.igCombustible.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igCombustible.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igCombustible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igCombustible.GroupImage = ((System.Drawing.Image)(resources.GetObject("igCombustible.GroupImage")));
            this.igCombustible.GroupTitle = "Nueva Carga Combustible";
            this.igCombustible.Location = new System.Drawing.Point(12, 12);
            this.igCombustible.Name = "igCombustible";
            this.igCombustible.Padding = new System.Windows.Forms.Padding(20);
            this.igCombustible.PaintGroupBox = true;
            this.igCombustible.RoundCorners = 10;
            this.igCombustible.ShadowColor = System.Drawing.Color.DarkGray;
            this.igCombustible.ShadowControl = true;
            this.igCombustible.ShadowThickness = 3;
            this.igCombustible.Size = new System.Drawing.Size(313, 164);
            this.igCombustible.SkinFixed = true;
            this.igCombustible.SkinFullFixed = true;
            this.igCombustible.TabIndex = 0;
            // 
            // numberEdit1
            // 
            this.numberEdit1.BackColor = System.Drawing.SystemColors.Window;
            this.numberEdit1.Location = new System.Drawing.Point(116, 77);
            this.numberEdit1.Name = "numberEdit1";
            this.numberEdit1.Size = new System.Drawing.Size(156, 20);
            this.numberEdit1.TabIndex = 2;
            this.numberEdit1.Text = "0";
            // 
            // lblImporte
            // 
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(23, 77);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(86, 23);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Kilometros:";
            this.lblImporte.Click += new System.EventHandler(this.lblImporte_Click);
            // 
            // AgregarKilometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 217);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarKilometros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.igCombustible.ResumeLayout(false);
            this.igCombustible.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.ImgGroup igCombustible;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.FullLabel lblImporte;
        private TNGS.NetControls.NumberEdit numberEdit1;
    }
}