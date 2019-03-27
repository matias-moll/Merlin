#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Mrln.Tg
{
    public partial class DestinatariosMails : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TNGS.NetControls.XPanel xpnlBase;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdModificar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblCodigo;
        private TNGS.NetControls.TextEdit txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private TNGS.NetControls.TextEdit txtDescripcion;
        private System.Windows.Forms.Label lblDestinatarios;
        private TNGS.NetControls.TextEdit teDestinatario;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.FullGrid grdDatos;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;

        /// <summary>
        /// Liberamos los recursos utilizados
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DestinatariosMails));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.gbHabilitar = new TNGS.NetControls.GlassButton();
            this.gbDeshabilitar = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.gbCompactar = new TNGS.NetControls.GlassButton();
            this.gbSalir = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.gbRemoveSelected = new TNGS.NetControls.GlassButton();
            this.gbAdd = new TNGS.NetControls.GlassButton();
            this.cdListaDestinatarios = new TNGS.NetControls.CDList();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new TNGS.NetControls.TextEdit();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new TNGS.NetControls.TextEdit();
            this.lblDestinatarios = new System.Windows.Forms.Label();
            this.teDestinatario = new TNGS.NetControls.TextEdit();
            this.xpnlBase.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.Controls.Add(this.tsContainer1);
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(1014, 543);
            this.xpnlBase.SkinFixed = true;
            this.xpnlBase.TabIndex = 0;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(1014, 115);
            this.tsContainer1.TabIndex = 22;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(1014, 89);
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
            this.tabStripPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(1006, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Edición";
            this.tsPanel2.Controls.Add(this.gbHabilitar);
            this.tsPanel2.Controls.Add(this.gbDeshabilitar);
            this.tsPanel2.Controls.Add(this.cmdCancelar);
            this.tsPanel2.Controls.Add(this.cmdGrabar);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel2.Location = new System.Drawing.Point(287, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(298, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // gbHabilitar
            // 
            this.gbHabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbHabilitar.BackgroundImage")));
            this.gbHabilitar.BlackBorder = true;
            this.gbHabilitar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbHabilitar.CircleButton = false;
            this.gbHabilitar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Check;
            this.gbHabilitar.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbHabilitar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbHabilitar.FlatFontSize = 9;
            this.gbHabilitar.FlatTextColor = System.Drawing.Color.Black;
            this.gbHabilitar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbHabilitar.Location = new System.Drawing.Point(173, 7);
            this.gbHabilitar.Name = "gbHabilitar";
            this.gbHabilitar.RoundCorners = 2;
            this.gbHabilitar.Size = new System.Drawing.Size(113, 25);
            this.gbHabilitar.TabIndex = 13;
            this.gbHabilitar.Text = "Habilitar";
            this.gbHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbHabilitar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbHabilitar.Click += new System.EventHandler(this.gbChangeHabilitado_Click);
            // 
            // gbDeshabilitar
            // 
            this.gbDeshabilitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbDeshabilitar.BackgroundImage")));
            this.gbDeshabilitar.BlackBorder = true;
            this.gbDeshabilitar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbDeshabilitar.CircleButton = false;
            this.gbDeshabilitar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Block;
            this.gbDeshabilitar.FlatColor = System.Drawing.Color.Red;
            this.gbDeshabilitar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbDeshabilitar.FlatFontSize = 9;
            this.gbDeshabilitar.FlatTextColor = System.Drawing.Color.Black;
            this.gbDeshabilitar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbDeshabilitar.Location = new System.Drawing.Point(173, 35);
            this.gbDeshabilitar.Name = "gbDeshabilitar";
            this.gbDeshabilitar.RoundCorners = 2;
            this.gbDeshabilitar.Size = new System.Drawing.Size(113, 25);
            this.gbDeshabilitar.TabIndex = 14;
            this.gbDeshabilitar.Text = "Deshabilitar";
            this.gbDeshabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbDeshabilitar.W8Color = System.Drawing.Color.Red;
            this.gbDeshabilitar.Click += new System.EventHandler(this.gbChangeHabilitado_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.BackgroundImage")));
            this.cmdCancelar.BlackBorder = true;
            this.cmdCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdCancelar.CircleButton = false;
            this.cmdCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.cmdCancelar.FlatColor = System.Drawing.Color.Red;
            this.cmdCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.cmdCancelar.FlatFontSize = 9;
            this.cmdCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdCancelar.ImageOnTop = true;
            this.cmdCancelar.Location = new System.Drawing.Point(86, 3);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.RoundCorners = 2;
            this.cmdCancelar.Size = new System.Drawing.Size(70, 60);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancelar.W8Color = System.Drawing.Color.Red;
            this.cmdCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdGrabar.BackgroundImage")));
            this.cmdGrabar.BlackBorder = true;
            this.cmdGrabar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdGrabar.CircleButton = false;
            this.cmdGrabar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Save;
            this.cmdGrabar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdGrabar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdGrabar.FlatFontSize = 9;
            this.cmdGrabar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdGrabar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdGrabar.ImageOnTop = true;
            this.cmdGrabar.Location = new System.Drawing.Point(11, 3);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.Size = new System.Drawing.Size(70, 60);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGrabar.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdGrabar.Click += new System.EventHandler(this.gbGrabar_Click);
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.gbCompactar);
            this.tsPanel1.Controls.Add(this.gbSalir);
            this.tsPanel1.Controls.Add(this.cmdModificar);
            this.tsPanel1.Controls.Add(this.cmdNuevo);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(287, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // gbCompactar
            // 
            this.gbCompactar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCompactar.BackgroundImage")));
            this.gbCompactar.BlackBorder = true;
            this.gbCompactar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCompactar.CircleButton = false;
            this.gbCompactar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Folder;
            this.gbCompactar.FlatColor = System.Drawing.Color.Gray;
            this.gbCompactar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.gbCompactar.FlatFontSize = 9;
            this.gbCompactar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCompactar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCompactar.Location = new System.Drawing.Point(171, 36);
            this.gbCompactar.Name = "gbCompactar";
            this.gbCompactar.RoundCorners = 2;
            this.gbCompactar.Size = new System.Drawing.Size(104, 25);
            this.gbCompactar.TabIndex = 10;
            this.gbCompactar.Text = "Compactar";
            this.gbCompactar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCompactar.W8Color = System.Drawing.Color.Gray;
            this.gbCompactar.Click += new System.EventHandler(this.gbCompactar_Click);
            // 
            // gbSalir
            // 
            this.gbSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbSalir.BackgroundImage")));
            this.gbSalir.BlackBorder = true;
            this.gbSalir.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbSalir.CircleButton = false;
            this.gbSalir.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Undo;
            this.gbSalir.FlatColor = System.Drawing.Color.Red;
            this.gbSalir.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbSalir.FlatFontSize = 9;
            this.gbSalir.FlatTextColor = System.Drawing.Color.Black;
            this.gbSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbSalir.Location = new System.Drawing.Point(171, 7);
            this.gbSalir.Name = "gbSalir";
            this.gbSalir.RoundCorners = 2;
            this.gbSalir.Size = new System.Drawing.Size(104, 25);
            this.gbSalir.TabIndex = 9;
            this.gbSalir.Text = "Salir";
            this.gbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbSalir.W8Color = System.Drawing.Color.Red;
            this.gbSalir.Click += new System.EventHandler(this.gbSalir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdModificar.BackgroundImage")));
            this.cmdModificar.BlackBorder = true;
            this.cmdModificar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdModificar.CircleButton = false;
            this.cmdModificar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.cmdModificar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdModificar.FlatFontSize = 9;
            this.cmdModificar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdModificar.ImageOnTop = true;
            this.cmdModificar.Location = new System.Drawing.Point(82, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.RoundCorners = 2;
            this.cmdModificar.Size = new System.Drawing.Size(75, 60);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdModificar.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdModificar.Click += new System.EventHandler(this.gbModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.BackgroundImage")));
            this.cmdNuevo.BlackBorder = true;
            this.cmdNuevo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdNuevo.CircleButton = false;
            this.cmdNuevo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.cmdNuevo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.cmdNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.cmdNuevo.FlatFontSize = 9;
            this.cmdNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.cmdNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdNuevo.ImageOnTop = true;
            this.cmdNuevo.Location = new System.Drawing.Point(8, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.RoundCorners = 2;
            this.cmdNuevo.Size = new System.Drawing.Size(70, 60);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNuevo.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdNuevo.Click += new System.EventHandler(this.gbNuevo_Click);
            // 
            // tsBase1
            // 
            this.tsBase1.AutoSize = false;
            this.tsBase1.FlatLigth = true;
            this.tsBase1.ForeColor = System.Drawing.Color.Black;
            this.tsBase1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBase1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tab1});
            this.tsBase1.Location = new System.Drawing.Point(0, 0);
            this.tsBase1.Name = "tsBase1";
            this.tsBase1.Padding = new System.Windows.Forms.Padding(60, 3, 30, 0);
            this.tsBase1.SelectedTab = null;
            this.tsBase1.ShowItemToolTips = false;
            this.tsBase1.Size = new System.Drawing.Size(1014, 26);
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
            this.tab1.Size = new System.Drawing.Size(114, 23);
            this.tab1.TabStripPage = this.tabStripPage1;
            this.tab1.Text = "Mantenimiento";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 126);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "DestinatariosMails:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataMember = "";
            this.grdDatos.ExcelName = "Datos Exportados";
            this.grdDatos.ExcelTitle = "";
            this.grdDatos.GridOrder = "";
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Location = new System.Drawing.Point(4, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(1006, 224);
            this.grdDatos.SkinFixed = true;
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPrint.BackgroundImage")));
            this.cmdPrint.BlackBorder = true;
            this.cmdPrint.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdPrint.CircleButton = false;
            this.cmdPrint.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fPrint;
            this.cmdPrint.FlatColor = System.Drawing.Color.Gray;
            this.cmdPrint.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.cmdPrint.FlatFontSize = 9;
            this.cmdPrint.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdPrint.Location = new System.Drawing.Point(984, 116);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPrint.W8Color = System.Drawing.Color.Gray;
            this.cmdPrint.Click += new System.EventHandler(this.gbPrint_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExcel.BackgroundImage")));
            this.cmdExcel.BlackBorder = true;
            this.cmdExcel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.cmdExcel.CircleButton = false;
            this.cmdExcel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fExcel;
            this.cmdExcel.FlatColor = System.Drawing.Color.LimeGreen;
            this.cmdExcel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Excel;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmdExcel.Location = new System.Drawing.Point(956, 116);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdExcel.W8Color = System.Drawing.Color.LimeGreen;
            this.cmdExcel.Click += new System.EventHandler(this.gbExcel_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BlackBorder = true;
            this.frmEdicion.BorderColor = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.Controls.Add(this.gbRemoveSelected);
            this.frmEdicion.Controls.Add(this.gbAdd);
            this.frmEdicion.Controls.Add(this.cdListaDestinatarios);
            this.frmEdicion.Controls.Add(this.lblCodigo);
            this.frmEdicion.Controls.Add(this.txtCodigo);
            this.frmEdicion.Controls.Add(this.lblDescripcion);
            this.frmEdicion.Controls.Add(this.txtDescripcion);
            this.frmEdicion.Controls.Add(this.lblDestinatarios);
            this.frmEdicion.Controls.Add(this.teDestinatario);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.FlatMode = true;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.ForeColor = System.Drawing.Color.Black;
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " DestinatariosMail ";
            this.frmEdicion.Location = new System.Drawing.Point(4, 372);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 4;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(1006, 167);
            this.frmEdicion.SkinFixed = true;
            this.frmEdicion.TabIndex = 21;
            this.frmEdicion.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmEdicion.TitleFontColor = System.Drawing.Color.White;
            // 
            // gbRemoveSelected
            // 
            this.gbRemoveSelected.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRemoveSelected.BackgroundImage")));
            this.gbRemoveSelected.BlackBorder = true;
            this.gbRemoveSelected.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbRemoveSelected.CircleButton = false;
            this.gbRemoveSelected.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fDelete;
            this.gbRemoveSelected.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbRemoveSelected.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbRemoveSelected.FlatFontSize = 9;
            this.gbRemoveSelected.FlatTextColor = System.Drawing.Color.Black;
            this.gbRemoveSelected.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbRemoveSelected.Location = new System.Drawing.Point(667, 93);
            this.gbRemoveSelected.Name = "gbRemoveSelected";
            this.gbRemoveSelected.RoundCorners = 2;
            this.gbRemoveSelected.Size = new System.Drawing.Size(26, 24);
            this.gbRemoveSelected.TabIndex = 4;
            this.gbRemoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbRemoveSelected.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbRemoveSelected.Click += new System.EventHandler(this.gbRemoveSelected_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAdd.BackgroundImage")));
            this.gbAdd.BlackBorder = true;
            this.gbAdd.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAdd.CircleButton = false;
            this.gbAdd.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.fAdd;
            this.gbAdd.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAdd.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAdd.FlatFontSize = 9;
            this.gbAdd.FlatTextColor = System.Drawing.Color.Black;
            this.gbAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAdd.Location = new System.Drawing.Point(430, 93);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.RoundCorners = 2;
            this.gbAdd.Size = new System.Drawing.Size(26, 24);
            this.gbAdd.TabIndex = 3;
            this.gbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAdd.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAdd.Click += new System.EventHandler(this.gbAdd_Click);
            // 
            // cdListaDestinatarios
            // 
            this.cdListaDestinatarios.FormattingEnabled = true;
            this.cdListaDestinatarios.ItemHeight = 15;
            this.cdListaDestinatarios.Location = new System.Drawing.Point(711, 34);
            this.cdListaDestinatarios.Name = "cdListaDestinatarios";
            this.cdListaDestinatarios.Size = new System.Drawing.Size(274, 124);
            this.cdListaDestinatarios.Sorted = true;
            this.cdListaDestinatarios.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(23, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 22);
            this.lblCodigo.TabIndex = 106;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.EmptyValid = false;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(106, 55);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(83, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 22);
            this.lblDescripcion.TabIndex = 107;
            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.EmptyValid = false;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(106, 95);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(287, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblDestinatarios
            // 
            this.lblDestinatarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatarios.Location = new System.Drawing.Point(427, 32);
            this.lblDestinatarios.Name = "lblDestinatarios";
            this.lblDestinatarios.Size = new System.Drawing.Size(88, 22);
            this.lblDestinatarios.TabIndex = 108;
            this.lblDestinatarios.Text = "Destinatarios:";
            this.lblDestinatarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // teDestinatario
            // 
            this.teDestinatario.BackColor = System.Drawing.SystemColors.Window;
            this.teDestinatario.Enabled = false;
            this.teDestinatario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teDestinatario.Location = new System.Drawing.Point(430, 57);
            this.teDestinatario.MaxLength = 0;
            this.teDestinatario.Multiline = true;
            this.teDestinatario.Name = "teDestinatario";
            this.teDestinatario.Size = new System.Drawing.Size(263, 20);
            this.teDestinatario.TabIndex = 2;
            // 
            // DestinatariosMails
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1014, 543);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DestinatariosMails";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TabText = "Mantenimiento de DestinatariosMails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DestinatariosMails_FormClosed);
            this.Load += new System.EventHandler(this.DestinatariosMails_Load);
            this.xpnlBase.ResumeLayout(false);
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmEdicion.ResumeLayout(false);
            this.frmEdicion.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TNGS.NetControls.CDList cdListaDestinatarios;
        private TNGS.NetControls.GlassButton gbRemoveSelected;
        private TNGS.NetControls.GlassButton gbAdd;
        private TNGS.NetControls.GlassButton gbHabilitar;
        private TNGS.NetControls.GlassButton gbDeshabilitar;
        private TNGS.NetControls.GlassButton gbCompactar;
        private TNGS.NetControls.GlassButton gbSalir;
    }
}
