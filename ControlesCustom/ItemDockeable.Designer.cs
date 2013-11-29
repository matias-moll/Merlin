namespace ControlesCustom
{
    partial class ItemDockeable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDockeable));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.panelPrincipal = new TNGS.NetControls.TSPanel();
            this.Numero = new TNGS.NetControls.FullLabel();
            this.Fecha = new TNGS.NetControls.FullLabel();
            this.pbEstadoBueno = new System.Windows.Forms.PictureBox();
            this.pbEstadoMalo = new System.Windows.Forms.PictureBox();
            this.glassButton1 = new TNGS.NetControls.GlassButton();
            this.xPanel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadoBueno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadoMalo)).BeginInit();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.panelPrincipal);
            this.xPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(144, 90);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Caption = "Orden de Trabajo";
            this.panelPrincipal.Controls.Add(this.glassButton1);
            this.panelPrincipal.Controls.Add(this.pbEstadoMalo);
            this.panelPrincipal.Controls.Add(this.pbEstadoBueno);
            this.panelPrincipal.Controls.Add(this.Fecha);
            this.panelPrincipal.Controls.Add(this.Numero);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Opacity = 255;
            this.panelPrincipal.Size = new System.Drawing.Size(144, 85);
            this.panelPrincipal.Speed = 1;
            this.panelPrincipal.TabIndex = 0;
            // 
            // Numero
            // 
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(52, 6);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(66, 19);
            this.Numero.TabIndex = 0;
            this.Numero.Text = "00000";
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(38, 24);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(83, 23);
            this.Fecha.TabIndex = 1;
            this.Fecha.Text = "13/11/2010";
            // 
            // pbEstadoBueno
            // 
            this.pbEstadoBueno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEstadoBueno.BackgroundImage")));
            this.pbEstadoBueno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEstadoBueno.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbEstadoBueno.InitialImage")));
            this.pbEstadoBueno.Location = new System.Drawing.Point(50, 44);
            this.pbEstadoBueno.Name = "pbEstadoBueno";
            this.pbEstadoBueno.Size = new System.Drawing.Size(20, 18);
            this.pbEstadoBueno.TabIndex = 2;
            this.pbEstadoBueno.TabStop = false;
            // 
            // pbEstadoMalo
            // 
            this.pbEstadoMalo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEstadoMalo.BackgroundImage")));
            this.pbEstadoMalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbEstadoMalo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbEstadoMalo.InitialImage")));
            this.pbEstadoMalo.Location = new System.Drawing.Point(50, 44);
            this.pbEstadoMalo.Name = "pbEstadoMalo";
            this.pbEstadoMalo.Size = new System.Drawing.Size(20, 18);
            this.pbEstadoMalo.TabIndex = 3;
            this.pbEstadoMalo.TabStop = false;
            // 
            // glassButton1
            // 
            this.glassButton1.FixedImage = TNGS.NetControls.FixedGlassButtons.bCopy;
            this.glassButton1.Location = new System.Drawing.Point(75, 42);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(23, 22);
            this.glassButton1.TabIndex = 4;
            this.glassButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemDockeable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xPanel1);
            this.Name = "ItemDockeable";
            this.Size = new System.Drawing.Size(144, 90);
            this.xPanel1.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadoBueno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstadoMalo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.TSPanel panelPrincipal;
        private System.Windows.Forms.PictureBox pbEstadoBueno;
        private TNGS.NetControls.FullLabel Fecha;
        private TNGS.NetControls.FullLabel Numero;
        private System.Windows.Forms.PictureBox pbEstadoMalo;
        private TNGS.NetControls.GlassButton glassButton1;

    }
}
