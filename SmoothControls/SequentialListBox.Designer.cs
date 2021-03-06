﻿namespace WildMouse.SmoothControls
{
    partial class SequentialListBox
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
            this.ElementsPanel = new System.Windows.Forms.Panel();
            this.ListScroller = new WildMouse.SmoothControls.VerticalScrollBar();
            this.SuspendLayout();
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.BackColor = System.Drawing.Color.White;
            this.ElementsPanel.Location = new System.Drawing.Point(3, 3);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(121, 100);
            this.ElementsPanel.TabIndex = 1;
            // 
            // ListScroller
            // 
            this.ListScroller.LargeChange = 50;
            this.ListScroller.Location = new System.Drawing.Point(130, 3);
            this.ListScroller.Maximum = 100;
            this.ListScroller.Minimum = 0;
            this.ListScroller.Name = "ListScroller";
            this.ListScroller.Size = new System.Drawing.Size(17, 144);
            this.ListScroller.SmallChange = 1;
            this.ListScroller.TabIndex = 0;
            this.ListScroller.Value = 0;
            // 
            // SequentialListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.ListScroller);
            this.DoubleBuffered = true;
            this.Name = "SequentialListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private WildMouse.SmoothControls.VerticalScrollBar ListScroller;
        protected System.Windows.Forms.Panel ElementsPanel;

    }
}
