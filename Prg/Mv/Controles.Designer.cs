#region Usings
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
#endregion

namespace Rivn.Mv
{
    public partial class Controles : DockContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private TNGS.NetControls.XPanel xpnlBase;
        private TNGS.NetControls.GlassButton cmdSalir;
        private TNGS.NetControls.ImgGroup frmOper;
        private TNGS.NetControls.GlassButton cmdNuevo;
        private TNGS.NetControls.GlassButton cmdBuscar;
        private TNGS.NetControls.ImgGroup frmEdicion;
        private System.Windows.Forms.Label lblCod;
        private TNGS.NetControls.TextEdit txtCod;
        private System.Windows.Forms.Label lblDes;
        private TNGS.NetControls.TextEdit txtDes;
        private System.Windows.Forms.Label lblCrit;
        private TNGS.NetControls.CDCombo cmbCrit;
        private TNGS.NetControls.GlassButton cmdGrabar;
        private TNGS.NetControls.GlassButton cmdCancelar;

        /// <summary>
        /// Liberamos los recursos utilizados
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
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
            this.xpnlBase = new TNGS.NetControls.XPanel();
            this.frmOper = new TNGS.NetControls.ImgGroup();
            this.cmdNuevo = new TNGS.NetControls.GlassButton();
            this.cmdBuscar = new TNGS.NetControls.GlassButton();
            this.cmdSalir = new TNGS.NetControls.GlassButton();
            this.frmEdicion = new TNGS.NetControls.ImgGroup();
            this.cmdCancelar = new TNGS.NetControls.GlassButton();
            this.cmdGrabar = new TNGS.NetControls.GlassButton();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new TNGS.NetControls.TextEdit();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtDes = new TNGS.NetControls.TextEdit();
            this.lblCrit = new System.Windows.Forms.Label();
            this.cmbCrit = new TNGS.NetControls.CDCombo();
            this.xpnlBase.SuspendLayout();
            this.frmOper.SuspendLayout();
            this.frmEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpnlBase
            // 
            this.xpnlBase.BackColor1 = System.Drawing.SystemColors.Control;
            this.xpnlBase.BackColor2 = System.Drawing.SystemColors.Control;
            this.xpnlBase.Controls.Add(this.frmOper);
            this.xpnlBase.Controls.Add(this.frmEdicion);
            this.xpnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpnlBase.Location = new System.Drawing.Point(0, 0);
            this.xpnlBase.Name = "xpnlBase";
            this.xpnlBase.Size = new System.Drawing.Size(746, 464);
            this.xpnlBase.TabIndex = 0;
            // 
            // frmOper
            // 
            this.frmOper.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frmOper.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmOper.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmOper.BorderColor = System.Drawing.Color.Black;
            this.frmOper.BorderThickness = 1F;
            this.frmOper.Controls.Add(this.cmdNuevo);
            this.frmOper.Controls.Add(this.cmdBuscar);
            this.frmOper.Controls.Add(this.cmdSalir);
            this.frmOper.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmOper.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmOper.GroupImage = null;
            this.frmOper.GroupTitle = " Operaciones ";
            this.frmOper.Location = new System.Drawing.Point(12, 12);
            this.frmOper.Name = "frmOper";
            this.frmOper.Padding = new System.Windows.Forms.Padding(20);
            this.frmOper.PaintGroupBox = false;
            this.frmOper.RoundCorners = 10;
            this.frmOper.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmOper.ShadowControl = false;
            this.frmOper.ShadowThickness = 3;
            this.frmOper.Size = new System.Drawing.Size(722, 71);
            this.frmOper.TabIndex = 21;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.FixedImage = TNGS.NetControls.FixedGlassButtons.New;
            this.cmdNuevo.Location = new System.Drawing.Point(14, 32);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(104, 26);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.FixedImage = TNGS.NetControls.FixedGlassButtons.Find;
            this.cmdBuscar.Location = new System.Drawing.Point(131, 32);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(104, 26);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.FixedImage = TNGS.NetControls.FixedGlassButtons.Quit;
            this.cmdSalir.Location = new System.Drawing.Point(609, 32);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(104, 26);
            this.cmdSalir.TabIndex = 5;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmEdicion
            // 
            this.frmEdicion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientColor = System.Drawing.SystemColors.Control;
            this.frmEdicion.BackgroundGradientMode = TNGS.NetControls.ImgGroup.GroupBoxGradientMode.ForwardDiagonal;
            this.frmEdicion.BorderColor = System.Drawing.Color.Black;
            this.frmEdicion.BorderThickness = 1F;
            this.frmEdicion.Controls.Add(this.cmdCancelar);
            this.frmEdicion.Controls.Add(this.cmdGrabar);
            this.frmEdicion.Controls.Add(this.lblCod);
            this.frmEdicion.Controls.Add(this.txtCod);
            this.frmEdicion.Controls.Add(this.lblDes);
            this.frmEdicion.Controls.Add(this.txtDes);
            this.frmEdicion.Controls.Add(this.lblCrit);
            this.frmEdicion.Controls.Add(this.cmbCrit);
            this.frmEdicion.CustomGroupBoxColor = System.Drawing.Color.White;
            this.frmEdicion.FontTitle = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmEdicion.GroupImage = null;
            this.frmEdicion.GroupTitle = " Control ";
            this.frmEdicion.Location = new System.Drawing.Point(12, 331);
            this.frmEdicion.Name = "frmEdicion";
            this.frmEdicion.Padding = new System.Windows.Forms.Padding(20);
            this.frmEdicion.PaintGroupBox = false;
            this.frmEdicion.RoundCorners = 10;
            this.frmEdicion.ShadowColor = System.Drawing.Color.DarkGray;
            this.frmEdicion.ShadowControl = false;
            this.frmEdicion.ShadowThickness = 3;
            this.frmEdicion.Size = new System.Drawing.Size(722, 121);
            this.frmEdicion.TabIndex = 21;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelar.FixedImage = TNGS.NetControls.FixedGlassButtons.Cancel;
            this.cmdCancelar.Location = new System.Drawing.Point(495, 83);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(104, 26);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGrabar.FixedImage = TNGS.NetControls.FixedGlassButtons.Save;
            this.cmdGrabar.Location = new System.Drawing.Point(603, 83);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(104, 26);
            this.cmdGrabar.TabIndex = 10;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // lblCod
            // 
            this.lblCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(11, 38);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(57, 22);
            this.lblCod.TabIndex = 106;
            this.lblCod.Text = "Codigo:";
            this.lblCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.SystemColors.Window;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.EmptyValid = false;
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(74, 38);
            this.txtCod.MaxLength = 4;
            this.txtCod.Name = "txtCod";
            this.txtCod.OnlyDigits = true;
            this.txtCod.Size = new System.Drawing.Size(134, 22);
            this.txtCod.TabIndex = 6;
            // 
            // lblDes
            // 
            this.lblDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(214, 38);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(91, 22);
            this.lblDes.TabIndex = 107;
            this.lblDes.Text = "Descripcion:";
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDes
            // 
            this.txtDes.BackColor = System.Drawing.SystemColors.Window;
            this.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDes.EmptyValid = false;
            this.txtDes.Enabled = false;
            this.txtDes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(311, 38);
            this.txtDes.MaxLength = 30;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(144, 22);
            this.txtDes.TabIndex = 7;
            // 
            // lblCrit
            // 
            this.lblCrit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrit.Location = new System.Drawing.Point(461, 38);
            this.lblCrit.Name = "lblCrit";
            this.lblCrit.Size = new System.Drawing.Size(63, 22);
            this.lblCrit.TabIndex = 108;
            this.lblCrit.Text = "Critico:";
            this.lblCrit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCrit
            // 
            this.cmbCrit.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrit.Enabled = false;
            this.cmbCrit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrit.Location = new System.Drawing.Point(530, 38);
            this.cmbCrit.Name = "cmbCrit";
            this.cmbCrit.Size = new System.Drawing.Size(154, 24);
            this.cmbCrit.Sorted = true;
            this.cmbCrit.TabIndex = 8;
            // 
            // Controles
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(746, 464);
            this.Controls.Add(this.xpnlBase);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Controles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimienro de Controles";
            this.Closed += new System.EventHandler(this.Controles_Closed);
            this.Load += new System.EventHandler(this.Controles_Load);
            this.xpnlBase.ResumeLayout(false);
            this.frmOper.ResumeLayout(false);
            this.frmEdicion.ResumeLayout(false);
            this.frmEdicion.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
