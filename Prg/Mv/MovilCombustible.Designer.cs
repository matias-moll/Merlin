namespace Rivn.Mv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovilCombustible));
            this.xpnlPanel = new TNGS.NetControls.XPanel();
            this.igCombustible = new TNGS.NetControls.ImgGroup();
            this.igOpciones = new TNGS.NetControls.ImgGroup();
            this.lblLitros = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.numberEdit1 = new TNGS.NetControls.NumberEdit();
            this.numberEdit2 = new TNGS.NetControls.NumberEdit();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.xpnlPanel.SuspendLayout();
            this.igCombustible.SuspendLayout();
            this.igOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanel
            // 
            this.xpnlPanel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel.Controls.Add(this.igOpciones);
            this.xpnlPanel.Controls.Add(this.igCombustible);
            this.xpnlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel.Name = "xpnlPanel";
            this.xpnlPanel.Size = new System.Drawing.Size(227, 349);
            this.xpnlPanel.SkinFixed = true;
            this.xpnlPanel.TabIndex = 0;
            // 
            // igCombustible
            // 
            this.igCombustible.BackgroundColor = System.Drawing.Color.White;
            this.igCombustible.BackgroundGradientColor = System.Drawing.Color.White;
            this.igCombustible.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.igCombustible.BorderColor = System.Drawing.Color.Black;
            this.igCombustible.BorderThickness = 1F;
            this.igCombustible.Controls.Add(this.numberEdit2);
            this.igCombustible.Controls.Add(this.numberEdit1);
            this.igCombustible.Controls.Add(this.fullLabel1);
            this.igCombustible.Controls.Add(this.lblLitros);
            this.igCombustible.CustomGroupBoxColor = System.Drawing.Color.White;
            this.igCombustible.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igCombustible.GroupImage = ((System.Drawing.Image)(resources.GetObject("igCombustible.GroupImage")));
            this.igCombustible.GroupTitle = "Carga Combustible";
            this.igCombustible.Location = new System.Drawing.Point(13, 4);
            this.igCombustible.Name = "igCombustible";
            this.igCombustible.Padding = new System.Windows.Forms.Padding(20);
            this.igCombustible.PaintGroupBox = false;
            this.igCombustible.RoundCorners = 10;
            this.igCombustible.ShadowColor = System.Drawing.Color.DarkGray;
            this.igCombustible.ShadowControl = false;
            this.igCombustible.ShadowThickness = 3;
            this.igCombustible.Size = new System.Drawing.Size(203, 254);
            this.igCombustible.TabIndex = 0;
            // 
            // igOpciones
            // 
            this.igOpciones.BackgroundColor = System.Drawing.Color.White;
            this.igOpciones.BackgroundGradientColor = System.Drawing.Color.White;
            this.igOpciones.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.igOpciones.BorderColor = System.Drawing.Color.Black;
            this.igOpciones.BorderThickness = 1F;
            this.igOpciones.Controls.Add(this.gbCancelar);
            this.igOpciones.Controls.Add(this.gbAceptar);
            this.igOpciones.CustomGroupBoxColor = System.Drawing.Color.White;
            this.igOpciones.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igOpciones.GroupImage = ((System.Drawing.Image)(resources.GetObject("igOpciones.GroupImage")));
            this.igOpciones.GroupTitle = "Opciones";
            this.igOpciones.Location = new System.Drawing.Point(12, 259);
            this.igOpciones.Name = "igOpciones";
            this.igOpciones.Padding = new System.Windows.Forms.Padding(20);
            this.igOpciones.PaintGroupBox = false;
            this.igOpciones.RoundCorners = 10;
            this.igOpciones.ShadowColor = System.Drawing.Color.DarkGray;
            this.igOpciones.ShadowControl = false;
            this.igOpciones.ShadowThickness = 3;
            this.igOpciones.Size = new System.Drawing.Size(204, 80);
            this.igOpciones.TabIndex = 1;
            // 
            // lblLitros
            // 
            this.lblLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(15, 34);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(100, 23);
            this.lblLitros.TabIndex = 0;
            this.lblLitros.Text = "Litros:";
            // 
            // fullLabel1
            // 
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(15, 94);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(100, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Importe:";
            // 
            // numberEdit1
            // 
            this.numberEdit1.BackColor = System.Drawing.SystemColors.Window;
            this.numberEdit1.Location = new System.Drawing.Point(77, 60);
            this.numberEdit1.MaxLength = 3;
            this.numberEdit1.Name = "numberEdit1";
            this.numberEdit1.Size = new System.Drawing.Size(47, 20);
            this.numberEdit1.TabIndex = 2;
            this.numberEdit1.Text = "0";
            // 
            // numberEdit2
            // 
            this.numberEdit2.BackColor = System.Drawing.SystemColors.Window;
            this.numberEdit2.Location = new System.Drawing.Point(77, 120);
            this.numberEdit2.MaxLength = 5;
            this.numberEdit2.Name = "numberEdit2";
            this.numberEdit2.Size = new System.Drawing.Size(47, 20);
            this.numberEdit2.TabIndex = 3;
            this.numberEdit2.Text = "0";
            // 
            // gbAceptar
            // 
            this.gbAceptar.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbAceptar.Location = new System.Drawing.Point(20, 31);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(78, 26);
            this.gbAceptar.TabIndex = 0;
            this.gbAceptar.Text = "Aceptar";
            this.gbAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCancelar
            // 
            this.gbCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.Cancel;
            this.gbCancelar.Location = new System.Drawing.Point(104, 31);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.Size = new System.Drawing.Size(84, 26);
            this.gbCancelar.TabIndex = 1;
            this.gbCancelar.Text = "Cancelar";
            this.gbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovilCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 349);
            this.Controls.Add(this.xpnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MovilCombustible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.xpnlPanel.ResumeLayout(false);
            this.igCombustible.ResumeLayout(false);
            this.igCombustible.PerformLayout();
            this.igOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanel;
        private TNGS.NetControls.ImgGroup igCombustible;
        private TNGS.NetControls.ImgGroup igOpciones;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.NumberEdit numberEdit2;
        private TNGS.NetControls.NumberEdit numberEdit1;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.FullLabel lblLitros;
    }
}