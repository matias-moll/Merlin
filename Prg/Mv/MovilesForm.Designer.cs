namespace Mrln.Mv
{
    partial class MovilesForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovilesForm));
            this.panelMoviles = new System.Windows.Forms.Panel();
            this.tgrpMoviles = new TNGS.NetControls.ImgGroup();
            this.teTipoMovil = new TNGS.NetControls.TextEdit();
            this.ftrMoviles = new TNGS.NetControls.FullTreeView();
            this.fullLabel5 = new TNGS.NetControls.FullLabel();
            this.lblModelo = new TNGS.NetControls.FullLabel();
            this.teEstado = new TNGS.NetControls.TextEdit();
            this.tePatente = new TNGS.NetControls.TextEdit();
            this.lblEstado = new TNGS.NetControls.FullLabel();
            this.teModelo = new TNGS.NetControls.TextEdit();
            this.lblPatente = new TNGS.NetControls.FullLabel();
            this.gbNuevoMovil = new TNGS.NetControls.GlassButton();
            this.gbBorrarMovil = new TNGS.NetControls.GlassButton();
            this.panelMovilSeleccionado = new System.Windows.Forms.Panel();
            this.gbHistorialCompleto = new TNGS.NetControls.GlassButton();
            this.fgKm = new TNGS.NetControls.FullGrid();
            this.gbCambiarEstado = new TNGS.NetControls.GlassButton();
            this.fgEquipamiento = new TNGS.NetControls.FullGrid();
            this.gbModificarMovil = new TNGS.NetControls.GlassButton();
            this.fgCombustibles = new TNGS.NetControls.FullGrid();
            this.fullLabel4 = new TNGS.NetControls.FullLabel();
            this.fgMovilEstados = new TNGS.NetControls.FullGrid();
            this.gbAgregarKMs = new TNGS.NetControls.GlassButton();
            this.gbInfracciones = new TNGS.NetControls.GlassButton();
            this.fullLabel3 = new TNGS.NetControls.FullLabel();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.gbCargarNafta = new TNGS.NetControls.GlassButton();
            this.gbAccidentes = new TNGS.NetControls.GlassButton();
            this.fullLabel2 = new TNGS.NetControls.FullLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMoviles.SuspendLayout();
            this.tgrpMoviles.SuspendLayout();
            this.panelMovilSeleccionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMoviles
            // 
            this.panelMoviles.BackColor = System.Drawing.Color.Transparent;
            this.panelMoviles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMoviles.Controls.Add(this.tgrpMoviles);
            this.panelMoviles.Controls.Add(this.gbNuevoMovil);
            this.panelMoviles.Controls.Add(this.gbBorrarMovil);
            this.panelMoviles.Controls.Add(this.gbModificarMovil);
            this.panelMoviles.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMoviles.Location = new System.Drawing.Point(0, 0);
            this.panelMoviles.Name = "panelMoviles";
            this.panelMoviles.Size = new System.Drawing.Size(258, 614);
            this.panelMoviles.TabIndex = 0;
            // 
            // tgrpMoviles
            // 
            this.tgrpMoviles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tgrpMoviles.BackgroundGradientColor = System.Drawing.Color.White;
            this.tgrpMoviles.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.None;
            this.tgrpMoviles.BlackBorder = true;
            this.tgrpMoviles.BorderColor = System.Drawing.Color.Black;
            this.tgrpMoviles.BorderThickness = 1F;
            this.tgrpMoviles.Controls.Add(this.teTipoMovil);
            this.tgrpMoviles.Controls.Add(this.ftrMoviles);
            this.tgrpMoviles.Controls.Add(this.fullLabel5);
            this.tgrpMoviles.Controls.Add(this.lblModelo);
            this.tgrpMoviles.Controls.Add(this.teEstado);
            this.tgrpMoviles.Controls.Add(this.tePatente);
            this.tgrpMoviles.Controls.Add(this.lblEstado);
            this.tgrpMoviles.Controls.Add(this.teModelo);
            this.tgrpMoviles.Controls.Add(this.lblPatente);
            this.tgrpMoviles.CustomGroupBoxColor = System.Drawing.Color.White;
            this.tgrpMoviles.FlatMode = true;
            this.tgrpMoviles.FontTitle = new System.Drawing.Font("Arial", 9F);
            this.tgrpMoviles.ForeColor = System.Drawing.Color.Black;
            this.tgrpMoviles.GroupImage = null;
            this.tgrpMoviles.GroupTitle = "Móviles";
            this.tgrpMoviles.Location = new System.Drawing.Point(6, 70);
            this.tgrpMoviles.Name = "tgrpMoviles";
            this.tgrpMoviles.Padding = new System.Windows.Forms.Padding(20);
            this.tgrpMoviles.PaintGroupBox = false;
            this.tgrpMoviles.RoundCorners = 4;
            this.tgrpMoviles.ShadowColor = System.Drawing.Color.DarkGray;
            this.tgrpMoviles.ShadowControl = false;
            this.tgrpMoviles.ShadowThickness = 3;
            this.tgrpMoviles.Size = new System.Drawing.Size(243, 541);
            this.tgrpMoviles.TabIndex = 0;
            this.tgrpMoviles.TitleBackground = System.Drawing.Color.Firebrick;
            this.tgrpMoviles.TitleBackgroundDefault = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.tgrpMoviles.TitleFontColor = System.Drawing.Color.White;
            // 
            // teTipoMovil
            // 
            this.teTipoMovil.BackColor = System.Drawing.SystemColors.Window;
            this.teTipoMovil.Enabled = false;
            this.teTipoMovil.Location = new System.Drawing.Point(80, 450);
            this.teTipoMovil.Name = "teTipoMovil";
            this.teTipoMovil.Size = new System.Drawing.Size(154, 20);
            this.teTipoMovil.TabIndex = 2;
            this.teTipoMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ftrMoviles
            // 
            this.ftrMoviles.IgnoreLevelInFill = false;
            this.ftrMoviles.Location = new System.Drawing.Point(12, 32);
            this.ftrMoviles.Name = "ftrMoviles";
            this.ftrMoviles.Size = new System.Drawing.Size(222, 381);
            this.ftrMoviles.TabIndex = 0;
            this.ftrMoviles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ftrMoviles_AfterSelect);
            this.ftrMoviles.DoubleClick += new System.EventHandler(this.ftrMoviles_DoubleClick);
            // 
            // fullLabel5
            // 
            this.fullLabel5.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel5.ForeColor = System.Drawing.Color.Black;
            this.fullLabel5.Location = new System.Drawing.Point(16, 450);
            this.fullLabel5.Name = "fullLabel5";
            this.fullLabel5.Size = new System.Drawing.Size(55, 18);
            this.fullLabel5.TabIndex = 26;
            this.fullLabel5.Text = "Tipo:";
            // 
            // lblModelo
            // 
            this.lblModelo.BackColor = System.Drawing.Color.Transparent;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(16, 478);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(55, 18);
            this.lblModelo.TabIndex = 20;
            this.lblModelo.Text = "Modelo:";
            // 
            // teEstado
            // 
            this.teEstado.BackColor = System.Drawing.SystemColors.Window;
            this.teEstado.Enabled = false;
            this.teEstado.Location = new System.Drawing.Point(80, 504);
            this.teEstado.Name = "teEstado";
            this.teEstado.Size = new System.Drawing.Size(154, 20);
            this.teEstado.TabIndex = 4;
            this.teEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tePatente
            // 
            this.tePatente.BackColor = System.Drawing.SystemColors.Window;
            this.tePatente.Enabled = false;
            this.tePatente.Location = new System.Drawing.Point(80, 423);
            this.tePatente.Name = "tePatente";
            this.tePatente.Size = new System.Drawing.Size(154, 20);
            this.tePatente.TabIndex = 1;
            this.tePatente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(16, 504);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 18);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // teModelo
            // 
            this.teModelo.BackColor = System.Drawing.SystemColors.Window;
            this.teModelo.Enabled = false;
            this.teModelo.Location = new System.Drawing.Point(80, 477);
            this.teModelo.Name = "teModelo";
            this.teModelo.Size = new System.Drawing.Size(154, 20);
            this.teModelo.TabIndex = 3;
            this.teModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatente
            // 
            this.lblPatente.BackColor = System.Drawing.Color.Transparent;
            this.lblPatente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.ForeColor = System.Drawing.Color.Black;
            this.lblPatente.Location = new System.Drawing.Point(16, 425);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(58, 18);
            this.lblPatente.TabIndex = 8;
            this.lblPatente.Text = "Patente:";
            // 
            // gbNuevoMovil
            // 
            this.gbNuevoMovil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevoMovil.BackgroundImage")));
            this.gbNuevoMovil.BlackBorder = true;
            this.gbNuevoMovil.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevoMovil.CircleButton = false;
            this.gbNuevoMovil.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.New;
            this.gbNuevoMovil.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbNuevoMovil.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Aceptar;
            this.gbNuevoMovil.FlatFontSize = 9;
            this.gbNuevoMovil.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevoMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbNuevoMovil.Location = new System.Drawing.Point(4, 15);
            this.gbNuevoMovil.Name = "gbNuevoMovil";
            this.gbNuevoMovil.RoundCorners = 2;
            this.gbNuevoMovil.Size = new System.Drawing.Size(74, 41);
            this.gbNuevoMovil.TabIndex = 1;
            this.gbNuevoMovil.Text = "Nuevo";
            this.gbNuevoMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbNuevoMovil.W8Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gbNuevoMovil.Click += new System.EventHandler(this.gbNuevoMovil_Click);
            // 
            // gbBorrarMovil
            // 
            this.gbBorrarMovil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBorrarMovil.BackgroundImage")));
            this.gbBorrarMovil.BlackBorder = true;
            this.gbBorrarMovil.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBorrarMovil.CircleButton = false;
            this.gbBorrarMovil.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbBorrarMovil.FlatColor = System.Drawing.Color.Red;
            this.gbBorrarMovil.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbBorrarMovil.FlatFontSize = 9;
            this.gbBorrarMovil.FlatTextColor = System.Drawing.Color.Black;
            this.gbBorrarMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBorrarMovil.Location = new System.Drawing.Point(180, 14);
            this.gbBorrarMovil.Name = "gbBorrarMovil";
            this.gbBorrarMovil.RoundCorners = 2;
            this.gbBorrarMovil.Size = new System.Drawing.Size(71, 41);
            this.gbBorrarMovil.TabIndex = 2;
            this.gbBorrarMovil.Text = "Borrar";
            this.gbBorrarMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbBorrarMovil.W8Color = System.Drawing.Color.Red;
            this.gbBorrarMovil.Click += new System.EventHandler(this.gbBorrarMovil_Click);
            // 
            // panelMovilSeleccionado
            // 
            this.panelMovilSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.panelMovilSeleccionado.Controls.Add(this.gbHistorialCompleto);
            this.panelMovilSeleccionado.Controls.Add(this.fgKm);
            this.panelMovilSeleccionado.Controls.Add(this.gbCambiarEstado);
            this.panelMovilSeleccionado.Controls.Add(this.fgEquipamiento);
            this.panelMovilSeleccionado.Controls.Add(this.fgCombustibles);
            this.panelMovilSeleccionado.Controls.Add(this.fullLabel4);
            this.panelMovilSeleccionado.Controls.Add(this.fgMovilEstados);
            this.panelMovilSeleccionado.Controls.Add(this.gbAgregarKMs);
            this.panelMovilSeleccionado.Controls.Add(this.gbInfracciones);
            this.panelMovilSeleccionado.Controls.Add(this.fullLabel3);
            this.panelMovilSeleccionado.Controls.Add(this.fullLabel1);
            this.panelMovilSeleccionado.Controls.Add(this.gbCargarNafta);
            this.panelMovilSeleccionado.Controls.Add(this.gbAccidentes);
            this.panelMovilSeleccionado.Controls.Add(this.fullLabel2);
            this.panelMovilSeleccionado.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMovilSeleccionado.Location = new System.Drawing.Point(258, 0);
            this.panelMovilSeleccionado.Name = "panelMovilSeleccionado";
            this.panelMovilSeleccionado.Size = new System.Drawing.Size(740, 614);
            this.panelMovilSeleccionado.TabIndex = 64;
            // 
            // gbHistorialCompleto
            // 
            this.gbHistorialCompleto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbHistorialCompleto.BackgroundImage")));
            this.gbHistorialCompleto.BlackBorder = true;
            this.gbHistorialCompleto.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbHistorialCompleto.CircleButton = false;
            this.gbHistorialCompleto.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.gbHistorialCompleto.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbHistorialCompleto.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbHistorialCompleto.FlatFontSize = 9;
            this.gbHistorialCompleto.FlatTextColor = System.Drawing.Color.Black;
            this.gbHistorialCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbHistorialCompleto.Location = new System.Drawing.Point(22, 5);
            this.gbHistorialCompleto.Name = "gbHistorialCompleto";
            this.gbHistorialCompleto.RoundCorners = 2;
            this.gbHistorialCompleto.Size = new System.Drawing.Size(101, 60);
            this.gbHistorialCompleto.TabIndex = 4;
            this.gbHistorialCompleto.Text = "Historial Unificado";
            this.gbHistorialCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbHistorialCompleto.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbHistorialCompleto.Click += new System.EventHandler(this.gbHistorialCompleto_Click);
            // 
            // fgKm
            // 
            this.fgKm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgKm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgKm.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.fgKm.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgKm.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgKm.CaptionVisible = false;
            this.fgKm.DataMember = "";
            this.fgKm.ExcelName = "Datos Exportados";
            this.fgKm.ExcelTitle = "";
            this.fgKm.GridOrder = "";
            this.fgKm.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgKm.Location = new System.Drawing.Point(6, 132);
            this.fgKm.Name = "fgKm";
            this.fgKm.Size = new System.Drawing.Size(325, 202);
            this.fgKm.SkinFixed = true;
            this.fgKm.TabIndex = 0;
            // 
            // gbCambiarEstado
            // 
            this.gbCambiarEstado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCambiarEstado.BackgroundImage")));
            this.gbCambiarEstado.BlackBorder = true;
            this.gbCambiarEstado.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCambiarEstado.CircleButton = false;
            this.gbCambiarEstado.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Car;
            this.gbCambiarEstado.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCambiarEstado.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCambiarEstado.FlatFontSize = 9;
            this.gbCambiarEstado.FlatTextColor = System.Drawing.Color.Black;
            this.gbCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCambiarEstado.ImageOnTop = true;
            this.gbCambiarEstado.Location = new System.Drawing.Point(178, 5);
            this.gbCambiarEstado.Name = "gbCambiarEstado";
            this.gbCambiarEstado.RoundCorners = 2;
            this.gbCambiarEstado.Size = new System.Drawing.Size(109, 60);
            this.gbCambiarEstado.TabIndex = 6;
            this.gbCambiarEstado.Text = "Cambiar Estado";
            this.gbCambiarEstado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCambiarEstado.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbCambiarEstado.Click += new System.EventHandler(this.gbModificarEstado_Click);
            // 
            // fgEquipamiento
            // 
            this.fgEquipamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgEquipamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgEquipamiento.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.fgEquipamiento.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgEquipamiento.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgEquipamiento.CaptionVisible = false;
            this.fgEquipamiento.DataMember = "";
            this.fgEquipamiento.ExcelName = "Datos Exportados";
            this.fgEquipamiento.ExcelTitle = "";
            this.fgEquipamiento.GridOrder = "";
            this.fgEquipamiento.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgEquipamiento.Location = new System.Drawing.Point(5, 391);
            this.fgEquipamiento.Name = "fgEquipamiento";
            this.fgEquipamiento.Size = new System.Drawing.Size(326, 220);
            this.fgEquipamiento.SkinFixed = true;
            this.fgEquipamiento.TabIndex = 2;
            // 
            // gbModificarMovil
            // 
            this.gbModificarMovil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbModificarMovil.BackgroundImage")));
            this.gbModificarMovil.BlackBorder = true;
            this.gbModificarMovil.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbModificarMovil.CircleButton = false;
            this.gbModificarMovil.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.gbModificarMovil.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbModificarMovil.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbModificarMovil.FlatFontSize = 9;
            this.gbModificarMovil.FlatTextColor = System.Drawing.Color.Black;
            this.gbModificarMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbModificarMovil.Location = new System.Drawing.Point(84, 14);
            this.gbModificarMovil.Name = "gbModificarMovil";
            this.gbModificarMovil.RoundCorners = 2;
            this.gbModificarMovil.Size = new System.Drawing.Size(91, 41);
            this.gbModificarMovil.TabIndex = 5;
            this.gbModificarMovil.Text = "Modificar";
            this.gbModificarMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gbModificarMovil.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbModificarMovil.Click += new System.EventHandler(this.gbModificarMovil_Click);
            // 
            // fgCombustibles
            // 
            this.fgCombustibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgCombustibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgCombustibles.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.fgCombustibles.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgCombustibles.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgCombustibles.CaptionVisible = false;
            this.fgCombustibles.DataMember = "";
            this.fgCombustibles.ExcelName = "Datos Exportados";
            this.fgCombustibles.ExcelTitle = "";
            this.fgCombustibles.GridOrder = "";
            this.fgCombustibles.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgCombustibles.Location = new System.Drawing.Point(338, 132);
            this.fgCombustibles.Name = "fgCombustibles";
            this.fgCombustibles.Size = new System.Drawing.Size(396, 202);
            this.fgCombustibles.SkinFixed = true;
            this.fgCombustibles.TabIndex = 1;
            // 
            // fullLabel4
            // 
            this.fullLabel4.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel4.Location = new System.Drawing.Point(488, 373);
            this.fullLabel4.Name = "fullLabel4";
            this.fullLabel4.Size = new System.Drawing.Size(100, 15);
            this.fullLabel4.TabIndex = 63;
            this.fullLabel4.Text = "Estado";
            this.fullLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fgMovilEstados
            // 
            this.fgMovilEstados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgMovilEstados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgMovilEstados.CaptionBackColor = System.Drawing.Color.DodgerBlue;
            this.fgMovilEstados.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgMovilEstados.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fgMovilEstados.CaptionVisible = false;
            this.fgMovilEstados.DataMember = "";
            this.fgMovilEstados.ExcelName = "Datos Exportados";
            this.fgMovilEstados.ExcelTitle = "";
            this.fgMovilEstados.GridOrder = "";
            this.fgMovilEstados.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgMovilEstados.Location = new System.Drawing.Point(337, 391);
            this.fgMovilEstados.Name = "fgMovilEstados";
            this.fgMovilEstados.Size = new System.Drawing.Size(397, 220);
            this.fgMovilEstados.SkinFixed = true;
            this.fgMovilEstados.TabIndex = 3;
            // 
            // gbAgregarKMs
            // 
            this.gbAgregarKMs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAgregarKMs.BackgroundImage")));
            this.gbAgregarKMs.BlackBorder = true;
            this.gbAgregarKMs.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAgregarKMs.CircleButton = false;
            this.gbAgregarKMs.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbAgregarKMs.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbAgregarKMs.FlatFontSize = 9;
            this.gbAgregarKMs.FlatTextColor = System.Drawing.Color.Black;
            this.gbAgregarKMs.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAgregarKMs.ImageOnTop = true;
            this.gbAgregarKMs.Location = new System.Drawing.Point(304, 5);
            this.gbAgregarKMs.Name = "gbAgregarKMs";
            this.gbAgregarKMs.RoundCorners = 2;
            this.gbAgregarKMs.Size = new System.Drawing.Size(109, 60);
            this.gbAgregarKMs.TabIndex = 7;
            this.gbAgregarKMs.Text = "Cargar Kms";
            this.gbAgregarKMs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbAgregarKMs.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbAgregarKMs.Click += new System.EventHandler(this.gbNuevoKM_Click);
            // 
            // gbInfracciones
            // 
            this.gbInfracciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbInfracciones.BackgroundImage")));
            this.gbInfracciones.BlackBorder = true;
            this.gbInfracciones.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbInfracciones.CircleButton = false;
            this.gbInfracciones.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Note;
            this.gbInfracciones.FlatColor = System.Drawing.Color.Gold;
            this.gbInfracciones.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Yellow;
            this.gbInfracciones.FlatFontSize = 9;
            this.gbInfracciones.FlatTextColor = System.Drawing.Color.Black;
            this.gbInfracciones.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbInfracciones.ImageOnTop = true;
            this.gbInfracciones.Location = new System.Drawing.Point(637, 5);
            this.gbInfracciones.Name = "gbInfracciones";
            this.gbInfracciones.RoundCorners = 2;
            this.gbInfracciones.Size = new System.Drawing.Size(93, 60);
            this.gbInfracciones.TabIndex = 10;
            this.gbInfracciones.Text = "Infracciónes";
            this.gbInfracciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbInfracciones.W8Color = System.Drawing.Color.Gold;
            this.gbInfracciones.Click += new System.EventHandler(this.gbInfracciones_Click);
            // 
            // fullLabel3
            // 
            this.fullLabel3.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel3.Location = new System.Drawing.Point(485, 112);
            this.fullLabel3.Name = "fullLabel3";
            this.fullLabel3.Size = new System.Drawing.Size(100, 15);
            this.fullLabel3.TabIndex = 62;
            this.fullLabel3.Text = "Combustible";
            this.fullLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullLabel1
            // 
            this.fullLabel1.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel1.Location = new System.Drawing.Point(115, 112);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(100, 15);
            this.fullLabel1.TabIndex = 60;
            this.fullLabel1.Text = "Kilómetros";
            this.fullLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbCargarNafta
            // 
            this.gbCargarNafta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCargarNafta.BackgroundImage")));
            this.gbCargarNafta.BlackBorder = true;
            this.gbCargarNafta.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCargarNafta.CircleButton = false;
            this.gbCargarNafta.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.GasPump;
            this.gbCargarNafta.FlatColor = System.Drawing.Color.DodgerBlue;
            this.gbCargarNafta.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.LightBlue;
            this.gbCargarNafta.FlatFontSize = 9;
            this.gbCargarNafta.FlatTextColor = System.Drawing.Color.Black;
            this.gbCargarNafta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCargarNafta.ImageOnTop = true;
            this.gbCargarNafta.Location = new System.Drawing.Point(429, 5);
            this.gbCargarNafta.Name = "gbCargarNafta";
            this.gbCargarNafta.RoundCorners = 2;
            this.gbCargarNafta.Size = new System.Drawing.Size(93, 60);
            this.gbCargarNafta.TabIndex = 8;
            this.gbCargarNafta.Text = "Cargar Nafta";
            this.gbCargarNafta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbCargarNafta.W8Color = System.Drawing.Color.DodgerBlue;
            this.gbCargarNafta.Click += new System.EventHandler(this.gbAgregarCombustible_Click);
            // 
            // gbAccidentes
            // 
            this.gbAccidentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAccidentes.BackgroundImage")));
            this.gbAccidentes.BlackBorder = true;
            this.gbAccidentes.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbAccidentes.CircleButton = false;
            this.gbAccidentes.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Warning;
            this.gbAccidentes.FlatColor = System.Drawing.Color.Red;
            this.gbAccidentes.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbAccidentes.FlatFontSize = 9;
            this.gbAccidentes.FlatTextColor = System.Drawing.Color.Black;
            this.gbAccidentes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbAccidentes.ImageOnTop = true;
            this.gbAccidentes.Location = new System.Drawing.Point(533, 5);
            this.gbAccidentes.Name = "gbAccidentes";
            this.gbAccidentes.RoundCorners = 2;
            this.gbAccidentes.Size = new System.Drawing.Size(93, 60);
            this.gbAccidentes.TabIndex = 9;
            this.gbAccidentes.Text = "Accidentes";
            this.gbAccidentes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gbAccidentes.W8Color = System.Drawing.Color.Red;
            this.gbAccidentes.Click += new System.EventHandler(this.gbAccidentes_Click);
            // 
            // fullLabel2
            // 
            this.fullLabel2.BackColor = System.Drawing.Color.Transparent;
            this.fullLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullLabel2.Location = new System.Drawing.Point(115, 373);
            this.fullLabel2.Name = "fullLabel2";
            this.fullLabel2.Size = new System.Drawing.Size(100, 15);
            this.fullLabel2.TabIndex = 61;
            this.fullLabel2.Text = "Equipamiento";
            this.fullLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovilesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelMovilSeleccionado);
            this.Controls.Add(this.panelMoviles);
            this.Name = "MovilesForm";
            this.Size = new System.Drawing.Size(998, 614);
            this.panelMoviles.ResumeLayout(false);
            this.tgrpMoviles.ResumeLayout(false);
            this.tgrpMoviles.PerformLayout();
            this.panelMovilSeleccionado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgKm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgEquipamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCombustibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMovilEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMoviles;
        private TNGS.NetControls.ImgGroup tgrpMoviles;
        private TNGS.NetControls.TextEdit teTipoMovil;
        private TNGS.NetControls.FullTreeView ftrMoviles;
        private TNGS.NetControls.FullLabel fullLabel5;
        private TNGS.NetControls.FullLabel lblModelo;
        private TNGS.NetControls.TextEdit teEstado;
        private TNGS.NetControls.TextEdit tePatente;
        private TNGS.NetControls.FullLabel lblEstado;
        private TNGS.NetControls.TextEdit teModelo;
        private TNGS.NetControls.FullLabel lblPatente;
        private TNGS.NetControls.GlassButton gbNuevoMovil;
        private TNGS.NetControls.GlassButton gbBorrarMovil;
        private TNGS.NetControls.GlassButton gbHistorialCompleto;
        private TNGS.NetControls.GlassButton gbCambiarEstado;
        private TNGS.NetControls.GlassButton gbModificarMovil;
        private TNGS.NetControls.FullLabel fullLabel4;
        private TNGS.NetControls.GlassButton gbAgregarKMs;
        private TNGS.NetControls.FullLabel fullLabel3;
        private TNGS.NetControls.GlassButton gbCargarNafta;
        private TNGS.NetControls.FullLabel fullLabel2;
        private TNGS.NetControls.GlassButton gbAccidentes;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.GlassButton gbInfracciones;
        private TNGS.NetControls.FullGrid fgMovilEstados;
        private TNGS.NetControls.FullGrid fgKm;
        private TNGS.NetControls.FullGrid fgCombustibles;
        private TNGS.NetControls.FullGrid fgEquipamiento;
        private System.Windows.Forms.Panel panelMovilSeleccionado;
        private System.Windows.Forms.Timer timer1;
    }
}
