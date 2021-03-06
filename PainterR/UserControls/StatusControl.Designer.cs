﻿namespace Paint.UserControls
{
    partial class StatusControl
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolLabelCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelWidth = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelShapeType = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabelCoordinates,
            this.toolLabelColor,
            this.toolLabelWidth,
            this.toolLabelShapeType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(789, 27);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolLabelCoordinates
            // 
            this.toolLabelCoordinates.Name = "toolLabelCoordinates";
            this.toolLabelCoordinates.Size = new System.Drawing.Size(71, 22);
            this.toolLabelCoordinates.Text = "Coordinates";
            // 
            // toolLabelColor
            // 
            this.toolLabelColor.Name = "toolLabelColor";
            this.toolLabelColor.Size = new System.Drawing.Size(36, 22);
            this.toolLabelColor.Text = "Color";
            // 
            // toolLabelWidth
            // 
            this.toolLabelWidth.Name = "toolLabelWidth";
            this.toolLabelWidth.Size = new System.Drawing.Size(39, 22);
            this.toolLabelWidth.Text = "Width";
            // 
            // toolLabelShapeType
            // 
            this.toolLabelShapeType.Name = "toolLabelShapeType";
            this.toolLabelShapeType.Size = new System.Drawing.Size(68, 22);
            this.toolLabelShapeType.Text = "Shape Type";
            // 
            // StatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Name = "StatusControl";
            this.Size = new System.Drawing.Size(789, 27);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelColor;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelWidth;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelShapeType;
    }
}
