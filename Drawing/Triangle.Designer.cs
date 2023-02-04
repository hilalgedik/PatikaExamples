namespace Drawing
{
    partial class Triangle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtPoint1x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoint2x = new System.Windows.Forms.TextBox();
            this.txtPoint3x = new System.Windows.Forms.TextBox();
            this.txtPoint1y = new System.Windows.Forms.TextBox();
            this.txtPoint2y = new System.Windows.Forms.TextBox();
            this.txtPoint3y = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(139, 259);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtPoint1x
            // 
            this.txtPoint1x.Location = new System.Drawing.Point(127, 101);
            this.txtPoint1x.Name = "txtPoint1x";
            this.txtPoint1x.Size = new System.Drawing.Size(49, 23);
            this.txtPoint1x.TabIndex = 1;
            this.txtPoint1x.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Point(x,y) 1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(355, 91);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(354, 245);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Point(x,y) 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Point(x,y) 3";
            // 
            // txtPoint2x
            // 
            this.txtPoint2x.Location = new System.Drawing.Point(128, 161);
            this.txtPoint2x.Name = "txtPoint2x";
            this.txtPoint2x.Size = new System.Drawing.Size(48, 23);
            this.txtPoint2x.TabIndex = 6;
            this.txtPoint2x.Text = "0";
            // 
            // txtPoint3x
            // 
            this.txtPoint3x.Location = new System.Drawing.Point(127, 213);
            this.txtPoint3x.Name = "txtPoint3x";
            this.txtPoint3x.Size = new System.Drawing.Size(49, 23);
            this.txtPoint3x.TabIndex = 7;
            this.txtPoint3x.Text = "130";
            // 
            // txtPoint1y
            // 
            this.txtPoint1y.Location = new System.Drawing.Point(197, 101);
            this.txtPoint1y.Name = "txtPoint1y";
            this.txtPoint1y.Size = new System.Drawing.Size(49, 23);
            this.txtPoint1y.TabIndex = 8;
            this.txtPoint1y.Text = "0";
            // 
            // txtPoint2y
            // 
            this.txtPoint2y.Location = new System.Drawing.Point(197, 161);
            this.txtPoint2y.Name = "txtPoint2y";
            this.txtPoint2y.Size = new System.Drawing.Size(49, 23);
            this.txtPoint2y.TabIndex = 9;
            this.txtPoint2y.Text = "120";
            // 
            // txtPoint3y
            // 
            this.txtPoint3y.Location = new System.Drawing.Point(197, 213);
            this.txtPoint3y.Name = "txtPoint3y";
            this.txtPoint3y.Size = new System.Drawing.Size(49, 23);
            this.txtPoint3y.TabIndex = 10;
            this.txtPoint3y.Text = "0";
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 370);
            this.Controls.Add(this.txtPoint3y);
            this.Controls.Add(this.txtPoint2y);
            this.Controls.Add(this.txtPoint1y);
            this.Controls.Add(this.txtPoint3x);
            this.Controls.Add(this.txtPoint2x);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoint1x);
            this.Controls.Add(this.btnDraw);
            this.Name = "Triangle";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDraw;
        private TextBox txtPoint1x;
        private Label label1;
        private PictureBox pictureBox;
        private Label label2;
        private Label label3;
        private TextBox txtPoint2x;
        private TextBox txtPoint3x;
        private TextBox txtPoint1y;
        private TextBox txtPoint2y;
        private TextBox txtPoint3y;
    }
}