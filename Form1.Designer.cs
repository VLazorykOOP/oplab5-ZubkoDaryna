namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxCurve;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxVx1;
        private System.Windows.Forms.TextBox textBoxVy1;
        private System.Windows.Forms.TextBox textBoxVx2;
        private System.Windows.Forms.TextBox textBoxVy2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelVx1;
        private System.Windows.Forms.Label labelVy1;
        private System.Windows.Forms.Label labelVx2;
        private System.Windows.Forms.Label labelVy2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxCurve = new System.Windows.Forms.PictureBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxVx1 = new System.Windows.Forms.TextBox();
            this.textBoxVy1 = new System.Windows.Forms.TextBox();
            this.textBoxVx2 = new System.Windows.Forms.TextBox();
            this.textBoxVy2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelVx1 = new System.Windows.Forms.Label();
            this.labelVy1 = new System.Windows.Forms.Label();
            this.labelVx2 = new System.Windows.Forms.Label();
            this.labelVy2 = new System.Windows.Forms.Label();
            // Встановлення значень за замовчуванням для TextBox
            this.textBoxX1.Text = "100";
            this.textBoxY1.Text = "100";
            this.textBoxX2.Text = "250";
            this.textBoxY2.Text = "100";
            this.textBoxVx1.Text = "50";
            this.textBoxVy1.Text = "-50";
            this.textBoxVx2.Text = "-50";
            this.textBoxVy2.Text = "50";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCurve
            // 
            this.pictureBoxCurve.BackColor = System.Drawing.Color.White;
            this.pictureBoxCurve.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCurve.Name = "pictureBoxCurve";
            this.pictureBoxCurve.Size = new System.Drawing.Size(776, 426);
            this.pictureBoxCurve.TabIndex = 0;
            this.pictureBoxCurve.TabStop = false;
            this.pictureBoxCurve.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCurve_Paint);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(12, 444);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(50, 22);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(68, 444);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(50, 22);
            this.textBoxY1.TabIndex = 2;
            this.textBoxY1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(124, 444);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(50, 22);
            this.textBoxX2.TabIndex = 3;
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(180, 444);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(50, 22);
            this.textBoxY2.TabIndex = 4;
            this.textBoxY2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxVx1
            // 
            this.textBoxVx1.Location = new System.Drawing.Point(236, 444);
            this.textBoxVx1.Name = "textBoxVx1";
            this.textBoxVx1.Size = new System.Drawing.Size(50, 22);
            this.textBoxVx1.TabIndex = 5;
            this.textBoxVx1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxVy1
            // 
            this.textBoxVy1.Location = new System.Drawing.Point(292, 444);
            this.textBoxVy1.Name = "textBoxVy1";
            this.textBoxVy1.Size = new System.Drawing.Size(50, 22);
            this.textBoxVy1.TabIndex = 6;
            this.textBoxVy1.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxVx2
            // 
            this.textBoxVx2.Location = new System.Drawing.Point(348, 444);
            this.textBoxVx2.Name = "textBoxVx2";
            this.textBoxVx2.Size = new System.Drawing.Size(50, 22);
            this.textBoxVx2.TabIndex = 7;
            this.textBoxVx2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxVy2
            // 
            this.textBoxVy2.Location = new System.Drawing.Point(404, 444);
            this.textBoxVy2.Name = "textBoxVy2";
            this.textBoxVy2.Size = new System.Drawing.Size(50, 22);
            this.textBoxVy2.TabIndex = 8;
            this.textBoxVy2.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(12, 425);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(25, 16);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "X1";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(68, 425);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(25, 16);
            this.labelY1.TabIndex = 10;
            this.labelY1.Text = "Y1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(124, 425);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(25, 16);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "X2";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(180, 425);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(25, 16);
            this.labelY2.TabIndex = 12;
            this.labelY2.Text = "Y2";
            // 
            // labelVx1
            // 
            this.labelVx1.AutoSize = true;
            this.labelVx1.Location = new System.Drawing.Point(236, 425);
            this.labelVx1.Name = "labelVx1";
            this.labelVx1.Size = new System.Drawing.Size(30, 16);
            this.labelVx1.TabIndex = 13;
            this.labelVx1.Text = "Vx1";
            // 
            // labelVy1
            // 
            this.labelVy1.AutoSize = true;
            this.labelVy1.Location = new System.Drawing.Point(292, 425);
            this.labelVy1.Name = "labelVy1";
            this.labelVy1.Size = new System.Drawing.Size(30, 16);
            this.labelVy1.TabIndex = 14;
            this.labelVy1.Text = "Vy1";
            // 
            // labelVx2
            // 
            this.labelVx2.AutoSize = true;
            this.labelVx2.Location = new System.Drawing.Point(348, 425);
            this.labelVx2.Name = "labelVx2";
            this.labelVx2.Size = new System.Drawing.Size(30, 16);
            this.labelVx2.TabIndex = 15;
            this.labelVx2.Text = "Vx2";
            // 
            // labelVy2
            // 
            this.labelVy2.AutoSize = true;
            this.labelVy2.Location = new System.Drawing.Point(404, 425);
            this.labelVy2.Name = "labelVy2";
            this.labelVy2.Size = new System.Drawing.Size(30, 16);
            this.labelVy2.TabIndex = 16;
            this.labelVy2.Text = "Vy2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.labelVy2);
            this.Controls.Add(this.labelVx2);
            this.Controls.Add(this.labelVy1);
            this.Controls.Add(this.labelVx1);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxVy2);
            this.Controls.Add(this.textBoxVx2);
            this.Controls.Add(this.textBoxVy1);
            this.Controls.Add(this.textBoxVx1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.pictureBoxCurve);
            this.Name = "Form1";
            this.Text = "Hermite Curve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
