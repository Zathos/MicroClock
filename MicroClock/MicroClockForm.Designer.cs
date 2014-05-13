namespace MicroClock
{
    partial class MicroClockForm
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
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colseToolStripMenuItem});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // colseToolStripMenuItem
            // 
            this.colseToolStripMenuItem.Name = "colseToolStripMenuItem";
            this.colseToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colseToolStripMenuItem.Text = "Close";
            this.colseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(12, 9);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(99, 17);
            this.CurrentTimeLabel.TabIndex = 1;
            this.CurrentTimeLabel.Text = "10:42:34 AM";
            // 
            // MicroClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(125, 34);
            this.Controls.Add(this.CurrentTimeLabel);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MicroClockForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MicroClockFormMouseClick);
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem colseToolStripMenuItem;
        private System.Windows.Forms.Label CurrentTimeLabel;
    }
}