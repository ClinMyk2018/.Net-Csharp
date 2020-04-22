namespace W6.T1.ClinardMykal
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.butLine = new System.Windows.Forms.Button();
            this.butEllipse = new System.Windows.Forms.Button();
            this.butRectangle = new System.Windows.Forms.Button();
            this.butArc = new System.Windows.Forms.Button();
            this.butPie = new System.Windows.Forms.Button();
            this.butPolygon = new System.Windows.Forms.Button();
            this.butBezier = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(7, 7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(570, 300);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // butLine
            // 
            this.butLine.Location = new System.Drawing.Point(7, 330);
            this.butLine.Name = "butLine";
            this.butLine.Size = new System.Drawing.Size(56, 23);
            this.butLine.TabIndex = 1;
            this.butLine.Text = "Line";
            this.butLine.UseVisualStyleBackColor = true;
            this.butLine.Click += new System.EventHandler(this.butLine_Click);
            // 
            // butEllipse
            // 
            this.butEllipse.Location = new System.Drawing.Point(79, 330);
            this.butEllipse.Name = "butEllipse";
            this.butEllipse.Size = new System.Drawing.Size(56, 23);
            this.butEllipse.TabIndex = 2;
            this.butEllipse.Text = "Ellipse";
            this.butEllipse.UseVisualStyleBackColor = true;
            this.butEllipse.Click += new System.EventHandler(this.butEllipse_Click);
            // 
            // butRectangle
            // 
            this.butRectangle.Location = new System.Drawing.Point(151, 330);
            this.butRectangle.Name = "butRectangle";
            this.butRectangle.Size = new System.Drawing.Size(66, 23);
            this.butRectangle.TabIndex = 3;
            this.butRectangle.Text = "Rectangle";
            this.butRectangle.UseVisualStyleBackColor = true;
            this.butRectangle.Click += new System.EventHandler(this.butRectangle_Click);
            // 
            // butArc
            // 
            this.butArc.Location = new System.Drawing.Point(233, 330);
            this.butArc.Name = "butArc";
            this.butArc.Size = new System.Drawing.Size(56, 23);
            this.butArc.TabIndex = 4;
            this.butArc.Text = "Arc";
            this.butArc.UseVisualStyleBackColor = true;
            this.butArc.Click += new System.EventHandler(this.butArc_Click);
            // 
            // butPie
            // 
            this.butPie.Location = new System.Drawing.Point(306, 330);
            this.butPie.Name = "butPie";
            this.butPie.Size = new System.Drawing.Size(56, 23);
            this.butPie.TabIndex = 5;
            this.butPie.Text = "Pie";
            this.butPie.UseVisualStyleBackColor = true;
            this.butPie.Click += new System.EventHandler(this.butPie_Click);
            // 
            // butPolygon
            // 
            this.butPolygon.Location = new System.Drawing.Point(378, 330);
            this.butPolygon.Name = "butPolygon";
            this.butPolygon.Size = new System.Drawing.Size(56, 23);
            this.butPolygon.TabIndex = 6;
            this.butPolygon.Text = "Polygon";
            this.butPolygon.UseVisualStyleBackColor = true;
            this.butPolygon.Click += new System.EventHandler(this.butPolygon_Click);
            // 
            // butBezier
            // 
            this.butBezier.Location = new System.Drawing.Point(450, 330);
            this.butBezier.Name = "butBezier";
            this.butBezier.Size = new System.Drawing.Size(56, 23);
            this.butBezier.TabIndex = 7;
            this.butBezier.Text = "Bezier";
            this.butBezier.UseVisualStyleBackColor = true;
            this.butBezier.Click += new System.EventHandler(this.butBezier_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(521, 330);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(56, 23);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butBezier);
            this.Controls.Add(this.butPolygon);
            this.Controls.Add(this.butPie);
            this.Controls.Add(this.butArc);
            this.Controls.Add(this.butRectangle);
            this.Controls.Add(this.butEllipse);
            this.Controls.Add(this.butLine);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button butLine;
        private System.Windows.Forms.Button butEllipse;
        private System.Windows.Forms.Button butRectangle;
        private System.Windows.Forms.Button butArc;
        private System.Windows.Forms.Button butPie;
        private System.Windows.Forms.Button butPolygon;
        private System.Windows.Forms.Button butBezier;
        private System.Windows.Forms.Button butClear;
    }
}

