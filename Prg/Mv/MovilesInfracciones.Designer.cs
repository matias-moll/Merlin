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
        private System.Windows.Forms.Label lblTitle;
        private TNGS.NetControls.GlassButton cmdExcel;
        private TNGS.NetControls.GlassButton cmdPrint;
        private TNGS.NetControls.GlassButton cmdNuevo;
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
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;
        private TNGS.NetControls.FullGrid grdDatos;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovilesInfracciones));
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.gbHabilitar = new TNGS.NetControls.GlassButton();
            this.gbDeshabilitar = new TNGS.NetControls.GlassButton();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.gbCompactar = new TNGS.NetControls.GlassButton();
            this.cmdModificar = new TNGS.NetControls.GlassButton();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.xpnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlBase.BorderColor = System.Drawing.Color.Black;
            this.xpnlBase.Controls.Add(this.btnExit);
            this.xpnlBase.Controls.Add(this.gbHabilitar);
            this.xpnlBase.Controls.Add(this.gbCompactar);
            this.xpnlBase.Controls.Add(this.gbDeshabilitar);
            this.xpnlBase.Controls.Add(this.cmdCancelar);
            this.xpnlBase.Controls.Add(this.cmdModificar);
            this.xpnlBase.Controls.Add(this.cmdGrabar);
            this.xpnlBase.Controls.Add(this.cmdNuevo);
            this.xpnlBase.Controls.Add(this.lblTitle);
            this.xpnlBase.Controls.Add(this.grdDatos);
            this.xpnlBase.Controls.Add(this.cmdPrint);
            this.xpnlBase.Controls.Add(this.cmdExcel);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(900, 600);
            this.xpnlBase.SkinFixed = true;
            this.xpnlBase.TabIndex = 0;
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
            this.gbHabilitar.Location = new System.Drawing.Point(624, 12);
            this.gbHabilitar.Name = "gbHabilitar";
            this.gbHabilitar.RoundCorners = 2;
            this.gbHabilitar.Size = new System.Drawing.Size(113, 25);
            this.gbHabilitar.TabIndex = 17;
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
            this.gbDeshabilitar.Location = new System.Drawing.Point(624, 40);
            this.gbDeshabilitar.Name = "gbDeshabilitar";
            this.gbDeshabilitar.RoundCorners = 2;
            this.gbDeshabilitar.Size = new System.Drawing.Size(113, 25);
            this.gbDeshabilitar.TabIndex = 18;
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
            this.cmdCancelar.Location = new System.Drawing.Point(545, 9);
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
            this.cmdGrabar.Location = new System.Drawing.Point(467, 9);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.RoundCorners = 2;
            this.cmdGrabar.Size = new System.Drawing.Size(70, 60);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdGrabar.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdGrabar.Click += new System.EventHandler(this.gbGrabar_Click);
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
            this.gbCompactar.Location = new System.Drawing.Point(223, 44);
            this.gbCompactar.Name = "gbCompactar";
            this.gbCompactar.RoundCorners = 2;
            this.gbCompactar.Size = new System.Drawing.Size(104, 25);
            this.gbCompactar.TabIndex = 14;
            this.gbCompactar.Text = "Compactar";
            this.gbCompactar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCompactar.W8Color = System.Drawing.Color.Gray;
            this.gbCompactar.Click += new System.EventHandler(this.gbCompactar_Click);
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
            this.cmdModificar.Location = new System.Drawing.Point(136, 12);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.RoundCorners = 2;
            this.cmdModificar.Size = new System.Drawing.Size(75, 60);
            this.cmdModificar.TabIndex = 12;
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
            this.cmdNuevo.Location = new System.Drawing.Point(60, 12);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.RoundCorners = 2;
            this.cmdNuevo.Size = new System.Drawing.Size(70, 60);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdNuevo.W8Color = System.Drawing.Color.DodgerBlue;
            this.cmdNuevo.Click += new System.EventHandler(this.gbNuevo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 96);
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
            this.grdDatos.Location = new System.Drawing.Point(8, 116);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(884, 302);
            this.grdDatos.SkinFixed = true;
            this.grdDatos.TabIndex = 0;
            this.grdDatos.DataDClick += new TNGS.NetRoutines.DataDClickEventHandler(this.grdDatos_DataDClick);
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
            this.cmdPrint.Location = new System.Drawing.Point(862, 86);
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
            this.cmdExcel.Location = new System.Drawing.Point(833, 86);
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
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmEdicion.FlatMode = true;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.frmEdicion.ForeColor = System.Drawing.Color.Black;
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = "Infracción";
            this.frmEdicion.Location = new System.Drawing.Point(8, 424);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 4;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(884, 164);
            this.frmEdicion.SkinFixed = true;
            this.frmEdicion.TabIndex = 21;
            this.frmEdicion.TitleBackground = System.Drawing.Color.Firebrick;
            this.frmEdicion.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.frmEdicion.TitleFontColor = System.Drawing.Color.White;
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
            this.cdcAnulada.TabIndex = 5;
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
            this.txtPatente.TabIndex = 0;
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
            this.txtFecha.TabIndex = 1;
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
            this.cmbCodmotivo.TabIndex = 6;
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
            this.txtLugar.TabIndex = 2;
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
            this.cmbPagada.TabIndex = 3;
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
            this.txtImporte.TabIndex = 4;
            this.txtImporte.Text = "0.00";
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
            this.txtComentario.TabIndex = 7;
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
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(834, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 22;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.Load += new System.EventHandler(this.MovilesInfracciones_Load);
            this.xpnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.frmEdicion.ResumeLayout(false);
            this.frmEdicion.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private TNGS.NetControls.CDCombo cdcAnulada;
        private IContainer components;
        private TNGS.NetControls.GlassButton gbHabilitar;
        private TNGS.NetControls.GlassButton gbDeshabilitar;
        private TNGS.NetControls.GlassButton gbCompactar;
        private TNGS.NetControls.GlassButton cmdModificar;
        private Button btnExit;
    }
}
