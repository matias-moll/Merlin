namespace Rivn.Ot
{
    partial class OTItemsNuevo
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
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.neOrdenTrabajo = new TNGS.NetControls.NumberEdit();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.rbReparaciones = new System.Windows.Forms.RadioButton();
            this.rbControles = new System.Windows.Forms.RadioButton();
            this.igControlReparacion = new TNGS.NetControls.ImgGroup();
            this.deImporte = new TNGS.NetControls.DecimalEdit();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.teComentario = new TNGS.NetControls.TextEdit();
            this.lstControlesReparaciones = new TNGS.NetControls.CDList();
            this.igOpciones = new TNGS.NetControls.ImgGroup();
            this.neSeleccionado = new TNGS.NetControls.NumberEdit();
            this.gbQuitarTodos = new TNGS.NetControls.GlassButton();
            this.gbQuitarUltimo = new TNGS.NetControls.GlassButton();
            this.gbQuitarSeleccionado = new TNGS.NetControls.GlassButton();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.gbAgregar = new TNGS.NetControls.GlassButton();
            this.cdcPatente = new TNGS.NetControls.CDCombo();
            this.gbAccept = new TNGS.NetControls.GlassButton();
            this.fgControlRepaSeleccionados = new TNGS.NetControls.FullGrid();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.igControlReparacion.SuspendLayout();
            this.igOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.neOrdenTrabajo);
            this.xPanel1.Controls.Add(this.pnlOpciones);
            this.xPanel1.Controls.Add(this.igControlReparacion);
            this.xPanel1.Controls.Add(this.igOpciones);
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
            this.xPanel1.Size = new System.Drawing.Size(860, 501);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // neOrdenTrabajo
            // 
            this.neOrdenTrabajo.BackColor = System.Drawing.SystemColors.Window;
            this.neOrdenTrabajo.Enabled = false;
            this.neOrdenTrabajo.Location = new System.Drawing.Point(764, 8);
            this.neOrdenTrabajo.Name = "neOrdenTrabajo";
            this.neOrdenTrabajo.Size = new System.Drawing.Size(79, 21);
            this.neOrdenTrabajo.TabIndex = 13;
            this.neOrdenTrabajo.Text = "0";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpciones.Controls.Add(this.rbReparaciones);
            this.pnlOpciones.Controls.Add(this.rbControles);
            this.pnlOpciones.Location = new System.Drawing.Point(332, 34);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(192, 25);
            this.pnlOpciones.TabIndex = 12;
            // 
            // rbReparaciones
            // 
            this.rbReparaciones.AutoSize = true;
            this.rbReparaciones.Location = new System.Drawing.Point(90, 3);
            this.rbReparaciones.Name = "rbReparaciones";
            this.rbReparaciones.Size = new System.Drawing.Size(102, 19);
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
            this.rbControles.Size = new System.Drawing.Size(77, 19);
            this.rbControles.TabIndex = 0;
            this.rbControles.TabStop = true;
            this.rbControles.Text = "Controles";
            this.rbControles.UseVisualStyleBackColor = false;
            this.rbControles.CheckedChanged += new System.EventHandler(this.rbControles_CheckedChanged);
            // 
            // igControlReparacion
            // 
            this.igControlReparacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igControlReparacion.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igControlReparacion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igControlReparacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igControlReparacion.BorderThickness = 1F;
            this.igControlReparacion.Controls.Add(this.deImporte);
            this.igControlReparacion.Controls.Add(this.fullLabel4);
            this.igControlReparacion.Controls.Add(this.fullLabel3);
            this.igControlReparacion.Controls.Add(this.teComentario);
            this.igControlReparacion.Controls.Add(this.lstControlesReparaciones);
            this.igControlReparacion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igControlReparacion.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igControlReparacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igControlReparacion.GroupImage = null;
            this.igControlReparacion.GroupTitle = "Controles y Reparaciones";
            this.igControlReparacion.Location = new System.Drawing.Point(12, 52);
            this.igControlReparacion.Name = "igControlReparacion";
            this.igControlReparacion.Padding = new System.Windows.Forms.Padding(20);
            this.igControlReparacion.PaintGroupBox = true;
            this.igControlReparacion.RoundCorners = 10;
            this.igControlReparacion.ShadowColor = System.Drawing.Color.DarkGray;
            this.igControlReparacion.ShadowControl = true;
            this.igControlReparacion.ShadowThickness = 3;
            this.igControlReparacion.Size = new System.Drawing.Size(535, 198);
            this.igControlReparacion.SkinFixed = true;
            this.igControlReparacion.SkinFullFixed = true;
            this.igControlReparacion.TabIndex = 1;
            // 
            // deImporte
            // 
            this.deImporte.BackColor = System.Drawing.SystemColors.Window;
            this.deImporte.Location = new System.Drawing.Point(410, 27);
            this.deImporte.MaxLength = 13;
            this.deImporte.Name = "deImporte";
            this.deImporte.Size = new System.Drawing.Size(113, 21);
            this.deImporte.TabIndex = 3;
            this.deImporte.Text = "0.00";
            // 
            // fullLabel4
            // 
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(290, 30);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(79, 21);
            this.fullLabel4.TabIndex = 14;
            this.fullLabel4.Text = "Importe:";
            // 
            // fullLabel3
            // 
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.Location = new System.Drawing.Point(288, 63);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(100, 18);
            this.fullLabel3.TabIndex = 13;
            this.fullLabel3.Text = "Comentario:";
            // 
            // teComentario
            // 
            this.teComentario.BackColor = System.Drawing.SystemColors.Window;
            this.teComentario.Location = new System.Drawing.Point(290, 84);
            this.teComentario.Multiline = true;
            this.teComentario.Name = "teComentario";
            this.teComentario.Size = new System.Drawing.Size(233, 101);
            this.teComentario.TabIndex = 4;
            // 
            // lstControlesReparaciones
            // 
            this.lstControlesReparaciones.FormattingEnabled = true;
            this.lstControlesReparaciones.ItemHeight = 15;
            this.lstControlesReparaciones.Location = new System.Drawing.Point(12, 31);
            this.lstControlesReparaciones.Name = "lstControlesReparaciones";
            this.lstControlesReparaciones.Size = new System.Drawing.Size(270, 154);
            this.lstControlesReparaciones.Sorted = true;
            this.lstControlesReparaciones.TabIndex = 2;
            // 
            // igOpciones
            // 
            this.igOpciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igOpciones.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igOpciones.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igOpciones.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igOpciones.BorderThickness = 1F;
            this.igOpciones.Controls.Add(this.neSeleccionado);
            this.igOpciones.Controls.Add(this.gbQuitarTodos);
            this.igOpciones.Controls.Add(this.gbQuitarUltimo);
            this.igOpciones.Controls.Add(this.gbQuitarSeleccionado);
            this.igOpciones.Controls.Add(this.fullLabel5);
            this.igOpciones.Controls.Add(this.gbAgregar);
            this.igOpciones.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igOpciones.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igOpciones.GroupImage = null;
            this.igOpciones.GroupTitle = "Opciones";
            this.igOpciones.Location = new System.Drawing.Point(559, 52);
            this.igOpciones.Name = "igOpciones";
            this.igOpciones.Padding = new System.Windows.Forms.Padding(20);
            this.igOpciones.PaintGroupBox = true;
            this.igOpciones.RoundCorners = 10;
            this.igOpciones.ShadowColor = System.Drawing.Color.DarkGray;
            this.igOpciones.ShadowControl = true;
            this.igOpciones.ShadowThickness = 3;
            this.igOpciones.Size = new System.Drawing.Size(291, 198);
            this.igOpciones.SkinFixed = true;
            this.igOpciones.SkinFullFixed = true;
            this.igOpciones.TabIndex = 2;
            // 
            // neSeleccionado
            // 
            this.neSeleccionado.BackColor = System.Drawing.SystemColors.Window;
            this.neSeleccionado.Enabled = false;
            this.neSeleccionado.Location = new System.Drawing.Point(153, 33);
            this.neSeleccionado.Name = "neSeleccionado";
            this.neSeleccionado.Size = new System.Drawing.Size(115, 21);
            this.neSeleccionado.TabIndex = 18;
            this.neSeleccionado.Text = "0";
            // 
            // gbQuitarTodos
            // 
            this.gbQuitarTodos.BlackBorder = true;
            this.gbQuitarTodos.CircleButton = false;
            this.gbQuitarTodos.FixedImage = TNGS.NetControls.FixedGlassButtons.Clean;
            this.gbQuitarTodos.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbQuitarTodos.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbQuitarTodos.FlatFontSize = 9;
            this.gbQuitarTodos.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarTodos.Location = new System.Drawing.Point(153, 131);
            this.gbQuitarTodos.Name = "gbQuitarTodos";
            this.gbQuitarTodos.RoundCorners = 2;
            this.gbQuitarTodos.Size = new System.Drawing.Size(117, 48);
            this.gbQuitarTodos.TabIndex = 3;
            this.gbQuitarTodos.Text = "Quitar Todos";
            this.gbQuitarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbQuitarTodos.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbQuitarTodos.Click += new System.EventHandler(this.gbQuitarTodos_Click);
            // 
            // gbQuitarUltimo
            // 
            this.gbQuitarUltimo.BlackBorder = true;
            this.gbQuitarUltimo.CircleButton = false;
            this.gbQuitarUltimo.FixedImage = TNGS.NetControls.FixedGlassButtons.Subs;
            this.gbQuitarUltimo.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbQuitarUltimo.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbQuitarUltimo.FlatFontSize = 9;
            this.gbQuitarUltimo.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarUltimo.Location = new System.Drawing.Point(20, 131);
            this.gbQuitarUltimo.Name = "gbQuitarUltimo";
            this.gbQuitarUltimo.RoundCorners = 2;
            this.gbQuitarUltimo.Size = new System.Drawing.Size(117, 48);
            this.gbQuitarUltimo.TabIndex = 2;
            this.gbQuitarUltimo.Text = "Quitar Ultimo";
            this.gbQuitarUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbQuitarUltimo.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbQuitarUltimo.Click += new System.EventHandler(this.gbQuitarUltimo_Click);
            // 
            // gbQuitarSeleccionado
            // 
            this.gbQuitarSeleccionado.BlackBorder = true;
            this.gbQuitarSeleccionado.CircleButton = false;
            this.gbQuitarSeleccionado.FixedImage = TNGS.NetControls.FixedGlassButtons.Delete;
            this.gbQuitarSeleccionado.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbQuitarSeleccionado.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbQuitarSeleccionado.FlatFontSize = 9;
            this.gbQuitarSeleccionado.FlatTextColor = System.Drawing.Color.Black;
            this.gbQuitarSeleccionado.Location = new System.Drawing.Point(152, 70);
            this.gbQuitarSeleccionado.Name = "gbQuitarSeleccionado";
            this.gbQuitarSeleccionado.RoundCorners = 2;
            this.gbQuitarSeleccionado.Size = new System.Drawing.Size(117, 48);
            this.gbQuitarSeleccionado.TabIndex = 1;
            this.gbQuitarSeleccionado.Text = "Quitar Seleccionado";
            this.gbQuitarSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbQuitarSeleccionado.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbQuitarSeleccionado.Click += new System.EventHandler(this.gbQuitarSeleccionado_Click);
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.Location = new System.Drawing.Point(16, 33);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(130, 17);
            this.fullLabel5.TabIndex = 17;
            this.fullLabel5.Text = "Item Seleccionado:";
            // 
            // gbAgregar
            // 
            this.gbAgregar.BlackBorder = true;
            this.gbAgregar.CircleButton = false;
            this.gbAgregar.FixedImage = TNGS.NetControls.FixedGlassButtons.Add;
            this.gbAgregar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbAgregar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAgregar.FlatFontSize = 9;
            this.gbAgregar.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregar.Location = new System.Drawing.Point(19, 70);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.RoundCorners = 2;
            this.gbAgregar.Size = new System.Drawing.Size(117, 48);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.Text = "Agregar Nuevo";
            this.gbAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAgregar.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbAgregar.Click += new System.EventHandler(this.gbAgregar_Click);
            // 
            // cdcPatente
            // 
            this.cdcPatente.BackColor = System.Drawing.SystemColors.Window;
            this.cdcPatente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcPatente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcPatente.FormattingEnabled = true;
            this.cdcPatente.Location = new System.Drawing.Point(127, 12);
            this.cdcPatente.Name = "cdcPatente";
            this.cdcPatente.Size = new System.Drawing.Size(89, 23);
            this.cdcPatente.Sorted = true;
            this.cdcPatente.TabIndex = 0;
            this.cdcPatente.SelectedIndexChanged += new System.EventHandler(this.cdcPatente_SelectedIndexChanged);
            // 
            // gbAccept
            // 
            this.gbAccept.BlackBorder = true;
            this.gbAccept.CircleButton = false;
            this.gbAccept.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbAccept.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbAccept.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbAccept.FlatFontSize = 9;
            this.gbAccept.FlatTextColor = System.Drawing.Color.Black;
            this.gbAccept.Location = new System.Drawing.Point(745, 458);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.RoundCorners = 2;
            this.gbAccept.Size = new System.Drawing.Size(103, 31);
            this.gbAccept.TabIndex = 4;
            this.gbAccept.Text = "Aceptar";
            this.gbAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbAccept.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbAccept.Click += new System.EventHandler(this.gbAccept_Click);
            // 
            // fgControlRepaSeleccionados
            // 
            this.fgControlRepaSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgControlRepaSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgControlRepaSeleccionados.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgControlRepaSeleccionados.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgControlRepaSeleccionados.DataMember = "";
            this.fgControlRepaSeleccionados.ExcelTitle = "";
            this.fgControlRepaSeleccionados.GridOrder = "";
            this.fgControlRepaSeleccionados.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgControlRepaSeleccionados.Location = new System.Drawing.Point(12, 256);
            this.fgControlRepaSeleccionados.Name = "fgControlRepaSeleccionados";
            this.fgControlRepaSeleccionados.Size = new System.Drawing.Size(838, 196);
            this.fgControlRepaSeleccionados.SkinFixed = true;
            this.fgControlRepaSeleccionados.TabIndex = 0;
            this.fgControlRepaSeleccionados.TabStop = false;
            this.fgControlRepaSeleccionados.CurrentCellChanged += new System.EventHandler(this.fgControlRepaSeleccionados_CurrentCellChanged);
            // 
            // gbCancel
            // 
            this.gbCancel.BlackBorder = true;
            this.gbCancel.CircleButton = false;
            this.gbCancel.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.gbCancel.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbCancel.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbCancel.FlatFontSize = 9;
            this.gbCancel.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancel.Location = new System.Drawing.Point(636, 458);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.RoundCorners = 2;
            this.gbCancel.Size = new System.Drawing.Size(103, 31);
            this.gbCancel.TabIndex = 3;
            this.gbCancel.Text = "Cancelar";
            this.gbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancel.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbCancel.Click += new System.EventHandler(this.gbCancel_Click);
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(591, 9);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(180, 21);
            this.fullLabel2.TabIndex = 5;
            this.fullLabel2.Text = "Orden de Trabajo Numero:";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(30, 14);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(98, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Movil Patente:";
            // 
            // OTItemsNuevo
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 501);
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OTItemsNuevo";
            this.Text = "Nueva Orden de Trabajo";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            this.igControlReparacion.ResumeLayout(false);
            this.igControlReparacion.PerformLayout();
            this.igOpciones.ResumeLayout(false);
            this.igOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private System.Windows.Forms.RadioButton rbControles;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.CDCombo cdcPatente;
        private TNGS.NetControls.ImgGroup igControlReparacion;
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
        private TNGS.NetControls.ImgGroup igOpciones;
        private TNGS.NetControls.GlassButton gbQuitarTodos;
        private TNGS.NetControls.GlassButton gbQuitarUltimo;
        private TNGS.NetControls.GlassButton gbQuitarSeleccionado;
        private TNGS.NetControls.GlassButton gbAgregar;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.NumberEdit neSeleccionado;
        private TNGS.NetControls.NumberEdit neOrdenTrabajo;
    }
}