namespace Rivn.Ot
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
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.teNumOrden = new TNGS.NetControls.TextEdit();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.fgControlRepaSeleccionados = new TNGS.NetControls.FullGrid();
            this.rbReparaciones = new System.Windows.Forms.RadioButton();
            this.rbControles = new System.Windows.Forms.RadioButton();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.cdcPatente = new TNGS.NetControls.CDCombo();
            this.igControlReparacion = new TNGS.NetControls.ImgGroup();
            this.textEdit5 = new TNGS.NetControls.TextEdit();
            this.textEdit4 = new TNGS.NetControls.TextEdit();
            this.textEdit3 = new TNGS.NetControls.TextEdit();
            this.textEdit2 = new TNGS.NetControls.TextEdit();
            this.cdlControlesReparaciones = new TNGS.NetControls.CDList();
            this.gbQuitarTodos = new TNGS.NetControls.GlassButton();
            this.gbQuitarUno = new TNGS.NetControls.GlassButton();
            this.glassButton3 = new TNGS.NetControls.GlassButton();
            this.gbCancel = new TNGS.NetControls.GlassButton();
            this.gbAccept = new TNGS.NetControls.GlassButton();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.lblNumSeleccionado = new TNGS.NetControls.FullLabel();
            this.xPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).BeginInit();
            this.igControlReparacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.lblNumSeleccionado);
            this.xPanel1.Controls.Add(this.fullLabel3);
            this.xPanel1.Controls.Add(this.gbAccept);
            this.xPanel1.Controls.Add(this.gbCancel);
            this.xPanel1.Controls.Add(this.gbQuitarUno);
            this.xPanel1.Controls.Add(this.gbQuitarTodos);
            this.xPanel1.Controls.Add(this.teNumOrden);
            this.xPanel1.Controls.Add(this.fullLabel2);
            this.xPanel1.Controls.Add(this.fgControlRepaSeleccionados);
            this.xPanel1.Controls.Add(this.rbReparaciones);
            this.xPanel1.Controls.Add(this.rbControles);
            this.xPanel1.Controls.Add(this.fullLabel1);
            this.xPanel1.Controls.Add(this.cdcPatente);
            this.xPanel1.Controls.Add(this.igControlReparacion);
            this.xPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xPanel1.Location = new System.Drawing.Point(0, 0);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(1008, 583);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 0;
            // 
            // teNumOrden
            // 
            this.teNumOrden.BackColor = System.Drawing.SystemColors.Window;
            this.teNumOrden.Enabled = false;
            this.teNumOrden.Location = new System.Drawing.Point(200, 17);
            this.teNumOrden.Name = "teNumOrden";
            this.teNumOrden.Size = new System.Drawing.Size(100, 20);
            this.teNumOrden.TabIndex = 6;
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(28, 18);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(169, 22);
            this.fullLabel2.TabIndex = 5;
            this.fullLabel2.Text = "Orden de Trabajo Numero:";
            // 
            // fgControlRepaSeleccionados
            // 
            this.fgControlRepaSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgControlRepaSeleccionados.DataMember = "";
            this.fgControlRepaSeleccionados.ExcelTitle = "";
            this.fgControlRepaSeleccionados.GridOrder = "";
            this.fgControlRepaSeleccionados.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgControlRepaSeleccionados.Location = new System.Drawing.Point(12, 346);
            this.fgControlRepaSeleccionados.Name = "fgControlRepaSeleccionados";
            this.fgControlRepaSeleccionados.Size = new System.Drawing.Size(983, 178);
            this.fgControlRepaSeleccionados.TabIndex = 0;
            // 
            // rbReparaciones
            // 
            this.rbReparaciones.AutoCheck = false;
            this.rbReparaciones.AutoSize = true;
            this.rbReparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReparaciones.Location = new System.Drawing.Point(842, 36);
            this.rbReparaciones.Name = "rbReparaciones";
            this.rbReparaciones.Size = new System.Drawing.Size(112, 20);
            this.rbReparaciones.TabIndex = 4;
            this.rbReparaciones.TabStop = true;
            this.rbReparaciones.Text = "Reparaciones";
            this.rbReparaciones.UseVisualStyleBackColor = true;
            // 
            // rbControles
            // 
            this.rbControles.AutoSize = true;
            this.rbControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbControles.Location = new System.Drawing.Point(748, 36);
            this.rbControles.Name = "rbControles";
            this.rbControles.Size = new System.Drawing.Size(83, 20);
            this.rbControles.TabIndex = 3;
            this.rbControles.TabStop = true;
            this.rbControles.Text = "Controles";
            this.rbControles.UseVisualStyleBackColor = true;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(467, 38);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(93, 23);
            this.fullLabel1.TabIndex = 2;
            this.fullLabel1.Text = "Movil Patente:";
            // 
            // cdcPatente
            // 
            this.cdcPatente.BackColor = System.Drawing.SystemColors.Window;
            this.cdcPatente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcPatente.FormattingEnabled = true;
            this.cdcPatente.Location = new System.Drawing.Point(562, 37);
            this.cdcPatente.Name = "cdcPatente";
            this.cdcPatente.Size = new System.Drawing.Size(136, 21);
            this.cdcPatente.Sorted = true;
            this.cdcPatente.TabIndex = 1;
            // 
            // igControlReparacion
            // 
            this.igControlReparacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igControlReparacion.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igControlReparacion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igControlReparacion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igControlReparacion.BorderThickness = 1F;
            this.igControlReparacion.Controls.Add(this.glassButton3);
            this.igControlReparacion.Controls.Add(this.textEdit5);
            this.igControlReparacion.Controls.Add(this.textEdit4);
            this.igControlReparacion.Controls.Add(this.textEdit3);
            this.igControlReparacion.Controls.Add(this.textEdit2);
            this.igControlReparacion.Controls.Add(this.cdlControlesReparaciones);
            this.igControlReparacion.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igControlReparacion.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igControlReparacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igControlReparacion.GroupImage = null;
            this.igControlReparacion.GroupTitle = "Controles y Reparaciones";
            this.igControlReparacion.Location = new System.Drawing.Point(13, 61);
            this.igControlReparacion.Name = "igControlReparacion";
            this.igControlReparacion.Padding = new System.Windows.Forms.Padding(20);
            this.igControlReparacion.PaintGroupBox = true;
            this.igControlReparacion.RoundCorners = 10;
            this.igControlReparacion.ShadowColor = System.Drawing.Color.DarkGray;
            this.igControlReparacion.ShadowControl = true;
            this.igControlReparacion.ShadowThickness = 3;
            this.igControlReparacion.Size = new System.Drawing.Size(984, 279);
            this.igControlReparacion.SkinFixed = true;
            this.igControlReparacion.SkinFullFixed = true;
            this.igControlReparacion.TabIndex = 0;
            // 
            // textEdit5
            // 
            this.textEdit5.BackColor = System.Drawing.SystemColors.Window;
            this.textEdit5.Location = new System.Drawing.Point(715, 71);
            this.textEdit5.Multiline = true;
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(246, 130);
            this.textEdit5.TabIndex = 10;
            // 
            // textEdit4
            // 
            this.textEdit4.BackColor = System.Drawing.SystemColors.Window;
            this.textEdit4.Location = new System.Drawing.Point(270, 212);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(389, 20);
            this.textEdit4.TabIndex = 9;
            // 
            // textEdit3
            // 
            this.textEdit3.BackColor = System.Drawing.SystemColors.Window;
            this.textEdit3.Location = new System.Drawing.Point(270, 147);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(389, 20);
            this.textEdit3.TabIndex = 8;
            // 
            // textEdit2
            // 
            this.textEdit2.BackColor = System.Drawing.SystemColors.Window;
            this.textEdit2.Location = new System.Drawing.Point(270, 83);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(389, 20);
            this.textEdit2.TabIndex = 7;
            // 
            // cdlControlesReparaciones
            // 
            this.cdlControlesReparaciones.FormattingEnabled = true;
            this.cdlControlesReparaciones.Location = new System.Drawing.Point(11, 31);
            this.cdlControlesReparaciones.Name = "cdlControlesReparaciones";
            this.cdlControlesReparaciones.Size = new System.Drawing.Size(209, 238);
            this.cdlControlesReparaciones.Sorted = true;
            this.cdlControlesReparaciones.TabIndex = 0;
            // 
            // gbQuitarTodos
            // 
            this.gbQuitarTodos.FixedImage = TNGS.NetControls.FixedGlassButtons.RemoveAll;
            this.gbQuitarTodos.Location = new System.Drawing.Point(122, 531);
            this.gbQuitarTodos.Name = "gbQuitarTodos";
            this.gbQuitarTodos.Size = new System.Drawing.Size(116, 40);
            this.gbQuitarTodos.TabIndex = 7;
            this.gbQuitarTodos.Text = "Quitar Todos";
            this.gbQuitarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbQuitarUno
            // 
            this.gbQuitarUno.FixedImage = TNGS.NetControls.FixedGlassButtons.RemoveOne;
            this.gbQuitarUno.Location = new System.Drawing.Point(12, 531);
            this.gbQuitarUno.Name = "gbQuitarUno";
            this.gbQuitarUno.Size = new System.Drawing.Size(104, 40);
            this.gbQuitarUno.TabIndex = 8;
            this.gbQuitarUno.Text = "Quitar Uno";
            this.gbQuitarUno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // glassButton3
            // 
            this.glassButton3.FixedImage = TNGS.NetControls.FixedGlassButtons.Add;
            this.glassButton3.Location = new System.Drawing.Point(866, 223);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.Size = new System.Drawing.Size(104, 33);
            this.glassButton3.TabIndex = 9;
            this.glassButton3.Text = "Agregar";
            this.glassButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbCancel
            // 
            this.gbCancel.FixedImage = TNGS.NetControls.FixedGlassButtons.Cancel;
            this.gbCancel.Location = new System.Drawing.Point(775, 531);
            this.gbCancel.Name = "gbCancel";
            this.gbCancel.Size = new System.Drawing.Size(104, 40);
            this.gbCancel.TabIndex = 9;
            this.gbCancel.Text = "Cancelar";
            this.gbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAccept
            // 
            this.gbAccept.FixedImage = TNGS.NetControls.FixedGlassButtons.Accept;
            this.gbAccept.Location = new System.Drawing.Point(891, 531);
            this.gbAccept.Name = "gbAccept";
            this.gbAccept.Size = new System.Drawing.Size(104, 40);
            this.gbAccept.TabIndex = 10;
            this.gbAccept.Text = "Aceptar";
            this.gbAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fullLabel3.Location = new System.Drawing.Point(29, 351);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(75, 14);
            this.fullLabel3.TabIndex = 11;
            this.fullLabel3.Text = "Seleccionado:";
            // 
            // lblNumSeleccionado
            // 
            this.lblNumSeleccionado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumSeleccionado.Location = new System.Drawing.Point(100, 351);
            this.lblNumSeleccionado.Name = "lblNumSeleccionado";
            this.lblNumSeleccionado.Size = new System.Drawing.Size(75, 14);
            this.lblNumSeleccionado.TabIndex = 12;
            this.lblNumSeleccionado.Text = "0";
            // 
            // NuevosControlesReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 583);
            this.Controls.Add(this.xPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NuevosControlesReparaciones";
            this.Text = "NuevosControlesReparaciones";
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgControlRepaSeleccionados)).EndInit();
            this.igControlReparacion.ResumeLayout(false);
            this.igControlReparacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xPanel1;
        private System.Windows.Forms.RadioButton rbReparaciones;
        private System.Windows.Forms.RadioButton rbControles;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.CDCombo cdcPatente;
        private TNGS.NetControls.ImgGroup igControlReparacion;
        private TNGS.NetControls.FullGrid fgControlRepaSeleccionados;
        private TNGS.NetControls.CDList cdlControlesReparaciones;
        private TNGS.NetControls.TextEdit teNumOrden;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.TextEdit textEdit5;
        private TNGS.NetControls.TextEdit textEdit4;
        private TNGS.NetControls.TextEdit textEdit3;
        private TNGS.NetControls.TextEdit textEdit2;
        private TNGS.NetControls.FullLabel lblNumSeleccionado;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.GlassButton gbAccept;
        private TNGS.NetControls.GlassButton gbCancel;
        private TNGS.NetControls.GlassButton gbQuitarUno;
        private TNGS.NetControls.GlassButton gbQuitarTodos;
        private TNGS.NetControls.GlassButton glassButton3;
    }
}