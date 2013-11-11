﻿namespace Rivn.Ot
{
    partial class NuevosControlesReparaciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbReparaciones = new System.Windows.Forms.RadioButton();
            this.rbControles = new System.Windows.Forms.RadioButton();
            this.igControlReparacion = new TNGS.NetControls.ImgGroup();
            this.deImporte = new TNGS.NetControls.DecimalEdit();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.teComentario = new TNGS.NetControls.TextEdit();
            this.cdlControlesReparaciones = new TNGS.NetControls.CDList();
            this.imgGroup2 = new TNGS.NetControls.ImgGroup();
            this.gbQuitarTodos = new TNGS.NetControls.GlassButton();
            this.textEdit2 = new TNGS.NetControls.TextEdit();
            this.gbQuitarUltimo = new TNGS.NetControls.GlassButton();
            this.gbQuitarSeleccionado = new TNGS.NetControls.GlassButton();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.gbAgregar = new TNGS.NetControls.GlassButton();
            this.cdcPatente = new TNGS.NetControls.CDCombo();
            this.gbAccept = new TNGS.NetControls.GlassButton();
            this.fgControlRepaSeleccionados = new TNGS.NetControls.FullGrid();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.teNumOrden = new TNGS.NetControls.TextEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.igControlReparacion.SuspendLayout();
            this.imgGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.panel1);
            this.xPanel1.Controls.Add(this.igControlReparacion);
            this.xPanel1.Controls.Add(this.imgGroup2);
            this.xPanel1.Controls.Add(this.cdcPatente);
            this.xPanel1.Controls.Add(this.gbAccept);
            this.xPanel1.Controls.Add(this.fgControlRepaSeleccionados);
            this.xPanel1.Controls.Add(this.gbCancel);
            this.xPanel1.Controls.Add(this.teNumOrden);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbReparaciones);
            this.panel1.Controls.Add(this.rbControles);
            this.panel1.Location = new System.Drawing.Point(332, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 25);
            this.panel1.TabIndex = 12;
            // 
            // rbReparaciones
            // 
            this.rbReparaciones.AutoSize = true;
            this.rbReparaciones.Location = new System.Drawing.Point(95, 3);
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
            this.rbControles.Location = new System.Drawing.Point(12, 3);
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
            this.igControlReparacion.Controls.Add(this.cdlControlesReparaciones);
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
            this.deImporte.Location = new System.Drawing.Point(291, 39);
            this.deImporte.MaxLength = 13;
            this.deImporte.Name = "deImporte";
            this.deImporte.Size = new System.Drawing.Size(128, 21);
            this.deImporte.TabIndex = 3;
            this.deImporte.Text = "0.00";
            // 
            // fullLabel4
            // 
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(288, 20);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(61, 21);
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
            this.teComentario.Location = new System.Drawing.Point(291, 84);
            this.teComentario.Multiline = true;
            this.teComentario.Name = "teComentario";
            this.teComentario.Size = new System.Drawing.Size(235, 101);
            this.teComentario.TabIndex = 4;
            // 
            // cdlControlesReparaciones
            // 
            this.cdlControlesReparaciones.FormattingEnabled = true;
            this.cdlControlesReparaciones.ItemHeight = 15;
            this.cdlControlesReparaciones.Location = new System.Drawing.Point(12, 31);
            this.cdlControlesReparaciones.Name = "cdlControlesReparaciones";
            this.cdlControlesReparaciones.Size = new System.Drawing.Size(270, 154);
            this.cdlControlesReparaciones.Sorted = true;
            this.cdlControlesReparaciones.TabIndex = 2;
            // 
            // imgGroup2
            // 
            this.imgGroup2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imgGroup2.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.imgGroup2.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.imgGroup2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgGroup2.BorderThickness = 1F;
            this.imgGroup2.Controls.Add(this.gbQuitarTodos);
            this.imgGroup2.Controls.Add(this.textEdit2);
            this.imgGroup2.Controls.Add(this.gbQuitarUltimo);
            this.imgGroup2.Controls.Add(this.gbQuitarSeleccionado);
            this.imgGroup2.Controls.Add(this.fullLabel5);
            this.imgGroup2.Controls.Add(this.gbAgregar);
            this.imgGroup2.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.imgGroup2.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgGroup2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imgGroup2.GroupImage = null;
            this.imgGroup2.GroupTitle = "Opciones";
            this.imgGroup2.Location = new System.Drawing.Point(559, 52);
            this.imgGroup2.Name = "imgGroup2";
            this.imgGroup2.Padding = new System.Windows.Forms.Padding(20);
            this.imgGroup2.PaintGroupBox = true;
            this.imgGroup2.RoundCorners = 10;
            this.imgGroup2.ShadowColor = System.Drawing.Color.DarkGray;
            this.imgGroup2.ShadowControl = true;
            this.imgGroup2.ShadowThickness = 3;
            this.imgGroup2.Size = new System.Drawing.Size(291, 198);
            this.imgGroup2.SkinFixed = true;
            this.imgGroup2.SkinFullFixed = true;
            this.imgGroup2.TabIndex = 2;
            // 
            // gbQuitarTodos
            // 
            this.gbQuitarTodos.FixedImage = TNGS.NetControls.FixedGlassButtons.Clean;
            this.gbQuitarTodos.Location = new System.Drawing.Point(153, 131);
            this.gbQuitarTodos.Name = "gbQuitarTodos";
            this.gbQuitarTodos.Size = new System.Drawing.Size(117, 48);
            this.gbQuitarTodos.TabIndex = 3;
            this.gbQuitarTodos.Text = "Quitar Todos";
            this.gbQuitarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textEdit2
            // 
            this.textEdit2.BackColor = System.Drawing.SystemColors.Window;
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(153, 33);
            this.textEdit2.Multiline = true;
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(117, 17);
            this.textEdit2.TabIndex = 20;
            this.textEdit2.TabStop = false;
            // 
            // gbQuitarUltimo
            // 
            this.gbQuitarUltimo.FixedImage = TNGS.NetControls.FixedGlassButtons.Subs;
            this.gbQuitarUltimo.Location = new System.Drawing.Point(20, 131);
            this.gbQuitarUltimo.Name = "gbQuitarUltimo";
            this.gbQuitarUltimo.Size = new System.Drawing.Size(117, 48);
            this.gbQuitarUltimo.TabIndex = 2;
            this.gbQuitarUltimo.Text = "Quitar Ultimo";
            this.gbQuitarUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbQuitarSeleccionado
            // 
            this.gbQuitarSeleccionado.FixedImage = TNGS.NetControls.FixedGlassButtons.Delete;
            this.gbQuitarSeleccionado.Location = new System.Drawing.Point(153, 60);
            this.gbQuitarSeleccionado.Name = "gbQuitarSeleccionado";
            this.gbQuitarSeleccionado.Size = new System.Drawing.Size(117, 48);
            this.gbQuitarSeleccionado.TabIndex = 1;
            this.gbQuitarSeleccionado.Text = "Quitar Seleccionado";
            this.gbQuitarSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.gbAgregar.FixedImage = TNGS.NetControls.FixedGlassButtons.Add;
            this.gbAgregar.Location = new System.Drawing.Point(20, 60);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(117, 48);
            this.gbAgregar.TabIndex = 0;
            this.gbAgregar.Text = "Agregar Nuevo";
            this.gbAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cdcPatente
            // 
            this.cdcPatente.BackColor = System.Drawing.SystemColors.Window;
            this.cdcPatente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cdcPatente.FormattingEnabled = true;
            this.cdcPatente.Location = new System.Drawing.Point(116, 18);
            this.cdcPatente.Name = "cdcPatente";
            this.cdcPatente.Size = new System.Drawing.Size(119, 23);
            this.cdcPatente.Sorted = true;
            this.cdcPatente.TabIndex = 0;
            // 
            // gbAccept
            // 
            this.gbAccept.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbAccept.Location = new System.Drawing.Point(745, 458);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.Size = new System.Drawing.Size(103, 31);
            this.gbAccept.TabIndex = 4;
            this.gbAccept.Text = "Aceptar";
            this.gbAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // gbCancel
            // 
            this.gbCancel.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.gbCancel.Location = new System.Drawing.Point(636, 458);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.Size = new System.Drawing.Size(103, 31);
            this.gbCancel.TabIndex = 3;
            this.gbCancel.Text = "Cancelar";
            this.gbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbCancel.Click += new System.EventHandler(this.gbCancel_Click);
            // 
            // teNumOrden
            // 
            this.teNumOrden.BackColor = System.Drawing.SystemColors.Window;
            this.teNumOrden.Enabled = false;
            this.teNumOrden.Location = new System.Drawing.Point(748, 9);
            this.teNumOrden.Name = "teNumOrden";
            this.teNumOrden.Size = new System.Drawing.Size(100, 21);
            this.teNumOrden.TabIndex = 6;
            this.teNumOrden.TabStop = false;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(575, 9);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(180, 22);
            this.fullLabel2.TabIndex = 5;
            this.fullLabel2.Text = "Orden de Trabajo Numero:";
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(24, 20);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(98, 23);
            this.fullLabel1.TabIndex = 1;
            this.fullLabel1.Text = "Movil Patente:";
            // 
            // NuevosControlesReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 501);
            this.Controls.Add(this.xPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NuevosControlesReparaciones";
            this.Text = "NuevosControlesReparaciones";
            this.Load += new System.EventHandler(this.NuevosControlesReparaciones_Load);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.igControlReparacion.ResumeLayout(false);
            this.igControlReparacion.PerformLayout();
            this.imgGroup2.ResumeLayout(false);
            this.imgGroup2.PerformLayout();
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
        private TNGS.NetControls.CDList cdlControlesReparaciones;
        private TNGS.NetControls.TextEdit teNumOrden;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.GlassButton gbAccept;
        private TNGS.NetControls.GlassButton gbCancel;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.TextEdit teComentario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbReparaciones;
        private TNGS.NetControls.DecimalEdit deImporte;
        private TNGS.NetControls.ImgGroup imgGroup2;
        private TNGS.NetControls.GlassButton gbQuitarTodos;
        private TNGS.NetControls.GlassButton gbQuitarUltimo;
        private TNGS.NetControls.GlassButton gbQuitarSeleccionado;
        private TNGS.NetControls.GlassButton gbAgregar;
        private TNGS.NetControls.TextEdit textEdit2;
        private TNGS.NetControls.FullLabel fullLabel5;
    }
}