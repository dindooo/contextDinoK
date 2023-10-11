namespace contextMenuStripDino
{
    partial class Form1
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
            this.txtBoxL = new System.Windows.Forms.TextBox();
            this.txtBoxD = new System.Windows.Forms.TextBox();
            this.conMenStrKontrole = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenStrKontrole.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxL
            // 
            this.txtBoxL.ContextMenuStrip = this.conMenStrKontrole;
            this.txtBoxL.Location = new System.Drawing.Point(163, 155);
            this.txtBoxL.Name = "txtBoxL";
            this.txtBoxL.Size = new System.Drawing.Size(100, 20);
            this.txtBoxL.TabIndex = 0;
            // 
            // txtBoxD
            // 
            this.txtBoxD.ContextMenuStrip = this.conMenStrKontrole;
            this.txtBoxD.Location = new System.Drawing.Point(498, 155);
            this.txtBoxD.Name = "txtBoxD";
            this.txtBoxD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxD.TabIndex = 1;
            // 
            // conMenStrKontrole
            // 
            this.conMenStrKontrole.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.conMenStrKontrole.Name = "conMenStrKontrole";
            this.conMenStrKontrole.Size = new System.Drawing.Size(201, 48);
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na desno Ctrl + D";
            // 
            // desnoNaLijevoToolStripMenuItem
            // 
            this.desnoNaLijevoToolStripMenuItem.Name = "desnoNaLijevoToolStripMenuItem";
            this.desnoNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.desnoNaLijevoToolStripMenuItem.Text = "Desno na Lijevo Ctrl + L";
            this.desnoNaLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxD);
            this.Controls.Add(this.txtBoxL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.conMenStrKontrole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxL;
        private System.Windows.Forms.TextBox txtBoxD;
        private System.Windows.Forms.ContextMenuStrip conMenStrKontrole;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
    }
}

