namespace Mrln.Ct
{
    /*Datos para la grilla:
     * Fecha de generación, tipo, cantidad de solicitudes para el mismo cliente, codVend, codCli
     * */
    partial class CierreOT
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreOT));
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.sbMain = new System.Windows.Forms.StatusStrip();
            this.sbpMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbpAvance = new System.Windows.Forms.ToolStripProgressBar();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.niSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.xpnlPanel1 = new TNGS.NetControls.XPanel();
            this.xPanel1 = new TNGS.NetControls.XPanel();
            this.itemBarra2 = new ControlesCustom.itemBarra();
            this.itemBarra1 = new ControlesCustom.itemBarra();
            this.fgGrillaOT = new TNGS.NetControls.FullGrid();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.textEdit1 = new TNGS.NetControls.TextEdit();
            this.fullLabel1 = new TNGS.NetControls.FullLabel();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.gbVerItems = new TNGS.NetControls.GlassButton();
            this.gbCerrarOT = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.tsPpanel1 = new TNGS.NetControls.TSPanel();
            this.gbBuscar = new TNGS.NetControls.GlassButton();
            this.cdcMoviles = new TNGS.NetControls.CDCombo();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.sbMain.SuspendLayout();
            this.xpnlPanel1.SuspendLayout();
            this.xPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgGrillaOT)).BeginInit();
            this.tsContainer1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsPpanel1.SuspendLayout();
            this.tsBase1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Magenta;
            this.imgTree.Images.SetKeyName(0, "tbOficinas.bmp");
            this.imgTree.Images.SetKeyName(1, "tbCobradores.bmp");
            this.imgTree.Images.SetKeyName(2, "tbPromotores.bmp");
            this.imgTree.Images.SetKeyName(3, "tbUsuarios.bmp");
            this.imgTree.Images.SetKeyName(4, "tbOfiTree.bmp");
            this.imgTree.Images.SetKeyName(5, "tbOfiFolder.bmp");
            // 
            // mnuMain
            // 
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(940, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // sbMain
            // 
            this.sbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbpMensaje,
            this.sbpConexion,
            this.sbpUsuario,
            this.sbpPercent,
            this.sbpAvance});
            this.sbMain.Location = new System.Drawing.Point(0, 625);
            this.sbMain.Name = "sbMain";
            this.sbMain.Size = new System.Drawing.Size(940, 23);
            this.sbMain.SizingGrip = false;
            this.sbMain.TabIndex = 13;
            this.sbMain.Text = "statusStrip1";
            // 
            // sbpMensaje
            // 
            this.sbpMensaje.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbpMensaje.Name = "sbpMensaje";
            this.sbpMensaje.Size = new System.Drawing.Size(732, 18);
            this.sbpMensaje.Spring = true;
            this.sbpMensaje.Text = "XXX";
            this.sbpMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbpConexion
            // 
            this.sbpConexion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.sbpConexion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpConexion.Name = "sbpConexion";
            this.sbpConexion.Size = new System.Drawing.Size(27, 18);
            this.sbpConexion.Text = "YY";
            // 
            // sbpUsuario
            // 
            this.sbpUsuario.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.sbpUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpUsuario.Name = "sbpUsuario";
            this.sbpUsuario.Size = new System.Drawing.Size(21, 18);
            this.sbpUsuario.Text = "zz";
            // 
            // sbpPercent
            // 
            this.sbpPercent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbpPercent.Name = "sbpPercent";
            this.sbpPercent.Size = new System.Drawing.Size(43, 18);
            this.sbpPercent.Text = "(15%)";
            // 
            // sbpAvance
            // 
            this.sbpAvance.AutoSize = false;
            this.sbpAvance.Margin = new System.Windows.Forms.Padding(1, 5, 1, 4);
            this.sbpAvance.Name = "sbpAvance";
            this.sbpAvance.Size = new System.Drawing.Size(100, 14);
            // 
            // xpnlPanel1
            // 
            this.xpnlPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel1.Controls.Add(this.xPanel1);
            this.xpnlPanel1.Controls.Add(this.fgGrillaOT);
            this.xpnlPanel1.Controls.Add(this.tsContainer1);
            this.xpnlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel1.Location = new System.Drawing.Point(0, 24);
            this.xpnlPanel1.Name = "xpnlPanel1";
            this.xpnlPanel1.Size = new System.Drawing.Size(940, 601);
            this.xpnlPanel1.SkinFixed = true;
            this.xpnlPanel1.TabIndex = 14;
            // 
            // xPanel1
            // 
            this.xPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xPanel1.Controls.Add(this.itemBarra2);
            this.xPanel1.Controls.Add(this.itemBarra1);
            this.xPanel1.Location = new System.Drawing.Point(0, 110);
            this.xPanel1.Name = "xPanel1";
            this.xPanel1.Size = new System.Drawing.Size(940, 96);
            this.xPanel1.SkinFixed = true;
            this.xPanel1.TabIndex = 3;
            // 
            // itemBarra2
            // 
            this.itemBarra2.AutoSize = true;
            this.itemBarra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemBarra2.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra2.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemBarra2.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra2.Location = new System.Drawing.Point(120, 0);
            this.itemBarra2.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra2.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra2.Name = "itemBarra2";
            this.itemBarra2.Numero = 0;
            this.itemBarra2.Size = new System.Drawing.Size(120, 96);
            this.itemBarra2.TabIndex = 1;
            this.itemBarra2.Titulo = "Orden de Trabajo";
            // 
            // itemBarra1
            // 
            this.itemBarra1.AutoSize = true;
            this.itemBarra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemBarra1.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra1.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemBarra1.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra1.Location = new System.Drawing.Point(0, 0);
            this.itemBarra1.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra1.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra1.Name = "itemBarra1";
            this.itemBarra1.Numero = 0;
            this.itemBarra1.Size = new System.Drawing.Size(120, 96);
            this.itemBarra1.TabIndex = 0;
            this.itemBarra1.Titulo = "Orden de Trabajo";
            // 
            // fgGrillaOT
            // 
            this.fgGrillaOT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgGrillaOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgGrillaOT.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgGrillaOT.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgGrillaOT.CaptionVisible = false;
            this.fgGrillaOT.DataMember = "";
            this.fgGrillaOT.ExcelTitle = "";
            this.fgGrillaOT.GridOrder = "";
            this.fgGrillaOT.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgGrillaOT.Location = new System.Drawing.Point(12, 365);
            this.fgGrillaOT.Margin = new System.Windows.Forms.Padding(10);
            this.fgGrillaOT.Name = "fgGrillaOT";
            this.fgGrillaOT.Padding = new System.Windows.Forms.Padding(10);
            this.fgGrillaOT.Size = new System.Drawing.Size(916, 229);
            this.fgGrillaOT.SkinFixed = true;
            this.fgGrillaOT.TabIndex = 2;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabStripPage1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(940, 115);
            this.tsContainer1.TabIndex = 0;
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Controls.Add(this.tsPpanel1);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(0, 26);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(940, 89);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 2;
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Seleccion";
            this.tsPanel2.Controls.Add(this.textEdit1);
            this.tsPanel2.Controls.Add(this.fullLabel1);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(708, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(223, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 2;
            // 
            // textEdit1
            // 
            this.textEdit1.BackColor = System.Drawing.SystemColors.Window;
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(36, 28);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(161, 21);
            this.textEdit1.TabIndex = 1;
            // 
            // fullLabel1
            // 
            this.fullLabel1.Location = new System.Drawing.Point(24, 13);
            this.fullLabel1.Name = "fullLabel1";
            this.fullLabel1.Size = new System.Drawing.Size(188, 23);
            this.fullLabel1.TabIndex = 0;
            this.fullLabel1.Text = "Orden De Trabajo Seleccionada:";
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Cierre Orden De Trabajo";
            this.tsPanel1.Controls.Add(this.gbVerItems);
            this.tsPanel1.Controls.Add(this.gbCerrarOT);
            this.tsPanel1.Controls.Add(this.gbCancelar);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.Location = new System.Drawing.Point(320, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(388, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 1;
            // 
            // gbVerItems
            // 
            this.gbVerItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbVerItems.BackgroundImage")));
            this.gbVerItems.BlackBorder = true;
            this.gbVerItems.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbVerItems.CircleButton = false;
            this.gbVerItems.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.gbVerItems.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbVerItems.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbVerItems.FlatFontSize = 9;
            this.gbVerItems.FlatTextColor = System.Drawing.Color.Black;
            this.gbVerItems.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbVerItems.Location = new System.Drawing.Point(11, 4);
            this.gbVerItems.Name = "gbVerItems";
            this.gbVerItems.RoundCorners = 2;
            this.gbVerItems.Size = new System.Drawing.Size(107, 58);
            this.gbVerItems.TabIndex = 2;
            this.gbVerItems.Text = "Ver Items ";
            this.gbVerItems.W8Color = System.Drawing.Color.RoyalBlue;
            // 
            // gbCerrarOT
            // 
            this.gbCerrarOT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCerrarOT.BackgroundImage")));
            this.gbCerrarOT.BlackBorder = true;
            this.gbCerrarOT.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCerrarOT.CircleButton = false;
            this.gbCerrarOT.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Ok;
            this.gbCerrarOT.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbCerrarOT.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbCerrarOT.FlatFontSize = 9;
            this.gbCerrarOT.FlatTextColor = System.Drawing.Color.Black;
            this.gbCerrarOT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCerrarOT.Location = new System.Drawing.Point(131, 4);
            this.gbCerrarOT.Name = "gbCerrarOT";
            this.gbCerrarOT.RoundCorners = 2;
            this.gbCerrarOT.Size = new System.Drawing.Size(114, 56);
            this.gbCerrarOT.TabIndex = 1;
            this.gbCerrarOT.Text = "Cerrar Orden de Trabajo";
            this.gbCerrarOT.W8Color = System.Drawing.Color.RoyalBlue;
            // 
            // gbCancelar
            // 
            this.gbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancelar.BackgroundImage")));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbCancelar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancelar.Location = new System.Drawing.Point(256, 4);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(126, 57);
            this.gbCancelar.TabIndex = 0;
            this.gbCancelar.Text = "Cancelar Orden de Trabajo";
            this.gbCancelar.W8Color = System.Drawing.Color.RoyalBlue;
            // 
            // tsPpanel1
            // 
            this.tsPpanel1.Caption = "Seleccion Movil";
            this.tsPpanel1.Controls.Add(this.gbBuscar);
            this.tsPpanel1.Controls.Add(this.cdcMoviles);
            this.tsPpanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPpanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPpanel1.Name = "tsPpanel1";
            this.tsPpanel1.Opacity = 255;
            this.tsPpanel1.Size = new System.Drawing.Size(320, 85);
            this.tsPpanel1.Speed = 1;
            this.tsPpanel1.TabIndex = 0;
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbBuscar.BackgroundImage")));
            this.gbBuscar.BlackBorder = true;
            this.gbBuscar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbBuscar.CircleButton = false;
            this.gbBuscar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.gbBuscar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbBuscar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbBuscar.FlatFontSize = 9;
            this.gbBuscar.FlatTextColor = System.Drawing.Color.Black;
            this.gbBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbBuscar.Location = new System.Drawing.Point(212, 5);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.RoundCorners = 2;
            this.gbBuscar.Size = new System.Drawing.Size(98, 56);
            this.gbBuscar.TabIndex = 1;
            this.gbBuscar.Text = "Buscar";
            this.gbBuscar.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbBuscar.Click += new System.EventHandler(this.gbBuscar_Click);
            // 
            // cdcMoviles
            // 
            this.cdcMoviles.BackColor = System.Drawing.SystemColors.Window;
            this.cdcMoviles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdcMoviles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cdcMoviles.FormattingEnabled = true;
            this.cdcMoviles.Location = new System.Drawing.Point(12, 23);
            this.cdcMoviles.Name = "cdcMoviles";
            this.cdcMoviles.Size = new System.Drawing.Size(181, 23);
            this.cdcMoviles.Sorted = true;
            this.cdcMoviles.TabIndex = 0;
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
            this.tsBase1.Size = new System.Drawing.Size(940, 26);
            this.tsBase1.TabIndex = 1;
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
            this.tab1.Size = new System.Drawing.Size(174, 23);
            this.tab1.TabStripPage = null;
            this.tab1.Text = "Cierre Ordenes De Trabajo";
            // 
            // CierreOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 648);
            this.Controls.Add(this.xpnlPanel1);
            this.Controls.Add(this.sbMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "CierreOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre De Ordenes De Trabajo";
            this.sbMain.ResumeLayout(false);
            this.sbMain.PerformLayout();
            this.xpnlPanel1.ResumeLayout(false);
            this.xPanel1.ResumeLayout(false);
            this.xPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgGrillaOT)).EndInit();
            this.tsContainer1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPanel2.PerformLayout();
            this.tsPanel1.ResumeLayout(false);
            this.tsPpanel1.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.StatusStrip sbMain;
        private System.Windows.Forms.ToolStripStatusLabel sbpMensaje;
        private System.Windows.Forms.ToolStripStatusLabel sbpConexion;
        private System.Windows.Forms.ToolStripStatusLabel sbpUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sbpPercent;
        private System.Windows.Forms.ToolStripProgressBar sbpAvance;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.NotifyIcon niSysTray;
        private TNGS.NetControls.XPanel xpnlPanel1;
        private TNGS.NetControls.TSContainer tsContainer1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TextEdit textEdit1;
        private TNGS.NetControls.FullLabel fullLabel1;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.GlassButton gbVerItems;
        private TNGS.NetControls.GlassButton gbCerrarOT;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.TSPanel tsPpanel1;
        private TNGS.NetControls.GlassButton gbBuscar;
        private TNGS.NetControls.CDCombo cdcMoviles;
        private TNGS.NetControls.FullGrid fgGrillaOT;
        private TNGS.NetControls.XPanel xPanel1;
        private ControlesCustom.itemBarra itemBarra2;
        private ControlesCustom.itemBarra itemBarra1;
    }
}