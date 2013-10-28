namespace Rivn.Mv
{
    partial class EjemploUsoTreeView
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
            this.ftrEjemplo = new TNGS.NetControls.FullTreeView();
            this.SuspendLayout();
            // 
            // ftrEjemplo
            // 
            this.ftrEjemplo.IgnoreLevelInFill = false;
            this.ftrEjemplo.Location = new System.Drawing.Point(68, 35);
            this.ftrEjemplo.Name = "ftrEjemplo";
            this.ftrEjemplo.Size = new System.Drawing.Size(158, 211);
            this.ftrEjemplo.TabIndex = 0;
            this.ftrEjemplo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ftrEjemplo_AfterSelect);
            // 
            // EjemploUsoTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 294);
            this.Controls.Add(this.ftrEjemplo);
            this.Name = "EjemploUsoTreeView";
            this.Text = "EjemploUsoTreeView";
            this.Load += new System.EventHandler(this.EjemploUsoTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TNGS.NetControls.FullTreeView ftrEjemplo;
    }
}