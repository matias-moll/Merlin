namespace Mrln.Mv
{
    partial class Home
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ftContainer = new TNGS.NetControls.FullTab();
            this.tpMoviles = new System.Windows.Forms.TabPage();
            this.movilesForm1 = new Mrln.Mv.MovilesForm();
            this.tpAlertas = new System.Windows.Forms.TabPage();
            this.alertasForm1 = new Mrln.Mv.AlertasForm();
            this.topPanel.SuspendLayout();
            this.ftContainer.SuspendLayout();
            this.tpMoviles.SuspendLayout();
            this.tpAlertas.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkRed;
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1024, 40);
            this.topPanel.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(924, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Solución Merlín";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(966, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.topPanel;
            this.dragControl.Vertical = true;
            // 
            // ftContainer
            // 
            this.ftContainer.Controls.Add(this.tpMoviles);
            this.ftContainer.Controls.Add(this.tpAlertas);
            this.ftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftContainer.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ftContainer.FlatColor = System.Drawing.Color.Firebrick;
            this.ftContainer.FlatMode = true;
            this.ftContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftContainer.ForeColor = System.Drawing.Color.Black;
            this.ftContainer.Location = new System.Drawing.Point(0, 40);
            this.ftContainer.Name = "ftContainer";
            this.ftContainer.SelectedIndex = 0;
            this.ftContainer.Size = new System.Drawing.Size(1024, 653);
            this.ftContainer.SkinFixed = true;
            this.ftContainer.TabIndex = 2;
            // 
            // tpMoviles
            // 
            this.tpMoviles.Controls.Add(this.movilesForm1);
            this.tpMoviles.Location = new System.Drawing.Point(4, 25);
            this.tpMoviles.Name = "tpMoviles";
            this.tpMoviles.Padding = new System.Windows.Forms.Padding(3);
            this.tpMoviles.Size = new System.Drawing.Size(1016, 624);
            this.tpMoviles.TabIndex = 0;
            this.tpMoviles.Text = "Móviles";
            this.tpMoviles.UseVisualStyleBackColor = true;
            // 
            // movilesForm1
            // 
            this.movilesForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movilesForm1.Location = new System.Drawing.Point(3, 3);
            this.movilesForm1.Name = "movilesForm1";
            this.movilesForm1.Size = new System.Drawing.Size(1010, 618);
            this.movilesForm1.TabIndex = 0;
            // 
            // tpAlertas
            // 
            this.tpAlertas.Controls.Add(this.alertasForm1);
            this.tpAlertas.Location = new System.Drawing.Point(4, 25);
            this.tpAlertas.Name = "tpAlertas";
            this.tpAlertas.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlertas.Size = new System.Drawing.Size(1016, 624);
            this.tpAlertas.TabIndex = 1;
            this.tpAlertas.Text = "Alertas";
            this.tpAlertas.UseVisualStyleBackColor = true;
            // 
            // alertasForm1
            // 
            this.alertasForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertasForm1.Location = new System.Drawing.Point(3, 3);
            this.alertasForm1.Name = "alertasForm1";
            this.alertasForm1.Size = new System.Drawing.Size(1010, 618);
            this.alertasForm1.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 693);
            this.Controls.Add(this.ftContainer);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.Load += new System.EventHandler(this.Home_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ftContainer.ResumeLayout(false);
            this.tpMoviles.ResumeLayout(false);
            this.tpAlertas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private TNGS.NetControls.FullTab ftContainer;
        private System.Windows.Forms.TabPage tpMoviles;
        private System.Windows.Forms.TabPage tpAlertas;
        private System.Windows.Forms.Button btnMinimize;
        private MovilesForm movilesForm1;
        private AlertasForm alertasForm1;
    }
}