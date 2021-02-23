
namespace William01.VISTA
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLICKPARAMASIMFORMACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mATETICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.mATETICASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLICKPARAMASIMFORMACIONToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // cLICKPARAMASIMFORMACIONToolStripMenuItem
            // 
            this.cLICKPARAMASIMFORMACIONToolStripMenuItem.Name = "cLICKPARAMASIMFORMACIONToolStripMenuItem";
            this.cLICKPARAMASIMFORMACIONToolStripMenuItem.Size = new System.Drawing.Size(311, 26);
            this.cLICKPARAMASIMFORMACIONToolStripMenuItem.Text = "CLICK PARA MAS IMFORMACION";
            this.cLICKPARAMASIMFORMACIONToolStripMenuItem.Click += new System.EventHandler(this.cLICKPARAMASIMFORMACIONToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // mATETICASToolStripMenuItem
            // 
            this.mATETICASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumasToolStripMenuItem,
            this.restasToolStripMenuItem});
            this.mATETICASToolStripMenuItem.Name = "mATETICASToolStripMenuItem";
            this.mATETICASToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.mATETICASToolStripMenuItem.Text = "MATETICAS";
            // 
            // sumasToolStripMenuItem
            // 
            this.sumasToolStripMenuItem.Name = "sumasToolStripMenuItem";
            this.sumasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sumasToolStripMenuItem.Text = "Suma";
            this.sumasToolStripMenuItem.Click += new System.EventHandler(this.sumasToolStripMenuItem_Click);
            // 
            // restasToolStripMenuItem
            // 
            this.restasToolStripMenuItem.Name = "restasToolStripMenuItem";
            this.restasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restasToolStripMenuItem.Text = "Resta";
            this.restasToolStripMenuItem.Click += new System.EventHandler(this.restasToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 736);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLICKPARAMASIMFORMACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mATETICASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restasToolStripMenuItem;
    }
}