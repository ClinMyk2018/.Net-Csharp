namespace W1.T2.ClinardMykal
{
    partial class frmHello_World
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
            this.lblHello_World_Display = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHello_World_Display
            // 
            this.lblHello_World_Display.AutoSize = true;
            this.lblHello_World_Display.Location = new System.Drawing.Point(368, 201);
            this.lblHello_World_Display.Name = "lblHello_World_Display";
            this.lblHello_World_Display.Size = new System.Drawing.Size(35, 13);
            this.lblHello_World_Display.TabIndex = 0;
            this.lblHello_World_Display.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHello_World
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHello_World_Display);
            this.Name = "frmHello_World";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.frmHello_World_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello_World_Display;
        private System.Windows.Forms.Button button1;
    }
}

