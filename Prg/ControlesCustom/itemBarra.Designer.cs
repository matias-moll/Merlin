namespace ControlesCustom
{
    partial class itemBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemBarra));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.fllDescripcion = new TNGS.NetControls.FullLabel();
            this.pbRojo = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.lblFecha = new TNGS.NetControls.FullLabel();
            this.lblNumero = new TNGS.NetControls.FullLabel();
            this.xPanel2 = new TNGS.NetControls.XPanel();
            this.lblTitulo = new TNGS.NetControls.FullLabel();
            this.pbAmarillo = new System.Windows.Forms.PictureBox();
            this.xPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            this.xPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo)).BeginInit();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.pbAmarillo);
            this.xPanel1.Controls.Add(this.fllDescripcion);
            this.xPanel1.Controls.Add(this.pbRojo);
            this.xPanel1.Controls.Add(this.pbVerde);
            this.xPanel1.Controls.Add(this.lblFecha);
            this.xPanel1.Controls.Add(this.lblNumero);
            this.xPanel1.Controls.Add(this.xPanel2);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(130, 120);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            this.xPanel1.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // fllDescripcion
            // 
            this.fllDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fllDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.fllDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fllDescripcion.Location = new System.Drawing.Point(3, 55);
            this.fllDescripcion.Name = "fllDescripcion";
            this.fllDescripcion.Size = new System.Drawing.Size(124, 37);
            this.fllDescripcion.TabIndex = 6;
            this.fllDescripcion.Text = "Descripcion testeando cantidad";
            this.fllDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fllDescripcion.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // pbRojo
            // 
            this.pbRojo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbRojo.BackColor = System.Drawing.Color.Transparent;
            this.pbRojo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRojo.BackgroundImage")));
            this.pbRojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbRojo.Location = new System.Drawing.Point(53, 97);
            this.pbRojo.Name = "pbRojo";
            this.pbRojo.Size = new System.Drawing.Size(20, 20);
            this.pbRojo.TabIndex = 4;
            this.pbRojo.TabStop = false;
            this.pbRojo.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // pbVerde
            // 
            this.pbVerde.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbVerde.BackColor = System.Drawing.Color.Transparent;
            this.pbVerde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbVerde.BackgroundImage")));
            this.pbVerde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbVerde.Location = new System.Drawing.Point(53, 97);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(20, 20);
            this.pbVerde.TabIndex = 3;
            this.pbVerde.TabStop = false;
            this.pbVerde.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(8, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(116, 14);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "1/1/2010";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(8, 21);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(116, 19);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "000000";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumero.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // xPanel2
            // 
            this.xPanel2.AutoSize = true;
            this.xPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.xPanel2.BackColor1 = System.Drawing.Color.LightBlue;
            this.xPanel2.BackColor2 = System.Drawing.Color.PowderBlue;
            this.xPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xPanel2.Controls.Add(this.lblTitulo);
            this.xPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xPanel2.Location = new System.Drawing.Point(0, 0);
            this.xPanel2.Name = "xPanel2";
            this.xPanel2.Size = new System.Drawing.Size(130, 21);
            this.xPanel2.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Orden de Trabajo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.itemBarra_Click);
            // 
            // pbAmarillo
            // 
            this.pbAmarillo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.pbAmarillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAmarillo.BackgroundImage")));
            this.pbAmarillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbAmarillo.Location = new System.Drawing.Point(53, 95);
            this.pbAmarillo.Name = "pbAmarillo";
            this.pbAmarillo.Size = new System.Drawing.Size(20, 20);
            this.pbAmarillo.TabIndex = 7;
            this.pbAmarillo.TabStop = false;
            // 
            // itemBarra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.xPanel1);
            this.MaximumSize = new System.Drawing.Size(130, 120);
            this.MinimumSize = new System.Drawing.Size(120, 90);
            this.Name = "itemBarra";
            this.Size = new System.Drawing.Size(130, 120);
            this.Click += new System.EventHandler(this.itemBarra_Click);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            this.xPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private System.Windows.Forms.PictureBox pbRojo;
        private System.Windows.Forms.PictureBox pbVerde;
        private TNGS.NetControls.FullLabel lblFecha;
        private TNGS.NetControls.FullLabel lblNumero;
        private TNGS.NetControls.XPanel xPanel2;
        private TNGS.NetControls.FullLabel lblTitulo;
        private TNGS.NetControls.FullLabel fllDescripcion;
        private System.Windows.Forms.PictureBox pbAmarillo;
    }
}
