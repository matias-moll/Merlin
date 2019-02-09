﻿using WeifenLuo.WinFormsUI.Docking;
namespace Mrln.Mv
{
    partial class Moviles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moviles));
            this.xpnlPanelAtras = new TNGS.NetControls.XPanel();
            this.tgrpMoviles = new TNGS.NetControls.ImgGroup();
            this.teTipoMovil = new TNGS.NetControls.TextEdit();
            this.ftrMoviles = new TNGS.NetControls.FullTreeView();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.lblModelo = new TNGS.NetControls.FullLabel();
            this.teEstado = new TNGS.NetControls.TextEdit();
            this.tePatente = new TNGS.NetControls.TextEdit();
            this.lblEstado = new TNGS.NetControls.FullLabel();
            this.teModelo = new TNGS.NetControls.TextEdit();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.pnlOpcionesEspecificas = new TNGS.NetControls.TSPanel();
            this.gbInfracciones = new TNGS.NetControls.GlassButton();
            this.gbAccidentes = new TNGS.NetControls.GlassButton();
            this.gbHistorialCompleto = new TNGS.NetControls.GlassButton();
            this.gbCargarNafta = new TNGS.NetControls.GlassButton();
            this.gbAgregarKMs = new TNGS.NetControls.GlassButton();
            this.gbModificarMovil = new TNGS.NetControls.GlassButton();
            this.gbCambiarEstado = new TNGS.NetControls.GlassButton();
            this.pnlOpcionesGenerales = new TNGS.NetControls.TSPanel();
            this.gbNuevoMovil = new TNGS.NetControls.GlassButton();
            this.gbBorrarMovil = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.fgMovilEstados = new TNGS.NetControls.FullGrid();
            this.fgCombustibles = new TNGS.NetControls.FullGrid();
            this.fgEquipamiento = new TNGS.NetControls.FullGrid();
            this.fgKm = new TNGS.NetControls.FullGrid();
            this.xpnlPanelAtras.SuspendLayout();
            this.tgrpMoviles.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.pnlOpcionesEspecificas.SuspendLayout();
            this.pnlOpcionesGenerales.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).BeginInit();
            this.SuspendLayout();
            // 
            // xpnlPanelAtras
            // 
            this.xpnlPanelAtras.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanelAtras.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanelAtras.Controls.Add(this.tgrpMoviles);
            this.xpnlPanelAtras.Controls.Add(this.fullLabel4);
            this.xpnlPanelAtras.Controls.Add(this.fullLabel3);
            this.xpnlPanelAtras.Controls.Add(this.fullLabel2);
            this.xpnlPanelAtras.Controls.Add(this.fullLabel1);
            this.xpnlPanelAtras.Controls.Add(this.tsContainer1);
            this.xpnlPanelAtras.Controls.Add(this.fgMovilEstados);
            this.xpnlPanelAtras.Controls.Add(this.fgCombustibles);
            this.xpnlPanelAtras.Controls.Add(this.fgEquipamiento);
            this.xpnlPanelAtras.Controls.Add(this.fgKm);
            this.xpnlPanelAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanelAtras.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanelAtras.Name = "xpnlPanelAtras";
            this.xpnlPanelAtras.Size = new System.Drawing.Size(1008, 673);
            this.xpnlPanelAtras.SkinFixed = true;
            this.xpnlPanelAtras.TabIndex = 0;
            // 
            // tgrpMoviles
            // 
            this.tgrpMoviles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpMoviles.BackgroundGradientColor = System.Drawing.Color.White;
            this.tgrpMoviles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.tgrpMoviles.BlackBorder = true;
            this.tgrpMoviles.BorderColor = System.Drawing.Color.Black;
            this.tgrpMoviles.BorderThickness = 1F;
            this.tgrpMoviles.Controls.Add(this.teTipoMovil);
            this.tgrpMoviles.Controls.Add(this.ftrMoviles);
            this.tgrpMoviles.Controls.Add(this.fullLabel5);
            this.tgrpMoviles.Controls.Add(this.lblModelo);
            this.tgrpMoviles.Controls.Add(this.teEstado);
            this.tgrpMoviles.Controls.Add(this.tePatente);
            this.tgrpMoviles.Controls.Add(this.lblEstado);
            this.tgrpMoviles.Controls.Add(this.teModelo);
            this.tgrpMoviles.Controls.Add(this.lblPatente);
            this.tgrpMoviles.CustomGroupBoxColor = System.Drawing.Color.White;
            this.tgrpMoviles.FlatMode = true;
            this.tgrpMoviles.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpMoviles.ForeColor = System.Drawing.Color.Black;
            this.tgrpMoviles.GroupImage = null;
            this.tgrpMoviles.GroupTitle = "Móviles";
            this.tgrpMoviles.Location = new System.Drawing.Point(4, 118);
            this.tgrpMoviles.Name = "tgrpMoviles";
            this.tgrpMoviles.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpMoviles.PaintGroupBox = false;
            this.tgrpMoviles.RoundCorners = 4;
            this.tgrpMoviles.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpMoviles.ShadowControl = false;
            this.tgrpMoviles.ShadowThickness = 3;
            this.tgrpMoviles.Size = new System.Drawing.Size(233, 543);
            this.tgrpMoviles.TabIndex = 39;
            this.tgrpMoviles.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.tgrpMoviles.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpMoviles.TitleFontColor = System.Drawing.Color.White;
            // 
            // teTipoMovil
            // 
            this.teTipoMovil.BackColor = System.Drawing.SystemColors.Window;
            this.teTipoMovil.Enabled = false;
            this.teTipoMovil.Location = new System.Drawing.Point(80, 457);
            this.teTipoMovil.Name = "teTipoMovil";
            this.teTipoMovil.Size = new System.Drawing.Size(138, 21);
            this.teTipoMovil.TabIndex = 27;
            this.teTipoMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ftrMoviles
            // 
            this.ftrMoviles.IgnoreLevelInFill = false;
            this.ftrMoviles.Location = new System.Drawing.Point(12, 32);
            this.ftrMoviles.Name = "ftrMoviles";
            this.ftrMoviles.Size = new System.Drawing.Size(206, 392);
            this.ftrMoviles.TabIndex = 0;
            this.ftrMoviles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ftrMoviles_AfterSelect);
            this.ftrMoviles.DoubleClick += new System.EventHandler(this.ftrMoviles_DoubleClick);
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.ForeColor = System.Drawing.Color.Black;
            this.fullLabel5.Location = new System.Drawing.Point(16, 457);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(55, 18);
            this.fullLabel5.TabIndex = 26;
            this.fullLabel5.Text = "Tipo:";
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(16, 485);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 18);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo:";
            // 
            // teEstado
            // 
            this.teEstado.BackColor = System.Drawing.SystemColors.Window;
            this.teEstado.Enabled = false;
            this.teEstado.Location = new System.Drawing.Point(80, 511);
            this.teEstado.Name = "teEstado";
            this.teEstado.Size = new System.Drawing.Size(138, 21);
            this.teEstado.TabIndex = 25;
            this.teEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.Enabled = false;
            this.tePatente.Location = new System.Drawing.Point(80, 430);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(138, 21);
            this.tePatente.TabIndex = 7;
            this.tePatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(16, 511);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // teModelo
            // 
            this.teModelo.BackColor = System.Drawing.SystemColors.Window;
            this.teModelo.Enabled = false;
            this.teModelo.Location = new System.Drawing.Point(80, 484);
            this.teModelo.Name = "teModelo";
            this.teModelo.Size = new System.Drawing.Size(138, 21);
            this.teModelo.TabIndex = 24;
            this.teModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(16, 432);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(58, 18);
            this.lblPatente.TabIndex = 8;
            this.lblPatente.Text = "Patente:";
            // 
            // fullLabel4
            // 
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(752, 410);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(100, 15);
            this.fullLabel4.TabIndex = 37;
            this.fullLabel4.Text = "Estado";
            this.fullLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.Location = new System.Drawing.Point(752, 139);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(100, 15);
            this.fullLabel3.TabIndex = 36;
            this.fullLabel3.Text = "Combustible";
            this.fullLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(370, 410);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(100, 15);
            this.fullLabel2.TabIndex = 35;
            this.fullLabel2.Text = "Equipamiento";
            this.fullLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(370, 139);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(100, 15);
            this.fullLabel1.TabIndex = 34;
            this.fullLabel1.Text = "Kilometros";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(1008, 115);
            this.tsContainer1.TabIndex = 33;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(1008, 89);
            this.tabPageSwitcher1.TabIndex = 1;
            this.tabPageSwitcher1.TabStrip = this.tsBase1;
            this.tabPageSwitcher1.Text = "tabPageSwitcher1";
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.pnlOpcionesEspecificas);
            this.tabStripPage1.Controls.Add(this.pnlOpcionesGenerales);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(1000, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // pnlOpcionesEspecificas
            // 
            this.pnlOpcionesEspecificas.Caption = "Operaciones Sobre Movil Seleccionado";
            this.pnlOpcionesEspecificas.Controls.Add(this.gbInfracciones);
            this.pnlOpcionesEspecificas.Controls.Add(this.gbAccidentes);
            this.pnlOpcionesEspecificas.Controls.Add(this.gbHistorialCompleto);
            this.pnlOpcionesEspecificas.Controls.Add(this.gbCargarNafta);
            this.pnlOpcionesEspecificas.Controls.Add(this.gbAgregarKMs);
            this.pnlOpcionesEspecificas.Controls.Add(this.gbModificarMovil);
            this.pnlOpcionesEspecificas.Controls.Add(this.gbCambiarEstado);
            this.pnlOpcionesEspecificas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpcionesEspecificas.Location = new System.Drawing.Point(233, 3);
            this.pnlOpcionesEspecificas.Name = "pnlOpcionesEspecificas";
            this.pnlOpcionesEspecificas.Opacity = 255;
            this.pnlOpcionesEspecificas.Size = new System.Drawing.Size(767, 85);
            this.pnlOpcionesEspecificas.Speed = 1;
            this.pnlOpcionesEspecificas.TabIndex = 1;
            // 
            // gbInfracciones
            // 
            this.gbInfracciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbInfracciones.BackgroundImage")));
            this.gbInfracciones.BlackBorder = true;
            this.gbInfracciones.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbInfracciones.CircleButton = false;
            this.gbInfracciones.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Note;
            this.gbInfracciones.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbInfracciones.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbInfracciones.FlatFontSize = 9;
            this.gbInfracciones.FlatTextColor = System.Drawing.Color.Black;
            this.gbInfracciones.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbInfracciones.ImageOnTop = true;
            this.gbInfracciones.Location = new System.Drawing.Point(666, 3);
            this.gbInfracciones.Name = "gbInfracciones";
            this.gbInfracciones.RoundCorners = 2;
            this.gbInfracciones.Size = new System.Drawing.Size(93, 60);
            this.gbInfracciones.TabIndex = 33;
            this.gbInfracciones.Text = "Infracciónes";
            this.gbInfracciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbInfracciones.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbInfracciones.Click += new System.EventHandler(this.gbInfracciones_Click);
            // 
            // gbAccidentes
            // 
            this.gbAccidentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAccidentes.BackgroundImage")));
            this.gbAccidentes.BlackBorder = true;
            this.gbAccidentes.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAccidentes.CircleButton = false;
            this.gbAccidentes.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Warning;
            this.gbAccidentes.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAccidentes.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAccidentes.FlatFontSize = 9;
            this.gbAccidentes.FlatTextColor = System.Drawing.Color.Black;
            this.gbAccidentes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAccidentes.ImageOnTop = true;
            this.gbAccidentes.Location = new System.Drawing.Point(567, 3);
            this.gbAccidentes.Name = "gbAccidentes";
            this.gbAccidentes.RoundCorners = 2;
            this.gbAccidentes.Size = new System.Drawing.Size(93, 60);
            this.gbAccidentes.TabIndex = 32;
            this.gbAccidentes.Text = "Accidentes";
            this.gbAccidentes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbAccidentes.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAccidentes.Click += new System.EventHandler(this.gbAccidentes_Click);
            // 
            // gbHistorialCompleto
            // 
            this.gbHistorialCompleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbHistorialCompleto.BackgroundImage")));
            this.gbHistorialCompleto.BlackBorder = true;
            this.gbHistorialCompleto.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbHistorialCompleto.CircleButton = false;
            this.gbHistorialCompleto.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.gbHistorialCompleto.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbHistorialCompleto.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbHistorialCompleto.FlatFontSize = 9;
            this.gbHistorialCompleto.FlatTextColor = System.Drawing.Color.Black;
            this.gbHistorialCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbHistorialCompleto.Location = new System.Drawing.Point(9, 3);
            this.gbHistorialCompleto.Name = "gbHistorialCompleto";
            this.gbHistorialCompleto.RoundCorners = 2;
            this.gbHistorialCompleto.Size = new System.Drawing.Size(101, 60);
            this.gbHistorialCompleto.TabIndex = 31;
            this.gbHistorialCompleto.Text = "Historial Unificado";
            this.gbHistorialCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbHistorialCompleto.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbHistorialCompleto.Click += new System.EventHandler(this.gbHistorialCompleto_Click);
            // 
            // gbCargarNafta
            // 
            this.gbCargarNafta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCargarNafta.BackgroundImage")));
            this.gbCargarNafta.BlackBorder = true;
            this.gbCargarNafta.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCargarNafta.CircleButton = false;
            this.gbCargarNafta.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCargarNafta.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCargarNafta.FlatFontSize = 9;
            this.gbCargarNafta.FlatTextColor = System.Drawing.Color.Black;
            this.gbCargarNafta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCargarNafta.ImageOnTop = true;
            this.gbCargarNafta.Location = new System.Drawing.Point(455, 3);
            this.gbCargarNafta.Name = "gbCargarNafta";
            this.gbCargarNafta.RoundCorners = 2;
            this.gbCargarNafta.Size = new System.Drawing.Size(93, 60);
            this.gbCargarNafta.TabIndex = 2;
            this.gbCargarNafta.Text = "Cargar Nafta";
            this.gbCargarNafta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCargarNafta.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbCargarNafta.Click += new System.EventHandler(this.gbAgregarCombustible_Click);
            // 
            // gbAgregarKMs
            // 
            this.gbAgregarKMs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAgregarKMs.BackgroundImage")));
            this.gbAgregarKMs.BlackBorder = true;
            this.gbAgregarKMs.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarKMs.CircleButton = false;
            this.gbAgregarKMs.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAgregarKMs.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAgregarKMs.FlatFontSize = 9;
            this.gbAgregarKMs.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarKMs.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAgregarKMs.ImageOnTop = true;
            this.gbAgregarKMs.Location = new System.Drawing.Point(352, 3);
            this.gbAgregarKMs.Name = "gbAgregarKMs";
            this.gbAgregarKMs.RoundCorners = 2;
            this.gbAgregarKMs.Size = new System.Drawing.Size(98, 60);
            this.gbAgregarKMs.TabIndex = 1;
            this.gbAgregarKMs.Text = "Agregar Kms";
            this.gbAgregarKMs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbAgregarKMs.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAgregarKMs.Click += new System.EventHandler(this.gbNuevoKM_Click);
            // 
            // gbModificarMovil
            // 
            this.gbModificarMovil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbModificarMovil.BackgroundImage")));
            this.gbModificarMovil.BlackBorder = true;
            this.gbModificarMovil.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbModificarMovil.CircleButton = false;
            this.gbModificarMovil.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.gbModificarMovil.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbModificarMovil.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbModificarMovil.FlatFontSize = 9;
            this.gbModificarMovil.FlatTextColor = System.Drawing.Color.Black;
            this.gbModificarMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbModificarMovil.Location = new System.Drawing.Point(115, 3);
            this.gbModificarMovil.Name = "gbModificarMovil";
            this.gbModificarMovil.RoundCorners = 2;
            this.gbModificarMovil.Size = new System.Drawing.Size(101, 60);
            this.gbModificarMovil.TabIndex = 30;
            this.gbModificarMovil.Text = "Modificar";
            this.gbModificarMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificarMovil.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbModificarMovil.Click += new System.EventHandler(this.gbModificarMovil_Click);
            // 
            // gbCambiarEstado
            // 
            this.gbCambiarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCambiarEstado.BackgroundImage")));
            this.gbCambiarEstado.BlackBorder = true;
            this.gbCambiarEstado.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCambiarEstado.CircleButton = false;
            this.gbCambiarEstado.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCambiarEstado.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCambiarEstado.FlatFontSize = 9;
            this.gbCambiarEstado.FlatTextColor = System.Drawing.Color.Black;
            this.gbCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCambiarEstado.ImageOnTop = true;
            this.gbCambiarEstado.Location = new System.Drawing.Point(235, 3);
            this.gbCambiarEstado.Name = "gbCambiarEstado";
            this.gbCambiarEstado.RoundCorners = 2;
            this.gbCambiarEstado.Size = new System.Drawing.Size(112, 60);
            this.gbCambiarEstado.TabIndex = 0;
            this.gbCambiarEstado.Text = "Cambiar Estado";
            this.gbCambiarEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCambiarEstado.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbCambiarEstado.Click += new System.EventHandler(this.gbModificarEstado_Click);
            // 
            // pnlOpcionesGenerales
            // 
            this.pnlOpcionesGenerales.Caption = "Operaciones Sobre Moviles";
            this.pnlOpcionesGenerales.Controls.Add(this.gbNuevoMovil);
            this.pnlOpcionesGenerales.Controls.Add(this.gbBorrarMovil);
            this.pnlOpcionesGenerales.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOpcionesGenerales.Location = new System.Drawing.Point(0, 3);
            this.pnlOpcionesGenerales.Name = "pnlOpcionesGenerales";
            this.pnlOpcionesGenerales.Opacity = 255;
            this.pnlOpcionesGenerales.Size = new System.Drawing.Size(233, 85);
            this.pnlOpcionesGenerales.Speed = 1;
            this.pnlOpcionesGenerales.TabIndex = 0;
            // 
            // gbNuevoMovil
            // 
            this.gbNuevoMovil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevoMovil.BackgroundImage")));
            this.gbNuevoMovil.BlackBorder = true;
            this.gbNuevoMovil.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevoMovil.CircleButton = false;
            this.gbNuevoMovil.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.gbNuevoMovil.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbNuevoMovil.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbNuevoMovil.FlatFontSize = 9;
            this.gbNuevoMovil.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevoMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbNuevoMovil.Location = new System.Drawing.Point(19, 12);
            this.gbNuevoMovil.Name = "gbNuevoMovil";
            this.gbNuevoMovil.RoundCorners = 2;
            this.gbNuevoMovil.Size = new System.Drawing.Size(80, 41);
            this.gbNuevoMovil.TabIndex = 27;
            this.gbNuevoMovil.Text = "Nuevo";
            this.gbNuevoMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbNuevoMovil.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbNuevoMovil.Click += new System.EventHandler(this.gbNuevoMovil_Click);
            // 
            // gbBorrarMovil
            // 
            this.gbBorrarMovil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBorrarMovil.BackgroundImage")));
            this.gbBorrarMovil.BlackBorder = true;
            this.gbBorrarMovil.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBorrarMovil.CircleButton = false;
            this.gbBorrarMovil.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbBorrarMovil.FlatColor = System.Drawing.Color.Red;
            this.gbBorrarMovil.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbBorrarMovil.FlatFontSize = 9;
            this.gbBorrarMovil.FlatTextColor = System.Drawing.Color.Black;
            this.gbBorrarMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBorrarMovil.Location = new System.Drawing.Point(127, 12);
            this.gbBorrarMovil.Name = "gbBorrarMovil";
            this.gbBorrarMovil.RoundCorners = 2;
            this.gbBorrarMovil.Size = new System.Drawing.Size(80, 41);
            this.gbBorrarMovil.TabIndex = 28;
            this.gbBorrarMovil.Text = "Borrar";
            this.gbBorrarMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBorrarMovil.W8Color = System.Drawing.Color.Red;
            this.gbBorrarMovil.Click += new System.EventHandler(this.gbBorrarMovil_Click);
            // 
            // tsBase1
            // 
            this.tsBase1.AutoSize = false;
            this.tsBase1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBase1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1});
            this.tsBase1.Location = new System.Drawing.Point(0, 0);
            this.tsBase1.Name = "tsBase1";
            this.tsBase1.Padding = new System.Windows.Forms.Padding(60, 3, 30, 0);
            this.tsBase1.SelectedTab = this.tab1;
            this.tsBase1.ShowItemToolTips = false;
            this.tsBase1.Size = new System.Drawing.Size(1008, 26);
            this.tsBase1.TabIndex = 0;
            this.tsBase1.TabOverlap = 0;
            this.tsBase1.Text = "tsBase1";
            // 
            // tab1
            // 
            this.tab1.AutoSize = false;
            this.tab1.Checked = true;
            this.tab1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tab1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(90)))), ((int)(((byte)(154)))));
            this.tab1.Margin = new System.Windows.Forms.Padding(6, 1, 0, 2);
            this.tab1.Name = "tab1";
            this.tab1.Size = new System.Drawing.Size(135, 23);
            this.tab1.TabStripPage = this.tabStripPage1;
            this.tab1.Text = "Opciones del Movil";
            // 
            // fgMovilEstados
            // 
            this.fgMovilEstados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgMovilEstados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgMovilEstados.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgMovilEstados.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgMovilEstados.CaptionVisible = false;
            this.fgMovilEstados.DataMember = "";
            this.fgMovilEstados.ExcelName = "Datos Exportados";
            this.fgMovilEstados.ExcelTitle = "";
            this.fgMovilEstados.GridOrder = "";
            this.fgMovilEstados.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgMovilEstados.Location = new System.Drawing.Point(604, 428);
            this.fgMovilEstados.Name = "fgMovilEstados";
            this.fgMovilEstados.Size = new System.Drawing.Size(392, 226);
            this.fgMovilEstados.SkinFixed = true;
            this.fgMovilEstados.TabIndex = 0;
            // 
            // fgCombustibles
            // 
            this.fgCombustibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgCombustibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgCombustibles.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgCombustibles.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgCombustibles.CaptionVisible = false;
            this.fgCombustibles.DataMember = "";
            this.fgCombustibles.ExcelName = "Datos Exportados";
            this.fgCombustibles.ExcelTitle = "";
            this.fgCombustibles.GridOrder = "";
            this.fgCombustibles.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgCombustibles.Location = new System.Drawing.Point(605, 159);
            this.fgCombustibles.Name = "fgCombustibles";
            this.fgCombustibles.Size = new System.Drawing.Size(391, 221);
            this.fgCombustibles.SkinFixed = true;
            this.fgCombustibles.TabIndex = 0;
            // 
            // fgEquipamiento
            // 
            this.fgEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgEquipamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgEquipamiento.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgEquipamiento.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgEquipamiento.CaptionVisible = false;
            this.fgEquipamiento.DataMember = "";
            this.fgEquipamiento.ExcelName = "Datos Exportados";
            this.fgEquipamiento.ExcelTitle = "";
            this.fgEquipamiento.GridOrder = "";
            this.fgEquipamiento.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgEquipamiento.Location = new System.Drawing.Point(260, 428);
            this.fgEquipamiento.Name = "fgEquipamiento";
            this.fgEquipamiento.Size = new System.Drawing.Size(326, 226);
            this.fgEquipamiento.SkinFixed = true;
            this.fgEquipamiento.TabIndex = 0;
            // 
            // fgKm
            // 
            this.fgKm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgKm.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgKm.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgKm.CaptionVisible = false;
            this.fgKm.DataMember = "";
            this.fgKm.ExcelName = "Datos Exportados";
            this.fgKm.ExcelTitle = "";
            this.fgKm.GridOrder = "";
            this.fgKm.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgKm.Location = new System.Drawing.Point(261, 159);
            this.fgKm.Name = "fgKm";
            this.fgKm.Size = new System.Drawing.Size(325, 221);
            this.fgKm.SkinFixed = true;
            this.fgKm.TabIndex = 0;
            // 
            // Moviles
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1008, 673);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.xpnlPanelAtras);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Moviles";
            this.Text = "Moviles";
            this.xpnlPanelAtras.ResumeLayout(false);
            this.tgrpMoviles.ResumeLayout(false);
            this.tgrpMoviles.PerformLayout();
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.pnlOpcionesEspecificas.ResumeLayout(false);
            this.pnlOpcionesGenerales.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanelAtras;
        private TNGS.NetControls.FullTreeView ftrMoviles;
        private TNGS.NetControls.FullGrid fgKm;
        private TNGS.NetControls.FullGrid fgCombustibles;
        private TNGS.NetControls.FullGrid fgEquipamiento;
        private TNGS.NetControls.TextEdit tePatente;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.FullLabel lblModelo;
        private TNGS.NetControls.TextEdit teModelo;
        private TNGS.NetControls.FullLabel lblEstado;
        private TNGS.NetControls.FullGrid fgMovilEstados;
        private TNGS.NetControls.GlassButton gbModificarMovil;
        private TNGS.NetControls.GlassButton gbNuevoMovil;
        private TNGS.NetControls.GlassButton gbBorrarMovil;
        private TNGS.NetControls.TextEdit teEstado;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel pnlOpcionesGenerales;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;
        private TNGS.NetControls.TSPanel pnlOpcionesEspecificas;
        private TNGS.NetControls.GlassButton gbCambiarEstado;
        private TNGS.NetControls.GlassButton gbCargarNafta;
        private TNGS.NetControls.GlassButton gbAgregarKMs;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbHistorialCompleto;
        private TNGS.NetControls.GlassButton gbInfracciones;
        private TNGS.NetControls.GlassButton gbAccidentes;
        private TNGS.NetControls.TextEdit teTipoMovil;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.ImgGroup tgrpMoviles;
    }
}