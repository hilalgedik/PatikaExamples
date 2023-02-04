namespace Drawing.Circle
{
    partial class Circle
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
            this.txtR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(154, 104);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 23);
            this.txtR.TabIndex = 0;
            this.txtR.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diameter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 354);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(154, 170);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 3;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 371);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR);
            this.Name = "Circle";
            this.Text = "Circle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtR;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnDraw;
    }
}