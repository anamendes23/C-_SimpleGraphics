namespace _9._1WorkingWithDataTime
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCurrentDateTime = new System.Windows.Forms.Button();
            this.btnRandomDT = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGetSelectedDate = new System.Windows.Forms.Button();
            this.btnCreateDateTime = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnComputeAge = new System.Windows.Forms.Button();
            this.lblage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 286);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCurrentDateTime
            // 
            this.btnCurrentDateTime.Location = new System.Drawing.Point(22, 331);
            this.btnCurrentDateTime.Name = "btnCurrentDateTime";
            this.btnCurrentDateTime.Size = new System.Drawing.Size(460, 47);
            this.btnCurrentDateTime.TabIndex = 1;
            this.btnCurrentDateTime.Text = "Current Date && Time";
            this.btnCurrentDateTime.UseVisualStyleBackColor = true;
            this.btnCurrentDateTime.Click += new System.EventHandler(this.btnCurrentDateTime_Click);
            // 
            // btnRandomDT
            // 
            this.btnRandomDT.Location = new System.Drawing.Point(22, 395);
            this.btnRandomDT.Name = "btnRandomDT";
            this.btnRandomDT.Size = new System.Drawing.Size(460, 47);
            this.btnRandomDT.TabIndex = 2;
            this.btnRandomDT.Text = "Create a Random Date Time";
            this.btnRandomDT.UseVisualStyleBackColor = true;
            this.btnRandomDT.Click += new System.EventHandler(this.btnRandomDT_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnGetSelectedDate
            // 
            this.btnGetSelectedDate.Location = new System.Drawing.Point(521, 63);
            this.btnGetSelectedDate.Name = "btnGetSelectedDate";
            this.btnGetSelectedDate.Size = new System.Drawing.Size(296, 47);
            this.btnGetSelectedDate.TabIndex = 4;
            this.btnGetSelectedDate.Text = "Get Selected Date";
            this.btnGetSelectedDate.UseVisualStyleBackColor = true;
            this.btnGetSelectedDate.Click += new System.EventHandler(this.btnGetSelectedDate_Click);
            // 
            // btnCreateDateTime
            // 
            this.btnCreateDateTime.Location = new System.Drawing.Point(521, 331);
            this.btnCreateDateTime.Name = "btnCreateDateTime";
            this.btnCreateDateTime.Size = new System.Drawing.Size(460, 47);
            this.btnCreateDateTime.TabIndex = 5;
            this.btnCreateDateTime.Text = "Create New Date Time from Today\'s Date";
            this.btnCreateDateTime.UseVisualStyleBackColor = true;
            this.btnCreateDateTime.Click += new System.EventHandler(this.btnCreateDateTime_Click);
            // 
            // timePicker
            // 
            this.timePicker.Location = new System.Drawing.Point(521, 282);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(296, 26);
            this.timePicker.TabIndex = 6;
            // 
            // btnComputeAge
            // 
            this.btnComputeAge.Location = new System.Drawing.Point(521, 157);
            this.btnComputeAge.Name = "btnComputeAge";
            this.btnComputeAge.Size = new System.Drawing.Size(296, 47);
            this.btnComputeAge.TabIndex = 7;
            this.btnComputeAge.Text = "Compute Age";
            this.btnComputeAge.UseVisualStyleBackColor = true;
            this.btnComputeAge.Click += new System.EventHandler(this.btnComputeAge_Click);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(521, 125);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(97, 20);
            this.lblage.TabIndex = 8;
            this.lblage.Text = "Your age is: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 468);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.btnComputeAge);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.btnCreateDateTime);
            this.Controls.Add(this.btnGetSelectedDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRandomDT);
            this.Controls.Add(this.btnCurrentDateTime);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCurrentDateTime;
        private System.Windows.Forms.Button btnRandomDT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGetSelectedDate;
        private System.Windows.Forms.Button btnCreateDateTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button btnComputeAge;
        private System.Windows.Forms.Label lblage;
    }
}

