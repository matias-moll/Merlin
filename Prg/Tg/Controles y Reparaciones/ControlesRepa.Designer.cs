#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Mrln.Tg
{
    public partial class ControlesRepa : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton cmdModPadre;
        private TNGS.NetControls.GlassButton cmdSalir;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.ImgGroup frmOper;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdModificar;
        private TNGS.NetControls.GlassButton cmdPurgar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private TNGS.NetControls.ImgGroup frmData;
        private System.Windows.Forms.Label lblNroitem;
        private TNGS.NetControls.NumberEdit txtNroitem;
        private System.Windows.Forms.Label lblCodrep;
        private TNGS.NetControls.GlassButton cmdDesHab;
        private TNGS.NetControls.GlassButton cmdHab;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.FullGrid grdDatos;
        private TNGS.NetControls.TSContainer tsContainer1;
        private RibbonStyle.TabPageSwitcher tabPageSwitcher1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.TSPanel tsPanel3;

        /// <summary>
        /// Liberamos los recursos utilizados
        /// </summary>
        protected override void Dispose( bool disposing )
        {

            base.Dispose(disposing);
       }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel3 = new TNGS.NetControls.TSPanel();
            this.cmdHab = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.cmdDesHab = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.cmdSalir = new TNGS.NetControls.GlassButton();
            this.cmdPurgar = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.cmbControl = new TNGS.NetControls.CDCombo();
            this.cmdModPadre = new TNGS.NetControls.GlassButton();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.grdDatos = new TNGS.NetControls.FullGrid();
            this.cmdPrint = new TNGS.NetControls.GlassButton();
            this.cmdExcel = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.cdcCodRep = new TNGS.NetControls.CDCombo();
            this.lblNroitem = new System.Windows.Forms.Label();
            this.txtNroitem = new TNGS.NetControls.NumberEdit();
            this.lblCodrep = new System.Windows.Forms.Label();
            this.frmOper = new TNGS.NetControls.ImgGroup();
            this.frmData = new TNGS.NetControls.ImgGroup();
            this.xpnlBase.SuspendLayout();
            this.tsContainer1.SuspendLayout();
            this.tabPageSwitcher1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel3.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsBase1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.SystemColors.Control;
            this.xpnlBase.BackColor2 = System.Drawing.SystemColors.Control;
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.tsContainer1);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(984, 484);
            this.xpnlBase.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 125);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 16);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Controles de Reparacion:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabPageSwitcher1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(984, 115);
            this.tsContainer1.TabIndex = 25;
            // 
            // tabPageSwitcher1
            // 
            this.tabPageSwitcher1.Controls.Add(this.tabStripPage1);
            this.tabPageSwitcher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageSwitcher1.Location = new System.Drawing.Point(0, 26);
            this.tabPageSwitcher1.Name = "tabPageSwitcher1";
            this.tabPageSwitcher1.SelectedTabStripPage = this.tabStripPage1;
            this.tabPageSwitcher1.Size = new System.Drawing.Size(984, 89);
            this.tabPageSwitcher1.TabIndex = 1;
            this.tabPageSwitcher1.TabStrip = this.tsBase1;
            this.tabPageSwitcher1.Text = "tabPageSwitcher1";
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.tsPanel3);
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(4, 0);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(976, 87);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 0;
            // 
            // tsPanel3
            // 
            this.tsPanel3.Caption = "Edición";
            this.tsPanel3.Controls.Add(this.cmdHab);
            this.tsPanel3.Controls.Add(this.cmdGrabar);
            this.tsPanel3.Controls.Add(this.cmdCancelar);
            this.tsPanel3.Controls.Add(this.cmdDesHab);
            this.tsPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel3.Location = new System.Drawing.Point(504, 3);
            this.tsPanel3.Name = "tsPanel3";
            this.tsPanel3.Opacity = 255;
            this.tsPanel3.Size = new System.Drawing.Size(292, 85);
            this.tsPanel3.Speed = 1;
            this.tsPanel3.TabIndex = 4;
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
            this.cmdHab.Location = new System.Drawing.Point(161, 3);
            this.cmdHab.Name = "cmdHab";
            this.cmdHab.RoundCorners = 2;
            this.cmdHab.Size = new System.Drawing.Size(118, 26);
            this.cmdHab.TabIndex = 11;
            this.cmdHab.Text = "Habilitar";
            this.cmdHab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHab.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdHab.Click += new System.EventHandler(this.cmdDesHab_Click);
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
            this.cmdGrabar.Location = new System.Drawing.Point(3, 4);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.Size = new System.Drawing.Size(73, 62);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
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
            this.cmdCancelar.Location = new System.Drawing.Point(82, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.RoundCorners = 2;
            this.cmdCancelar.Size = new System.Drawing.Size(73, 62);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
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
            this.cmdDesHab.Location = new System.Drawing.Point(161, 35);
            this.cmdDesHab.Name = "cmdDesHab";
            this.cmdDesHab.RoundCorners = 2;
            this.cmdDesHab.Size = new System.Drawing.Size(118, 26);
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
            this.tsPanel1.Location = new System.Drawing.Point(224, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(280, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 2;
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
            this.cmdSalir.Location = new System.Drawing.Point(170, 7);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.RoundCorners = 2;
            this.cmdSalir.Size = new System.Drawing.Size(104, 26);
            this.cmdSalir.TabIndex = 5;
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
            this.cmdPurgar.Location = new System.Drawing.Point(170, 36);
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
            this.cmdModificar.Location = new System.Drawing.Point(87, 3);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.RoundCorners = 2;
            this.cmdModificar.Size = new System.Drawing.Size(73, 62);
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
            this.cmdNuevo.Size = new System.Drawing.Size(73, 62);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Control";
            this.tsPanel2.Controls.Add(this.cmbControl);
            this.tsPanel2.Controls.Add(this.cmdModPadre);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(0, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(224, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 3;
            // 
            // cmbControl
            // 
            this.cmbControl.BackColor = System.Drawing.SystemColors.Window;
            this.cmbControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Location = new System.Drawing.Point(8, 39);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(210, 23);
            this.cmbControl.Sorted = true;
            this.cmbControl.TabIndex = 25;
            this.cmbControl.SelectedIndexChanged += new System.EventHandler(this.cmbControl_SelectedIndexChanged);
            // 
            // cmdModPadre
            // 
            this.cmdModPadre.BlackBorder = true;
            this.cmdModPadre.CircleButton = false;
            this.cmdModPadre.FixedImage = TNGS.NetControls.FixedGlassButtons.Folder2;
            this.cmdModPadre.FlatColor = System.Drawing.Color.RoyalBlue;
            this.cmdModPadre.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.cmdModPadre.FlatFontSize = 9;
            this.cmdModPadre.FlatTextColor = System.Drawing.Color.Black;
            this.cmdModPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmdModPadre.Location = new System.Drawing.Point(8, 7);
            this.cmdModPadre.Name = "cmdModPadre";
            this.cmdModPadre.PCode = "M.CONTROL";
            this.cmdModPadre.RoundCorners = 2;
            this.cmdModPadre.Size = new System.Drawing.Size(210, 26);
            this.cmdModPadre.TabIndex = 24;
            this.cmdModPadre.Text = "Mantenimiento de Controles";
            this.cmdModPadre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModPadre.W8Color = System.Drawing.Color.RoyalBlue;
            this.cmdModPadre.Click += new System.EventHandler(this.cmdModPadre_Click);
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
            this.tsBase1.Size = new System.Drawing.Size(984, 26);
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
            this.grdDatos.Location = new System.Drawing.Point(4, 141);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(976, 263);
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
            this.cmdPrint.Location = new System.Drawing.Point(954, 117);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.RoundCorners = 2;
            this.cmdPrint.Size = new System.Drawing.Size(26, 24);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cmdExcel.Location = new System.Drawing.Point(928, 117);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.PRINT";
            this.cmdExcel.RoundCorners = 2;
            this.cmdExcel.Size = new System.Drawing.Size(26, 24);
            this.cmdExcel.TabIndex = 1;
            this.cmdExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.frmEdicion.Controls.Add(this.cdcCodRep);
            this.frmEdicion.Controls.Add(this.lblNroitem);
            this.frmEdicion.Controls.Add(this.txtNroitem);
            this.frmEdicion.Controls.Add(this.lblCodrep);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = "Controles de Reparacion";
            this.frmEdicion.Location = new System.Drawing.Point(4, 410);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 10;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(976, 67);
            this.frmEdicion.TabIndex = 21;
            // 
            // cdcCodRep
            // 
            this.cdcCodRep.BackColor = System.Drawing.SystemColors.Window;
            this.cdcCodRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcCodRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcCodRep.FormattingEnabled = true;
            this.cdcCodRep.Location = new System.Drawing.Point(578, 29);
            this.cdcCodRep.Name = "cdcCodRep";
            this.cdcCodRep.Size = new System.Drawing.Size(205, 23);
            this.cdcCodRep.Sorted = true;
            this.cdcCodRep.TabIndex = 108;
            // 
            // lblNroitem
            // 
            this.lblNroitem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroitem.Location = new System.Drawing.Point(122, 29);
            this.lblNroitem.Name = "lblNroitem";
            this.lblNroitem.Size = new System.Drawing.Size(104, 22);
            this.lblNroitem.TabIndex = 106;
            this.lblNroitem.Text = "Item:";
            this.lblNroitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNroitem
            // 
            this.txtNroitem.BackColor = System.Drawing.SystemColors.Window;
            this.txtNroitem.Enabled = false;
            this.txtNroitem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroitem.Location = new System.Drawing.Point(232, 29);
            this.txtNroitem.MaxLength = 5;
            this.txtNroitem.Name = "txtNroitem";
            this.txtNroitem.NegativeValid = false;
            this.txtNroitem.Size = new System.Drawing.Size(159, 22);
            this.txtNroitem.TabIndex = 6;
            this.txtNroitem.Text = "0";
            this.txtNroitem.ZeroValid = false;
            // 
            // lblCodrep
            // 
            this.lblCodrep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodrep.Location = new System.Drawing.Point(485, 29);
            this.lblCodrep.Name = "lblCodrep";
            this.lblCodrep.Size = new System.Drawing.Size(86, 22);
            this.lblCodrep.TabIndex = 107;
            this.lblCodrep.Text = "Reparacion:";
            this.lblCodrep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmOper
            // 
            this.frmOper.BackgroundColor = System.Drawing.Color.White;
            this.frmOper.BackgroundGradientColor = System.Drawing.Color.White;
            this.frmOper.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.frmOper.BorderColor = System.Drawing.Color.Black;
            this.frmOper.BorderThickness = 1F;
            this.frmOper.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmOper.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOper.GroupImage = null;
            this.frmOper.GroupTitle = "The Grouper";
            this.frmOper.Location = new System.Drawing.Point(0, 0);
            this.frmOper.Name = "frmOper";
            this.frmOper.Padding = new System.Windows.Forms.Padding(20);
            this.frmOper.PaintGroupBox = false;
            this.frmOper.RoundCorners = 10;
            this.frmOper.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmOper.ShadowControl = false;
            this.frmOper.ShadowThickness = 3;
            this.frmOper.Size = new System.Drawing.Size(368, 288);
            this.frmOper.TabIndex = 0;
            // 
            // frmData
            // 
            this.frmData.BackgroundColor = System.Drawing.Color.White;
            this.frmData.BackgroundGradientColor = System.Drawing.Color.White;
            this.frmData.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.frmData.BorderColor = System.Drawing.Color.Black;
            this.frmData.BorderThickness = 1F;
            this.frmData.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmData.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmData.GroupImage = null;
            this.frmData.GroupTitle = "The Grouper";
            this.frmData.Location = new System.Drawing.Point(0, 0);
            this.frmData.Name = "frmData";
            this.frmData.Padding = new System.Windows.Forms.Padding(20);
            this.frmData.PaintGroupBox = false;
            this.frmData.RoundCorners = 10;
            this.frmData.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmData.ShadowControl = false;
            this.frmData.ShadowThickness = 3;
            this.frmData.Size = new System.Drawing.Size(368, 288);
            this.frmData.TabIndex = 0;
            // 
            // ControlesRepa
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.Controls.Add(this.xpnlBase);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControlesRepa";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.Document;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento de ControlesReparations";
            this.Closed += new System.EventHandler(this.ControlesRepa_Closed);
            this.Load += new System.EventHandler(this.ControlesRepa_Load);
            this.xpnlBase.ResumeLayout(false);
            this.tsContainer1.ResumeLayout(false);
            this.tabPageSwitcher1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel3.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmEdicion.ResumeLayout(false);
            this.frmEdicion.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TNGS.NetControls.CDCombo cdcCodRep;
        private TNGS.NetControls.CDCombo cmbControl;
    }
}
