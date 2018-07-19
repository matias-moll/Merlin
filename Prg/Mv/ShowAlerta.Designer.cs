namespace Mrln.Mv
{
    partial class ShowAlertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowAlertas));
            this.xpFondo = new TNGS.NetControls.XPanel();
            this.gbFinalizarAlerta = new TNGS.NetControls.GlassButton();
            this.lblTotalAlertas = new TNGS.NetControls.FullLabel();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.lblNroActualAlerta = new TNGS.NetControls.FullLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbVisto = new TNGS.NetControls.GlassButton();
            this.gbConfirmarRecordarEn = new TNGS.NetControls.GlassButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.neRepetirEn = new TNGS.NetControls.NumberEdit();
            this.lblNroAlerta = new TNGS.NetControls.FullLabel();
            this.gbAceptar = new TNGS.NetControls.GlassButton();
            this.lblDetalle = new TNGS.NetControls.FullLabel();
            this.lblDescripcion = new TNGS.NetControls.FullLabel();
            this.lblRecordar = new TNGS.NetControls.FullLabel();
            this.xpFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpFondo
            // 
            this.xpFondo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpFondo.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpFondo.Controls.Add(this.gbFinalizarAlerta);
            this.xpFondo.Controls.Add(this.lblTotalAlertas);
            this.xpFondo.Controls.Add(this.fullLabel2);
            this.xpFondo.Controls.Add(this.lblNroActualAlerta);
            this.xpFondo.Controls.Add(this.panel2);
            this.xpFondo.Controls.Add(this.gbVisto);
            this.xpFondo.Controls.Add(this.gbConfirmarRecordarEn);
            this.xpFondo.Controls.Add(this.panel1);
            this.xpFondo.Controls.Add(this.neRepetirEn);
            this.xpFondo.Controls.Add(this.lblNroAlerta);
            this.xpFondo.Controls.Add(this.gbAceptar);
            this.xpFondo.Controls.Add(this.lblDetalle);
            this.xpFondo.Controls.Add(this.lblDescripcion);
            this.xpFondo.Controls.Add(this.lblRecordar);
            this.xpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpFondo.Location = new System.Drawing.Point(0, 0);
            this.xpFondo.Name = "xpFondo";
            this.xpFondo.Size = new System.Drawing.Size(337, 305);
            this.xpFondo.SkinFixed = true;
            this.xpFondo.TabIndex = 0;
            // 
            // gbFinalizarAlerta
            // 
            this.gbFinalizarAlerta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbFinalizarAlerta.BackgroundImage")));
            this.gbFinalizarAlerta.BlackBorder = true;
            this.gbFinalizarAlerta.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbFinalizarAlerta.CircleButton = false;
            this.gbFinalizarAlerta.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fTrash;
            this.gbFinalizarAlerta.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbFinalizarAlerta.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbFinalizarAlerta.FlatFontSize = 9;
            this.gbFinalizarAlerta.FlatTextColor = System.Drawing.Color.Black;
            this.gbFinalizarAlerta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbFinalizarAlerta.Location = new System.Drawing.Point(298, 215);
            this.gbFinalizarAlerta.Name = "gbFinalizarAlerta";
            this.gbFinalizarAlerta.RoundCorners = 2;
            this.gbFinalizarAlerta.Size = new System.Drawing.Size(26, 24);
            this.gbFinalizarAlerta.TabIndex = 217;
            this.gbFinalizarAlerta.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbFinalizarAlerta.Click += new System.EventHandler(this.gbFinalizarAlerta_Click);
            // 
            // lblTotalAlertas
            // 
            this.lblTotalAlertas.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAlertas.Location = new System.Drawing.Point(303, 3);
            this.lblTotalAlertas.Name = "lblTotalAlertas";
            this.lblTotalAlertas.Size = new System.Drawing.Size(24, 23);
            this.lblTotalAlertas.TabIndex = 215;
            this.lblTotalAlertas.Text = "99";
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(295, 3);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(16, 23);
            this.fullLabel2.TabIndex = 216;
            this.fullLabel2.Text = "/";
            // 
            // lblNroActualAlerta
            // 
            this.lblNroActualAlerta.BackColor = System.Drawing.Color.Transparent;
            this.lblNroActualAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroActualAlerta.Location = new System.Drawing.Point(284, 3);
            this.lblNroActualAlerta.Name = "lblNroActualAlerta";
            this.lblNroActualAlerta.Size = new System.Drawing.Size(13, 23);
            this.lblNroActualAlerta.TabIndex = 214;
            this.lblNroActualAlerta.Text = "1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 2);
            this.panel2.TabIndex = 213;
            // 
            // gbVisto
            // 
            this.gbVisto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbVisto.BackgroundImage")));
            this.gbVisto.BlackBorder = true;
            this.gbVisto.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbVisto.CircleButton = false;
            this.gbVisto.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fCheck;
            this.gbVisto.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbVisto.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbVisto.FlatFontSize = 9;
            this.gbVisto.FlatTextColor = System.Drawing.Color.Black;
            this.gbVisto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbVisto.Location = new System.Drawing.Point(241, 215);
            this.gbVisto.Name = "gbVisto";
            this.gbVisto.RoundCorners = 2;
            this.gbVisto.Size = new System.Drawing.Size(26, 24);
            this.gbVisto.TabIndex = 212;
            this.gbVisto.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbVisto.Click += new System.EventHandler(this.gbVisto_Click);
            // 
            // gbConfirmarRecordarEn
            // 
            this.gbConfirmarRecordarEn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbConfirmarRecordarEn.BackgroundImage")));
            this.gbConfirmarRecordarEn.BlackBorder = true;
            this.gbConfirmarRecordarEn.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbConfirmarRecordarEn.CircleButton = false;
            this.gbConfirmarRecordarEn.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fOk;
            this.gbConfirmarRecordarEn.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbConfirmarRecordarEn.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbConfirmarRecordarEn.FlatFontSize = 9;
            this.gbConfirmarRecordarEn.FlatTextColor = System.Drawing.Color.Black;
            this.gbConfirmarRecordarEn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbConfirmarRecordarEn.Location = new System.Drawing.Point(126, 215);
            this.gbConfirmarRecordarEn.Name = "gbConfirmarRecordarEn";
            this.gbConfirmarRecordarEn.RoundCorners = 2;
            this.gbConfirmarRecordarEn.Size = new System.Drawing.Size(26, 24);
            this.gbConfirmarRecordarEn.TabIndex = 211;
            this.gbConfirmarRecordarEn.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbConfirmarRecordarEn.Click += new System.EventHandler(this.gbConfirmarRecordarEn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(3, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 2);
            this.panel1.TabIndex = 210;
            // 
            // neRepetirEn
            // 
            this.neRepetirEn.BackColor = System.Drawing.SystemColors.Window;
            this.neRepetirEn.Location = new System.Drawing.Point(80, 217);
            this.neRepetirEn.MaxLength = 100;
            this.neRepetirEn.Name = "neRepetirEn";
            this.neRepetirEn.Size = new System.Drawing.Size(30, 20);
            this.neRepetirEn.TabIndex = 29;
            this.neRepetirEn.Text = "0";
            // 
            // lblNroAlerta
            // 
            this.lblNroAlerta.BackColor = System.Drawing.Color.Transparent;
            this.lblNroAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroAlerta.Location = new System.Drawing.Point(3, 3);
            this.lblNroAlerta.Name = "lblNroAlerta";
            this.lblNroAlerta.Size = new System.Drawing.Size(47, 23);
            this.lblNroAlerta.TabIndex = 10;
            this.lblNroAlerta.Text = "Nro";
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
            this.gbAceptar.Location = new System.Drawing.Point(241, 265);
            this.gbAceptar.Name = "gbAceptar";
            this.gbAceptar.Size = new System.Drawing.Size(83, 27);
            this.gbAceptar.TabIndex = 8;
            this.gbAceptar.Text = "Cerrar";
            this.gbAceptar.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAceptar.Click += new System.EventHandler(this.gbAceptar_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(5, 70);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(324, 116);
            this.lblDetalle.TabIndex = 5;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(3, 30);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(329, 23);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordar
            // 
            this.lblRecordar.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordar.Location = new System.Drawing.Point(3, 218);
            this.lblRecordar.Name = "lblRecordar";
            this.lblRecordar.Size = new System.Drawing.Size(85, 23);
            this.lblRecordar.TabIndex = 1;
            this.lblRecordar.Text = "Recordar en";
            // 
            // ShowAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 305);
            this.ControlBox = false;
            this.Controls.Add(this.xpFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowAlertas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MovilCombustible";
            this.Load += new System.EventHandler(this.ShowAlertas_Load);
            this.xpFondo.ResumeLayout(false);
            this.xpFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpFondo;
        private TNGS.NetControls.FullLabel lblRecordar;
        private TNGS.NetControls.FullLabel lblDescripcion;
        private TNGS.NetControls.FullLabel lblDetalle;
        private TNGS.NetControls.GlassButton gbAceptar;
        private TNGS.NetControls.FullLabel lblNroAlerta;
        private TNGS.NetControls.NumberEdit neRepetirEn;
        private TNGS.NetControls.GlassButton gbFinalizarAlerta;
        private TNGS.NetControls.FullLabel lblTotalAlertas;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.FullLabel lblNroActualAlerta;
        private System.Windows.Forms.Panel panel2;
        private TNGS.NetControls.GlassButton gbVisto;
        private TNGS.NetControls.GlassButton gbConfirmarRecordarEn;
        private System.Windows.Forms.Panel panel1;
    }
}