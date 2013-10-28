namespace Rivn.Mv
{
    partial class Estados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estados));
            this.xpnlPanelAtras = new TNGS.NetControls.XPanel();
            this.ftrMoviles = new TNGS.NetControls.FullTreeView();
            this.igMoviles = new TNGS.NetControls.ImgGroup();
            this.igKilometros = new TNGS.NetControls.ImgGroup();
            this.fullGrid1 = new TNGS.NetControls.FullGrid();
            this.igCombustibles = new TNGS.NetControls.ImgGroup();
            this.fullGrid2 = new TNGS.NetControls.FullGrid();
            this.igEquipamiento = new TNGS.NetControls.ImgGroup();
            this.fullGrid3 = new TNGS.NetControls.FullGrid();
            this.gbNuevoEq = new TNGS.NetControls.GlassButton();
            this.gbModificarEq = new TNGS.NetControls.GlassButton();
            this.gbBorrarEq = new TNGS.NetControls.GlassButton();
            this.neKilometros = new TNGS.NetControls.NumberEdit();
            this.gbNuevoKM = new TNGS.NetControls.GlassButton();
            this.tePatente = new TNGS.NetControls.TextEdit();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.gbAgregarCombustible = new TNGS.NetControls.GlassButton();
            this.lblModelo = new TNGS.NetControls.FullLabel();
            this.cmbEstado = new TNGS.NetControls.CDCombo();
            this.lblEstado = new TNGS.NetControls.FullLabel();
            this.teModelo = new TNGS.NetControls.TextEdit();
            this.glassButton1 = new TNGS.NetControls.GlassButton();
            this.xpnlPanelAtras.SuspendLayout();
            this.igMoviles.SuspendLayout();
            this.igKilometros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid1)).BeginInit();
            this.igCombustibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid2)).BeginInit();
            this.igEquipamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // xpnlPanelAtras
            // 
            this.xpnlPanelAtras.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanelAtras.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanelAtras.Controls.Add(this.igEquipamiento);
            this.xpnlPanelAtras.Controls.Add(this.igCombustibles);
            this.xpnlPanelAtras.Controls.Add(this.igKilometros);
            this.xpnlPanelAtras.Controls.Add(this.igMoviles);
            this.xpnlPanelAtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanelAtras.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanelAtras.Name = "xpnlPanelAtras";
            this.xpnlPanelAtras.Size = new System.Drawing.Size(788, 485);
            this.xpnlPanelAtras.SkinFixed = true;
            this.xpnlPanelAtras.TabIndex = 0;
            // 
            // ftrMoviles
            // 
            this.ftrMoviles.IgnoreLevelInFill = false;
            this.ftrMoviles.Location = new System.Drawing.Point(17, 37);
            this.ftrMoviles.Name = "ftrMoviles";
            this.ftrMoviles.Size = new System.Drawing.Size(171, 190);
            this.ftrMoviles.TabIndex = 0;
            // 
            // igMoviles
            // 
            this.igMoviles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igMoviles.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igMoviles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igMoviles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igMoviles.BorderThickness = 1F;
            this.igMoviles.Controls.Add(this.glassButton1);
            this.igMoviles.Controls.Add(this.teModelo);
            this.igMoviles.Controls.Add(this.lblEstado);
            this.igMoviles.Controls.Add(this.cmbEstado);
            this.igMoviles.Controls.Add(this.lblModelo);
            this.igMoviles.Controls.Add(this.tePatente);
            this.igMoviles.Controls.Add(this.lblPatente);
            this.igMoviles.Controls.Add(this.ftrMoviles);
            this.igMoviles.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igMoviles.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igMoviles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igMoviles.GroupImage = ((System.Drawing.Image)(resources.GetObject("igMoviles.GroupImage")));
            this.igMoviles.GroupTitle = "Moviles";
            this.igMoviles.Location = new System.Drawing.Point(12, 12);
            this.igMoviles.Name = "igMoviles";
            this.igMoviles.Padding = new System.Windows.Forms.Padding(20);
            this.igMoviles.PaintGroupBox = true;
            this.igMoviles.RoundCorners = 10;
            this.igMoviles.ShadowColor = System.Drawing.Color.DarkGray;
            this.igMoviles.ShadowControl = true;
            this.igMoviles.ShadowThickness = 3;
            this.igMoviles.Size = new System.Drawing.Size(204, 461);
            this.igMoviles.SkinFixed = true;
            this.igMoviles.SkinFullFixed = true;
            this.igMoviles.TabIndex = 1;
            // 
            // igKilometros
            // 
            this.igKilometros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igKilometros.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igKilometros.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igKilometros.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igKilometros.BorderThickness = 1F;
            this.igKilometros.Controls.Add(this.gbNuevoKM);
            this.igKilometros.Controls.Add(this.neKilometros);
            this.igKilometros.Controls.Add(this.fullGrid1);
            this.igKilometros.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igKilometros.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igKilometros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igKilometros.GroupImage = ((System.Drawing.Image)(resources.GetObject("igKilometros.GroupImage")));
            this.igKilometros.GroupTitle = "Kilometraje";
            this.igKilometros.Location = new System.Drawing.Point(222, 12);
            this.igKilometros.Name = "igKilometros";
            this.igKilometros.Padding = new System.Windows.Forms.Padding(20);
            this.igKilometros.PaintGroupBox = true;
            this.igKilometros.RoundCorners = 10;
            this.igKilometros.ShadowColor = System.Drawing.Color.DarkGray;
            this.igKilometros.ShadowControl = true;
            this.igKilometros.ShadowThickness = 3;
            this.igKilometros.Size = new System.Drawing.Size(280, 241);
            this.igKilometros.SkinFixed = true;
            this.igKilometros.SkinFullFixed = true;
            this.igKilometros.TabIndex = 3;
            // 
            // fullGrid1
            // 
            this.fullGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullGrid1.DataMember = "";
            this.fullGrid1.ExcelTitle = "";
            this.fullGrid1.GridOrder = "";
            this.fullGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fullGrid1.Location = new System.Drawing.Point(23, 37);
            this.fullGrid1.Name = "fullGrid1";
            this.fullGrid1.Size = new System.Drawing.Size(234, 124);
            this.fullGrid1.TabIndex = 0;
            // 
            // igCombustibles
            // 
            this.igCombustibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igCombustibles.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igCombustibles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igCombustibles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igCombustibles.BorderThickness = 1F;
            this.igCombustibles.Controls.Add(this.gbAgregarCombustible);
            this.igCombustibles.Controls.Add(this.fullGrid2);
            this.igCombustibles.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igCombustibles.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igCombustibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igCombustibles.GroupImage = ((System.Drawing.Image)(resources.GetObject("igCombustibles.GroupImage")));
            this.igCombustibles.GroupTitle = "Combustibles";
            this.igCombustibles.Location = new System.Drawing.Point(222, 259);
            this.igCombustibles.Name = "igCombustibles";
            this.igCombustibles.Padding = new System.Windows.Forms.Padding(20);
            this.igCombustibles.PaintGroupBox = true;
            this.igCombustibles.RoundCorners = 10;
            this.igCombustibles.ShadowColor = System.Drawing.Color.DarkGray;
            this.igCombustibles.ShadowControl = true;
            this.igCombustibles.ShadowThickness = 3;
            this.igCombustibles.Size = new System.Drawing.Size(276, 214);
            this.igCombustibles.SkinFixed = true;
            this.igCombustibles.SkinFullFixed = true;
            this.igCombustibles.TabIndex = 4;
            // 
            // fullGrid2
            // 
            this.fullGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullGrid2.DataMember = "";
            this.fullGrid2.ExcelTitle = "";
            this.fullGrid2.GridOrder = "";
            this.fullGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fullGrid2.Location = new System.Drawing.Point(23, 37);
            this.fullGrid2.Name = "fullGrid2";
            this.fullGrid2.Size = new System.Drawing.Size(231, 124);
            this.fullGrid2.TabIndex = 0;
            // 
            // igEquipamiento
            // 
            this.igEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.igEquipamiento.BackgroundGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.igEquipamiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.BorderThickness = 1F;
            this.igEquipamiento.Controls.Add(this.gbBorrarEq);
            this.igEquipamiento.Controls.Add(this.gbModificarEq);
            this.igEquipamiento.Controls.Add(this.gbNuevoEq);
            this.igEquipamiento.Controls.Add(this.fullGrid3);
            this.igEquipamiento.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.igEquipamiento.FontTitle = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igEquipamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.igEquipamiento.GroupImage = ((System.Drawing.Image)(resources.GetObject("igEquipamiento.GroupImage")));
            this.igEquipamiento.GroupTitle = "Equipamiento";
            this.igEquipamiento.Location = new System.Drawing.Point(504, 12);
            this.igEquipamiento.Name = "igEquipamiento";
            this.igEquipamiento.Padding = new System.Windows.Forms.Padding(20);
            this.igEquipamiento.PaintGroupBox = true;
            this.igEquipamiento.RoundCorners = 10;
            this.igEquipamiento.ShadowColor = System.Drawing.Color.DarkGray;
            this.igEquipamiento.ShadowControl = true;
            this.igEquipamiento.ShadowThickness = 3;
            this.igEquipamiento.Size = new System.Drawing.Size(280, 461);
            this.igEquipamiento.SkinFixed = true;
            this.igEquipamiento.SkinFullFixed = true;
            this.igEquipamiento.TabIndex = 4;
            // 
            // fullGrid3
            // 
            this.fullGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullGrid3.DataMember = "";
            this.fullGrid3.ExcelTitle = "";
            this.fullGrid3.GridOrder = "";
            this.fullGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fullGrid3.Location = new System.Drawing.Point(23, 37);
            this.fullGrid3.Name = "fullGrid3";
            this.fullGrid3.Size = new System.Drawing.Size(234, 363);
            this.fullGrid3.TabIndex = 0;
            // 
            // gbNuevoEq
            // 
            this.gbNuevoEq.FixedImage = TNGS.NetControls.FixedGlassButtons.Add;
            this.gbNuevoEq.Location = new System.Drawing.Point(10, 412);
            this.gbNuevoEq.Name = "gbNuevoEq";
            this.gbNuevoEq.Size = new System.Drawing.Size(84, 26);
            this.gbNuevoEq.TabIndex = 1;
            this.gbNuevoEq.Text = "Agregar";
            this.gbNuevoEq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbModificarEq
            // 
            this.gbModificarEq.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.gbModificarEq.Location = new System.Drawing.Point(100, 412);
            this.gbModificarEq.Name = "gbModificarEq";
            this.gbModificarEq.Size = new System.Drawing.Size(87, 26);
            this.gbModificarEq.TabIndex = 2;
            this.gbModificarEq.Text = "Modificar";
            this.gbModificarEq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbBorrarEq
            // 
            this.gbBorrarEq.FixedImage = TNGS.NetControls.FixedGlassButtons.Delete;
            this.gbBorrarEq.Location = new System.Drawing.Point(193, 412);
            this.gbBorrarEq.Name = "gbBorrarEq";
            this.gbBorrarEq.Size = new System.Drawing.Size(81, 26);
            this.gbBorrarEq.TabIndex = 3;
            this.gbBorrarEq.Text = "Borrar";
            this.gbBorrarEq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // neKilometros
            // 
            this.neKilometros.BackColor = System.Drawing.SystemColors.Window;
            this.neKilometros.Location = new System.Drawing.Point(24, 179);
            this.neKilometros.MaxLength = 7;
            this.neKilometros.Name = "neKilometros";
            this.neKilometros.Size = new System.Drawing.Size(100, 20);
            this.neKilometros.TabIndex = 1;
            this.neKilometros.Text = "0";
            // 
            // gbNuevoKM
            // 
            this.gbNuevoKM.FixedImage = TNGS.NetControls.FixedGlassButtons.Add;
            this.gbNuevoKM.Location = new System.Drawing.Point(139, 175);
            this.gbNuevoKM.Name = "gbNuevoKM";
            this.gbNuevoKM.Size = new System.Drawing.Size(104, 26);
            this.gbNuevoKM.TabIndex = 4;
            this.gbNuevoKM.Text = "Agregar";
            this.gbNuevoKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.Location = new System.Drawing.Point(87, 272);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(69, 20);
            this.tePatente.TabIndex = 7;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(14, 272);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(67, 18);
            this.lblPatente.TabIndex = 8;
            this.lblPatente.Text = "Patente:";
            // 
            // gbAgregarCombustible
            // 
            this.gbAgregarCombustible.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.gbAgregarCombustible.Location = new System.Drawing.Point(79, 167);
            this.gbAgregarCombustible.Name = "gbAgregarCombustible";
            this.gbAgregarCombustible.Size = new System.Drawing.Size(104, 26);
            this.gbAgregarCombustible.TabIndex = 5;
            this.gbAgregarCombustible.Text = "Nuevo";
            this.gbAgregarCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(14, 310);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 18);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(70, 350);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(118, 21);
            this.cmbEstado.Sorted = true;
            this.cmbEstado.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(14, 353);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // teModelo
            // 
            this.teModelo.BackColor = System.Drawing.SystemColors.Window;
            this.teModelo.Location = new System.Drawing.Point(75, 308);
            this.teModelo.Name = "teModelo";
            this.teModelo.Size = new System.Drawing.Size(105, 20);
            this.teModelo.TabIndex = 24;
            // 
            // glassButton1
            // 
            this.glassButton1.FixedImage = TNGS.NetControls.FixedGlassButtons.Modify;
            this.glassButton1.Location = new System.Drawing.Point(87, 392);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(87, 37);
            this.glassButton1.TabIndex = 25;
            this.glassButton1.Text = "Modificar Estado";
            this.glassButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 485);
            this.Controls.Add(this.xpnlPanelAtras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Estados";
            this.Text = "Estados";
            this.Load += new System.EventHandler(this.Estados_Load);
            this.xpnlPanelAtras.ResumeLayout(false);
            this.igMoviles.ResumeLayout(false);
            this.igMoviles.PerformLayout();
            this.igKilometros.ResumeLayout(false);
            this.igKilometros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid1)).EndInit();
            this.igCombustibles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid2)).EndInit();
            this.igEquipamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullGrid3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.XPanel xpnlPanelAtras;
        private TNGS.NetControls.ImgGroup igMoviles;
        private TNGS.NetControls.FullTreeView ftrMoviles;
        private TNGS.NetControls.ImgGroup igKilometros;
        private TNGS.NetControls.FullGrid fullGrid1;
        private TNGS.NetControls.ImgGroup igCombustibles;
        private TNGS.NetControls.FullGrid fullGrid2;
        private TNGS.NetControls.ImgGroup igEquipamiento;
        private TNGS.NetControls.FullGrid fullGrid3;
        private TNGS.NetControls.GlassButton gbBorrarEq;
        private TNGS.NetControls.GlassButton gbModificarEq;
        private TNGS.NetControls.GlassButton gbNuevoEq;
        private TNGS.NetControls.NumberEdit neKilometros;
        private TNGS.NetControls.GlassButton gbNuevoKM;
        private TNGS.NetControls.GlassButton gbAgregarCombustible;
        private TNGS.NetControls.TextEdit tePatente;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.FullLabel lblModelo;
        private TNGS.NetControls.GlassButton glassButton1;
        private TNGS.NetControls.TextEdit teModelo;
        private TNGS.NetControls.FullLabel lblEstado;
        private TNGS.NetControls.CDCombo cmbEstado;
    }
}