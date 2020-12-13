namespace ProjectAhmadMalakh
{
    partial class SelectArea
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
            this.panelDrag = new System.Windows.Forms.Panel();
            this.btnCaptureThis = new MaterialSkin.Controls.MaterialButton();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.AutoScroll = true;
            this.panelDrag.Controls.Add(this.btnCaptureThis);
            this.panelDrag.Location = new System.Drawing.Point(12, 46);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(776, 392);
            this.panelDrag.TabIndex = 0;
            this.panelDrag.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            // 
            // btnCaptureThis
            // 
            this.btnCaptureThis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCaptureThis.Depth = 0;
            this.btnCaptureThis.DrawShadows = true;
            this.btnCaptureThis.HighEmphasis = true;
            this.btnCaptureThis.Icon = null;
            this.btnCaptureThis.Location = new System.Drawing.Point(1, 0);
            this.btnCaptureThis.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCaptureThis.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCaptureThis.Name = "btnCaptureThis";
            this.btnCaptureThis.Size = new System.Drawing.Size(147, 36);
            this.btnCaptureThis.TabIndex = 1;
            this.btnCaptureThis.Text = "btnCaptureThis";
            this.btnCaptureThis.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCaptureThis.UseAccentColor = false;
            this.btnCaptureThis.UseVisualStyleBackColor = true;
            this.btnCaptureThis.Click += new System.EventHandler(this.btnCaptureThis_Click);
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDrag);
            this.Name = "SelectArea";
            this.Text = "SelectArea";
            this.Load += new System.EventHandler(this.SelectArea_Load);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrag;
        private MaterialSkin.Controls.MaterialButton btnCaptureThis;
    }
}