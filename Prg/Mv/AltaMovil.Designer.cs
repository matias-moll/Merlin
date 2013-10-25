namespace Rivn.Mv
{
    partial class AltaMovil
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
            this.btnLimpiarTodo = new TNGS.NetControls.GlassButton();
            this.btnCancel = new TNGS.NetControls.GlassButton();
            this.btnGrabar = new TNGS.NetControls.GlassButton();
            this.igEquipamiento = new TNGS.NetControls.ImgGroup();
            this.btnDestildarTodoEqi = new TNGS.NetControls.GlassButton();
            this.btnTildaTodos = new TNGS.NetControls.GlassButton();
            this.clEquipamientos = new TNGS.NetControls.CDCheckedList();
            this.igDatosBasicosMovil = new TNGS.NetControls.ImgGroup();
            this.tePatente = new TNGS.NetControls.TextEdit();
            this.lblAnotaciones = new TNGS.NetControls.FullLabel();
            this.lblAnioFabricacion = new TNGS.NetControls.FullLabel();
            this.teAnotaciones = new TNGS.NetControls.TextEdit();
            this.lblMovilPropio = new TNGS.NetControls.FullLabel();
            this.neAnioFabric = new TNGS.NetControls.NumberEdit();
            this.teNroMotor = new TNGS.NetControls.TextEdit();
            this.cmbMovilPropio = new TNGS.NetControls.CDCombo();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.lblDescripcionMovil = new TNGS.NetControls.FullLabel();
            this.teDescripcionMovil = new TNGS.NetControls.TextEdit();
            this.lblModelo = new TNGS.NetControls.FullLabel();
            this.teNroChasis = new TNGS.NetControls.TextEdit();
            this.lblNroMotor = new TNGS.NetControls.FullLabel();
            this.lblNroChasis = new TNGS.NetControls.FullLabel();
            this.cmbModelo = new TNGS.NetControls.CDCombo();
            this.xPanel1.SuspendLayout();
            this.igEquipamiento.SuspendLayout();
            this.igDatosBasicosMovil.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.btnLimpiarTodo);
            this.xPanel1.Controls.Add(this.btnCancel);
            this.xPanel1.Controls.Add(this.btnGrabar);
            this.xPanel1.Controls.Add(this.igEquipamiento);
            this.xPanel1.Controls.Add(this.igDatosBasicosMovil);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(784, 485);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.FixedImage = TNGS.NetControls.FixedGlassButtons.tDelete;
            this.btnLimpiarTodo.ImageOnTop = true;
            this.btnLimpiarTodo.Location = new System.Drawing.Point(426, 405);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(93, 68);
            this.btnLimpiarTodo.TabIndex = 27;
            this.btnLimpiarTodo.Text = "Limpiar Campos";
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FixedImage = TNGS.NetControls.FixedGlassButtons.tCancel;
            this.btnCancel.ImageOnTop = true;
            this.btnCancel.Location = new System.Drawing.Point(566, 405);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 68);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancelar";
            // 
            // btnGrabar
            // 
            this.btnGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.tSave;
            this.btnGrabar.ImageOnTop = true;
            this.btnGrabar.Location = new System.Drawing.Point(665, 405);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(93, 68);
            this.btnGrabar.TabIndex = 25;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // igEquipamiento
            // 
            this.igEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igEquipamiento.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igEquipamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.BorderThickness = 1F;
            this.igEquipamiento.Controls.Add(this.btnDestildarTodoEqi);
            this.igEquipamiento.Controls.Add(this.btnTildaTodos);
            this.igEquipamiento.Controls.Add(this.clEquipamientos);
            this.igEquipamiento.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igEquipamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.GroupImage = null;
            this.igEquipamiento.GroupTitle = "Movil: Equipamiento";
            this.igEquipamiento.Location = new System.Drawing.Point(512, 12);
            this.igEquipamiento.Name = "igEquipamiento";
            this.igEquipamiento.Padding = new System.Windows.Forms.Padding(20);
            this.igEquipamiento.PaintGroupBox = true;
            this.igEquipamiento.RoundCorners = 10;
            this.igEquipamiento.ShadowColor = System.Drawing.Color.DarkGray;
            this.igEquipamiento.ShadowControl = true;
            this.igEquipamiento.ShadowThickness = 3;
            this.igEquipamiento.Size = new System.Drawing.Size(260, 372);
            this.igEquipamiento.SkinFixed = true;
            this.igEquipamiento.SkinFullFixed = true;
            this.igEquipamiento.TabIndex = 24;
            // 
            // btnDestildarTodoEqi
            // 
            this.btnDestildarTodoEqi.FixedImage = TNGS.NetControls.FixedGlassButtons.UnCheckAll;
            this.btnDestildarTodoEqi.Location = new System.Drawing.Point(8, 336);
            this.btnDestildarTodoEqi.Name = "btnDestildarTodoEqi";
            this.btnDestildarTodoEqi.Size = new System.Drawing.Size(119, 24);
            this.btnDestildarTodoEqi.TabIndex = 28;
            this.btnDestildarTodoEqi.Text = "Destildar Todo";
            this.btnDestildarTodoEqi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestildarTodoEqi.Click += new System.EventHandler(this.btnDestildarTodoEqi_Click);
            // 
            // btnTildaTodos
            // 
            this.btnTildaTodos.FixedImage = TNGS.NetControls.FixedGlassButtons.CheckAll;
            this.btnTildaTodos.Location = new System.Drawing.Point(128, 336);
            this.btnTildaTodos.Name = "btnTildaTodos";
            this.btnTildaTodos.Size = new System.Drawing.Size(119, 24);
            this.btnTildaTodos.TabIndex = 27;
            this.btnTildaTodos.Text = "Tildar Todo";
            this.btnTildaTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTildaTodos.Click += new System.EventHandler(this.tildarTodo_Click);
            // 
            // clEquipamientos
            // 
            this.clEquipamientos.BackColor = System.Drawing.SystemColors.Window;
            this.clEquipamientos.FormattingEnabled = true;
            this.clEquipamientos.Location = new System.Drawing.Point(11, 34);
            this.clEquipamientos.Name = "clEquipamientos";
            this.clEquipamientos.Size = new System.Drawing.Size(235, 289);
            this.clEquipamientos.Sorted = true;
            this.clEquipamientos.TabIndex = 8;
            // 
            // igDatosBasicosMovil
            // 
            this.igDatosBasicosMovil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igDatosBasicosMovil.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igDatosBasicosMovil.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igDatosBasicosMovil.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igDatosBasicosMovil.BorderThickness = 1F;
            this.igDatosBasicosMovil.Controls.Add(this.cmbModelo);
            this.igDatosBasicosMovil.Controls.Add(this.tePatente);
            this.igDatosBasicosMovil.Controls.Add(this.lblAnotaciones);
            this.igDatosBasicosMovil.Controls.Add(this.lblAnioFabricacion);
            this.igDatosBasicosMovil.Controls.Add(this.teAnotaciones);
            this.igDatosBasicosMovil.Controls.Add(this.lblMovilPropio);
            this.igDatosBasicosMovil.Controls.Add(this.neAnioFabric);
            this.igDatosBasicosMovil.Controls.Add(this.teNroMotor);
            this.igDatosBasicosMovil.Controls.Add(this.cmbMovilPropio);
            this.igDatosBasicosMovil.Controls.Add(this.lblPatente);
            this.igDatosBasicosMovil.Controls.Add(this.lblDescripcionMovil);
            this.igDatosBasicosMovil.Controls.Add(this.teDescripcionMovil);
            this.igDatosBasicosMovil.Controls.Add(this.lblModelo);
            this.igDatosBasicosMovil.Controls.Add(this.teNroChasis);
            this.igDatosBasicosMovil.Controls.Add(this.lblNroMotor);
            this.igDatosBasicosMovil.Controls.Add(this.lblNroChasis);
            this.igDatosBasicosMovil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.igDatosBasicosMovil.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igDatosBasicosMovil.FontTitle = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igDatosBasicosMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igDatosBasicosMovil.GroupImage = null;
            this.igDatosBasicosMovil.GroupTitle = "Movil: Datos Basicos";
            this.igDatosBasicosMovil.Location = new System.Drawing.Point(12, 12);
            this.igDatosBasicosMovil.Name = "igDatosBasicosMovil";
            this.igDatosBasicosMovil.Padding = new System.Windows.Forms.Padding(20);
            this.igDatosBasicosMovil.PaintGroupBox = true;
            this.igDatosBasicosMovil.RoundCorners = 10;
            this.igDatosBasicosMovil.ShadowColor = System.Drawing.Color.DarkGray;
            this.igDatosBasicosMovil.ShadowControl = true;
            this.igDatosBasicosMovil.ShadowThickness = 3;
            this.igDatosBasicosMovil.Size = new System.Drawing.Size(494, 372);
            this.igDatosBasicosMovil.SkinFixed = true;
            this.igDatosBasicosMovil.SkinFullFixed = true;
            this.igDatosBasicosMovil.TabIndex = 23;
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.Location = new System.Drawing.Point(87, 43);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(91, 20);
            this.tePatente.TabIndex = 0;
            this.tePatente.Text = "234";
            // 
            // lblAnotaciones
            // 
            this.lblAnotaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblAnotaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotaciones.ForeColor = System.Drawing.Color.Black;
            this.lblAnotaciones.Location = new System.Drawing.Point(29, 212);
            this.lblAnotaciones.Name = "lblAnotaciones";
            this.lblAnotaciones.Size = new System.Drawing.Size(87, 18);
            this.lblAnotaciones.TabIndex = 13;
            this.lblAnotaciones.Text = "Anotaciones:";
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.BackColor = System.Drawing.Color.Transparent;
            this.lblAnioFabricacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioFabricacion.ForeColor = System.Drawing.Color.Black;
            this.lblAnioFabricacion.Location = new System.Drawing.Point(244, 134);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(107, 18);
            this.lblAnioFabricacion.TabIndex = 17;
            this.lblAnioFabricacion.Text = "Año Fabricacion:";
            // 
            // teAnotaciones
            // 
            this.teAnotaciones.BackColor = System.Drawing.SystemColors.Window;
            this.teAnotaciones.Location = new System.Drawing.Point(26, 233);
            this.teAnotaciones.Multiline = true;
            this.teAnotaciones.Name = "teAnotaciones";
            this.teAnotaciones.Size = new System.Drawing.Size(445, 87);
            this.teAnotaciones.TabIndex = 7;
            this.teAnotaciones.Text = "234234242342342342342354tregwegsfgdgdfgsgsegsfg";
            // 
            // lblMovilPropio
            // 
            this.lblMovilPropio.BackColor = System.Drawing.Color.Transparent;
            this.lblMovilPropio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovilPropio.ForeColor = System.Drawing.Color.Black;
            this.lblMovilPropio.Location = new System.Drawing.Point(269, 98);
            this.lblMovilPropio.Name = "lblMovilPropio";
            this.lblMovilPropio.Size = new System.Drawing.Size(82, 18);
            this.lblMovilPropio.TabIndex = 18;
            this.lblMovilPropio.Text = "Movil Propio:";
            // 
            // neAnioFabric
            // 
            this.neAnioFabric.BackColor = System.Drawing.SystemColors.Window;
            this.neAnioFabric.Location = new System.Drawing.Point(351, 134);
            this.neAnioFabric.Name = "neAnioFabric";
            this.neAnioFabric.Size = new System.Drawing.Size(118, 20);
            this.neAnioFabric.TabIndex = 5;
            this.neAnioFabric.Text = "234234";
            // 
            // teNroMotor
            // 
            this.teNroMotor.BackColor = System.Drawing.SystemColors.Window;
            this.teNroMotor.Location = new System.Drawing.Point(115, 134);
            this.teNroMotor.Name = "teNroMotor";
            this.teNroMotor.Size = new System.Drawing.Size(118, 20);
            this.teNroMotor.TabIndex = 4;
            this.teNroMotor.Text = "234";
            // 
            // cmbMovilPropio
            // 
            this.cmbMovilPropio.BackColor = System.Drawing.SystemColors.Window;
            this.cmbMovilPropio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovilPropio.FormattingEnabled = true;
            this.cmbMovilPropio.Location = new System.Drawing.Point(351, 96);
            this.cmbMovilPropio.Name = "cmbMovilPropio";
            this.cmbMovilPropio.Size = new System.Drawing.Size(118, 21);
            this.cmbMovilPropio.Sorted = true;
            this.cmbMovilPropio.TabIndex = 3;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(23, 43);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(67, 18);
            this.lblPatente.TabIndex = 6;
            this.lblPatente.Text = "Patente:";
            // 
            // lblDescripcionMovil
            // 
            this.lblDescripcionMovil.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionMovil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMovil.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionMovil.Location = new System.Drawing.Point(185, 43);
            this.lblDescripcionMovil.Name = "lblDescripcionMovil";
            this.lblDescripcionMovil.Size = new System.Drawing.Size(82, 18);
            this.lblDescripcionMovil.TabIndex = 10;
            this.lblDescripcionMovil.Text = "Descripcion:";
            // 
            // teDescripcionMovil
            // 
            this.teDescripcionMovil.BackColor = System.Drawing.SystemColors.Window;
            this.teDescripcionMovil.Location = new System.Drawing.Point(268, 42);
            this.teDescripcionMovil.Name = "teDescripcionMovil";
            this.teDescripcionMovil.Size = new System.Drawing.Size(201, 20);
            this.teDescripcionMovil.TabIndex = 1;
            this.teDescripcionMovil.Text = "24234";
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(60, 176);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 18);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // teNroChasis
            // 
            this.teNroChasis.BackColor = System.Drawing.SystemColors.Window;
            this.teNroChasis.Location = new System.Drawing.Point(115, 96);
            this.teNroChasis.Name = "teNroChasis";
            this.teNroChasis.Size = new System.Drawing.Size(118, 20);
            this.teNroChasis.TabIndex = 2;
            this.teNroChasis.Text = "234";
            // 
            // lblNroMotor
            // 
            this.lblNroMotor.BackColor = System.Drawing.Color.Transparent;
            this.lblNroMotor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMotor.ForeColor = System.Drawing.Color.Black;
            this.lblNroMotor.Location = new System.Drawing.Point(21, 136);
            this.lblNroMotor.Name = "lblNroMotor";
            this.lblNroMotor.Size = new System.Drawing.Size(95, 18);
            this.lblNroMotor.TabIndex = 15;
            this.lblNroMotor.Text = "Numero Motor:";
            // 
            // lblNroChasis
            // 
            this.lblNroChasis.BackColor = System.Drawing.Color.Transparent;
            this.lblNroChasis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroChasis.ForeColor = System.Drawing.Color.Black;
            this.lblNroChasis.Location = new System.Drawing.Point(15, 97);
            this.lblNroChasis.Name = "lblNroChasis";
            this.lblNroChasis.Size = new System.Drawing.Size(107, 18);
            this.lblNroChasis.TabIndex = 14;
            this.lblNroChasis.Text = "Numero Chasis:";
            // 
            // cmbModelo
            // 
            this.cmbModelo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(115, 172);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(118, 21);
            this.cmbModelo.Sorted = true;
            this.cmbModelo.TabIndex = 19;
            // 
            // AltaMovil
            // 
            this.AcceptButton = this.btnGrabar;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.xPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AltaMovil";
            this.ShowIcon = false;
            this.Text = "Nuevo Movil";
            this.xPanel1.ResumeLayout(false);
            this.igEquipamiento.ResumeLayout(false);
            this.igDatosBasicosMovil.ResumeLayout(false);
            this.igDatosBasicosMovil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private TNGS.NetControls.ImgGroup igEquipamiento;
        private TNGS.NetControls.CDCheckedList clEquipamientos;
        private TNGS.NetControls.ImgGroup igDatosBasicosMovil;
        private TNGS.NetControls.TextEdit tePatente;
        private TNGS.NetControls.FullLabel lblAnotaciones;
        private TNGS.NetControls.FullLabel lblAnioFabricacion;
        private TNGS.NetControls.TextEdit teAnotaciones;
        private TNGS.NetControls.FullLabel lblMovilPropio;
        private TNGS.NetControls.NumberEdit neAnioFabric;
        private TNGS.NetControls.TextEdit teNroMotor;
        private TNGS.NetControls.CDCombo cmbMovilPropio;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.FullLabel lblDescripcionMovil;
        private TNGS.NetControls.TextEdit teDescripcionMovil;
        private TNGS.NetControls.FullLabel lblModelo;
        private TNGS.NetControls.TextEdit teNroChasis;
        private TNGS.NetControls.FullLabel lblNroMotor;
        private TNGS.NetControls.FullLabel lblNroChasis;
        private TNGS.NetControls.GlassButton btnGrabar;
        private TNGS.NetControls.GlassButton btnLimpiarTodo;
        private TNGS.NetControls.GlassButton btnCancel;
        private TNGS.NetControls.GlassButton btnDestildarTodoEqi;
        private TNGS.NetControls.GlassButton btnTildaTodos;
        private TNGS.NetControls.CDCombo cmbModelo;
    }
}