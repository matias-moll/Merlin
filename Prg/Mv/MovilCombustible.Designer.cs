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
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.igCombustible = new TNGS.NetControls.ImgGroup();
            this.deImporte = new TNGS.NetControls.DecimalEdit();
            this.lblEstacion = new TNGS.NetControls.FullLabel();
            this.cdcEstacion = new TNGS.NetControls.CDCombo();
            this.neLitros = new TNGS.NetControls.NumberEdit();
            this.lblImporte = new TNGS.NetControls.FullLabel();
            this.lblLitros = new TNGS.NetControls.FullLabel();
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
            this.igCombustible.Controls.Add(this.deImporte);
            this.igCombustible.Controls.Add(this.lblEstacion);
            this.igCombustible.Controls.Add(this.cdcEstacion);
            this.igCombustible.Controls.Add(this.neLitros);
            this.igCombustible.Controls.Add(this.lblImporte);
            this.igCombustible.Controls.Add(this.lblLitros);
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
            // deImporte
            // 
            this.deImporte.BackColor = System.Drawing.SystemColors.Window;
            this.deImporte.Location = new System.Drawing.Point(137, 112);
            this.deImporte.MaxLength = 13;
            this.deImporte.Name = "deImporte";
            this.deImporte.Size = new System.Drawing.Size(153, 20);
            this.deImporte.TabIndex = 6;
            this.deImporte.Text = "0.00";
            // 
            // lblEstacion
            // 
            this.lblEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacion.Location = new System.Drawing.Point(23, 74);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(75, 23);
            this.lblEstacion.TabIndex = 5;
            this.lblEstacion.Text = "Estacion:";
            // 
            // cdcEstacion
            // 
            this.cdcEstacion.BackColor = System.Drawing.SystemColors.Window;
            this.cdcEstacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcEstacion.FormattingEnabled = true;
            this.cdcEstacion.Location = new System.Drawing.Point(137, 75);
            this.cdcEstacion.Name = "cdcEstacion";
            this.cdcEstacion.Size = new System.Drawing.Size(153, 21);
            this.cdcEstacion.Sorted = true;
            this.cdcEstacion.TabIndex = 4;
            // 
            // neLitros
            // 
            this.neLitros.BackColor = System.Drawing.SystemColors.Window;
            this.neLitros.Location = new System.Drawing.Point(217, 39);
            this.neLitros.MaxLength = 3;
            this.neLitros.Name = "neLitros";
            this.neLitros.Size = new System.Drawing.Size(73, 20);
            this.neLitros.TabIndex = 2;
            this.neLitros.Text = "0";
            // 
            // lblImporte
            // 
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(23, 111);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(67, 23);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe:";
            // 
            // lblLitros
            // 
            this.lblLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(23, 38);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(146, 23);
            this.lblLitros.TabIndex = 0;
            this.lblLitros.Text = "Cantidad de Litros:";
            // 
            // MovilCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 217);
            this.ControlBox = false;
            this.Controls.Add(this.xpnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovilCombustible";
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
        private TNGS.NetControls.NumberEdit neLitros;
        private TNGS.NetControls.FullLabel lblImporte;
        private TNGS.NetControls.FullLabel lblLitros;
        private TNGS.NetControls.FullLabel lblEstacion;
        private TNGS.NetControls.CDCombo cdcEstacion;
        private TNGS.NetControls.DecimalEdit deImporte;
    }
}