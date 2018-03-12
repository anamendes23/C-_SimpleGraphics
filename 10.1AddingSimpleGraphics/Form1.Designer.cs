namespace _10._1AddingSimpleGraphics
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLines = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFillCircle = new System.Windows.Forms.Button();
            this.btnFillRect = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btn3Circles = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnTCircle = new System.Windows.Forms.Button();
            this.btnDrawPolygon = new System.Windows.Forms.Button();
            this.btnDrawPie = new System.Windows.Forms.Button();
            this.btnFillPolygon = new System.Windows.Forms.Button();
            this.btnFillPie = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox1.Location = new System.Drawing.Point(39, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 416);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLines
            // 
            this.btnLines.Location = new System.Drawing.Point(39, 477);
            this.btnLines.Name = "btnLines";
            this.btnLines.Size = new System.Drawing.Size(137, 48);
            this.btnLines.TabIndex = 1;
            this.btnLines.Text = "Draw Lines";
            this.btnLines.UseVisualStyleBackColor = true;
            this.btnLines.Click += new System.EventHandler(this.btnLines_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(182, 477);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(142, 48);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Draw Rect";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(330, 477);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(137, 48);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Draw Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(473, 477);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(183, 48);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Choose Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(676, 185);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 123);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "STOP\r\n\r\nTIMER";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFillCircle
            // 
            this.btnFillCircle.Location = new System.Drawing.Point(330, 531);
            this.btnFillCircle.Name = "btnFillCircle";
            this.btnFillCircle.Size = new System.Drawing.Size(137, 48);
            this.btnFillCircle.TabIndex = 7;
            this.btnFillCircle.Text = "Fill Circle";
            this.btnFillCircle.UseVisualStyleBackColor = true;
            this.btnFillCircle.Click += new System.EventHandler(this.btnFillCircle_Click);
            // 
            // btnFillRect
            // 
            this.btnFillRect.Location = new System.Drawing.Point(182, 531);
            this.btnFillRect.Name = "btnFillRect";
            this.btnFillRect.Size = new System.Drawing.Size(142, 48);
            this.btnFillRect.TabIndex = 6;
            this.btnFillRect.Text = "Fill Rect";
            this.btnFillRect.UseVisualStyleBackColor = true;
            this.btnFillRect.Click += new System.EventHandler(this.btnFillRect_Click);
            // 
            // btnArc
            // 
            this.btnArc.Location = new System.Drawing.Point(39, 531);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(137, 48);
            this.btnArc.TabIndex = 8;
            this.btnArc.Text = "Draw ArcCircle";
            this.btnArc.UseVisualStyleBackColor = true;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btn3Circles
            // 
            this.btn3Circles.Location = new System.Drawing.Point(473, 531);
            this.btn3Circles.Name = "btn3Circles";
            this.btn3Circles.Size = new System.Drawing.Size(183, 48);
            this.btn3Circles.TabIndex = 9;
            this.btn3Circles.Text = "3 Concentric Circles";
            this.btn3Circles.UseVisualStyleBackColor = true;
            this.btn3Circles.Click += new System.EventHandler(this.btn3Circles_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(674, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 125);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(676, 531);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(77, 48);
            this.btnSquare.TabIndex = 11;
            this.btnSquare.Text = "|   | (   )";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnTCircle
            // 
            this.btnTCircle.Location = new System.Drawing.Point(676, 477);
            this.btnTCircle.Name = "btnTCircle";
            this.btnTCircle.Size = new System.Drawing.Size(75, 48);
            this.btnTCircle.TabIndex = 12;
            this.btnTCircle.Text = "Tcircle";
            this.btnTCircle.UseVisualStyleBackColor = true;
            this.btnTCircle.Click += new System.EventHandler(this.btnTCircle_Click);
            // 
            // btnDrawPolygon
            // 
            this.btnDrawPolygon.Location = new System.Drawing.Point(330, 585);
            this.btnDrawPolygon.Name = "btnDrawPolygon";
            this.btnDrawPolygon.Size = new System.Drawing.Size(137, 48);
            this.btnDrawPolygon.TabIndex = 16;
            this.btnDrawPolygon.Text = "Draw Polygon";
            this.btnDrawPolygon.UseVisualStyleBackColor = true;
            this.btnDrawPolygon.Click += new System.EventHandler(this.btnDrawPolygon_Click);
            // 
            // btnDrawPie
            // 
            this.btnDrawPie.Location = new System.Drawing.Point(39, 585);
            this.btnDrawPie.Name = "btnDrawPie";
            this.btnDrawPie.Size = new System.Drawing.Size(137, 48);
            this.btnDrawPie.TabIndex = 15;
            this.btnDrawPie.Text = "Draw Pie";
            this.btnDrawPie.UseVisualStyleBackColor = true;
            this.btnDrawPie.Click += new System.EventHandler(this.btnDrawPie_Click);
            // 
            // btnFillPolygon
            // 
            this.btnFillPolygon.Location = new System.Drawing.Point(473, 585);
            this.btnFillPolygon.Name = "btnFillPolygon";
            this.btnFillPolygon.Size = new System.Drawing.Size(183, 48);
            this.btnFillPolygon.TabIndex = 14;
            this.btnFillPolygon.Text = "Fill Polygon";
            this.btnFillPolygon.UseVisualStyleBackColor = true;
            this.btnFillPolygon.Click += new System.EventHandler(this.btnFillPolygon_Click);
            // 
            // btnFillPie
            // 
            this.btnFillPie.Location = new System.Drawing.Point(182, 585);
            this.btnFillPie.Name = "btnFillPie";
            this.btnFillPie.Size = new System.Drawing.Size(142, 48);
            this.btnFillPie.TabIndex = 13;
            this.btnFillPie.Text = "Fill Pie";
            this.btnFillPie.UseVisualStyleBackColor = true;
            this.btnFillPie.Click += new System.EventHandler(this.btnFillPie_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(674, 585);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(77, 48);
            this.btnString.TabIndex = 18;
            this.btnString.Text = "Str";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(676, 40);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 124);
            this.btnStartTimer.TabIndex = 19;
            this.btnStartTimer.Text = "START\r\n\r\nTIMER";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 698);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnDrawPolygon);
            this.Controls.Add(this.btnDrawPie);
            this.Controls.Add(this.btnFillPolygon);
            this.Controls.Add(this.btnFillPie);
            this.Controls.Add(this.btnTCircle);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn3Circles);
            this.Controls.Add(this.btnArc);
            this.Controls.Add(this.btnFillCircle);
            this.Controls.Add(this.btnFillRect);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnLines);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLines;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFillCircle;
        private System.Windows.Forms.Button btnFillRect;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btn3Circles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnTCircle;
        private System.Windows.Forms.Button btnDrawPolygon;
        private System.Windows.Forms.Button btnDrawPie;
        private System.Windows.Forms.Button btnFillPolygon;
        private System.Windows.Forms.Button btnFillPie;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStartTimer;
    }
}

