namespace Mrln.Mv
{
    partial class Alertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alertas));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.gbBorrarSeleccionados = new TNGS.NetControls.GlassButton();
            this.tgrpAñadirAlarmas = new TNGS.NetControls.TitledGroup();
            this.cdListaDestinatarios = new TNGS.NetControls.CDList();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.cdcGruposDestinatarios = new TNGS.NetControls.CDCombo();
            this.tgrpEspecifico = new TNGS.NetControls.TitledGroup();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.gbAgregarEspecifico = new TNGS.NetControls.GlassButton();
            this.neEnkmEspecifico = new TNGS.NetControls.NumberEdit();
            this.fullLabel7 = new TNGS.NetControls.FullLabel();
            this.cdcControlesEspecifico = new TNGS.NetControls.CDCombo();
            this.fullLabel8 = new TNGS.NetControls.FullLabel();
            this.tgrpPeriódicos = new TNGS.NetControls.TitledGroup();
            this.neHastaKmsPeriodicos = new TNGS.NetControls.NumberEdit();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.neCadaKmsPeriodicos = new TNGS.NetControls.NumberEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.gbAgregarPeriodicos = new TNGS.NetControls.GlassButton();
            this.neDesdeKmsPeriodicos = new TNGS.NetControls.NumberEdit();
            this.lblNroChasis = new TNGS.NetControls.FullLabel();
            this.cdcControlesPeriodicos = new TNGS.NetControls.CDCombo();
            this.lblControl = new TNGS.NetControls.FullLabel();
            this.tgrpPostReparacion = new TNGS.NetControls.TitledGroup();
            this.cdcReparacionesPostReparacion = new TNGS.NetControls.CDCombo();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.gbAgregarPostReparacion = new TNGS.NetControls.GlassButton();
            this.neEnkmPostReparacion = new TNGS.NetControls.NumberEdit();
            this.fullLabel9 = new TNGS.NetControls.FullLabel();
            this.cdcControlesPostReparacion = new TNGS.NetControls.CDCombo();
            this.fullLabel10 = new TNGS.NetControls.FullLabel();
            this.cdcMoviles = new TNGS.NetControls.CDCombo();
            this.fgConfigAlertas = new TNGS.NetControls.FullGrid();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.tgrpAñadirAlarmas.SuspendLayout();
            this.tgrpEspecifico.SuspendLayout();
            this.tgrpPeriódicos.SuspendLayout();
            this.tgrpPostReparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgConfigAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.gbBorrarSeleccionados);
            this.xPanel1.Controls.Add(this.tgrpAñadirAlarmas);
            this.xPanel1.Controls.Add(this.cdcMoviles);
            this.xPanel1.Controls.Add(this.fgConfigAlertas);
            this.xPanel1.Controls.Add(this.fullLabel4);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(1008, 651);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // gbBorrarSeleccionados
            // 
            this.gbBorrarSeleccionados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBorrarSeleccionados.BackgroundImage")));
            this.gbBorrarSeleccionados.BlackBorder = true;
            this.gbBorrarSeleccionados.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBorrarSeleccionados.CircleButton = false;
            this.gbBorrarSeleccionados.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Trash;
            this.gbBorrarSeleccionados.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbBorrarSeleccionados.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbBorrarSeleccionados.FlatFontSize = 9;
            this.gbBorrarSeleccionados.FlatTextColor = System.Drawing.Color.Black;
            this.gbBorrarSeleccionados.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBorrarSeleccionados.Location = new System.Drawing.Point(875, 588);
            this.gbBorrarSeleccionados.Name = "gbBorrarSeleccionados";
            this.gbBorrarSeleccionados.RoundCorners = 2;
            this.gbBorrarSeleccionados.Size = new System.Drawing.Size(126, 51);
            this.gbBorrarSeleccionados.TabIndex = 35;
            this.gbBorrarSeleccionados.Text = "Borrar Seleccionados";
            this.gbBorrarSeleccionados.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbBorrarSeleccionados.Click += new System.EventHandler(this.gbBorrarSeleccionados_Click);
            // 
            // tgrpAñadirAlarmas
            // 
            this.tgrpAñadirAlarmas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpAñadirAlarmas.BackgroundGradientColor = System.Drawing.Color.White;
            this.tgrpAñadirAlarmas.BackgroundGradientMode = TNGS.NetControls.TitledGroup.GroupBoxGradientMode.None;
            this.tgrpAñadirAlarmas.BlackBorder = true;
            this.tgrpAñadirAlarmas.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpAñadirAlarmas.BorderThickness = 1F;
            this.tgrpAñadirAlarmas.Controls.Add(this.cdListaDestinatarios);
            this.tgrpAñadirAlarmas.Controls.Add(this.fullLabel1);
            this.tgrpAñadirAlarmas.Controls.Add(this.cdcGruposDestinatarios);
            this.tgrpAñadirAlarmas.Controls.Add(this.tgrpEspecifico);
            this.tgrpAñadirAlarmas.Controls.Add(this.tgrpPeriódicos);
            this.tgrpAñadirAlarmas.Controls.Add(this.tgrpPostReparacion);
            this.tgrpAñadirAlarmas.CustomGroupBoxColor = System.Drawing.Color.White;
            this.tgrpAñadirAlarmas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tgrpAñadirAlarmas.ForeColor = System.Drawing.Color.Black;
            this.tgrpAñadirAlarmas.ImageGroup = null;
            this.tgrpAñadirAlarmas.Location = new System.Drawing.Point(8, 58);
            this.tgrpAñadirAlarmas.Name = "tgrpAñadirAlarmas";
            this.tgrpAñadirAlarmas.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpAñadirAlarmas.PaintGroupBox = false;
            this.tgrpAñadirAlarmas.RoundCorners = 4;
            this.tgrpAñadirAlarmas.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpAñadirAlarmas.ShadowControl = false;
            this.tgrpAñadirAlarmas.ShadowThickness = 3;
            this.tgrpAñadirAlarmas.Size = new System.Drawing.Size(993, 348);
            this.tgrpAñadirAlarmas.TabIndex = 34;
            this.tgrpAñadirAlarmas.Title = "Añadir Alarmas";
            this.tgrpAñadirAlarmas.TitleAlignment = TNGS.NetControls.TitledGroup.TitleAlign.Center;
            this.tgrpAñadirAlarmas.TitleBackground = System.Drawing.SystemColors.ControlDark;
            this.tgrpAñadirAlarmas.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpAñadirAlarmas.TitleFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgrpAñadirAlarmas.TitleFontColor = System.Drawing.Color.White;
            // 
            // cdListaDestinatarios
            // 
            this.cdListaDestinatarios.FormattingEnabled = true;
            this.cdListaDestinatarios.ItemHeight = 15;
            this.cdListaDestinatarios.Location = new System.Drawing.Point(4, 107);
            this.cdListaDestinatarios.Name = "cdListaDestinatarios";
            this.cdListaDestinatarios.Size = new System.Drawing.Size(207, 214);
            this.cdListaDestinatarios.Sorted = true;
            this.cdListaDestinatarios.TabIndex = 110;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(52, 52);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(98, 23);
            this.fullLabel1.TabIndex = 33;
            this.fullLabel1.Text = "Enviar Mails A:";
            // 
            // cdcGruposDestinatarios
            // 
            this.cdcGruposDestinatarios.BackColor = System.Drawing.SystemColors.Window;
            this.cdcGruposDestinatarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcGruposDestinatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcGruposDestinatarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcGruposDestinatarios.FormattingEnabled = true;
            this.cdcGruposDestinatarios.Location = new System.Drawing.Point(4, 75);
            this.cdcGruposDestinatarios.Name = "cdcGruposDestinatarios";
            this.cdcGruposDestinatarios.Size = new System.Drawing.Size(203, 23);
            this.cdcGruposDestinatarios.Sorted = true;
            this.cdcGruposDestinatarios.TabIndex = 32;
            this.cdcGruposDestinatarios.SelectedIndexChanged += new System.EventHandler(this.cdcGruposDestinatarios_SelectedIndexChanged);
            // 
            // tgrpEspecifico
            // 
            this.tgrpEspecifico.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpEspecifico.BackgroundGradientColor = System.Drawing.Color.White;
            this.tgrpEspecifico.BackgroundGradientMode = TNGS.NetControls.TitledGroup.GroupBoxGradientMode.None;
            this.tgrpEspecifico.BlackBorder = true;
            this.tgrpEspecifico.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpEspecifico.BorderThickness = 1F;
            this.tgrpEspecifico.Controls.Add(this.fullLabel6);
            this.tgrpEspecifico.Controls.Add(this.gbAgregarEspecifico);
            this.tgrpEspecifico.Controls.Add(this.neEnkmEspecifico);
            this.tgrpEspecifico.Controls.Add(this.fullLabel7);
            this.tgrpEspecifico.Controls.Add(this.cdcControlesEspecifico);
            this.tgrpEspecifico.Controls.Add(this.fullLabel8);
            this.tgrpEspecifico.CustomGroupBoxColor = System.Drawing.Color.White;
            this.tgrpEspecifico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tgrpEspecifico.ForeColor = System.Drawing.Color.Black;
            this.tgrpEspecifico.ImageGroup = null;
            this.tgrpEspecifico.Location = new System.Drawing.Point(217, 50);
            this.tgrpEspecifico.Name = "tgrpEspecifico";
            this.tgrpEspecifico.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpEspecifico.PaintGroupBox = false;
            this.tgrpEspecifico.RoundCorners = 4;
            this.tgrpEspecifico.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpEspecifico.ShadowControl = false;
            this.tgrpEspecifico.ShadowThickness = 3;
            this.tgrpEspecifico.Size = new System.Drawing.Size(762, 80);
            this.tgrpEspecifico.TabIndex = 30;
            this.tgrpEspecifico.Title = "Especifico";
            this.tgrpEspecifico.TitleAlignment = TNGS.NetControls.TitledGroup.TitleAlign.Left;
            this.tgrpEspecifico.TitleBackground = System.Drawing.SystemColors.HotTrack;
            this.tgrpEspecifico.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpEspecifico.TitleFont = new System.Drawing.Font("Segoe UI", 10F);
            this.tgrpEspecifico.TitleFontColor = System.Drawing.Color.White;
            // 
            // fullLabel6
            // 
            this.fullLabel6.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel6.ForeColor = System.Drawing.Color.Black;
            this.fullLabel6.Location = new System.Drawing.Point(263, 45);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(57, 18);
            this.fullLabel6.TabIndex = 31;
            this.fullLabel6.Text = "km";
            // 
            // gbAgregarEspecifico
            // 
            this.gbAgregarEspecifico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarEspecifico.BlackBorder = true;
            this.gbAgregarEspecifico.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarEspecifico.CircleButton = false;
            this.gbAgregarEspecifico.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAgregarEspecifico.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarEspecifico.FlatFontSize = 9;
            this.gbAgregarEspecifico.FlatTextColor = System.Drawing.Color.White;
            this.gbAgregarEspecifico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAgregarEspecifico.Location = new System.Drawing.Point(680, 39);
            this.gbAgregarEspecifico.Name = "gbAgregarEspecifico";
            this.gbAgregarEspecifico.Size = new System.Drawing.Size(68, 27);
            this.gbAgregarEspecifico.TabIndex = 30;
            this.gbAgregarEspecifico.Text = "Agregar";
            this.gbAgregarEspecifico.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAgregarEspecifico.Click += new System.EventHandler(this.gbAgregarEspecifico_Click);
            // 
            // neEnkmEspecifico
            // 
            this.neEnkmEspecifico.BackColor = System.Drawing.SystemColors.Window;
            this.neEnkmEspecifico.Location = new System.Drawing.Point(205, 42);
            this.neEnkmEspecifico.Name = "neEnkmEspecifico";
            this.neEnkmEspecifico.Size = new System.Drawing.Size(51, 23);
            this.neEnkmEspecifico.TabIndex = 22;
            this.neEnkmEspecifico.Text = "0";
            // 
            // fullLabel7
            // 
            this.fullLabel7.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel7.ForeColor = System.Drawing.Color.Black;
            this.fullLabel7.Location = new System.Drawing.Point(169, 45);
            this.fullLabel7.Name = "fullLabel7";
            this.fullLabel7.Size = new System.Drawing.Size(30, 18);
            this.fullLabel7.TabIndex = 14;
            this.fullLabel7.Text = "En";
            // 
            // cdcControlesEspecifico
            // 
            this.cdcControlesEspecifico.BackColor = System.Drawing.SystemColors.Window;
            this.cdcControlesEspecifico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcControlesEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcControlesEspecifico.FormattingEnabled = true;
            this.cdcControlesEspecifico.Location = new System.Drawing.Point(488, 40);
            this.cdcControlesEspecifico.Name = "cdcControlesEspecifico";
            this.cdcControlesEspecifico.Size = new System.Drawing.Size(176, 23);
            this.cdcControlesEspecifico.Sorted = true;
            this.cdcControlesEspecifico.TabIndex = 6;
            // 
            // fullLabel8
            // 
            this.fullLabel8.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel8.ForeColor = System.Drawing.Color.Black;
            this.fullLabel8.Location = new System.Drawing.Point(427, 45);
            this.fullLabel8.Name = "fullLabel8";
            this.fullLabel8.Size = new System.Drawing.Size(62, 18);
            this.fullLabel8.TabIndex = 16;
            this.fullLabel8.Text = "Control:";
            // 
            // tgrpPeriódicos
            // 
            this.tgrpPeriódicos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpPeriódicos.BackgroundGradientColor = System.Drawing.Color.White;
            this.tgrpPeriódicos.BackgroundGradientMode = TNGS.NetControls.TitledGroup.GroupBoxGradientMode.None;
            this.tgrpPeriódicos.BlackBorder = true;
            this.tgrpPeriódicos.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpPeriódicos.BorderThickness = 1F;
            this.tgrpPeriódicos.Controls.Add(this.neHastaKmsPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.fullLabel3);
            this.tgrpPeriódicos.Controls.Add(this.neCadaKmsPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.fullLabel2);
            this.tgrpPeriódicos.Controls.Add(this.gbAgregarPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.neDesdeKmsPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.lblNroChasis);
            this.tgrpPeriódicos.Controls.Add(this.cdcControlesPeriodicos);
            this.tgrpPeriódicos.Controls.Add(this.lblControl);
            this.tgrpPeriódicos.CustomGroupBoxColor = System.Drawing.Color.White;
            this.tgrpPeriódicos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tgrpPeriódicos.ForeColor = System.Drawing.Color.Black;
            this.tgrpPeriódicos.ImageGroup = null;
            this.tgrpPeriódicos.Location = new System.Drawing.Point(217, 146);
            this.tgrpPeriódicos.Name = "tgrpPeriódicos";
            this.tgrpPeriódicos.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpPeriódicos.PaintGroupBox = false;
            this.tgrpPeriódicos.RoundCorners = 4;
            this.tgrpPeriódicos.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpPeriódicos.ShadowControl = false;
            this.tgrpPeriódicos.ShadowThickness = 3;
            this.tgrpPeriódicos.Size = new System.Drawing.Size(762, 80);
            this.tgrpPeriódicos.TabIndex = 27;
            this.tgrpPeriódicos.Title = "Periódicos";
            this.tgrpPeriódicos.TitleAlignment = TNGS.NetControls.TitledGroup.TitleAlign.Left;
            this.tgrpPeriódicos.TitleBackground = System.Drawing.SystemColors.HotTrack;
            this.tgrpPeriódicos.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpPeriódicos.TitleFont = new System.Drawing.Font("Segoe UI", 10F);
            this.tgrpPeriódicos.TitleFontColor = System.Drawing.Color.White;
            // 
            // neHastaKmsPeriodicos
            // 
            this.neHastaKmsPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.neHastaKmsPeriodicos.Location = new System.Drawing.Point(317, 42);
            this.neHastaKmsPeriodicos.Name = "neHastaKmsPeriodicos";
            this.neHastaKmsPeriodicos.Size = new System.Drawing.Size(51, 23);
            this.neHastaKmsPeriodicos.TabIndex = 34;
            this.neHastaKmsPeriodicos.Text = "0";
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.ForeColor = System.Drawing.Color.Black;
            this.fullLabel3.Location = new System.Drawing.Point(260, 46);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(61, 18);
            this.fullLabel3.TabIndex = 33;
            this.fullLabel3.Text = ",    hasta";
            // 
            // neCadaKmsPeriodicos
            // 
            this.neCadaKmsPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.neCadaKmsPeriodicos.Location = new System.Drawing.Point(205, 42);
            this.neCadaKmsPeriodicos.Name = "neCadaKmsPeriodicos";
            this.neCadaKmsPeriodicos.Size = new System.Drawing.Size(51, 23);
            this.neCadaKmsPeriodicos.TabIndex = 32;
            this.neCadaKmsPeriodicos.Text = "0";
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.ForeColor = System.Drawing.Color.Black;
            this.fullLabel2.Location = new System.Drawing.Point(154, 46);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(57, 18);
            this.fullLabel2.TabIndex = 31;
            this.fullLabel2.Text = ",   cada";
            // 
            // gbAgregarPeriodicos
            // 
            this.gbAgregarPeriodicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarPeriodicos.BlackBorder = true;
            this.gbAgregarPeriodicos.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarPeriodicos.CircleButton = false;
            this.gbAgregarPeriodicos.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAgregarPeriodicos.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarPeriodicos.FlatFontSize = 9;
            this.gbAgregarPeriodicos.FlatTextColor = System.Drawing.Color.White;
            this.gbAgregarPeriodicos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAgregarPeriodicos.Location = new System.Drawing.Point(680, 39);
            this.gbAgregarPeriodicos.Name = "gbAgregarPeriodicos";
            this.gbAgregarPeriodicos.Size = new System.Drawing.Size(68, 27);
            this.gbAgregarPeriodicos.TabIndex = 30;
            this.gbAgregarPeriodicos.Text = "Agregar";
            this.gbAgregarPeriodicos.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAgregarPeriodicos.Click += new System.EventHandler(this.gbAgregarPeriodicos_Click);
            // 
            // neDesdeKmsPeriodicos
            // 
            this.neDesdeKmsPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.neDesdeKmsPeriodicos.Location = new System.Drawing.Point(98, 42);
            this.neDesdeKmsPeriodicos.Name = "neDesdeKmsPeriodicos";
            this.neDesdeKmsPeriodicos.Size = new System.Drawing.Size(51, 23);
            this.neDesdeKmsPeriodicos.TabIndex = 22;
            this.neDesdeKmsPeriodicos.Text = "0";
            // 
            // lblNroChasis
            // 
            this.lblNroChasis.BackColor = System.Drawing.Color.Transparent;
            this.lblNroChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroChasis.ForeColor = System.Drawing.Color.Black;
            this.lblNroChasis.Location = new System.Drawing.Point(45, 46);
            this.lblNroChasis.Name = "lblNroChasis";
            this.lblNroChasis.Size = new System.Drawing.Size(56, 18);
            this.lblNroChasis.TabIndex = 14;
            this.lblNroChasis.Text = "Desde";
            // 
            // cdcControlesPeriodicos
            // 
            this.cdcControlesPeriodicos.BackColor = System.Drawing.SystemColors.Window;
            this.cdcControlesPeriodicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcControlesPeriodicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcControlesPeriodicos.FormattingEnabled = true;
            this.cdcControlesPeriodicos.Location = new System.Drawing.Point(488, 44);
            this.cdcControlesPeriodicos.Name = "cdcControlesPeriodicos";
            this.cdcControlesPeriodicos.Size = new System.Drawing.Size(176, 23);
            this.cdcControlesPeriodicos.Sorted = true;
            this.cdcControlesPeriodicos.TabIndex = 6;
            // 
            // lblControl
            // 
            this.lblControl.BackColor = System.Drawing.Color.Transparent;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.Color.Black;
            this.lblControl.Location = new System.Drawing.Point(429, 46);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(59, 18);
            this.lblControl.TabIndex = 16;
            this.lblControl.Text = "Control:";
            // 
            // tgrpPostReparacion
            // 
            this.tgrpPostReparacion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpPostReparacion.BackgroundGradientColor = System.Drawing.Color.White;
            this.tgrpPostReparacion.BackgroundGradientMode = TNGS.NetControls.TitledGroup.GroupBoxGradientMode.None;
            this.tgrpPostReparacion.BlackBorder = true;
            this.tgrpPostReparacion.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpPostReparacion.BorderThickness = 1F;
            this.tgrpPostReparacion.Controls.Add(this.cdcReparacionesPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.fullLabel5);
            this.tgrpPostReparacion.Controls.Add(this.gbAgregarPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.neEnkmPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.fullLabel9);
            this.tgrpPostReparacion.Controls.Add(this.cdcControlesPostReparacion);
            this.tgrpPostReparacion.Controls.Add(this.fullLabel10);
            this.tgrpPostReparacion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.tgrpPostReparacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tgrpPostReparacion.ForeColor = System.Drawing.Color.Black;
            this.tgrpPostReparacion.ImageGroup = null;
            this.tgrpPostReparacion.Location = new System.Drawing.Point(217, 244);
            this.tgrpPostReparacion.Name = "tgrpPostReparacion";
            this.tgrpPostReparacion.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpPostReparacion.PaintGroupBox = false;
            this.tgrpPostReparacion.RoundCorners = 4;
            this.tgrpPostReparacion.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpPostReparacion.ShadowControl = false;
            this.tgrpPostReparacion.ShadowThickness = 3;
            this.tgrpPostReparacion.Size = new System.Drawing.Size(762, 80);
            this.tgrpPostReparacion.TabIndex = 31;
            this.tgrpPostReparacion.Title = "Post Reparación";
            this.tgrpPostReparacion.TitleAlignment = TNGS.NetControls.TitledGroup.TitleAlign.Left;
            this.tgrpPostReparacion.TitleBackground = System.Drawing.SystemColors.HotTrack;
            this.tgrpPostReparacion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpPostReparacion.TitleFont = new System.Drawing.Font("Segoe UI", 10F);
            this.tgrpPostReparacion.TitleFontColor = System.Drawing.Color.White;
            // 
            // cdcReparacionesPostReparacion
            // 
            this.cdcReparacionesPostReparacion.BackColor = System.Drawing.SystemColors.Window;
            this.cdcReparacionesPostReparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcReparacionesPostReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcReparacionesPostReparacion.FormattingEnabled = true;
            this.cdcReparacionesPostReparacion.Location = new System.Drawing.Point(223, 42);
            this.cdcReparacionesPostReparacion.Name = "cdcReparacionesPostReparacion";
            this.cdcReparacionesPostReparacion.Size = new System.Drawing.Size(196, 23);
            this.cdcReparacionesPostReparacion.Sorted = true;
            this.cdcReparacionesPostReparacion.TabIndex = 32;
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.ForeColor = System.Drawing.Color.Black;
            this.fullLabel5.Location = new System.Drawing.Point(90, 45);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(140, 18);
            this.fullLabel5.TabIndex = 31;
            this.fullLabel5.Text = "km    post reparación";
            // 
            // gbAgregarPostReparacion
            // 
            this.gbAgregarPostReparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgregarPostReparacion.BlackBorder = true;
            this.gbAgregarPostReparacion.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarPostReparacion.CircleButton = false;
            this.gbAgregarPostReparacion.FlatColor = System.Drawing.Color.LimeGreen;
            this.gbAgregarPostReparacion.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregarPostReparacion.FlatFontSize = 9;
            this.gbAgregarPostReparacion.FlatTextColor = System.Drawing.Color.White;
            this.gbAgregarPostReparacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAgregarPostReparacion.Location = new System.Drawing.Point(680, 39);
            this.gbAgregarPostReparacion.Name = "gbAgregarPostReparacion";
            this.gbAgregarPostReparacion.Size = new System.Drawing.Size(68, 27);
            this.gbAgregarPostReparacion.TabIndex = 30;
            this.gbAgregarPostReparacion.Text = "Agregar";
            this.gbAgregarPostReparacion.W8Color = System.Drawing.Color.LimeGreen;
            this.gbAgregarPostReparacion.Click += new System.EventHandler(this.gbAgregarPostReparacion_Click);
            // 
            // neEnkmPostReparacion
            // 
            this.neEnkmPostReparacion.BackColor = System.Drawing.SystemColors.Window;
            this.neEnkmPostReparacion.Location = new System.Drawing.Point(35, 42);
            this.neEnkmPostReparacion.Name = "neEnkmPostReparacion";
            this.neEnkmPostReparacion.Size = new System.Drawing.Size(51, 23);
            this.neEnkmPostReparacion.TabIndex = 22;
            this.neEnkmPostReparacion.Text = "0";
            // 
            // fullLabel9
            // 
            this.fullLabel9.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel9.ForeColor = System.Drawing.Color.Black;
            this.fullLabel9.Location = new System.Drawing.Point(9, 45);
            this.fullLabel9.Name = "fullLabel9";
            this.fullLabel9.Size = new System.Drawing.Size(30, 18);
            this.fullLabel9.TabIndex = 14;
            this.fullLabel9.Text = "En";
            // 
            // cdcControlesPostReparacion
            // 
            this.cdcControlesPostReparacion.BackColor = System.Drawing.SystemColors.Window;
            this.cdcControlesPostReparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcControlesPostReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcControlesPostReparacion.FormattingEnabled = true;
            this.cdcControlesPostReparacion.Location = new System.Drawing.Point(488, 42);
            this.cdcControlesPostReparacion.Name = "cdcControlesPostReparacion";
            this.cdcControlesPostReparacion.Size = new System.Drawing.Size(176, 23);
            this.cdcControlesPostReparacion.Sorted = true;
            this.cdcControlesPostReparacion.TabIndex = 6;
            // 
            // fullLabel10
            // 
            this.fullLabel10.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel10.ForeColor = System.Drawing.Color.Black;
            this.fullLabel10.Location = new System.Drawing.Point(427, 45);
            this.fullLabel10.Name = "fullLabel10";
            this.fullLabel10.Size = new System.Drawing.Size(59, 18);
            this.fullLabel10.TabIndex = 16;
            this.fullLabel10.Text = "Control:";
            // 
            // cdcMoviles
            // 
            this.cdcMoviles.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMoviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMoviles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcMoviles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcMoviles.FormattingEnabled = true;
            this.cdcMoviles.Location = new System.Drawing.Point(113, 16);
            this.cdcMoviles.Name = "cdcMoviles";
            this.cdcMoviles.Size = new System.Drawing.Size(194, 23);
            this.cdcMoviles.Sorted = true;
            this.cdcMoviles.TabIndex = 28;
            this.cdcMoviles.SelectedIndexChanged += new System.EventHandler(this.cdcMoviles_SelectedIndexChanged);
            // 
            // fgConfigAlertas
            // 
            this.fgConfigAlertas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgConfigAlertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgConfigAlertas.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgConfigAlertas.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgConfigAlertas.CaptionText = "Configuraciónes Alarmas";
            this.fgConfigAlertas.DataMember = "";
            this.fgConfigAlertas.ExcelTitle = "";
            this.fgConfigAlertas.GridOrder = "";
            this.fgConfigAlertas.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgConfigAlertas.Location = new System.Drawing.Point(12, 428);
            this.fgConfigAlertas.Name = "fgConfigAlertas";
            this.fgConfigAlertas.Size = new System.Drawing.Size(853, 211);
            this.fgConfigAlertas.SkinFixed = true;
            this.fgConfigAlertas.TabIndex = 32;
            this.fgConfigAlertas.WithCheckBoxes = true;
            // 
            // fullLabel4
            // 
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(18, 19);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(98, 23);
            this.fullLabel4.TabIndex = 29;
            this.fullLabel4.Text = "Movil Patente:";
            // 
            // Alertas
            // 
            this.AllowEndUserDocking = false;
            this.ClientSize = new System.Drawing.Size(1008, 651);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alertas";
            this.ShowIcon = false;
            this.Text = "Alertas";
            this.Load += new System.EventHandler(this.Alertas_Load);
            this.xPanel1.ResumeLayout(false);
            this.tgrpAñadirAlarmas.ResumeLayout(false);
            this.tgrpEspecifico.ResumeLayout(false);
            this.tgrpEspecifico.PerformLayout();
            this.tgrpPeriódicos.ResumeLayout(false);
            this.tgrpPeriódicos.PerformLayout();
            this.tgrpPostReparacion.ResumeLayout(false);
            this.tgrpPostReparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgConfigAlertas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.FullLabel lblControl;
        private TNGS.NetControls.FullLabel lblNroChasis;
        private TNGS.NetControls.CDCombo cdcControlesPeriodicos;
        private TNGS.NetControls.TitledGroup tgrpPeriódicos;
        private TNGS.NetControls.CDCombo cdcMoviles;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.NumberEdit neDesdeKmsPeriodicos;
        private TNGS.NetControls.NumberEdit neHastaKmsPeriodicos;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.NumberEdit neCadaKmsPeriodicos;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.GlassButton gbAgregarPeriodicos;
        private TNGS.NetControls.TitledGroup tgrpEspecifico;
        private TNGS.NetControls.FullLabel fullLabel6;
        private TNGS.NetControls.GlassButton gbAgregarEspecifico;
        private TNGS.NetControls.NumberEdit neEnkmEspecifico;
        private TNGS.NetControls.FullLabel fullLabel7;
        private TNGS.NetControls.CDCombo cdcControlesEspecifico;
        private TNGS.NetControls.FullLabel fullLabel8;
        private TNGS.NetControls.TitledGroup tgrpPostReparacion;
        private TNGS.NetControls.CDCombo cdcReparacionesPostReparacion;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.GlassButton gbAgregarPostReparacion;
        private TNGS.NetControls.NumberEdit neEnkmPostReparacion;
        private TNGS.NetControls.FullLabel fullLabel9;
        private TNGS.NetControls.CDCombo cdcControlesPostReparacion;
        private TNGS.NetControls.FullLabel fullLabel10;
        private TNGS.NetControls.FullGrid fgConfigAlertas;
        private TNGS.NetControls.TitledGroup tgrpAñadirAlarmas;
        private TNGS.NetControls.GlassButton gbBorrarSeleccionados;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.CDCombo cdcGruposDestinatarios;
        private TNGS.NetControls.CDList cdListaDestinatarios;
    }
}