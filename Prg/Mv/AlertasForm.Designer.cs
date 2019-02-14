namespace Mrln.Mv
{
    partial class AlertasForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertasForm));
            this.fgConfigAlertas = new TNGS.NetControls.FullGrid();
            this.cdcMoviles = new TNGS.NetControls.CDCombo();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.gbBorrarSeleccionados = new TNGS.NetControls.GlassButton();
            this.tgrpAñadirAlertas = new TNGS.NetControls.ImgGroup();
            this.tgrpPostReparacion = new TNGS.NetControls.ImgGroup();
            this.cdcReparacionesPostReparacion = new TNGS.NetControls.CDCombo();
            this.gbAgregarPostReparacion = new TNGS.NetControls.GlassButton();
            this.fullLabel7 = new TNGS.NetControls.FullLabel();
            this.fullLabel10 = new TNGS.NetControls.FullLabel();
            this.cdcControlesPostReparacion = new TNGS.NetControls.CDCombo();
            this.neEnkmPostReparacion = new TNGS.NetControls.NumberEdit();
            this.fullLabel9 = new TNGS.NetControls.FullLabel();
            this.tgrpPeriódicos = new TNGS.NetControls.ImgGroup();
            this.neHastaKmsPeriodicos = new TNGS.NetControls.NumberEdit();
            this.gbAgregarPeriodicos = new TNGS.NetControls.GlassButton();
            this.fullLabel8 = new TNGS.NetControls.FullLabel();
            this.lblControl = new TNGS.NetControls.FullLabel();
            this.neCadaKmsPeriodicos = new TNGS.NetControls.NumberEdit();
            this.cdcControlesPeriodicos = new TNGS.NetControls.CDCombo();
            this.fullLabel11 = new TNGS.NetControls.FullLabel();
            this.lblNroChasis = new TNGS.NetControls.FullLabel();
            this.neDesdeKmsPeriodicos = new TNGS.NetControls.NumberEdit();
            this.tgrpEspecifico = new TNGS.NetControls.ImgGroup();
            this.fullLabel12 = new TNGS.NetControls.FullLabel();
            this.gbAgregarEspecifico = new TNGS.NetControls.GlassButton();
            this.fullLabel13 = new TNGS.NetControls.FullLabel();
            this.neEnkmEspecifico = new TNGS.NetControls.NumberEdit();
            this.cdcControlesEspecifico = new TNGS.NetControls.CDCombo();
            this.fullLabel14 = new TNGS.NetControls.FullLabel();
            this.cdListaDestinatarios = new TNGS.NetControls.CDList();
            this.fullLabel15 = new TNGS.NetControls.FullLabel();
            this.cdcGruposDestinatarios = new TNGS.NetControls.CDCombo();
            ((System.ComponentModel.ISupportInitialize)(this.fgConfigAlertas)).BeginInit();
            this.tgrpAñadirAlertas.SuspendLayout();
            this.tgrpPostReparacion.SuspendLayout();
            this.tgrpPeriódicos.SuspendLayout();
            this.tgrpEspecifico.SuspendLayout();
            this.SuspendLayout();
            // 
            // fgConfigAlertas
            // 
            this.fgConfigAlertas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fgConfigAlertas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgConfigAlertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgConfigAlertas.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.fgConfigAlertas.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgConfigAlertas.CaptionForeColor = System.Drawing.Color.Black;
            this.fgConfigAlertas.CaptionText = "Configuraciones Alertas";
            this.fgConfigAlertas.DataMember = "";
            this.fgConfigAlertas.ExcelName = "Configuraciónes Alertas";
            this.fgConfigAlertas.ExcelTitle = "";
            this.fgConfigAlertas.GridOrder = "";
            this.fgConfigAlertas.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgConfigAlertas.Location = new System.Drawing.Point(9, 372);
            this.fgConfigAlertas.Name = "fgConfigAlertas";
            this.fgConfigAlertas.Size = new System.Drawing.Size(853, 233);
            this.fgConfigAlertas.SkinFixed = true;
            this.fgConfigAlertas.TabIndex = 47;
            this.fgConfigAlertas.WithCheckBoxes = true;
            // 
            // cdcMoviles
            // 
            this.cdcMoviles.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMoviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMoviles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcMoviles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cdcMoviles.FormattingEnabled = true;
            this.cdcMoviles.Location = new System.Drawing.Point(442, 7);
            this.cdcMoviles.Name = "cdcMoviles";
            this.cdcMoviles.Size = new System.Drawing.Size(194, 23);
            this.cdcMoviles.Sorted = true;
            this.cdcMoviles.TabIndex = 44;
            this.cdcMoviles.SelectedIndexChanged += new System.EventHandler(this.cdcMoviles_SelectedIndexChanged);
            // 
            // fullLabel6
            // 
            this.fullLabel6.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel6.Location = new System.Drawing.Point(328, 10);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(117, 23);
            this.fullLabel6.TabIndex = 45;
            this.fullLabel6.Text = "Selección Movil:";
            // 
            // gbBorrarSeleccionados
            // 
            this.gbBorrarSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBorrarSeleccionados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBorrarSeleccionados.BackgroundImage")));
            this.gbBorrarSeleccionados.BlackBorder = true;
            this.gbBorrarSeleccionados.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBorrarSeleccionados.CircleButton = false;
            this.gbBorrarSeleccionados.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Trash;
            this.gbBorrarSeleccionados.FlatColor = System.Drawing.Color.Red;
            this.gbBorrarSeleccionados.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbBorrarSeleccionados.FlatFontSize = 9;
            this.gbBorrarSeleccionados.FlatTextColor = System.Drawing.Color.Black;
            this.gbBorrarSeleccionados.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBorrarSeleccionados.Location = new System.Drawing.Point(868, 554);
            this.gbBorrarSeleccionados.Name = "gbBorrarSeleccionados";
            this.gbBorrarSeleccionados.RoundCorners = 2;
            this.gbBorrarSeleccionados.Size = new System.Drawing.Size(126, 51);
            this.gbBorrarSeleccionados.TabIndex = 48;
            this.gbBorrarSeleccionados.Text = "Borrar Seleccionados";
            this.gbBorrarSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBorrarSeleccionados.W8Color = System.Drawing.Color.Red;
            this.gbBorrarSeleccionados.Click += new System.EventHandler(this.gbBorrarSeleccionados_Click);
            // 
            // tgrpAñadirAlertas
            // 
            this.tgrpAñadirAlertas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpAñadirAlertas.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpAñadirAlertas.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpAñadirAlertas.BlackBorder = true;
            this.tgrpAñadirAlertas.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tgrpAñadirAlertas.BorderThickness = 1F;
            this.tgrpAñadirAlertas.Controls.Add(this.tgrpPostReparacion);
            this.tgrpAñadirAlertas.Controls.Add(this.tgrpPeriódicos);
            this.tgrpAñadirAlertas.Controls.Add(this.tgrpEspecifico);
            this.tgrpAñadirAlertas.Controls.Add(this.cdListaDestinatarios);
            this.tgrpAñadirAlertas.Controls.Add(this.fullLabel15);
            this.tgrpAñadirAlertas.Controls.Add(this.cdcGruposDestinatarios);
            this.tgrpAñadirAlertas.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpAñadirAlertas.FlatMode = true;
            this.tgrpAñadirAlertas.Font = new System.Drawing.Font("Arial", 9F);
            this.tgrpAñadirAlertas.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpAñadirAlertas.ForeColor = System.Drawing.Color.Black;
            this.tgrpAñadirAlertas.GroupImage = null;
            this.tgrpAñadirAlertas.GroupTitle = "Añadir Alertas";
            this.tgrpAñadirAlertas.Location = new System.Drawing.Point(9, 41);
            this.tgrpAñadirAlertas.Name = "tgrpAñadirAlertas";
            this.tgrpAñadirAlertas.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpAñadirAlertas.PaintGroupBox = false;
            this.tgrpAñadirAlertas.RoundCorners = 4;
            this.tgrpAñadirAlertas.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpAñadirAlertas.ShadowControl = false;
            this.tgrpAñadirAlertas.ShadowThickness = 3;
            this.tgrpAñadirAlertas.Size = new System.Drawing.Size(985, 313);
            this.tgrpAñadirAlertas.SkinFixed = true;
            this.tgrpAñadirAlertas.TabIndex = 46;
            this.tgrpAñadirAlertas.TitleBackground = System.Drawing.Color.Firebrick;
            this.tgrpAñadirAlertas.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpAñadirAlertas.TitleFontColor = System.Drawing.Color.White;
            // 
            // tgrpPostReparacion
            // 
            this.tgrpPostReparacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpPostReparacion.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpPostReparacion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpPostReparacion.BlackBorder = true;
            this.tgrpPostReparacion.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tgrpPostReparacion.BorderThickness = 1F;
            this.tgrpPostReparacion.Controls.Add(this.cdcReparacionesPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.gbAgregarPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.fullLabel7);
            this.tgrpPostReparacion.Controls.Add(this.fullLabel10);
            this.tgrpPostReparacion.Controls.Add(this.cdcControlesPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.neEnkmPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.fullLabel9);
            this.tgrpPostReparacion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpPostReparacion.FlatMode = true;
            this.tgrpPostReparacion.Font = new System.Drawing.Font("Arial", 9F);
            this.tgrpPostReparacion.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpPostReparacion.ForeColor = System.Drawing.Color.Black;
            this.tgrpPostReparacion.GroupImage = null;
            this.tgrpPostReparacion.GroupTitle = "Post Reparación";
            this.tgrpPostReparacion.Location = new System.Drawing.Point(210, 223);
            this.tgrpPostReparacion.Name = "tgrpPostReparacion";
            this.tgrpPostReparacion.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpPostReparacion.PaintGroupBox = false;
            this.tgrpPostReparacion.RoundCorners = 4;
            this.tgrpPostReparacion.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpPostReparacion.ShadowControl = false;
            this.tgrpPostReparacion.ShadowThickness = 3;
            this.tgrpPostReparacion.Size = new System.Drawing.Size(767, 80);
            this.tgrpPostReparacion.SkinFixed = true;
            this.tgrpPostReparacion.TabIndex = 113;
            this.tgrpPostReparacion.TitleAlignment = TNGS.NetControls.ImgGroup.TitleAlign.Left;
            this.tgrpPostReparacion.TitleBackground = System.Drawing.Color.IndianRed;
            this.tgrpPostReparacion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpPostReparacion.TitleFontColor = System.Drawing.Color.White;
            // 
            // cdcReparacionesPostReparacion
            // 
            this.cdcReparacionesPostReparacion.BackColor = System.Drawing.SystemColors.Window;
            this.cdcReparacionesPostReparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcReparacionesPostReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcReparacionesPostReparacion.FormattingEnabled = true;
            this.cdcReparacionesPostReparacion.Location = new System.Drawing.Point(223, 41);
            this.cdcReparacionesPostReparacion.Name = "cdcReparacionesPostReparacion";
            this.cdcReparacionesPostReparacion.Size = new System.Drawing.Size(196, 23);
            this.cdcReparacionesPostReparacion.Sorted = true;
            this.cdcReparacionesPostReparacion.TabIndex = 32;
            // 
            // gbAgregarPostReparacion
            // 
            this.gbAgregarPostReparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarPostReparacion.BlackBorder = true;
            this.gbAgregarPostReparacion.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarPostReparacion.CircleButton = false;
            this.gbAgregarPostReparacion.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAgregarPostReparacion.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarPostReparacion.FlatFontSize = 9;
            this.gbAgregarPostReparacion.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarPostReparacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAgregarPostReparacion.Location = new System.Drawing.Point(685, 38);
            this.gbAgregarPostReparacion.Name = "gbAgregarPostReparacion";
            this.gbAgregarPostReparacion.Size = new System.Drawing.Size(68, 27);
            this.gbAgregarPostReparacion.TabIndex = 30;
            this.gbAgregarPostReparacion.Text = "Agregar";
            this.gbAgregarPostReparacion.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAgregarPostReparacion.Click += new System.EventHandler(this.gbAgregarPostReparacion_Click);
            // 
            // fullLabel7
            // 
            this.fullLabel7.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel7.ForeColor = System.Drawing.Color.Black;
            this.fullLabel7.Location = new System.Drawing.Point(90, 44);
            this.fullLabel7.Name = "fullLabel7";
            this.fullLabel7.Size = new System.Drawing.Size(140, 18);
            this.fullLabel7.TabIndex = 31;
            this.fullLabel7.Text = "km    post reparación";
            // 
            // fullLabel10
            // 
            this.fullLabel10.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel10.ForeColor = System.Drawing.Color.Black;
            this.fullLabel10.Location = new System.Drawing.Point(427, 44);
            this.fullLabel10.Name = "fullLabel10";
            this.fullLabel10.Size = new System.Drawing.Size(59, 18);
            this.fullLabel10.TabIndex = 16;
            this.fullLabel10.Text = "Control:";
            // 
            // cdcControlesPostReparacion
            // 
            this.cdcControlesPostReparacion.BackColor = System.Drawing.SystemColors.Window;
            this.cdcControlesPostReparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcControlesPostReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcControlesPostReparacion.FormattingEnabled = true;
            this.cdcControlesPostReparacion.Location = new System.Drawing.Point(488, 41);
            this.cdcControlesPostReparacion.Name = "cdcControlesPostReparacion";
            this.cdcControlesPostReparacion.Size = new System.Drawing.Size(176, 23);
            this.cdcControlesPostReparacion.Sorted = true;
            this.cdcControlesPostReparacion.TabIndex = 6;
            // 
            // neEnkmPostReparacion
            // 
            this.neEnkmPostReparacion.BackColor = System.Drawing.SystemColors.Window;
            this.neEnkmPostReparacion.Location = new System.Drawing.Point(35, 41);
            this.neEnkmPostReparacion.Name = "neEnkmPostReparacion";
            this.neEnkmPostReparacion.Size = new System.Drawing.Size(51, 21);
            this.neEnkmPostReparacion.TabIndex = 22;
            this.neEnkmPostReparacion.Text = "0";
            // 
            // fullLabel9
            // 
            this.fullLabel9.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel9.ForeColor = System.Drawing.Color.Black;
            this.fullLabel9.Location = new System.Drawing.Point(9, 44);
            this.fullLabel9.Name = "fullLabel9";
            this.fullLabel9.Size = new System.Drawing.Size(30, 18);
            this.fullLabel9.TabIndex = 14;
            this.fullLabel9.Text = "En";
            // 
            // tgrpPeriódicos
            // 
            this.tgrpPeriódicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpPeriódicos.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpPeriódicos.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpPeriódicos.BlackBorder = true;
            this.tgrpPeriódicos.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tgrpPeriódicos.BorderThickness = 1F;
            this.tgrpPeriódicos.Controls.Add(this.neHastaKmsPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.gbAgregarPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.fullLabel8);
            this.tgrpPeriódicos.Controls.Add(this.lblControl);
            this.tgrpPeriódicos.Controls.Add(this.neCadaKmsPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.cdcControlesPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.fullLabel11);
            this.tgrpPeriódicos.Controls.Add(this.lblNroChasis);
            this.tgrpPeriódicos.Controls.Add(this.neDesdeKmsPeriodicos);
            this.tgrpPeriódicos.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpPeriódicos.FlatMode = true;
            this.tgrpPeriódicos.Font = new System.Drawing.Font("Arial", 9F);
            this.tgrpPeriódicos.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpPeriódicos.ForeColor = System.Drawing.Color.Black;
            this.tgrpPeriódicos.GroupImage = null;
            this.tgrpPeriódicos.GroupTitle = "Periódicos";
            this.tgrpPeriódicos.Location = new System.Drawing.Point(210, 127);
            this.tgrpPeriódicos.Name = "tgrpPeriódicos";
            this.tgrpPeriódicos.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpPeriódicos.PaintGroupBox = false;
            this.tgrpPeriódicos.RoundCorners = 4;
            this.tgrpPeriódicos.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpPeriódicos.ShadowControl = false;
            this.tgrpPeriódicos.ShadowThickness = 3;
            this.tgrpPeriódicos.Size = new System.Drawing.Size(767, 80);
            this.tgrpPeriódicos.SkinFixed = true;
            this.tgrpPeriódicos.TabIndex = 112;
            this.tgrpPeriódicos.TitleAlignment = TNGS.NetControls.ImgGroup.TitleAlign.Left;
            this.tgrpPeriódicos.TitleBackground = System.Drawing.Color.IndianRed;
            this.tgrpPeriódicos.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpPeriódicos.TitleFontColor = System.Drawing.Color.White;
            // 
            // neHastaKmsPeriodicos
            // 
            this.neHastaKmsPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.neHastaKmsPeriodicos.Location = new System.Drawing.Point(317, 40);
            this.neHastaKmsPeriodicos.Name = "neHastaKmsPeriodicos";
            this.neHastaKmsPeriodicos.Size = new System.Drawing.Size(51, 21);
            this.neHastaKmsPeriodicos.TabIndex = 34;
            this.neHastaKmsPeriodicos.Text = "0";
            // 
            // gbAgregarPeriodicos
            // 
            this.gbAgregarPeriodicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarPeriodicos.BlackBorder = true;
            this.gbAgregarPeriodicos.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarPeriodicos.CircleButton = false;
            this.gbAgregarPeriodicos.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAgregarPeriodicos.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarPeriodicos.FlatFontSize = 9;
            this.gbAgregarPeriodicos.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarPeriodicos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAgregarPeriodicos.Location = new System.Drawing.Point(685, 39);
            this.gbAgregarPeriodicos.Name = "gbAgregarPeriodicos";
            this.gbAgregarPeriodicos.Size = new System.Drawing.Size(68, 27);
            this.gbAgregarPeriodicos.TabIndex = 30;
            this.gbAgregarPeriodicos.Text = "Agregar";
            this.gbAgregarPeriodicos.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAgregarPeriodicos.Click += new System.EventHandler(this.gbAgregarPeriodicos_Click);
            // 
            // fullLabel8
            // 
            this.fullLabel8.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel8.ForeColor = System.Drawing.Color.Black;
            this.fullLabel8.Location = new System.Drawing.Point(260, 44);
            this.fullLabel8.Name = "fullLabel8";
            this.fullLabel8.Size = new System.Drawing.Size(61, 18);
            this.fullLabel8.TabIndex = 33;
            this.fullLabel8.Text = ",    hasta";
            // 
            // lblControl
            // 
            this.lblControl.BackColor = System.Drawing.Color.Transparent;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.Color.Black;
            this.lblControl.Location = new System.Drawing.Point(429, 44);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(59, 18);
            this.lblControl.TabIndex = 16;
            this.lblControl.Text = "Control:";
            // 
            // neCadaKmsPeriodicos
            // 
            this.neCadaKmsPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.neCadaKmsPeriodicos.Location = new System.Drawing.Point(205, 40);
            this.neCadaKmsPeriodicos.Name = "neCadaKmsPeriodicos";
            this.neCadaKmsPeriodicos.Size = new System.Drawing.Size(51, 21);
            this.neCadaKmsPeriodicos.TabIndex = 32;
            this.neCadaKmsPeriodicos.Text = "0";
            // 
            // cdcControlesPeriodicos
            // 
            this.cdcControlesPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.cdcControlesPeriodicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcControlesPeriodicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcControlesPeriodicos.FormattingEnabled = true;
            this.cdcControlesPeriodicos.Location = new System.Drawing.Point(488, 42);
            this.cdcControlesPeriodicos.Name = "cdcControlesPeriodicos";
            this.cdcControlesPeriodicos.Size = new System.Drawing.Size(176, 23);
            this.cdcControlesPeriodicos.Sorted = true;
            this.cdcControlesPeriodicos.TabIndex = 6;
            // 
            // fullLabel11
            // 
            this.fullLabel11.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel11.ForeColor = System.Drawing.Color.Black;
            this.fullLabel11.Location = new System.Drawing.Point(154, 44);
            this.fullLabel11.Name = "fullLabel11";
            this.fullLabel11.Size = new System.Drawing.Size(57, 18);
            this.fullLabel11.TabIndex = 31;
            this.fullLabel11.Text = ",   cada";
            // 
            // lblNroChasis
            // 
            this.lblNroChasis.BackColor = System.Drawing.Color.Transparent;
            this.lblNroChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroChasis.ForeColor = System.Drawing.Color.Black;
            this.lblNroChasis.Location = new System.Drawing.Point(46, 44);
            this.lblNroChasis.Name = "lblNroChasis";
            this.lblNroChasis.Size = new System.Drawing.Size(51, 18);
            this.lblNroChasis.TabIndex = 14;
            this.lblNroChasis.Text = "Desde";
            // 
            // neDesdeKmsPeriodicos
            // 
            this.neDesdeKmsPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.neDesdeKmsPeriodicos.Location = new System.Drawing.Point(98, 40);
            this.neDesdeKmsPeriodicos.Name = "neDesdeKmsPeriodicos";
            this.neDesdeKmsPeriodicos.Size = new System.Drawing.Size(51, 21);
            this.neDesdeKmsPeriodicos.TabIndex = 22;
            this.neDesdeKmsPeriodicos.Text = "0";
            // 
            // tgrpEspecifico
            // 
            this.tgrpEspecifico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpEspecifico.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpEspecifico.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpEspecifico.BlackBorder = true;
            this.tgrpEspecifico.BorderColor = System.Drawing.Color.DodgerBlue;
            this.tgrpEspecifico.BorderThickness = 1F;
            this.tgrpEspecifico.Controls.Add(this.fullLabel12);
            this.tgrpEspecifico.Controls.Add(this.gbAgregarEspecifico);
            this.tgrpEspecifico.Controls.Add(this.fullLabel13);
            this.tgrpEspecifico.Controls.Add(this.neEnkmEspecifico);
            this.tgrpEspecifico.Controls.Add(this.cdcControlesEspecifico);
            this.tgrpEspecifico.Controls.Add(this.fullLabel14);
            this.tgrpEspecifico.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpEspecifico.FlatMode = true;
            this.tgrpEspecifico.Font = new System.Drawing.Font("Arial", 9F);
            this.tgrpEspecifico.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpEspecifico.ForeColor = System.Drawing.Color.Black;
            this.tgrpEspecifico.GroupImage = null;
            this.tgrpEspecifico.GroupTitle = "Específico";
            this.tgrpEspecifico.Location = new System.Drawing.Point(210, 34);
            this.tgrpEspecifico.Name = "tgrpEspecifico";
            this.tgrpEspecifico.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpEspecifico.PaintGroupBox = false;
            this.tgrpEspecifico.RoundCorners = 4;
            this.tgrpEspecifico.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpEspecifico.ShadowControl = false;
            this.tgrpEspecifico.ShadowThickness = 3;
            this.tgrpEspecifico.Size = new System.Drawing.Size(767, 80);
            this.tgrpEspecifico.SkinFixed = true;
            this.tgrpEspecifico.TabIndex = 111;
            this.tgrpEspecifico.TitleAlignment = TNGS.NetControls.ImgGroup.TitleAlign.Left;
            this.tgrpEspecifico.TitleBackground = System.Drawing.Color.IndianRed;
            this.tgrpEspecifico.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpEspecifico.TitleFontColor = System.Drawing.Color.White;
            // 
            // fullLabel12
            // 
            this.fullLabel12.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel12.ForeColor = System.Drawing.Color.Black;
            this.fullLabel12.Location = new System.Drawing.Point(253, 46);
            this.fullLabel12.Name = "fullLabel12";
            this.fullLabel12.Size = new System.Drawing.Size(57, 18);
            this.fullLabel12.TabIndex = 31;
            this.fullLabel12.Text = "km";
            // 
            // gbAgregarEspecifico
            // 
            this.gbAgregarEspecifico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarEspecifico.BlackBorder = true;
            this.gbAgregarEspecifico.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarEspecifico.CircleButton = false;
            this.gbAgregarEspecifico.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAgregarEspecifico.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarEspecifico.FlatFontSize = 9;
            this.gbAgregarEspecifico.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarEspecifico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAgregarEspecifico.Location = new System.Drawing.Point(685, 39);
            this.gbAgregarEspecifico.Name = "gbAgregarEspecifico";
            this.gbAgregarEspecifico.Size = new System.Drawing.Size(68, 27);
            this.gbAgregarEspecifico.TabIndex = 30;
            this.gbAgregarEspecifico.Text = "Agregar";
            this.gbAgregarEspecifico.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAgregarEspecifico.Click += new System.EventHandler(this.gbAgregarEspecifico_Click);
            // 
            // fullLabel13
            // 
            this.fullLabel13.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel13.ForeColor = System.Drawing.Color.Black;
            this.fullLabel13.Location = new System.Drawing.Point(423, 45);
            this.fullLabel13.Name = "fullLabel13";
            this.fullLabel13.Size = new System.Drawing.Size(62, 18);
            this.fullLabel13.TabIndex = 16;
            this.fullLabel13.Text = "Control:";
            // 
            // neEnkmEspecifico
            // 
            this.neEnkmEspecifico.BackColor = System.Drawing.SystemColors.Window;
            this.neEnkmEspecifico.Location = new System.Drawing.Point(195, 43);
            this.neEnkmEspecifico.Name = "neEnkmEspecifico";
            this.neEnkmEspecifico.Size = new System.Drawing.Size(51, 21);
            this.neEnkmEspecifico.TabIndex = 22;
            this.neEnkmEspecifico.Text = "0";
            // 
            // cdcControlesEspecifico
            // 
            this.cdcControlesEspecifico.BackColor = System.Drawing.SystemColors.Window;
            this.cdcControlesEspecifico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcControlesEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcControlesEspecifico.FormattingEnabled = true;
            this.cdcControlesEspecifico.Location = new System.Drawing.Point(485, 43);
            this.cdcControlesEspecifico.Name = "cdcControlesEspecifico";
            this.cdcControlesEspecifico.Size = new System.Drawing.Size(176, 23);
            this.cdcControlesEspecifico.Sorted = true;
            this.cdcControlesEspecifico.TabIndex = 6;
            // 
            // fullLabel14
            // 
            this.fullLabel14.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel14.ForeColor = System.Drawing.Color.Black;
            this.fullLabel14.Location = new System.Drawing.Point(159, 46);
            this.fullLabel14.Name = "fullLabel14";
            this.fullLabel14.Size = new System.Drawing.Size(30, 18);
            this.fullLabel14.TabIndex = 14;
            this.fullLabel14.Text = "En";
            // 
            // cdListaDestinatarios
            // 
            this.cdListaDestinatarios.FormattingEnabled = true;
            this.cdListaDestinatarios.ItemHeight = 15;
            this.cdListaDestinatarios.Location = new System.Drawing.Point(10, 89);
            this.cdListaDestinatarios.Name = "cdListaDestinatarios";
            this.cdListaDestinatarios.Size = new System.Drawing.Size(188, 199);
            this.cdListaDestinatarios.Sorted = true;
            this.cdListaDestinatarios.TabIndex = 110;
            // 
            // fullLabel15
            // 
            this.fullLabel15.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel15.Location = new System.Drawing.Point(44, 34);
            this.fullLabel15.Name = "fullLabel15";
            this.fullLabel15.Size = new System.Drawing.Size(98, 23);
            this.fullLabel15.TabIndex = 33;
            this.fullLabel15.Text = "Enviar Mails A:";
            // 
            // cdcGruposDestinatarios
            // 
            this.cdcGruposDestinatarios.BackColor = System.Drawing.SystemColors.Window;
            this.cdcGruposDestinatarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcGruposDestinatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcGruposDestinatarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcGruposDestinatarios.FormattingEnabled = true;
            this.cdcGruposDestinatarios.Location = new System.Drawing.Point(10, 57);
            this.cdcGruposDestinatarios.Name = "cdcGruposDestinatarios";
            this.cdcGruposDestinatarios.Size = new System.Drawing.Size(188, 23);
            this.cdcGruposDestinatarios.Sorted = true;
            this.cdcGruposDestinatarios.TabIndex = 32;
            this.cdcGruposDestinatarios.SelectedIndexChanged += new System.EventHandler(this.cdcGruposDestinatarios_SelectedIndexChanged);
            // 
            // AlertasForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.fgConfigAlertas);
            this.Controls.Add(this.cdcMoviles);
            this.Controls.Add(this.fullLabel6);
            this.Controls.Add(this.gbBorrarSeleccionados);
            this.Controls.Add(this.tgrpAñadirAlertas);
            this.Name = "AlertasForm";
            this.Size = new System.Drawing.Size(998, 614);
            this.Load += new System.EventHandler(this.Alertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fgConfigAlertas)).EndInit();
            this.tgrpAñadirAlertas.ResumeLayout(false);
            this.tgrpPostReparacion.ResumeLayout(false);
            this.tgrpPostReparacion.PerformLayout();
            this.tgrpPeriódicos.ResumeLayout(false);
            this.tgrpPeriódicos.PerformLayout();
            this.tgrpEspecifico.ResumeLayout(false);
            this.tgrpEspecifico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.FullGrid fgConfigAlertas;
        private TNGS.NetControls.CDCombo cdcMoviles;
        private TNGS.NetControls.FullLabel fullLabel6;
        private TNGS.NetControls.GlassButton gbBorrarSeleccionados;
        private TNGS.NetControls.ImgGroup tgrpAñadirAlertas;
        private TNGS.NetControls.ImgGroup tgrpPostReparacion;
        private TNGS.NetControls.CDCombo cdcReparacionesPostReparacion;
        private TNGS.NetControls.GlassButton gbAgregarPostReparacion;
        private TNGS.NetControls.FullLabel fullLabel7;
        private TNGS.NetControls.FullLabel fullLabel10;
        private TNGS.NetControls.CDCombo cdcControlesPostReparacion;
        private TNGS.NetControls.NumberEdit neEnkmPostReparacion;
        private TNGS.NetControls.FullLabel fullLabel9;
        private TNGS.NetControls.ImgGroup tgrpPeriódicos;
        private TNGS.NetControls.NumberEdit neHastaKmsPeriodicos;
        private TNGS.NetControls.GlassButton gbAgregarPeriodicos;
        private TNGS.NetControls.FullLabel fullLabel8;
        private TNGS.NetControls.FullLabel lblControl;
        private TNGS.NetControls.NumberEdit neCadaKmsPeriodicos;
        private TNGS.NetControls.CDCombo cdcControlesPeriodicos;
        private TNGS.NetControls.FullLabel fullLabel11;
        private TNGS.NetControls.FullLabel lblNroChasis;
        private TNGS.NetControls.NumberEdit neDesdeKmsPeriodicos;
        private TNGS.NetControls.ImgGroup tgrpEspecifico;
        private TNGS.NetControls.FullLabel fullLabel12;
        private TNGS.NetControls.GlassButton gbAgregarEspecifico;
        private TNGS.NetControls.FullLabel fullLabel13;
        private TNGS.NetControls.NumberEdit neEnkmEspecifico;
        private TNGS.NetControls.CDCombo cdcControlesEspecifico;
        private TNGS.NetControls.FullLabel fullLabel14;
        private TNGS.NetControls.CDList cdListaDestinatarios;
        private TNGS.NetControls.FullLabel fullLabel15;
        private TNGS.NetControls.CDCombo cdcGruposDestinatarios;
    }
}
