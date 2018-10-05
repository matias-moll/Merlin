namespace Mrln.Ot
{
    /*Datos para la grilla:
     * Fecha de generación, tipo, cantidad de solicitudes para el mismo cliente, codVend, codCli
     * */
    partial class VisorOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorOrdenes));
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.niSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.xpnlPanel1 = new TNGS.NetControls.XPanel();
            this.xpPanelOrdenes = new TNGS.NetControls.XPanel();
            this.itemBarra10 = new ControlesCustom.itemBarra();
            this.itemBarra9 = new ControlesCustom.itemBarra();
            this.itemBarra7 = new ControlesCustom.itemBarra();
            this.itemBarra6 = new ControlesCustom.itemBarra();
            this.itemBarra5 = new ControlesCustom.itemBarra();
            this.itemBarra4 = new ControlesCustom.itemBarra();
            this.itemBarra3 = new ControlesCustom.itemBarra();
            this.itemBarra2 = new ControlesCustom.itemBarra();
            this.itemBarra1 = new ControlesCustom.itemBarra();
            this.itemBarra8 = new ControlesCustom.itemBarra();
            this.fgGrillaItemsOT = new TNGS.NetControls.FullGrid();
            this.tsContainer1 = new TNGS.NetControls.TSContainer();
            this.tabStripPage1 = new RibbonStyle.TabStripPage();
            this.tsPanel1 = new TNGS.NetControls.TSPanel();
            this.gbRealizando = new TNGS.NetControls.GlassButton();
            this.gbImprimirSeleccionado = new TNGS.NetControls.GlassButton();
            this.gbEditarOT = new TNGS.NetControls.GlassButton();
            this.gbVerItems = new TNGS.NetControls.GlassButton();
            this.gbCerrarOT = new TNGS.NetControls.GlassButton();
            this.gbCancelar = new TNGS.NetControls.GlassButton();
            this.tsPanel2 = new TNGS.NetControls.TSPanel();
            this.gbImprimirTodos = new TNGS.NetControls.GlassButton();
            this.gbNuevaOrden = new TNGS.NetControls.GlassButton();
            this.tsPpanel1 = new TNGS.NetControls.TSPanel();
            this.gbFiltrar = new TNGS.NetControls.GlassButton();
            this.cdcMoviles = new TNGS.NetControls.CDCombo();
            this.tsBase1 = new TNGS.NetControls.TSBase();
            this.tab1 = new RibbonStyle.Tab();
            this.xpnlPanel1.SuspendLayout();
            this.xpPanelOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgGrillaItemsOT)).BeginInit();
            this.tsContainer1.SuspendLayout();
            this.tabStripPage1.SuspendLayout();
            this.tsPanel1.SuspendLayout();
            this.tsPanel2.SuspendLayout();
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
            // xpnlPanel1
            // 
            this.xpnlPanel1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpnlPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpnlPanel1.Controls.Add(this.xpPanelOrdenes);
            this.xpnlPanel1.Controls.Add(this.fgGrillaItemsOT);
            this.xpnlPanel1.Controls.Add(this.tsContainer1);
            this.xpnlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.xpnlPanel1.Name = "xpnlPanel1";
            this.xpnlPanel1.Size = new System.Drawing.Size(969, 648);
            this.xpnlPanel1.SkinFixed = true;
            this.xpnlPanel1.TabIndex = 14;
            // 
            // xpPanelOrdenes
            // 
            this.xpPanelOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xpPanelOrdenes.AutoScroll = true;
            this.xpPanelOrdenes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xpPanelOrdenes.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.xpPanelOrdenes.Controls.Add(this.itemBarra10);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra9);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra7);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra6);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra5);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra4);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra3);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra2);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra1);
            this.xpPanelOrdenes.Controls.Add(this.itemBarra8);
            this.xpPanelOrdenes.Location = new System.Drawing.Point(0, 116);
            this.xpPanelOrdenes.Name = "xpPanelOrdenes";
            this.xpPanelOrdenes.Size = new System.Drawing.Size(966, 302);
            this.xpPanelOrdenes.SkinFixed = true;
            this.xpPanelOrdenes.TabIndex = 3;
            this.xpPanelOrdenes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xpPanelOrdenes_MouseClick);
            // 
            // itemBarra10
            // 
            this.itemBarra10.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra10.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra10.Location = new System.Drawing.Point(810, 0);
            this.itemBarra10.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra10.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra10.Name = "itemBarra10";
            this.itemBarra10.Numero = 0;
            this.itemBarra10.Seleccionado = false;
            this.itemBarra10.Size = new System.Drawing.Size(130, 120);
            this.itemBarra10.TabIndex = 16;
            this.itemBarra10.Taller = "Descripcion testeando cantidad";
            this.itemBarra10.Titulo = "Orden de Trabajo";
            // 
            // itemBarra9
            // 
            this.itemBarra9.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra9.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra9.Location = new System.Drawing.Point(138, 135);
            this.itemBarra9.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra9.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra9.Name = "itemBarra9";
            this.itemBarra9.Numero = 0;
            this.itemBarra9.Seleccionado = false;
            this.itemBarra9.Size = new System.Drawing.Size(130, 120);
            this.itemBarra9.TabIndex = 15;
            this.itemBarra9.Taller = "Descripcion testeando cantidad";
            this.itemBarra9.Titulo = "Orden de Trabajo";
            // 
            // itemBarra7
            // 
            this.itemBarra7.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra7.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra7.Location = new System.Drawing.Point(0, 135);
            this.itemBarra7.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra7.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra7.Name = "itemBarra7";
            this.itemBarra7.Numero = 0;
            this.itemBarra7.Seleccionado = false;
            this.itemBarra7.Size = new System.Drawing.Size(130, 120);
            this.itemBarra7.TabIndex = 14;
            this.itemBarra7.Taller = "Descripcion testeando cantidad";
            this.itemBarra7.Titulo = "Orden de Trabajo";
            // 
            // itemBarra6
            // 
            this.itemBarra6.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra6.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra6.Location = new System.Drawing.Point(3, 270);
            this.itemBarra6.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra6.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra6.Name = "itemBarra6";
            this.itemBarra6.Numero = 0;
            this.itemBarra6.Seleccionado = false;
            this.itemBarra6.Size = new System.Drawing.Size(130, 120);
            this.itemBarra6.TabIndex = 13;
            this.itemBarra6.Taller = "Descripcion testeando cantidad";
            this.itemBarra6.Titulo = "Orden de Trabajo";
            // 
            // itemBarra5
            // 
            this.itemBarra5.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra5.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra5.Location = new System.Drawing.Point(675, 0);
            this.itemBarra5.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra5.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra5.Name = "itemBarra5";
            this.itemBarra5.Numero = 0;
            this.itemBarra5.Seleccionado = false;
            this.itemBarra5.Size = new System.Drawing.Size(130, 120);
            this.itemBarra5.TabIndex = 12;
            this.itemBarra5.Taller = "Descripcion testeando cantidad";
            this.itemBarra5.Titulo = "Orden de Trabajo";
            // 
            // itemBarra4
            // 
            this.itemBarra4.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra4.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra4.Location = new System.Drawing.Point(540, 0);
            this.itemBarra4.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra4.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra4.Name = "itemBarra4";
            this.itemBarra4.Numero = 0;
            this.itemBarra4.Seleccionado = false;
            this.itemBarra4.Size = new System.Drawing.Size(130, 120);
            this.itemBarra4.TabIndex = 11;
            this.itemBarra4.Taller = "Descripcion testeando cantidad";
            this.itemBarra4.Titulo = "Orden de Trabajo";
            // 
            // itemBarra3
            // 
            this.itemBarra3.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra3.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra3.Location = new System.Drawing.Point(405, 0);
            this.itemBarra3.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra3.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra3.Name = "itemBarra3";
            this.itemBarra3.Numero = 0;
            this.itemBarra3.Seleccionado = false;
            this.itemBarra3.Size = new System.Drawing.Size(130, 120);
            this.itemBarra3.TabIndex = 10;
            this.itemBarra3.Taller = "Descripcion testeando cantidad";
            this.itemBarra3.Titulo = "Orden de Trabajo";
            // 
            // itemBarra2
            // 
            this.itemBarra2.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra2.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra2.Location = new System.Drawing.Point(270, 0);
            this.itemBarra2.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra2.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra2.Name = "itemBarra2";
            this.itemBarra2.Numero = 0;
            this.itemBarra2.Seleccionado = false;
            this.itemBarra2.Size = new System.Drawing.Size(130, 120);
            this.itemBarra2.TabIndex = 9;
            this.itemBarra2.Taller = "Descripcion testeando cantidad";
            this.itemBarra2.Titulo = "Orden de Trabajo";
            // 
            // itemBarra1
            // 
            this.itemBarra1.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra1.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra1.Location = new System.Drawing.Point(135, 0);
            this.itemBarra1.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra1.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra1.Name = "itemBarra1";
            this.itemBarra1.Numero = 0;
            this.itemBarra1.Seleccionado = false;
            this.itemBarra1.Size = new System.Drawing.Size(130, 120);
            this.itemBarra1.TabIndex = 8;
            this.itemBarra1.Taller = "Descripcion testeando cantidad";
            this.itemBarra1.Titulo = "Orden de Trabajo";
            // 
            // itemBarra8
            // 
            this.itemBarra8.CambiarEstado = ControlesCustom.itemBarra.Estados.Verde;
            this.itemBarra8.Fecha = new System.DateTime(1993, 1, 29, 0, 0, 0, 0);
            this.itemBarra8.Location = new System.Drawing.Point(0, 0);
            this.itemBarra8.MaximumSize = new System.Drawing.Size(160, 120);
            this.itemBarra8.MinimumSize = new System.Drawing.Size(120, 90);
            this.itemBarra8.Name = "itemBarra8";
            this.itemBarra8.Numero = 0;
            this.itemBarra8.Seleccionado = false;
            this.itemBarra8.Size = new System.Drawing.Size(130, 120);
            this.itemBarra8.TabIndex = 7;
            this.itemBarra8.Taller = "Descripcion testeando cantidad";
            this.itemBarra8.Titulo = "Orden de Trabajo";
            // 
            // fgGrillaItemsOT
            // 
            this.fgGrillaItemsOT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgGrillaItemsOT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.fgGrillaItemsOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fgGrillaItemsOT.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.fgGrillaItemsOT.CaptionFilterColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(119)))), ((int)(((byte)(7)))));
            this.fgGrillaItemsOT.CaptionVisible = false;
            this.fgGrillaItemsOT.DataMember = "";
            this.fgGrillaItemsOT.ExcelTitle = "";
            this.fgGrillaItemsOT.GridOrder = "";
            this.fgGrillaItemsOT.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.fgGrillaItemsOT.Location = new System.Drawing.Point(12, 435);
            this.fgGrillaItemsOT.Margin = new System.Windows.Forms.Padding(10);
            this.fgGrillaItemsOT.Name = "fgGrillaItemsOT";
            this.fgGrillaItemsOT.Padding = new System.Windows.Forms.Padding(10);
            this.fgGrillaItemsOT.Size = new System.Drawing.Size(945, 203);
            this.fgGrillaItemsOT.SkinFixed = true;
            this.fgGrillaItemsOT.TabIndex = 2;
            // 
            // tsContainer1
            // 
            this.tsContainer1.Controls.Add(this.tabStripPage1);
            this.tsContainer1.Controls.Add(this.tsBase1);
            this.tsContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tsContainer1.Location = new System.Drawing.Point(0, 0);
            this.tsContainer1.Name = "tsContainer1";
            this.tsContainer1.Size = new System.Drawing.Size(969, 115);
            this.tsContainer1.TabIndex = 0;
            // 
            // tabStripPage1
            // 
            this.tabStripPage1.Caption = "";
            this.tabStripPage1.Controls.Add(this.tsPanel1);
            this.tabStripPage1.Controls.Add(this.tsPanel2);
            this.tabStripPage1.Controls.Add(this.tsPpanel1);
            this.tabStripPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStripPage1.Location = new System.Drawing.Point(0, 26);
            this.tabStripPage1.Name = "tabStripPage1";
            this.tabStripPage1.Opacity = 255;
            this.tabStripPage1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabStripPage1.Size = new System.Drawing.Size(969, 89);
            this.tabStripPage1.Speed = 8;
            this.tabStripPage1.TabIndex = 2;
            // 
            // tsPanel1
            // 
            this.tsPanel1.Caption = "Orden De Trabajo Seleccionada";
            this.tsPanel1.Controls.Add(this.gbRealizando);
            this.tsPanel1.Controls.Add(this.gbImprimirSeleccionado);
            this.tsPanel1.Controls.Add(this.gbEditarOT);
            this.tsPanel1.Controls.Add(this.gbVerItems);
            this.tsPanel1.Controls.Add(this.gbCerrarOT);
            this.tsPanel1.Controls.Add(this.gbCancelar);
            this.tsPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel1.Location = new System.Drawing.Point(502, 3);
            this.tsPanel1.Name = "tsPanel1";
            this.tsPanel1.Opacity = 255;
            this.tsPanel1.Size = new System.Drawing.Size(464, 85);
            this.tsPanel1.Speed = 1;
            this.tsPanel1.TabIndex = 1;
            // 
            // gbRealizando
            // 
            this.gbRealizando.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRealizando.BackgroundImage")));
            this.gbRealizando.BlackBorder = true;
            this.gbRealizando.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbRealizando.CircleButton = false;
            this.gbRealizando.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Car;
            this.gbRealizando.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbRealizando.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbRealizando.FlatFontSize = 9;
            this.gbRealizando.FlatTextColor = System.Drawing.Color.Black;
            this.gbRealizando.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbRealizando.Location = new System.Drawing.Point(193, 7);
            this.gbRealizando.Name = "gbRealizando";
            this.gbRealizando.RoundCorners = 2;
            this.gbRealizando.Size = new System.Drawing.Size(110, 53);
            this.gbRealizando.TabIndex = 7;
            this.gbRealizando.Text = "Realizando Orden";
            this.gbRealizando.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbRealizando.Click += new System.EventHandler(this.gbRealizando_Click);
            // 
            // gbImprimirSeleccionado
            // 
            this.gbImprimirSeleccionado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbImprimirSeleccionado.BackgroundImage")));
            this.gbImprimirSeleccionado.BlackBorder = true;
            this.gbImprimirSeleccionado.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbImprimirSeleccionado.CircleButton = false;
            this.gbImprimirSeleccionado.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Print;
            this.gbImprimirSeleccionado.FlatColor = System.Drawing.Color.Gray;
            this.gbImprimirSeleccionado.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Imprimir;
            this.gbImprimirSeleccionado.FlatFontSize = 9;
            this.gbImprimirSeleccionado.FlatTextColor = System.Drawing.Color.Black;
            this.gbImprimirSeleccionado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbImprimirSeleccionado.Location = new System.Drawing.Point(427, 35);
            this.gbImprimirSeleccionado.Name = "gbImprimirSeleccionado";
            this.gbImprimirSeleccionado.RoundCorners = 2;
            this.gbImprimirSeleccionado.Size = new System.Drawing.Size(28, 28);
            this.gbImprimirSeleccionado.TabIndex = 6;
            this.gbImprimirSeleccionado.Text = "Imprimir";
            this.gbImprimirSeleccionado.W8Color = System.Drawing.Color.Gray;
            this.gbImprimirSeleccionado.Click += new System.EventHandler(this.gbImprimirSeleccionado_Click);
            // 
            // gbEditarOT
            // 
            this.gbEditarOT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbEditarOT.BackgroundImage")));
            this.gbEditarOT.BlackBorder = true;
            this.gbEditarOT.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbEditarOT.CircleButton = false;
            this.gbEditarOT.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Edit;
            this.gbEditarOT.FlatColor = System.Drawing.Color.Gold;
            this.gbEditarOT.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Yellow;
            this.gbEditarOT.FlatFontSize = 9;
            this.gbEditarOT.FlatTextColor = System.Drawing.Color.Black;
            this.gbEditarOT.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbEditarOT.Location = new System.Drawing.Point(393, 4);
            this.gbEditarOT.Name = "gbEditarOT";
            this.gbEditarOT.RoundCorners = 2;
            this.gbEditarOT.Size = new System.Drawing.Size(28, 28);
            this.gbEditarOT.TabIndex = 3;
            this.gbEditarOT.Text = "Editar";
            this.gbEditarOT.W8Color = System.Drawing.Color.Gold;
            this.gbEditarOT.Click += new System.EventHandler(this.gbEditarOT_Click);
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
            this.gbVerItems.Location = new System.Drawing.Point(6, 7);
            this.gbVerItems.Name = "gbVerItems";
            this.gbVerItems.RoundCorners = 2;
            this.gbVerItems.Size = new System.Drawing.Size(94, 52);
            this.gbVerItems.TabIndex = 2;
            this.gbVerItems.Text = "Ver Items ";
            this.gbVerItems.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbVerItems.Click += new System.EventHandler(this.gbVerItems_Click);
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
            this.gbCerrarOT.Location = new System.Drawing.Point(106, 7);
            this.gbCerrarOT.Name = "gbCerrarOT";
            this.gbCerrarOT.RoundCorners = 2;
            this.gbCerrarOT.Size = new System.Drawing.Size(81, 53);
            this.gbCerrarOT.TabIndex = 1;
            this.gbCerrarOT.Text = "Cerrar";
            this.gbCerrarOT.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbCerrarOT.Click += new System.EventHandler(this.gbCerrarOT_Click);
            // 
            // gbCancelar
            // 
            this.gbCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbCancelar.BackgroundImage")));
            this.gbCancelar.BlackBorder = true;
            this.gbCancelar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbCancelar.CircleButton = false;
            this.gbCancelar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Delete;
            this.gbCancelar.FlatColor = System.Drawing.Color.Red;
            this.gbCancelar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.Cancelar;
            this.gbCancelar.FlatFontSize = 9;
            this.gbCancelar.FlatTextColor = System.Drawing.Color.Black;
            this.gbCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbCancelar.Location = new System.Drawing.Point(427, 4);
            this.gbCancelar.Name = "gbCancelar";
            this.gbCancelar.RoundCorners = 2;
            this.gbCancelar.Size = new System.Drawing.Size(28, 28);
            this.gbCancelar.TabIndex = 0;
            this.gbCancelar.Text = "Eliminar";
            this.gbCancelar.W8Color = System.Drawing.Color.Red;
            this.gbCancelar.Click += new System.EventHandler(this.gbCancelar_Click);
            // 
            // tsPanel2
            // 
            this.tsPanel2.Caption = "Operación";
            this.tsPanel2.Controls.Add(this.gbImprimirTodos);
            this.tsPanel2.Controls.Add(this.gbNuevaOrden);
            this.tsPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPanel2.Location = new System.Drawing.Point(287, 3);
            this.tsPanel2.Name = "tsPanel2";
            this.tsPanel2.Opacity = 255;
            this.tsPanel2.Size = new System.Drawing.Size(215, 85);
            this.tsPanel2.Speed = 1;
            this.tsPanel2.TabIndex = 2;
            // 
            // gbImprimirTodos
            // 
            this.gbImprimirTodos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbImprimirTodos.BackgroundImage")));
            this.gbImprimirTodos.BlackBorder = true;
            this.gbImprimirTodos.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbImprimirTodos.CircleButton = false;
            this.gbImprimirTodos.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Print2;
            this.gbImprimirTodos.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbImprimirTodos.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbImprimirTodos.FlatFontSize = 9;
            this.gbImprimirTodos.FlatTextColor = System.Drawing.Color.Black;
            this.gbImprimirTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbImprimirTodos.Location = new System.Drawing.Point(105, 6);
            this.gbImprimirTodos.Name = "gbImprimirTodos";
            this.gbImprimirTodos.RoundCorners = 2;
            this.gbImprimirTodos.Size = new System.Drawing.Size(97, 51);
            this.gbImprimirTodos.TabIndex = 5;
            this.gbImprimirTodos.Text = "Imprimir Todas";
            this.gbImprimirTodos.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbImprimirTodos.Click += new System.EventHandler(this.gbImprimirTodos_Click);
            // 
            // gbNuevaOrden
            // 
            this.gbNuevaOrden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbNuevaOrden.BackgroundImage")));
            this.gbNuevaOrden.BlackBorder = true;
            this.gbNuevaOrden.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbNuevaOrden.CircleButton = false;
            this.gbNuevaOrden.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Add;
            this.gbNuevaOrden.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbNuevaOrden.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbNuevaOrden.FlatFontSize = 9;
            this.gbNuevaOrden.FlatTextColor = System.Drawing.Color.Black;
            this.gbNuevaOrden.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbNuevaOrden.Location = new System.Drawing.Point(9, 7);
            this.gbNuevaOrden.Name = "gbNuevaOrden";
            this.gbNuevaOrden.RoundCorners = 2;
            this.gbNuevaOrden.Size = new System.Drawing.Size(89, 51);
            this.gbNuevaOrden.TabIndex = 4;
            this.gbNuevaOrden.Text = "Nueva";
            this.gbNuevaOrden.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbNuevaOrden.Click += new System.EventHandler(this.gbNuevaOrden_Click);
            // 
            // tsPpanel1
            // 
            this.tsPpanel1.Caption = "Seleccion Movil";
            this.tsPpanel1.Controls.Add(this.gbFiltrar);
            this.tsPpanel1.Controls.Add(this.cdcMoviles);
            this.tsPpanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPpanel1.Location = new System.Drawing.Point(0, 3);
            this.tsPpanel1.Name = "tsPpanel1";
            this.tsPpanel1.Opacity = 255;
            this.tsPpanel1.Size = new System.Drawing.Size(287, 85);
            this.tsPpanel1.Speed = 1;
            this.tsPpanel1.TabIndex = 0;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbFiltrar.BackgroundImage")));
            this.gbFiltrar.BlackBorder = true;
            this.gbFiltrar.ButtonMode = TNGS.NetControls.GlassButton.GBMode.Flat;
            this.gbFiltrar.CircleButton = false;
            this.gbFiltrar.FixedFlatImage = TNGS.NetControls.FixedFlatImageButtons.Search;
            this.gbFiltrar.FlatColor = System.Drawing.Color.RoyalBlue;
            this.gbFiltrar.FlatDefaultColor = TNGS.NetControls.ColorRuts.ColoresDefault.None;
            this.gbFiltrar.FlatFontSize = 9;
            this.gbFiltrar.FlatTextColor = System.Drawing.Color.Black;
            this.gbFiltrar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbFiltrar.Location = new System.Drawing.Point(202, 7);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.RoundCorners = 2;
            this.gbFiltrar.Size = new System.Drawing.Size(73, 53);
            this.gbFiltrar.TabIndex = 1;
            this.gbFiltrar.Text = "Filtrar";
            this.gbFiltrar.W8Color = System.Drawing.Color.RoyalBlue;
            this.gbFiltrar.Click += new System.EventHandler(this.gbFiltrar_Click);
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
            this.tsBase1.Size = new System.Drawing.Size(969, 26);
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
            this.tab1.Size = new System.Drawing.Size(139, 23);
            this.tab1.TabStripPage = null;
            this.tab1.Text = "Ordenes De Trabajo";
            // 
            // VisorOrdenes
            // 
            this.AllowEndUserDocking = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 648);
            this.Controls.Add(this.xpnlPanel1);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisorOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Visor de OTs";
            this.Text = "Visor Ordenes de Trabajo";
            this.Load += new System.EventHandler(this.VisorOrdenes_Load);
            this.xpnlPanel1.ResumeLayout(false);
            this.xpPanelOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgGrillaItemsOT)).EndInit();
            this.tsContainer1.ResumeLayout(false);
            this.tabStripPage1.ResumeLayout(false);
            this.tsPanel1.ResumeLayout(false);
            this.tsPanel2.ResumeLayout(false);
            this.tsPpanel1.ResumeLayout(false);
            this.tsBase1.ResumeLayout(false);
            this.tsBase1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.NotifyIcon niSysTray;
        private TNGS.NetControls.XPanel xpnlPanel1;
        private TNGS.NetControls.TSContainer tsContainer1;
        private TNGS.NetControls.TSBase tsBase1;
        private RibbonStyle.Tab tab1;
        private RibbonStyle.TabStripPage tabStripPage1;
        private TNGS.NetControls.TSPanel tsPanel2;
        private TNGS.NetControls.TSPanel tsPanel1;
        private TNGS.NetControls.GlassButton gbVerItems;
        private TNGS.NetControls.GlassButton gbCerrarOT;
        private TNGS.NetControls.GlassButton gbCancelar;
        private TNGS.NetControls.TSPanel tsPpanel1;
        private TNGS.NetControls.GlassButton gbFiltrar;
        private TNGS.NetControls.CDCombo cdcMoviles;
        private TNGS.NetControls.FullGrid fgGrillaItemsOT;
        private TNGS.NetControls.XPanel xpPanelOrdenes;
        private TNGS.NetControls.GlassButton gbEditarOT;
        private TNGS.NetControls.GlassButton gbNuevaOrden;
        private ControlesCustom.itemBarra itemBarra8;
        private ControlesCustom.itemBarra itemBarra10;
        private ControlesCustom.itemBarra itemBarra9;
        private ControlesCustom.itemBarra itemBarra7;
        private ControlesCustom.itemBarra itemBarra6;
        private ControlesCustom.itemBarra itemBarra5;
        private ControlesCustom.itemBarra itemBarra4;
        private ControlesCustom.itemBarra itemBarra3;
        private ControlesCustom.itemBarra itemBarra2;
        private ControlesCustom.itemBarra itemBarra1;
        private TNGS.NetControls.GlassButton gbImprimirTodos;
        private TNGS.NetControls.GlassButton gbImprimirSeleccionado;
        private TNGS.NetControls.GlassButton gbRealizando;
    }
}