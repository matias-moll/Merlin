using WeifenLuo.WinFormsUI.Docking;
namespace Rivn.Mv
{
    partial class Estados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estados));
            this.xpnlPanelAtras = new TNGS.NetControls.XPanel();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.glassButton3 = new TNGS.NetControls.GlassButton();
            this.glassButton2 = new TNGS.NetControls.GlassButton();
            this.glassButton1 = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.gbNuevoMovil = new TNGS.NetControls.GlassButton();
            this.gbModificarMovil = new TNGS.NetControls.GlassButton();
            this.gbBorrarMovil = new TNGS.NetControls.GlassButton();
            this.gbModificarEstado = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.fgMovilEstados = new TNGS.NetControls.FullGrid();
            this.fgCombustibles = new TNGS.NetControls.FullGrid();
            this.fgEquipamiento = new TNGS.NetControls.FullGrid();
            this.fgKm = new TNGS.NetControls.FullGrid();
            this.igMoviles = new TNGS.NetControls.ImgGroup();
            this.teEstado = new TNGS.NetControls.TextEdit();
            this.teModelo = new TNGS.NetControls.TextEdit();
            this.lblEstado = new TNGS.NetControls.FullLabel();
            this.lblModelo = new TNGS.NetControls.FullLabel();
            this.tePatente = new TNGS.NetControls.TextEdit();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.ftrMoviles = new TNGS.NetControls.FullTreeView();
            this.xpnlPanelAtras.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).BeginInit();
            this.igMoviles.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanelAtras
            // 
            this.xpnlPanelAtras.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanelAtras.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanelAtras.Controls.Add(this.tsContainer1);
            this.xpnlPanelAtras.Controls.Add(this.fgMovilEstados);
            this.xpnlPanelAtras.Controls.Add(this.fgCombustibles);
            this.xpnlPanelAtras.Controls.Add(this.fgEquipamiento);
            this.xpnlPanelAtras.Controls.Add(this.fgKm);
            this.xpnlPanelAtras.Controls.Add(this.igMoviles);
            this.xpnlPanelAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanelAtras.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanelAtras.Name = "xpnlPanelAtras";
            this.xpnlPanelAtras.Size = new System.Drawing.Size(1008, 651);
            this.xpnlPanelAtras.SkinFixed = true;
            this.xpnlPanelAtras.TabIndex = 0;
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
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(1000, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Opciones Espeficificas";
            this.tsPanel2.Controls.Add(this.glassButton3);
            this.tsPanel2.Controls.Add(this.glassButton2);
            this.tsPanel2.Controls.Add(this.glassButton1);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(456, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(359, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // glassButton3
            // 
            this.glassButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("glassButton3.BackgroundImage")));
            this.glassButton3.ImageOnTop = true;
            this.glassButton3.Location = new System.Drawing.Point(224, 6);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.Size = new System.Drawing.Size(99, 55);
            this.glassButton3.TabIndex = 2;
            this.glassButton3.Text = "Cargar Nafta";
            // 
            // glassButton2
            // 
            this.glassButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("glassButton2.BackgroundImage")));
            this.glassButton2.ImageOnTop = true;
            this.glassButton2.Location = new System.Drawing.Point(112, 6);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(106, 55);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "Agregar Kms";
            // 
            // glassButton1
            // 
            this.glassButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("glassButton1.BackgroundImage")));
            this.glassButton1.ImageOnTop = true;
            this.glassButton1.Location = new System.Drawing.Point(6, 6);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(100, 55);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "Cambiar Estado";
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Opciones generales";
            this.tsPanel1.Controls.Add(this.pnlOpciones);
            this.tsPanel1.Controls.Add(this.gbModificarEstado);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(456, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.gbNuevoMovil);
            this.pnlOpciones.Controls.Add(this.gbModificarMovil);
            this.pnlOpciones.Controls.Add(this.gbBorrarMovil);
            this.pnlOpciones.Location = new System.Drawing.Point(127, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(323, 63);
            this.pnlOpciones.TabIndex = 31;
            // 
            // gbNuevoMovil
            // 
            this.gbNuevoMovil.FixedImage = TNGS.NetControls.FixedGlassButtons.tNew;
            this.gbNuevoMovil.ImageOnTop = true;
            this.gbNuevoMovil.Location = new System.Drawing.Point(4, 6);
            this.gbNuevoMovil.Name = "gbNuevoMovil";
            this.gbNuevoMovil.Size = new System.Drawing.Size(100, 55);
            this.gbNuevoMovil.TabIndex = 27;
            this.gbNuevoMovil.Text = "Nuevo Movil";
            this.gbNuevoMovil.Click += new System.EventHandler(this.gbNuevoMovil_Click);
            // 
            // gbModificarMovil
            // 
            this.gbModificarMovil.FixedImage = TNGS.NetControls.FixedGlassButtons.tChange;
            this.gbModificarMovil.ImageOnTop = true;
            this.gbModificarMovil.Location = new System.Drawing.Point(110, 6);
            this.gbModificarMovil.Name = "gbModificarMovil";
            this.gbModificarMovil.Size = new System.Drawing.Size(100, 55);
            this.gbModificarMovil.TabIndex = 26;
            this.gbModificarMovil.Text = "Cambiar";
            this.gbModificarMovil.Click += new System.EventHandler(this.gbModificarMovil_Click);
            // 
            // gbBorrarMovil
            // 
            this.gbBorrarMovil.FixedImage = TNGS.NetControls.FixedGlassButtons.tDelete;
            this.gbBorrarMovil.ImageOnTop = true;
            this.gbBorrarMovil.Location = new System.Drawing.Point(218, 6);
            this.gbBorrarMovil.Name = "gbBorrarMovil";
            this.gbBorrarMovil.Size = new System.Drawing.Size(100, 55);
            this.gbBorrarMovil.TabIndex = 28;
            this.gbBorrarMovil.Text = "Borrar";
            this.gbBorrarMovil.Click += new System.EventHandler(this.gbBorrarMovil_Click);
            // 
            // gbModificarEstado
            // 
            this.gbModificarEstado.FixedImage = TNGS.NetControls.FixedGlassButtons.tModify;
            this.gbModificarEstado.ImageOnTop = true;
            this.gbModificarEstado.Location = new System.Drawing.Point(8, 6);
            this.gbModificarEstado.Name = "gbModificarEstado";
            this.gbModificarEstado.Size = new System.Drawing.Size(117, 55);
            this.gbModificarEstado.TabIndex = 30;
            this.gbModificarEstado.Text = "Modificar Estado";
            this.gbModificarEstado.Click += new System.EventHandler(this.gbModificarEstado_Click);
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
            this.fgMovilEstados.DataMember = "";
            this.fgMovilEstados.ExcelTitle = "";
            this.fgMovilEstados.GridOrder = "";
            this.fgMovilEstados.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgMovilEstados.Location = new System.Drawing.Point(572, 290);
            this.fgMovilEstados.Name = "fgMovilEstados";
            this.fgMovilEstados.Size = new System.Drawing.Size(274, 112);
            this.fgMovilEstados.SkinFixed = true;
            this.fgMovilEstados.TabIndex = 0;
            // 
            // fgCombustibles
            // 
            this.fgCombustibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgCombustibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgCombustibles.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgCombustibles.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgCombustibles.DataMember = "";
            this.fgCombustibles.ExcelTitle = "";
            this.fgCombustibles.GridOrder = "";
            this.fgCombustibles.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgCombustibles.Location = new System.Drawing.Point(258, 290);
            this.fgCombustibles.Name = "fgCombustibles";
            this.fgCombustibles.Size = new System.Drawing.Size(273, 112);
            this.fgCombustibles.SkinFixed = true;
            this.fgCombustibles.TabIndex = 0;
            // 
            // fgEquipamiento
            // 
            this.fgEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgEquipamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgEquipamiento.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgEquipamiento.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgEquipamiento.DataMember = "";
            this.fgEquipamiento.ExcelTitle = "";
            this.fgEquipamiento.GridOrder = "";
            this.fgEquipamiento.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgEquipamiento.Location = new System.Drawing.Point(572, 144);
            this.fgEquipamiento.Name = "fgEquipamiento";
            this.fgEquipamiento.Size = new System.Drawing.Size(274, 110);
            this.fgEquipamiento.SkinFixed = true;
            this.fgEquipamiento.TabIndex = 0;
            // 
            // fgKm
            // 
            this.fgKm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgKm.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgKm.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgKm.DataMember = "";
            this.fgKm.ExcelTitle = "";
            this.fgKm.GridOrder = "";
            this.fgKm.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgKm.Location = new System.Drawing.Point(258, 144);
            this.fgKm.Name = "fgKm";
            this.fgKm.Size = new System.Drawing.Size(273, 110);
            this.fgKm.SkinFixed = true;
            this.fgKm.TabIndex = 0;
            // 
            // igMoviles
            // 
            this.igMoviles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igMoviles.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igMoviles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igMoviles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igMoviles.BorderThickness = 1F;
            this.igMoviles.Controls.Add(this.teEstado);
            this.igMoviles.Controls.Add(this.teModelo);
            this.igMoviles.Controls.Add(this.lblEstado);
            this.igMoviles.Controls.Add(this.lblModelo);
            this.igMoviles.Controls.Add(this.tePatente);
            this.igMoviles.Controls.Add(this.lblPatente);
            this.igMoviles.Controls.Add(this.ftrMoviles);
            this.igMoviles.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igMoviles.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igMoviles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igMoviles.GroupImage = ((System.Drawing.Image)(resources.GetObject("igMoviles.GroupImage")));
            this.igMoviles.GroupTitle = "Moviles";
            this.igMoviles.Location = new System.Drawing.Point(18, 120);
            this.igMoviles.Name = "igMoviles";
            this.igMoviles.Padding = new System.Windows.Forms.Padding(20);
            this.igMoviles.PaintGroupBox = true;
            this.igMoviles.RoundCorners = 10;
            this.igMoviles.ShadowColor = System.Drawing.Color.DarkGray;
            this.igMoviles.ShadowControl = true;
            this.igMoviles.ShadowThickness = 3;
            this.igMoviles.Size = new System.Drawing.Size(217, 311);
            this.igMoviles.SkinFixed = true;
            this.igMoviles.SkinFullFixed = true;
            this.igMoviles.TabIndex = 1;
            // 
            // teEstado
            // 
            this.teEstado.BackColor = System.Drawing.SystemColors.Window;
            this.teEstado.Enabled = false;
            this.teEstado.Location = new System.Drawing.Point(69, 273);
            this.teEstado.Name = "teEstado";
            this.teEstado.Size = new System.Drawing.Size(135, 20);
            this.teEstado.TabIndex = 25;
            this.teEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teModelo
            // 
            this.teModelo.BackColor = System.Drawing.SystemColors.Window;
            this.teModelo.Enabled = false;
            this.teModelo.Location = new System.Drawing.Point(69, 247);
            this.teModelo.Name = "teModelo";
            this.teModelo.Size = new System.Drawing.Size(135, 20);
            this.teModelo.TabIndex = 24;
            this.teModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(8, 273);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(8, 248);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 18);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo:";
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.Enabled = false;
            this.tePatente.Location = new System.Drawing.Point(69, 221);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(135, 20);
            this.tePatente.TabIndex = 7;
            this.tePatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(8, 223);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(67, 18);
            this.lblPatente.TabIndex = 8;
            this.lblPatente.Text = "Patente:";
            // 
            // ftrMoviles
            // 
            this.ftrMoviles.IgnoreLevelInFill = false;
            this.ftrMoviles.Location = new System.Drawing.Point(11, 35);
            this.ftrMoviles.Name = "ftrMoviles";
            this.ftrMoviles.Size = new System.Drawing.Size(194, 169);
            this.ftrMoviles.TabIndex = 0;
            this.ftrMoviles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ftrMoviles_AfterSelect);
            this.ftrMoviles.DoubleClick += new System.EventHandler(this.ftrMoviles_DoubleClick);
            // 
            // Estados
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 651);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.xpnlPanelAtras);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Estados";
            this.Text = "Estados";
            this.xpnlPanelAtras.ResumeLayout(false);
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).EndInit();
            this.igMoviles.ResumeLayout(false);
            this.igMoviles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanelAtras;
        private TNGS.NetControls.ImgGroup igMoviles;
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
        private TNGS.NetControls.GlassButton gbModificarEstado;
        private System.Windows.Forms.Panel pnlOpciones;
        private TNGS.NetControls.GlassButton gbNuevoMovil;
        private TNGS.NetControls.GlassButton gbModificarMovil;
        private TNGS.NetControls.GlassButton gbBorrarMovil;
        private TNGS.NetControls.TextEdit teEstado;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.GlassButton glassButton1;
        private TNGS.NetControls.GlassButton glassButton3;
        private TNGS.NetControls.GlassButton glassButton2;
    }
}