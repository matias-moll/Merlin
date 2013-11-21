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
            this.igOpciones = new TNGS.NetControls.ImgGroup();
            this.gbModificarEstado = new TNGS.NetControls.GlassButton();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.gbNuevoMovil = new TNGS.NetControls.GlassButton();
            this.gbModificarMovil = new TNGS.NetControls.GlassButton();
            this.gbBorrarMovil = new TNGS.NetControls.GlassButton();
            this.igHistorialEstados = new TNGS.NetControls.ImgGroup();
            this.fgMovilEstados = new TNGS.NetControls.FullGrid();
            this.igCombustibles = new TNGS.NetControls.ImgGroup();
            this.gbAgregarCombustible = new TNGS.NetControls.GlassButton();
            this.fgCombustibles = new TNGS.NetControls.FullGrid();
            this.igEquipamiento = new TNGS.NetControls.ImgGroup();
            this.gbModificarEq = new TNGS.NetControls.GlassButton();
            this.fgEquipamiento = new TNGS.NetControls.FullGrid();
            this.igKilometros = new TNGS.NetControls.ImgGroup();
            this.gbNuevoKM = new TNGS.NetControls.GlassButton();
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
            this.igOpciones.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.igHistorialEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).BeginInit();
            this.igCombustibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).BeginInit();
            this.igEquipamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).BeginInit();
            this.igKilometros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).BeginInit();
            this.igMoviles.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlPanelAtras
            // 
            this.xpnlPanelAtras.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanelAtras.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanelAtras.Controls.Add(this.igOpciones);
            this.xpnlPanelAtras.Controls.Add(this.igHistorialEstados);
            this.xpnlPanelAtras.Controls.Add(this.igCombustibles);
            this.xpnlPanelAtras.Controls.Add(this.igEquipamiento);
            this.xpnlPanelAtras.Controls.Add(this.igKilometros);
            this.xpnlPanelAtras.Controls.Add(this.igMoviles);
            this.xpnlPanelAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanelAtras.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanelAtras.Name = "xpnlPanelAtras";
            this.xpnlPanelAtras.Size = new System.Drawing.Size(865, 514);
            this.xpnlPanelAtras.SkinFixed = true;
            this.xpnlPanelAtras.TabIndex = 0;
            this.xpnlPanelAtras.Paint += new System.Windows.Forms.PaintEventHandler(this.xpnlPanelAtras_Paint);
            // 
            // igOpciones
            // 
            this.igOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.igOpciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igOpciones.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igOpciones.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igOpciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igOpciones.BorderThickness = 1F;
            this.igOpciones.Controls.Add(this.gbModificarEstado);
            this.igOpciones.Controls.Add(this.pnlOpciones);
            this.igOpciones.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igOpciones.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igOpciones.GroupImage = ((System.Drawing.Image)(resources.GetObject("igOpciones.GroupImage")));
            this.igOpciones.GroupTitle = "Opciones";
            this.igOpciones.Location = new System.Drawing.Point(247, 3);
            this.igOpciones.Name = "igOpciones";
            this.igOpciones.Padding = new System.Windows.Forms.Padding(20);
            this.igOpciones.PaintGroupBox = true;
            this.igOpciones.RoundCorners = 10;
            this.igOpciones.ShadowColor = System.Drawing.Color.DarkGray;
            this.igOpciones.ShadowControl = true;
            this.igOpciones.ShadowThickness = 3;
            this.igOpciones.Size = new System.Drawing.Size(577, 58);
            this.igOpciones.SkinFixed = true;
            this.igOpciones.SkinFullFixed = true;
            this.igOpciones.TabIndex = 32;
            // 
            // gbModificarEstado
            // 
            this.gbModificarEstado.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.gbModificarEstado.Location = new System.Drawing.Point(23, 26);
            this.gbModificarEstado.Name = "gbModificarEstado";
            this.gbModificarEstado.Size = new System.Drawing.Size(129, 26);
            this.gbModificarEstado.TabIndex = 30;
            this.gbModificarEstado.Text = "Modificar Estado";
            this.gbModificarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificarEstado.Click += new System.EventHandler(this.gbModificarEstado_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.gbNuevoMovil);
            this.pnlOpciones.Controls.Add(this.gbModificarMovil);
            this.pnlOpciones.Controls.Add(this.gbBorrarMovil);
            this.pnlOpciones.Location = new System.Drawing.Point(158, 23);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(414, 32);
            this.pnlOpciones.TabIndex = 31;
            // 
            // gbNuevoMovil
            // 
            this.gbNuevoMovil.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.gbNuevoMovil.Location = new System.Drawing.Point(3, 3);
            this.gbNuevoMovil.Name = "gbNuevoMovil";
            this.gbNuevoMovil.Size = new System.Drawing.Size(129, 26);
            this.gbNuevoMovil.TabIndex = 27;
            this.gbNuevoMovil.Text = "Nuevo Movil";
            this.gbNuevoMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbNuevoMovil.Click += new System.EventHandler(this.gbNuevoMovil_Click);
            // 
            // gbModificarMovil
            // 
            this.gbModificarMovil.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.gbModificarMovil.Location = new System.Drawing.Point(138, 3);
            this.gbModificarMovil.Name = "gbModificarMovil";
            this.gbModificarMovil.Size = new System.Drawing.Size(129, 26);
            this.gbModificarMovil.TabIndex = 26;
            this.gbModificarMovil.Text = "Modificar Movil";
            this.gbModificarMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificarMovil.Click += new System.EventHandler(this.gbModificarMovil_Click);
            // 
            // gbBorrarMovil
            // 
            this.gbBorrarMovil.FixedImage = TNGS.NetControls.FixedGlassButtons.Delete;
            this.gbBorrarMovil.Location = new System.Drawing.Point(273, 3);
            this.gbBorrarMovil.Name = "gbBorrarMovil";
            this.gbBorrarMovil.Size = new System.Drawing.Size(129, 26);
            this.gbBorrarMovil.TabIndex = 28;
            this.gbBorrarMovil.Text = "Borrar Movil";
            this.gbBorrarMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBorrarMovil.Click += new System.EventHandler(this.gbBorrarMovil_Click);
            // 
            // igHistorialEstados
            // 
            this.igHistorialEstados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igHistorialEstados.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igHistorialEstados.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igHistorialEstados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igHistorialEstados.BorderThickness = 1F;
            this.igHistorialEstados.Controls.Add(this.fgMovilEstados);
            this.igHistorialEstados.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igHistorialEstados.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igHistorialEstados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igHistorialEstados.GroupImage = ((System.Drawing.Image)(resources.GetObject("igHistorialEstados.GroupImage")));
            this.igHistorialEstados.GroupTitle = "Historial Estados";
            this.igHistorialEstados.Location = new System.Drawing.Point(541, 290);
            this.igHistorialEstados.Name = "igHistorialEstados";
            this.igHistorialEstados.Padding = new System.Windows.Forms.Padding(20);
            this.igHistorialEstados.PaintGroupBox = true;
            this.igHistorialEstados.RoundCorners = 10;
            this.igHistorialEstados.ShadowColor = System.Drawing.Color.DarkGray;
            this.igHistorialEstados.ShadowControl = true;
            this.igHistorialEstados.ShadowThickness = 3;
            this.igHistorialEstados.Size = new System.Drawing.Size(285, 212);
            this.igHistorialEstados.SkinFixed = true;
            this.igHistorialEstados.SkinFullFixed = true;
            this.igHistorialEstados.TabIndex = 5;
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
            this.fgMovilEstados.Location = new System.Drawing.Point(4, 23);
            this.fgMovilEstados.Name = "fgMovilEstados";
            this.fgMovilEstados.Size = new System.Drawing.Size(274, 174);
            this.fgMovilEstados.SkinFixed = true;
            this.fgMovilEstados.TabIndex = 0;
            // 
            // igCombustibles
            // 
            this.igCombustibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igCombustibles.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igCombustibles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igCombustibles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igCombustibles.BorderThickness = 1F;
            this.igCombustibles.Controls.Add(this.gbAgregarCombustible);
            this.igCombustibles.Controls.Add(this.fgCombustibles);
            this.igCombustibles.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igCombustibles.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igCombustibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igCombustibles.GroupImage = ((System.Drawing.Image)(resources.GetObject("igCombustibles.GroupImage")));
            this.igCombustibles.GroupTitle = "Combustibles";
            this.igCombustibles.Location = new System.Drawing.Point(238, 290);
            this.igCombustibles.Name = "igCombustibles";
            this.igCombustibles.Padding = new System.Windows.Forms.Padding(20);
            this.igCombustibles.PaintGroupBox = true;
            this.igCombustibles.RoundCorners = 10;
            this.igCombustibles.ShadowColor = System.Drawing.Color.DarkGray;
            this.igCombustibles.ShadowControl = true;
            this.igCombustibles.ShadowThickness = 3;
            this.igCombustibles.Size = new System.Drawing.Size(288, 212);
            this.igCombustibles.SkinFixed = true;
            this.igCombustibles.SkinFullFixed = true;
            this.igCombustibles.TabIndex = 4;
            // 
            // gbAgregarCombustible
            // 
            this.gbAgregarCombustible.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.gbAgregarCombustible.Location = new System.Drawing.Point(202, 183);
            this.gbAgregarCombustible.Name = "gbAgregarCombustible";
            this.gbAgregarCombustible.Size = new System.Drawing.Size(76, 23);
            this.gbAgregarCombustible.TabIndex = 5;
            this.gbAgregarCombustible.Text = "Nuevo";
            this.gbAgregarCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAgregarCombustible.Click += new System.EventHandler(this.gbAgregarCombustible_Click);
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
            this.fgCombustibles.Location = new System.Drawing.Point(5, 25);
            this.fgCombustibles.Name = "fgCombustibles";
            this.fgCombustibles.Size = new System.Drawing.Size(273, 156);
            this.fgCombustibles.SkinFixed = true;
            this.fgCombustibles.TabIndex = 0;
            // 
            // igEquipamiento
            // 
            this.igEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igEquipamiento.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igEquipamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.BorderThickness = 1F;
            this.igEquipamiento.Controls.Add(this.gbModificarEq);
            this.igEquipamiento.Controls.Add(this.fgEquipamiento);
            this.igEquipamiento.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igEquipamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.GroupImage = ((System.Drawing.Image)(resources.GetObject("igEquipamiento.GroupImage")));
            this.igEquipamiento.GroupTitle = "Equipamiento";
            this.igEquipamiento.Location = new System.Drawing.Point(541, 67);
            this.igEquipamiento.Name = "igEquipamiento";
            this.igEquipamiento.Padding = new System.Windows.Forms.Padding(20);
            this.igEquipamiento.PaintGroupBox = true;
            this.igEquipamiento.RoundCorners = 10;
            this.igEquipamiento.ShadowColor = System.Drawing.Color.DarkGray;
            this.igEquipamiento.ShadowControl = true;
            this.igEquipamiento.ShadowThickness = 3;
            this.igEquipamiento.Size = new System.Drawing.Size(285, 223);
            this.igEquipamiento.SkinFixed = true;
            this.igEquipamiento.SkinFullFixed = true;
            this.igEquipamiento.TabIndex = 4;
            // 
            // gbModificarEq
            // 
            this.gbModificarEq.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.gbModificarEq.Location = new System.Drawing.Point(189, 194);
            this.gbModificarEq.Name = "gbModificarEq";
            this.gbModificarEq.Size = new System.Drawing.Size(89, 23);
            this.gbModificarEq.TabIndex = 2;
            this.gbModificarEq.Text = "Modificar";
            this.gbModificarEq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificarEq.Click += new System.EventHandler(this.gbModificarEq_Click);
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
            this.fgEquipamiento.Location = new System.Drawing.Point(4, 23);
            this.fgEquipamiento.Name = "fgEquipamiento";
            this.fgEquipamiento.Size = new System.Drawing.Size(274, 169);
            this.fgEquipamiento.SkinFixed = true;
            this.fgEquipamiento.TabIndex = 0;
            // 
            // igKilometros
            // 
            this.igKilometros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igKilometros.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igKilometros.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igKilometros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igKilometros.BorderThickness = 1F;
            this.igKilometros.Controls.Add(this.gbNuevoKM);
            this.igKilometros.Controls.Add(this.fgKm);
            this.igKilometros.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igKilometros.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igKilometros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igKilometros.GroupImage = ((System.Drawing.Image)(resources.GetObject("igKilometros.GroupImage")));
            this.igKilometros.GroupTitle = "Kilometraje";
            this.igKilometros.Location = new System.Drawing.Point(238, 67);
            this.igKilometros.Name = "igKilometros";
            this.igKilometros.Padding = new System.Windows.Forms.Padding(20);
            this.igKilometros.PaintGroupBox = true;
            this.igKilometros.RoundCorners = 10;
            this.igKilometros.ShadowColor = System.Drawing.Color.DarkGray;
            this.igKilometros.ShadowControl = true;
            this.igKilometros.ShadowThickness = 3;
            this.igKilometros.Size = new System.Drawing.Size(288, 223);
            this.igKilometros.SkinFixed = true;
            this.igKilometros.SkinFullFixed = true;
            this.igKilometros.TabIndex = 3;
            // 
            // gbNuevoKM
            // 
            this.gbNuevoKM.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.gbNuevoKM.Location = new System.Drawing.Point(202, 194);
            this.gbNuevoKM.Name = "gbNuevoKM";
            this.gbNuevoKM.Size = new System.Drawing.Size(76, 23);
            this.gbNuevoKM.TabIndex = 4;
            this.gbNuevoKM.Text = "Nuevo";
            this.gbNuevoKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbNuevoKM.Click += new System.EventHandler(this.gbNuevoKM_Click);
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
            this.fgKm.Location = new System.Drawing.Point(5, 23);
            this.fgKm.Name = "fgKm";
            this.fgKm.Size = new System.Drawing.Size(273, 169);
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
            this.igMoviles.Location = new System.Drawing.Point(12, 10);
            this.igMoviles.Name = "igMoviles";
            this.igMoviles.Padding = new System.Windows.Forms.Padding(20);
            this.igMoviles.PaintGroupBox = true;
            this.igMoviles.RoundCorners = 10;
            this.igMoviles.ShadowColor = System.Drawing.Color.DarkGray;
            this.igMoviles.ShadowControl = true;
            this.igMoviles.ShadowThickness = 3;
            this.igMoviles.Size = new System.Drawing.Size(215, 500);
            this.igMoviles.SkinFixed = true;
            this.igMoviles.SkinFullFixed = true;
            this.igMoviles.TabIndex = 1;
            // 
            // teEstado
            // 
            this.teEstado.BackColor = System.Drawing.SystemColors.Window;
            this.teEstado.Enabled = false;
            this.teEstado.Location = new System.Drawing.Point(69, 443);
            this.teEstado.Name = "teEstado";
            this.teEstado.Size = new System.Drawing.Size(123, 20);
            this.teEstado.TabIndex = 25;
            this.teEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // teModelo
            // 
            this.teModelo.BackColor = System.Drawing.SystemColors.Window;
            this.teModelo.Enabled = false;
            this.teModelo.Location = new System.Drawing.Point(69, 417);
            this.teModelo.Name = "teModelo";
            this.teModelo.Size = new System.Drawing.Size(123, 20);
            this.teModelo.TabIndex = 24;
            this.teModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(14, 443);
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
            this.lblModelo.Location = new System.Drawing.Point(14, 418);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 18);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo:";
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.Enabled = false;
            this.tePatente.Location = new System.Drawing.Point(69, 391);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(123, 20);
            this.tePatente.TabIndex = 7;
            this.tePatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(14, 393);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(67, 18);
            this.lblPatente.TabIndex = 8;
            this.lblPatente.Text = "Patente:";
            // 
            // ftrMoviles
            // 
            this.ftrMoviles.IgnoreLevelInFill = false;
            this.ftrMoviles.Location = new System.Drawing.Point(9, 26);
            this.ftrMoviles.Name = "ftrMoviles";
            this.ftrMoviles.Size = new System.Drawing.Size(194, 359);
            this.ftrMoviles.TabIndex = 0;
            this.ftrMoviles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ftrMoviles_AfterSelect);
            this.ftrMoviles.DoubleClick += new System.EventHandler(this.ftrMoviles_DoubleClick);
            // 
            // Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 514);
            this.Controls.Add(this.xpnlPanelAtras);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Estados";
            this.Text = "Estados";
            this.xpnlPanelAtras.ResumeLayout(false);
            this.igOpciones.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            this.igHistorialEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).EndInit();
            this.igCombustibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).EndInit();
            this.igEquipamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).EndInit();
            this.igKilometros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).EndInit();
            this.igMoviles.ResumeLayout(false);
            this.igMoviles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanelAtras;
        private TNGS.NetControls.ImgGroup igMoviles;
        private TNGS.NetControls.FullTreeView ftrMoviles;
        private TNGS.NetControls.ImgGroup igKilometros;
        private TNGS.NetControls.FullGrid fgKm;
        private TNGS.NetControls.ImgGroup igCombustibles;
        private TNGS.NetControls.FullGrid fgCombustibles;
        private TNGS.NetControls.ImgGroup igEquipamiento;
        private TNGS.NetControls.FullGrid fgEquipamiento;
        private TNGS.NetControls.GlassButton gbModificarEq;
        private TNGS.NetControls.GlassButton gbNuevoKM;
        private TNGS.NetControls.GlassButton gbAgregarCombustible;
        private TNGS.NetControls.TextEdit tePatente;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.FullLabel lblModelo;
        private TNGS.NetControls.TextEdit teModelo;
        private TNGS.NetControls.FullLabel lblEstado;
        private TNGS.NetControls.ImgGroup igHistorialEstados;
        private TNGS.NetControls.FullGrid fgMovilEstados;
        private TNGS.NetControls.GlassButton gbModificarEstado;
        private System.Windows.Forms.Panel pnlOpciones;
        private TNGS.NetControls.GlassButton gbNuevoMovil;
        private TNGS.NetControls.GlassButton gbModificarMovil;
        private TNGS.NetControls.GlassButton gbBorrarMovil;
        private TNGS.NetControls.ImgGroup igOpciones;
        private TNGS.NetControls.TextEdit teEstado;
    }
}