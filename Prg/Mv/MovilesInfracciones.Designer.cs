#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Mrln.Mv
{
    public partial class MovilesInfracciones : Form
    {
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton cmdSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdModificar;
        private TNGS.NetControls.GlassButton cmdPurgar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblPatente;
        private TNGS.NetControls.TextEdit txtPatente;
        private System.Windows.Forms.Label lblFecha;
        private TNGS.NetControls.DateTimeEdit txtFecha;
        private System.Windows.Forms.Label lblCodmotivo;
        private TNGS.NetControls.CDCombo cmbCodmotivo;
        private System.Windows.Forms.Label lblLugar;
        private TNGS.NetControls.TextEdit txtLugar;
        private System.Windows.Forms.Label lblPagada;
        private TNGS.NetControls.CDCombo cmbPagada;
        private System.Windows.Forms.Label lblImporte;
        private TNGS.NetControls.DecimalEdit txtImporte;
        private System.Windows.Forms.Label lblComentario;
        private TNGS.NetControls.TextEdit txtComentario;
        private System.Windows.Forms.Label lblAnulada;
        private TNGS.NetControls.GlassButton cmdDesHab;
        private TNGS.NetControls.GlassButton cmdHab;
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
            this.components = new System.ComponentModel.Container();
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.cmdHab = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.cmdDesHab = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.cmdSalir = new TNGS.NetControls.GlassButton();
            this.cmdPurgar = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.cdcAnulada = new TNGS.NetControls.CDCombo();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new TNGS.NetControls.TextEdit();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new TNGS.NetControls.DateTimeEdit();
            this.lblCodmotivo = new System.Windows.Forms.Label();
            this.cmbCodmotivo = new TNGS.NetControls.CDCombo();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new TNGS.NetControls.TextEdit();
            this.lblPagada = new System.Windows.Forms.Label();
            this.cmbPagada = new TNGS.NetControls.CDCombo();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new TNGS.NetControls.DecimalEdit();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new TNGS.NetControls.TextEdit();
            this.lblAnulada = new System.Windows.Forms.Label();
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
            this.xpnlBase.BackColor1 = System.Drawing.SystemColors.Control;
            this.xpnlBase.BackColor2 = System.Drawing.SystemColors.Control;
            this.xpnlBase.Controls.Add(this.tsContainer1);
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(900, 600);
            this.xpnlBase.TabIndex = 0;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(900, 115);
            this.tsContainer1.TabIndex = 22;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(900, 89);
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
            this.tabStripPage1.Size = new System.Drawing.Size(892, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Edición";
            this.tsPanel2.Controls.Add(this.cmdHab);
            this.tsPanel2.Controls.Add(this.cmdCancelar);
            this.tsPanel2.Controls.Add(this.cmdGrabar);
            this.tsPanel2.Controls.Add(this.cmdDesHab);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(268, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(294, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 1;
            // 
            // cmdHab
            // 
            this.cmdHab.BlackBorder = true;
            this.cmdHab.CircleButton = false;
            this.cmdHab.FixedImage = TNGS.NetControls.FixedGlassButtons.Enable;
            this.cmdHab.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdHab.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdHab.FlatFontSize = 9;
            this.cmdHab.FlatTextColor = System.Drawing.Color.Black;
            this.cmdHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdHab.Location = new System.Drawing.Point(166, 7);
            this.cmdHab.Name = "cmdHab";
            this.cmdHab.RoundCorners = 2;
            this.cmdHab.Size = new System.Drawing.Size(113, 26);
            this.cmdHab.TabIndex = 11;
            this.cmdHab.Text = "Habilitar";
            this.cmdHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHab.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BlackBorder = true;
            this.cmdCancelar.CircleButton = false;
            this.cmdCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.tCancel;
            this.cmdCancelar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdCancelar.FlatFontSize = 9;
            this.cmdCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdCancelar.ImageOnTop = true;
            this.cmdCancelar.Location = new System.Drawing.Point(83, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.RoundCorners = 2;
            this.cmdCancelar.Size = new System.Drawing.Size(73, 62);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.BlackBorder = true;
            this.cmdGrabar.CircleButton = false;
            this.cmdGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.tSave;
            this.cmdGrabar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdGrabar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdGrabar.FlatFontSize = 9;
            this.cmdGrabar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdGrabar.ImageOnTop = true;
            this.cmdGrabar.Location = new System.Drawing.Point(8, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.Size = new System.Drawing.Size(72, 62);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdDesHab
            // 
            this.cmdDesHab.BlackBorder = true;
            this.cmdDesHab.CircleButton = false;
            this.cmdDesHab.FixedImage = TNGS.NetControls.FixedGlassButtons.Disable;
            this.cmdDesHab.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdDesHab.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdDesHab.FlatFontSize = 9;
            this.cmdDesHab.FlatTextColor = System.Drawing.Color.Black;
            this.cmdDesHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdDesHab.Location = new System.Drawing.Point(166, 35);
            this.cmdDesHab.Name = "cmdDesHab";
            this.cmdDesHab.RoundCorners = 2;
            this.cmdDesHab.Size = new System.Drawing.Size(113, 26);
            this.cmdDesHab.TabIndex = 11;
            this.cmdDesHab.Text = "Deshabilitar";
            this.cmdDesHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDesHab.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdDesHab.Click += new System.EventHandler(this.cmdDesHab_Click);
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.cmdSalir);
            this.tsPanel1.Controls.Add(this.cmdPurgar);
            this.tsPanel1.Controls.Add(this.cmdModificar);
            this.tsPanel1.Controls.Add(this.cmdNuevo);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(268, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 0;
            // 
            // cmdSalir
            // 
            this.cmdSalir.BlackBorder = true;
            this.cmdSalir.CircleButton = false;
            this.cmdSalir.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.cmdSalir.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdSalir.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdSalir.FlatFontSize = 9;
            this.cmdSalir.FlatTextColor = System.Drawing.Color.Black;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdSalir.Location = new System.Drawing.Point(151, 7);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.RoundCorners = 2;
            this.cmdSalir.Size = new System.Drawing.Size(104, 26);
            this.cmdSalir.TabIndex = 6;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdPurgar
            // 
            this.cmdPurgar.BlackBorder = true;
            this.cmdPurgar.CircleButton = false;
            this.cmdPurgar.FixedImage = TNGS.NetControls.FixedGlassButtons.Agrupa;
            this.cmdPurgar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdPurgar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdPurgar.FlatFontSize = 9;
            this.cmdPurgar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPurgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdPurgar.Location = new System.Drawing.Point(151, 35);
            this.cmdPurgar.Name = "cmdPurgar";
            this.cmdPurgar.RoundCorners = 2;
            this.cmdPurgar.Size = new System.Drawing.Size(104, 26);
            this.cmdPurgar.TabIndex = 5;
            this.cmdPurgar.Text = "Compactar";
            this.cmdPurgar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPurgar.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdPurgar.Click += new System.EventHandler(this.cmdPurgar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BlackBorder = true;
            this.cmdModificar.CircleButton = false;
            this.cmdModificar.FixedImage = TNGS.NetControls.FixedGlassButtons.tModify;
            this.cmdModificar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdModificar.FlatFontSize = 9;
            this.cmdModificar.FlatTextColor = System.Drawing.Color.Black;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdModificar.ImageOnTop = true;
            this.cmdModificar.Location = new System.Drawing.Point(72, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.RoundCorners = 2;
            this.cmdModificar.Size = new System.Drawing.Size(62, 62);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Text = "Editar";
            this.cmdModificar.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.BlackBorder = true;
            this.cmdNuevo.CircleButton = false;
            this.cmdNuevo.FixedImage = TNGS.NetControls.FixedGlassButtons.tNew;
            this.cmdNuevo.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdNuevo.FlatFontSize = 9;
            this.cmdNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdNuevo.ImageOnTop = true;
            this.cmdNuevo.Location = new System.Drawing.Point(8, 4);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.RoundCorners = 2;
            this.cmdNuevo.Size = new System.Drawing.Size(62, 62);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
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
            this.tsBase1.Size = new System.Drawing.Size(900, 26);
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
            this.lblTitle.Text = "Infracciones del Móvil:";
            // 
            // grdDatos
            // 
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grdDatos.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(206)))), ((int)(((byte)(72)))));
            this.grdDatos.CaptionVisible = false;
            this.grdDatos.DataMember = "";
            this.grdDatos.ExcelTitle = "";
            this.grdDatos.GridOrder = "";
            this.grdDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDatos.Location = new System.Drawing.Point(4, 142);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(892, 276);
            this.grdDatos.TabIndex = 0;
            this.grdDatos.Advance += new TNGS.NetRoutines.AdvanceEventHandler(this.grdDatos_Advance);
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
            this.grdDatos.HeaderClick += new TNGS.NetRoutines.HeaderClickEventHandler(this.grdDatos_HeaderClick);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPrint.BlackBorder = true;
            this.cmdPrint.CircleButton = false;
            this.cmdPrint.FixedImage = TNGS.NetControls.FixedGlassButtons.bPrint;
            this.cmdPrint.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdPrint.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdPrint.FlatFontSize = 9;
            this.cmdPrint.FlatTextColor = System.Drawing.Color.Black;
            this.cmdPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdPrint.Location = new System.Drawing.Point(870, 118);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.PCode = "TNGS.PRINT";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdExcel
            // 
            this.cmdExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExcel.BlackBorder = true;
            this.cmdExcel.CircleButton = false;
            this.cmdExcel.FixedImage = TNGS.NetControls.FixedGlassButtons.bExcel;
            this.cmdExcel.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdExcel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdExcel.FlatFontSize = 9;
            this.cmdExcel.FlatTextColor = System.Drawing.Color.Black;
            this.cmdExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdExcel.Location = new System.Drawing.Point(845, 118);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.EXCEL";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmEdicion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BorderColor = System.Drawing.Color.Black;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.Controls.Add(this.cdcAnulada);
            this.frmEdicion.Controls.Add(this.lblPatente);
            this.frmEdicion.Controls.Add(this.txtPatente);
            this.frmEdicion.Controls.Add(this.lblFecha);
            this.frmEdicion.Controls.Add(this.txtFecha);
            this.frmEdicion.Controls.Add(this.lblCodmotivo);
            this.frmEdicion.Controls.Add(this.cmbCodmotivo);
            this.frmEdicion.Controls.Add(this.lblLugar);
            this.frmEdicion.Controls.Add(this.txtLugar);
            this.frmEdicion.Controls.Add(this.lblPagada);
            this.frmEdicion.Controls.Add(this.cmbPagada);
            this.frmEdicion.Controls.Add(this.lblImporte);
            this.frmEdicion.Controls.Add(this.txtImporte);
            this.frmEdicion.Controls.Add(this.lblComentario);
            this.frmEdicion.Controls.Add(this.txtComentario);
            this.frmEdicion.Controls.Add(this.lblAnulada);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = "Infracción";
            this.frmEdicion.Location = new System.Drawing.Point(4, 424);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 10;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(892, 172);
            this.frmEdicion.TabIndex = 21;
            // 
            // cdcAnulada
            // 
            this.cdcAnulada.BackColor = System.Drawing.SystemColors.Window;
            this.cdcAnulada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcAnulada.Enabled = false;
            this.cdcAnulada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcAnulada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdcAnulada.Location = new System.Drawing.Point(474, 123);
            this.cdcAnulada.Name = "cdcAnulada";
            this.cdcAnulada.Size = new System.Drawing.Size(88, 24);
            this.cdcAnulada.Sorted = true;
            this.cdcAnulada.TabIndex = 114;
            // 
            // lblPatente
            // 
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(13, 46);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(62, 22);
            this.lblPatente.TabIndex = 106;
            this.lblPatente.Text = "Patente:";
            this.lblPatente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPatente
            // 
            this.txtPatente.BackColor = System.Drawing.SystemColors.Window;
            this.txtPatente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatente.EmptyValid = false;
            this.txtPatente.Enabled = false;
            this.txtPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatente.Location = new System.Drawing.Point(81, 46);
            this.txtPatente.MaxLength = 8;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(133, 22);
            this.txtPatente.TabIndex = 6;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(348, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 22);
            this.lblFecha.TabIndex = 107;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Window;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(412, 46);
            this.txtFecha.MaxLength = 16;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(150, 22);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.Text = "01/01/1900 00:00";
            // 
            // lblCodmotivo
            // 
            this.lblCodmotivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodmotivo.Location = new System.Drawing.Point(573, 44);
            this.lblCodmotivo.Name = "lblCodmotivo";
            this.lblCodmotivo.Size = new System.Drawing.Size(65, 22);
            this.lblCodmotivo.TabIndex = 108;
            this.lblCodmotivo.Text = "Motivo:";
            this.lblCodmotivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCodmotivo
            // 
            this.cmbCodmotivo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCodmotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodmotivo.Enabled = false;
            this.cmbCodmotivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCodmotivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodmotivo.Location = new System.Drawing.Point(644, 42);
            this.cmbCodmotivo.Name = "cmbCodmotivo";
            this.cmbCodmotivo.Size = new System.Drawing.Size(225, 24);
            this.cmbCodmotivo.Sorted = true;
            this.cmbCodmotivo.TabIndex = 8;
            // 
            // lblLugar
            // 
            this.lblLugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(16, 86);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(59, 22);
            this.lblLugar.TabIndex = 109;
            this.lblLugar.Text = "Lugar:";
            this.lblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLugar
            // 
            this.txtLugar.BackColor = System.Drawing.SystemColors.Window;
            this.txtLugar.Enabled = false;
            this.txtLugar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugar.Location = new System.Drawing.Point(81, 86);
            this.txtLugar.MaxLength = 60;
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(481, 22);
            this.txtLugar.TabIndex = 9;
            // 
            // lblPagada
            // 
            this.lblPagada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagada.Location = new System.Drawing.Point(13, 125);
            this.lblPagada.Name = "lblPagada";
            this.lblPagada.Size = new System.Drawing.Size(62, 22);
            this.lblPagada.TabIndex = 110;
            this.lblPagada.Text = "Pagada:";
            this.lblPagada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPagada
            // 
            this.cmbPagada.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPagada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPagada.Enabled = false;
            this.cmbPagada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPagada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPagada.Location = new System.Drawing.Point(81, 123);
            this.cmbPagada.Name = "cmbPagada";
            this.cmbPagada.Size = new System.Drawing.Size(104, 24);
            this.cmbPagada.Sorted = true;
            this.cmbPagada.TabIndex = 10;
            // 
            // lblImporte
            // 
            this.lblImporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(214, 123);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(65, 22);
            this.lblImporte.TabIndex = 111;
            this.lblImporte.Text = "Importe:";
            this.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtImporte.Enabled = false;
            this.txtImporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(281, 123);
            this.txtImporte.MaxLength = 10;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(109, 22);
            this.txtImporte.TabIndex = 11;
            this.txtImporte.Text = "0,00";
            // 
            // lblComentario
            // 
            this.lblComentario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(577, 81);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(61, 22);
            this.lblComentario.TabIndex = 112;
            this.lblComentario.Text = "Detalle:";
            this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.SystemColors.Window;
            this.txtComentario.Enabled = false;
            this.txtComentario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(644, 83);
            this.txtComentario.MaxLength = 0;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(225, 64);
            this.txtComentario.TabIndex = 12;
            // 
            // lblAnulada
            // 
            this.lblAnulada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulada.Location = new System.Drawing.Point(402, 123);
            this.lblAnulada.Name = "lblAnulada";
            this.lblAnulada.Size = new System.Drawing.Size(70, 22);
            this.lblAnulada.TabIndex = 113;
            this.lblAnulada.Text = "Anulada:";
            this.lblAnulada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MovilesInfracciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.xpnlBase);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MovilesInfracciones";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MovilesInfracciones_FormClosed);
            this.Load += new System.EventHandler(this.MovilesInfracciones_Load);
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

        private TNGS.NetControls.CDCombo cdcAnulada;
        private IContainer components;
    }
}
