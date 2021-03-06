﻿namespace Mrln.Ot
{
    partial class AltaOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaOrdenes));
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.cdcTalleres = new TNGS.NetControls.CDCombo();
            this.fullLabel6 = new TNGS.NetControls.FullLabel();
            this.neSeleccionado = new TNGS.NetControls.NumberEdit();
            this.gbQuitarSeleccionado = new TNGS.NetControls.GlassButton();
            this.gbQuitarTodos = new TNGS.NetControls.GlassButton();
            this.gbAgregar = new TNGS.NetControls.GlassButton();
            this.gbQuitarUltimo = new TNGS.NetControls.GlassButton();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.deImporte = new TNGS.NetControls.DecimalEdit();
            this.lstControlesReparaciones = new TNGS.NetControls.CDList();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.teComentario = new TNGS.NetControls.TextEdit();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.neOrdenTrabajo = new TNGS.NetControls.NumberEdit();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.rbReparaciones = new System.Windows.Forms.RadioButton();
            this.rbControles = new System.Windows.Forms.RadioButton();
            this.cdcPatente = new TNGS.NetControls.CDCombo();
            this.gbAccept = new TNGS.NetControls.GlassButton();
            this.fgControlRepaSeleccionados = new TNGS.NetControls.FullGrid();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.tgrpControlesYRep = new TNGS.NetControls.ImgGroup();
            this.tgrpOpciones = new TNGS.NetControls.ImgGroup();
            this.xPanel1.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).BeginInit();
            this.tgrpControlesYRep.SuspendLayout();
            this.tgrpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.BorderColor = System.Drawing.Color.Black;
            this.xPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xPanel1.Controls.Add(this.tgrpOpciones);
            this.xPanel1.Controls.Add(this.tgrpControlesYRep);
            this.xPanel1.Controls.Add(this.cdcTalleres);
            this.xPanel1.Controls.Add(this.fullLabel6);
            this.xPanel1.Controls.Add(this.neOrdenTrabajo);
            this.xPanel1.Controls.Add(this.pnlOpciones);
            this.xPanel1.Controls.Add(this.cdcPatente);
            this.xPanel1.Controls.Add(this.gbAccept);
            this.xPanel1.Controls.Add(this.fgControlRepaSeleccionados);
            this.xPanel1.Controls.Add(this.gbCancel);
            this.xPanel1.Controls.Add(this.fullLabel2);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(1003, 571);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // cdcTalleres
            // 
            this.cdcTalleres.BackColor = System.Drawing.SystemColors.Window;
            this.cdcTalleres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcTalleres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcTalleres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcTalleres.FormattingEnabled = true;
            this.cdcTalleres.Location = new System.Drawing.Point(363, 50);
            this.cdcTalleres.Name = "cdcTalleres";
            this.cdcTalleres.Size = new System.Drawing.Size(282, 23);
            this.cdcTalleres.Sorted = true;
            this.cdcTalleres.TabIndex = 18;
            // 
            // fullLabel6
            // 
            this.fullLabel6.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel6.Location = new System.Drawing.Point(302, 53);
            this.fullLabel6.Name = "fullLabel6";
            this.fullLabel6.Size = new System.Drawing.Size(61, 27);
            this.fullLabel6.TabIndex = 19;
            this.fullLabel6.Text = "Taller:";
            // 
            // neSeleccionado
            // 
            this.neSeleccionado.BackColor = System.Drawing.SystemColors.Window;
            this.neSeleccionado.Enabled = false;
            this.neSeleccionado.Location = new System.Drawing.Point(178, 44);
            this.neSeleccionado.Name = "neSeleccionado";
            this.neSeleccionado.Size = new System.Drawing.Size(133, 21);
            this.neSeleccionado.TabIndex = 18;
            this.neSeleccionado.Text = "0";
            // 
            // gbQuitarSeleccionado
            // 
            this.gbQuitarSeleccionado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbQuitarSeleccionado.BackgroundImage")));
            this.gbQuitarSeleccionado.BlackBorder = true;
            this.gbQuitarSeleccionado.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbQuitarSeleccionado.CircleButton = false;
            this.gbQuitarSeleccionado.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbQuitarSeleccionado.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbQuitarSeleccionado.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbQuitarSeleccionado.FlatFontSize = 9;
            this.gbQuitarSeleccionado.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbQuitarSeleccionado.Location = new System.Drawing.Point(178, 87);
            this.gbQuitarSeleccionado.Name = "gbQuitarSeleccionado";
            this.gbQuitarSeleccionado.RoundCorners = 2;
            this.gbQuitarSeleccionado.Size = new System.Drawing.Size(146, 52);
            this.gbQuitarSeleccionado.TabIndex = 1;
            this.gbQuitarSeleccionado.Text = "Quitar Seleccionado";
            this.gbQuitarSeleccionado.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbQuitarSeleccionado.Click += new System.EventHandler(this.gbQuitarSeleccionado_Click);
            // 
            // gbQuitarTodos
            // 
            this.gbQuitarTodos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbQuitarTodos.BackgroundImage")));
            this.gbQuitarTodos.BlackBorder = true;
            this.gbQuitarTodos.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbQuitarTodos.CircleButton = false;
            this.gbQuitarTodos.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Trash;
            this.gbQuitarTodos.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbQuitarTodos.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbQuitarTodos.FlatFontSize = 9;
            this.gbQuitarTodos.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbQuitarTodos.Location = new System.Drawing.Point(178, 157);
            this.gbQuitarTodos.Name = "gbQuitarTodos";
            this.gbQuitarTodos.RoundCorners = 2;
            this.gbQuitarTodos.Size = new System.Drawing.Size(146, 51);
            this.gbQuitarTodos.TabIndex = 3;
            this.gbQuitarTodos.Text = "Quitar Todos";
            this.gbQuitarTodos.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbQuitarTodos.Click += new System.EventHandler(this.gbQuitarTodos_Click);
            // 
            // gbAgregar
            // 
            this.gbAgregar.AutoEllipsis = true;
            this.gbAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAgregar.BackgroundImage")));
            this.gbAgregar.BlackBorder = true;
            this.gbAgregar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregar.CircleButton = false;
            this.gbAgregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbAgregar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Add;
            this.gbAgregar.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAgregar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAgregar.FlatFontSize = 9;
            this.gbAgregar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAgregar.Location = new System.Drawing.Point(22, 87);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.RoundCorners = 2;
            this.gbAgregar.Size = new System.Drawing.Size(138, 52);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.Text = "Agregar";
            this.gbAgregar.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAgregar.Click += new System.EventHandler(this.gbAgregar_Click);
            // 
            // gbQuitarUltimo
            // 
            this.gbQuitarUltimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbQuitarUltimo.BackgroundImage")));
            this.gbQuitarUltimo.BlackBorder = true;
            this.gbQuitarUltimo.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbQuitarUltimo.CircleButton = false;
            this.gbQuitarUltimo.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbQuitarUltimo.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbQuitarUltimo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbQuitarUltimo.FlatFontSize = 9;
            this.gbQuitarUltimo.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarUltimo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbQuitarUltimo.Location = new System.Drawing.Point(23, 157);
            this.gbQuitarUltimo.Name = "gbQuitarUltimo";
            this.gbQuitarUltimo.RoundCorners = 2;
            this.gbQuitarUltimo.Size = new System.Drawing.Size(136, 51);
            this.gbQuitarUltimo.TabIndex = 2;
            this.gbQuitarUltimo.Text = "Quitar Último";
            this.gbQuitarUltimo.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbQuitarUltimo.Click += new System.EventHandler(this.gbQuitarUltimo_Click);
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.Location = new System.Drawing.Point(19, 44);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(152, 20);
            this.fullLabel5.TabIndex = 17;
            this.fullLabel5.Text = "Item Seleccionado:";
            // 
            // deImporte
            // 
            this.deImporte.BackColor = System.Drawing.SystemColors.Window;
            this.deImporte.Location = new System.Drawing.Point(479, 38);
            this.deImporte.MaxLength = 13;
            this.deImporte.Name = "deImporte";
            this.deImporte.Size = new System.Drawing.Size(131, 21);
            this.deImporte.TabIndex = 3;
            this.deImporte.Text = "0.00";
            // 
            // lstControlesReparaciones
            // 
            this.lstControlesReparaciones.FormattingEnabled = true;
            this.lstControlesReparaciones.ItemHeight = 15;
            this.lstControlesReparaciones.Location = new System.Drawing.Point(15, 39);
            this.lstControlesReparaciones.Name = "lstControlesReparaciones";
            this.lstControlesReparaciones.Size = new System.Drawing.Size(314, 169);
            this.lstControlesReparaciones.Sorted = true;
            this.lstControlesReparaciones.TabIndex = 2;
            // 
            // fullLabel4
            // 
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(339, 42);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(92, 24);
            this.fullLabel4.TabIndex = 14;
            this.fullLabel4.Text = "Importe:";
            // 
            // teComentario
            // 
            this.teComentario.BackColor = System.Drawing.SystemColors.Window;
            this.teComentario.Location = new System.Drawing.Point(339, 99);
            this.teComentario.Multiline = true;
            this.teComentario.Name = "teComentario";
            this.teComentario.Size = new System.Drawing.Size(271, 116);
            this.teComentario.TabIndex = 4;
            // 
            // fullLabel3
            // 
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.Location = new System.Drawing.Point(337, 75);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(117, 21);
            this.fullLabel3.TabIndex = 13;
            this.fullLabel3.Text = "Comentario:";
            // 
            // neOrdenTrabajo
            // 
            this.neOrdenTrabajo.BackColor = System.Drawing.SystemColors.Window;
            this.neOrdenTrabajo.Enabled = false;
            this.neOrdenTrabajo.Location = new System.Drawing.Point(891, 12);
            this.neOrdenTrabajo.Name = "neOrdenTrabajo";
            this.neOrdenTrabajo.Size = new System.Drawing.Size(91, 21);
            this.neOrdenTrabajo.TabIndex = 13;
            this.neOrdenTrabajo.Text = "0";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpciones.Controls.Add(this.rbReparaciones);
            this.pnlOpciones.Controls.Add(this.rbControles);
            this.pnlOpciones.Location = new System.Drawing.Point(38, 47);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(231, 29);
            this.pnlOpciones.TabIndex = 12;
            // 
            // rbReparaciones
            // 
            this.rbReparaciones.AutoSize = true;
            this.rbReparaciones.Location = new System.Drawing.Point(108, 3);
            this.rbReparaciones.Name = "rbReparaciones";
            this.rbReparaciones.Size = new System.Drawing.Size(119, 22);
            this.rbReparaciones.TabIndex = 1;
            this.rbReparaciones.TabStop = true;
            this.rbReparaciones.Text = "Reparaciones";
            this.rbReparaciones.UseVisualStyleBackColor = true;
            this.rbReparaciones.CheckedChanged += new System.EventHandler(this.rbReparaciones_CheckedChanged);
            // 
            // rbControles
            // 
            this.rbControles.AutoSize = true;
            this.rbControles.BackColor = System.Drawing.Color.Transparent;
            this.rbControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbControles.Location = new System.Drawing.Point(3, 3);
            this.rbControles.Name = "rbControles";
            this.rbControles.Size = new System.Drawing.Size(90, 22);
            this.rbControles.TabIndex = 0;
            this.rbControles.TabStop = true;
            this.rbControles.Text = "Controles";
            this.rbControles.UseVisualStyleBackColor = false;
            this.rbControles.CheckedChanged += new System.EventHandler(this.rbControles_CheckedChanged);
            // 
            // cdcPatente
            // 
            this.cdcPatente.BackColor = System.Drawing.SystemColors.Window;
            this.cdcPatente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcPatente.FormattingEnabled = true;
            this.cdcPatente.Location = new System.Drawing.Point(148, 9);
            this.cdcPatente.Name = "cdcPatente";
            this.cdcPatente.Size = new System.Drawing.Size(138, 23);
            this.cdcPatente.Sorted = true;
            this.cdcPatente.TabIndex = 0;
            this.cdcPatente.SelectedIndexChanged += new System.EventHandler(this.cdcPatente_SelectedIndexChanged);
            // 
            // gbAccept
            // 
            this.gbAccept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAccept.BackgroundImage")));
            this.gbAccept.BlackBorder = true;
            this.gbAccept.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAccept.CircleButton = false;
            this.gbAccept.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Accept;
            this.gbAccept.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAccept.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbAccept.FlatFontSize = 9;
            this.gbAccept.FlatTextColor = System.Drawing.Color.Black;
            this.gbAccept.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAccept.Location = new System.Drawing.Point(894, 531);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.RoundCorners = 2;
            this.gbAccept.Size = new System.Drawing.Size(96, 29);
            this.gbAccept.TabIndex = 4;
            this.gbAccept.Text = "Aceptar";
            this.gbAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAccept.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbAccept.Click += new System.EventHandler(this.gbAccept_Click);
            // 
            // fgControlRepaSeleccionados
            // 
            this.fgControlRepaSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgControlRepaSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgControlRepaSeleccionados.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgControlRepaSeleccionados.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgControlRepaSeleccionados.CaptionFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgControlRepaSeleccionados.CaptionVisible = false;
            this.fgControlRepaSeleccionados.DataMember = "";
            this.fgControlRepaSeleccionados.ExcelTitle = "";
            this.fgControlRepaSeleccionados.GridOrder = "";
            this.fgControlRepaSeleccionados.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgControlRepaSeleccionados.Location = new System.Drawing.Point(21, 327);
            this.fgControlRepaSeleccionados.Name = "fgControlRepaSeleccionados";
            this.fgControlRepaSeleccionados.Size = new System.Drawing.Size(971, 195);
            this.fgControlRepaSeleccionados.SkinFixed = true;
            this.fgControlRepaSeleccionados.TabIndex = 0;
            this.fgControlRepaSeleccionados.CurrentCellChanged += new System.EventHandler(this.fgControlRepaSeleccionados_CurrentCellChanged);
            // 
            // gbCancel
            // 
            this.gbCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancel.BackgroundImage")));
            this.gbCancel.BlackBorder = true;
            this.gbCancel.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancel.CircleButton = false;
            this.gbCancel.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Cancel;
            this.gbCancel.FlatColor = System.Drawing.Color.Red;
            this.gbCancel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbCancel.FlatFontSize = 9;
            this.gbCancel.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancel.Location = new System.Drawing.Point(766, 531);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.RoundCorners = 2;
            this.gbCancel.Size = new System.Drawing.Size(103, 29);
            this.gbCancel.TabIndex = 3;
            this.gbCancel.Text = "Cancelar";
            this.gbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancel.W8Color = System.Drawing.Color.Red;
            this.gbCancel.Click += new System.EventHandler(this.gbCancel_Click);
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(689, 13);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(210, 24);
            this.fullLabel2.TabIndex = 5;
            this.fullLabel2.Text = "Orden de Trabajo Numero:";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(35, 12);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(114, 27);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Movil Patente:";
            // 
            // tgrpControlesYRep
            // 
            this.tgrpControlesYRep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpControlesYRep.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tgrpControlesYRep.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpControlesYRep.BlackBorder = true;
            this.tgrpControlesYRep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tgrpControlesYRep.BorderThickness = 1F;
            this.tgrpControlesYRep.Controls.Add(this.deImporte);
            this.tgrpControlesYRep.Controls.Add(this.lstControlesReparaciones);
            this.tgrpControlesYRep.Controls.Add(this.fullLabel3);
            this.tgrpControlesYRep.Controls.Add(this.fullLabel4);
            this.tgrpControlesYRep.Controls.Add(this.teComentario);
            this.tgrpControlesYRep.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tgrpControlesYRep.FlatMode = true;
            this.tgrpControlesYRep.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgrpControlesYRep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tgrpControlesYRep.GroupImage = null;
            this.tgrpControlesYRep.GroupTitle = "Controles y Reparaciones";
            this.tgrpControlesYRep.Location = new System.Drawing.Point(21, 83);
            this.tgrpControlesYRep.Name = "tgrpControlesYRep";
            this.tgrpControlesYRep.Padding = new System.Windows.Forms.Padding(23, 23, 23, 23);
            this.tgrpControlesYRep.PaintGroupBox = false;
            this.tgrpControlesYRep.RoundCorners = 4;
            this.tgrpControlesYRep.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpControlesYRep.ShadowControl = false;
            this.tgrpControlesYRep.ShadowThickness = 3;
            this.tgrpControlesYRep.Size = new System.Drawing.Size(624, 234);
            this.tgrpControlesYRep.SkinFixed = true;
            this.tgrpControlesYRep.TabIndex = 20;
            this.tgrpControlesYRep.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.tgrpControlesYRep.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpControlesYRep.TitleFontColor = System.Drawing.Color.White;
            // 
            // tgrpOpciones
            // 
            this.tgrpOpciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tgrpOpciones.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tgrpOpciones.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.tgrpOpciones.BlackBorder = true;
            this.tgrpOpciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tgrpOpciones.BorderThickness = 1F;
            this.tgrpOpciones.Controls.Add(this.neSeleccionado);
            this.tgrpOpciones.Controls.Add(this.gbQuitarSeleccionado);
            this.tgrpOpciones.Controls.Add(this.fullLabel5);
            this.tgrpOpciones.Controls.Add(this.gbQuitarTodos);
            this.tgrpOpciones.Controls.Add(this.gbQuitarUltimo);
            this.tgrpOpciones.Controls.Add(this.gbAgregar);
            this.tgrpOpciones.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.tgrpOpciones.FlatMode = true;
            this.tgrpOpciones.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgrpOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tgrpOpciones.GroupImage = null;
            this.tgrpOpciones.GroupTitle = "Opciones";
            this.tgrpOpciones.Location = new System.Drawing.Point(652, 83);
            this.tgrpOpciones.Name = "tgrpOpciones";
            this.tgrpOpciones.Padding = new System.Windows.Forms.Padding(23, 23, 23, 23);
            this.tgrpOpciones.PaintGroupBox = false;
            this.tgrpOpciones.RoundCorners = 4;
            this.tgrpOpciones.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpOpciones.ShadowControl = false;
            this.tgrpOpciones.ShadowThickness = 3;
            this.tgrpOpciones.Size = new System.Drawing.Size(339, 234);
            this.tgrpOpciones.SkinFixed = true;
            this.tgrpOpciones.TabIndex = 21;
            this.tgrpOpciones.TitleBackground = System.Drawing.Color.DodgerBlue;
            this.tgrpOpciones.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpOpciones.TitleFontColor = System.Drawing.Color.White;
            // 
            // AltaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 571);
            this.Controls.Add(this.xPanel1);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AltaOrdenes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Orden de Trabajo";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).EndInit();
            this.tgrpControlesYRep.ResumeLayout(false);
            this.tgrpControlesYRep.PerformLayout();
            this.tgrpOpciones.ResumeLayout(false);
            this.tgrpOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private System.Windows.Forms.RadioButton rbControles;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.CDCombo cdcPatente;
        private TNGS.NetControls.FullGrid fgControlRepaSeleccionados;
        private TNGS.NetControls.CDList lstControlesReparaciones;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.GlassButton gbAccept;
        private TNGS.NetControls.GlassButton gbCancel;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.TextEdit teComentario;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.RadioButton rbReparaciones;
        private TNGS.NetControls.DecimalEdit deImporte;
        private TNGS.NetControls.GlassButton gbQuitarTodos;
        private TNGS.NetControls.GlassButton gbQuitarUltimo;
        private TNGS.NetControls.GlassButton gbQuitarSeleccionado;
        private TNGS.NetControls.GlassButton gbAgregar;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.NumberEdit neSeleccionado;
        private TNGS.NetControls.NumberEdit neOrdenTrabajo;
        private TNGS.NetControls.CDCombo cdcTalleres;
        private TNGS.NetControls.FullLabel fullLabel6;
        private TNGS.NetControls.ImgGroup tgrpOpciones;
        private TNGS.NetControls.ImgGroup tgrpControlesYRep;
    }
}