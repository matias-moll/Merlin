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
        private TNGS.NetControls.GlassButton gbModPadre;
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.ImgGroup frmOper;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private TNGS.NetControls.ImgGroup frmData;
        private System.Windows.Forms.Label lblNroitem;
        private TNGS.NetControls.NumberEdit txtNroitem;
        private System.Windows.Forms.Label lblCodrep;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlesRepa));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabPageSwitcher1 = new RibbonStyle.TabPageSwitcher();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel3 = new TNGS.NetControls.TSPanel();
            this.gbHabilitar = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.gbDeshabilitar = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.gbCompactar = new TNGS.NetControls.GlassButton();
            this.gbNuevo = new TNGS.NetControls.GlassButton();
            this.gbModificar = new TNGS.NetControls.GlassButton();
            this.gbSalir = new TNGS.NetControls.GlassButton();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.cmbControl = new TNGS.NetControls.CDCombo();
            this.gbModPadre = new TNGS.NetControls.GlassButton();
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
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.xpnlBase.SkinFixed = true;
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
            this.tabStripPage1.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.tsPanel3.Controls.Add(this.gbHabilitar);
            this.tsPanel3.Controls.Add(this.cmdGrabar);
            this.tsPanel3.Controls.Add(this.gbDeshabilitar);
            this.tsPanel3.Controls.Add(this.cmdCancelar);
            this.tsPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel3.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel3.Location = new System.Drawing.Point(539, 3);
            this.tsPanel3.Name = "tsPanel3";
            this.tsPanel3.Opacity = 255;
            this.tsPanel3.Size = new System.Drawing.Size(318, 85);
            this.tsPanel3.Speed = 1;
            this.tsPanel3.TabIndex = 4;
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
            this.gbHabilitar.Location = new System.Drawing.Point(181, 6);
            this.gbHabilitar.Name = "gbHabilitar";
            this.gbHabilitar.RoundCorners = 2;
            this.gbHabilitar.Size = new System.Drawing.Size(127, 25);
            this.gbHabilitar.TabIndex = 21;
            this.gbHabilitar.Text = "Habilitar";
            this.gbHabilitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbHabilitar.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbHabilitar.Click += new System.EventHandler(this.gbChangeHabilitado_Click);
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
            this.cmdGrabar.Location = new System.Drawing.Point(24, 2);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.Size = new System.Drawing.Size(70, 60);
            this.cmdGrabar.TabIndex = 19;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGrabar.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdGrabar.Click += new System.EventHandler(this.gbGrabar_Click);
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
            this.gbDeshabilitar.Location = new System.Drawing.Point(181, 35);
            this.gbDeshabilitar.Name = "gbDeshabilitar";
            this.gbDeshabilitar.RoundCorners = 2;
            this.gbDeshabilitar.Size = new System.Drawing.Size(127, 25);
            this.gbDeshabilitar.TabIndex = 22;
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
            this.cmdCancelar.Location = new System.Drawing.Point(98, 2);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.RoundCorners = 2;
            this.cmdCancelar.Size = new System.Drawing.Size(70, 60);
            this.cmdCancelar.TabIndex = 20;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCancelar.W8Color = System.Drawing.Color.Red;
            this.cmdCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Operaciones";
            this.tsPanel1.Controls.Add(this.gbCompactar);
            this.tsPanel1.Controls.Add(this.gbNuevo);
            this.tsPanel1.Controls.Add(this.gbModificar);
            this.tsPanel1.Controls.Add(this.gbSalir);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel1.Location = new System.Drawing.Point(242, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(297, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 2;
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
            this.gbCompactar.Location = new System.Drawing.Point(176, 35);
            this.gbCompactar.Name = "gbCompactar";
            this.gbCompactar.RoundCorners = 2;
            this.gbCompactar.Size = new System.Drawing.Size(104, 25);
            this.gbCompactar.TabIndex = 16;
            this.gbCompactar.Text = "Compactar";
            this.gbCompactar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCompactar.W8Color = System.Drawing.Color.Gray;
            this.gbCompactar.Click += new System.EventHandler(this.gbCompactar_Click);
            // 
            // gbNuevo
            // 
            this.gbNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevo.BackgroundImage")));
            this.gbNuevo.BlackBorder = true;
            this.gbNuevo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevo.CircleButton = false;
            this.gbNuevo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.gbNuevo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbNuevo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbNuevo.FlatFontSize = 9;
            this.gbNuevo.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbNuevo.ImageOnTop = true;
            this.gbNuevo.Location = new System.Drawing.Point(11, 2);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.RoundCorners = 2;
            this.gbNuevo.Size = new System.Drawing.Size(70, 60);
            this.gbNuevo.TabIndex = 13;
            this.gbNuevo.Text = "Nuevo";
            this.gbNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbNuevo.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbNuevo.Click += new System.EventHandler(this.gbNuevo_Click);
            // 
            // gbModificar
            // 
            this.gbModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbModificar.BackgroundImage")));
            this.gbModificar.BlackBorder = true;
            this.gbModificar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbModificar.CircleButton = false;
            this.gbModificar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.gbModificar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbModificar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbModificar.FlatFontSize = 9;
            this.gbModificar.FlatTextColor = System.Drawing.Color.Black;
            this.gbModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbModificar.ImageOnTop = true;
            this.gbModificar.Location = new System.Drawing.Point(89, 2);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.RoundCorners = 2;
            this.gbModificar.Size = new System.Drawing.Size(75, 60);
            this.gbModificar.TabIndex = 14;
            this.gbModificar.Text = "Modificar";
            this.gbModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbModificar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbModificar.Click += new System.EventHandler(this.gbModificar_Click);
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
            this.gbSalir.Location = new System.Drawing.Point(176, 6);
            this.gbSalir.Name = "gbSalir";
            this.gbSalir.RoundCorners = 2;
            this.gbSalir.Size = new System.Drawing.Size(104, 25);
            this.gbSalir.TabIndex = 15;
            this.gbSalir.Text = "Salir";
            this.gbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbSalir.W8Color = System.Drawing.Color.Red;
            this.gbSalir.Click += new System.EventHandler(this.gbSalir_Click);
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Control";
            this.tsPanel2.Controls.Add(this.cmbControl);
            this.tsPanel2.Controls.Add(this.gbModPadre);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.FlatColor = System.Drawing.Color.RoyalBlue;
            this.tsPanel2.Location = new System.Drawing.Point(0, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(242, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 3;
            // 
            // cmbControl
            // 
            this.cmbControl.BackColor = System.Drawing.SystemColors.Window;
            this.cmbControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbControl.FormattingEnabled = true;
            this.cmbControl.Location = new System.Drawing.Point(14, 39);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(210, 23);
            this.cmbControl.Sorted = true;
            this.cmbControl.TabIndex = 25;
            this.cmbControl.SelectedIndexChanged += new System.EventHandler(this.cmbControl_SelectedIndexChanged);
            // 
            // gbModPadre
            // 
            this.gbModPadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbModPadre.BackgroundImage")));
            this.gbModPadre.BlackBorder = true;
            this.gbModPadre.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbModPadre.CircleButton = false;
            this.gbModPadre.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Folder;
            this.gbModPadre.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbModPadre.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Default;
            this.gbModPadre.FlatFontSize = 9;
            this.gbModPadre.FlatTextColor = System.Drawing.Color.Black;
            this.gbModPadre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbModPadre.Location = new System.Drawing.Point(14, 7);
            this.gbModPadre.Name = "gbModPadre";
            this.gbModPadre.PCode = "M.CONTROL";
            this.gbModPadre.RoundCorners = 2;
            this.gbModPadre.Size = new System.Drawing.Size(210, 25);
            this.gbModPadre.TabIndex = 24;
            this.gbModPadre.Text = "Mantenimiento de Controles";
            this.gbModPadre.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbModPadre.Click += new System.EventHandler(this.gbModPadre_Click);
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
            this.grdDatos.Location = new System.Drawing.Point(4, 141);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(976, 247);
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
            this.cmdPrint.Location = new System.Drawing.Point(950, 117);
            this.cmdPrint.Name = "cmdPrint";
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
            this.cmdExcel.Location = new System.Drawing.Point(920, 117);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.PCode = "TNGS.PRINT";
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
            this.frmEdicion.Controls.Add(this.cdcCodRep);
            this.frmEdicion.Controls.Add(this.lblNroitem);
            this.frmEdicion.Controls.Add(this.txtNroitem);
            this.frmEdicion.Controls.Add(this.lblCodrep);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.FlatMode = true;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.ForeColor = System.Drawing.Color.Black;
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = "Controles de Reparacion";
            this.frmEdicion.Location = new System.Drawing.Point(4, 394);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 4;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(976, 83);
            this.frmEdicion.SkinFixed = true;
            this.frmEdicion.TabIndex = 21;
            this.frmEdicion.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmEdicion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmEdicion.TitleFontColor = System.Drawing.Color.White;
            // 
            // cdcCodRep
            // 
            this.cdcCodRep.BackColor = System.Drawing.SystemColors.Window;
            this.cdcCodRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcCodRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcCodRep.FormattingEnabled = true;
            this.cdcCodRep.Location = new System.Drawing.Point(462, 45);
            this.cdcCodRep.Name = "cdcCodRep";
            this.cdcCodRep.Size = new System.Drawing.Size(360, 23);
            this.cdcCodRep.Sorted = true;
            this.cdcCodRep.TabIndex = 108;
            // 
            // lblNroitem
            // 
            this.lblNroitem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroitem.Location = new System.Drawing.Point(114, 44);
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
            this.txtNroitem.Location = new System.Drawing.Point(224, 44);
            this.txtNroitem.MaxLength = 5;
            this.txtNroitem.Name = "txtNroitem";
            this.txtNroitem.NegativeValid = false;
            this.txtNroitem.Size = new System.Drawing.Size(110, 22);
            this.txtNroitem.TabIndex = 6;
            this.txtNroitem.Text = "0";
            this.txtNroitem.ZeroValid = false;
            // 
            // lblCodrep
            // 
            this.lblCodrep.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodrep.Location = new System.Drawing.Point(369, 45);
            this.lblCodrep.Name = "lblCodrep";
            this.lblCodrep.Size = new System.Drawing.Size(86, 22);
            this.lblCodrep.TabIndex = 107;
            this.lblCodrep.Text = "Reparacion:";
            this.lblCodrep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmOper
            // 
            this.frmOper.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.frmOper.BackgroundGradientColor = System.Drawing.Color.White;
            this.frmOper.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.frmOper.BlackBorder = true;
            this.frmOper.BorderColor = System.Drawing.Color.Black;
            this.frmOper.BorderThickness = 1F;
            this.frmOper.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmOper.FlatMode = true;
            this.frmOper.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOper.ForeColor = System.Drawing.Color.Black;
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
            this.frmOper.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmOper.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmOper.TitleFontColor = System.Drawing.Color.White;
            // 
            // frmData
            // 
            this.frmData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.frmData.BackgroundGradientColor = System.Drawing.Color.White;
            this.frmData.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.frmData.BlackBorder = true;
            this.frmData.BorderColor = System.Drawing.Color.Black;
            this.frmData.BorderThickness = 1F;
            this.frmData.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmData.FlatMode = true;
            this.frmData.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmData.ForeColor = System.Drawing.Color.Black;
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
            this.frmData.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.frmData.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmData.TitleFontColor = System.Drawing.Color.White;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private IContainer components;
        private TNGS.NetControls.GlassButton gbHabilitar;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton gbDeshabilitar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.GlassButton gbCompactar;
        private TNGS.NetControls.GlassButton gbNuevo;
        private TNGS.NetControls.GlassButton gbModificar;
        private TNGS.NetControls.GlassButton gbSalir;
    }
}
