
namespace DesktopClient
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.buttonGetBookings = new System.Windows.Forms.Button();
            this.labelProcessText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxBookings);
            this.groupBox1.Location = new System.Drawing.Point(47, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.ItemHeight = 20;
            this.listBoxBookings.Location = new System.Drawing.Point(7, 27);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(271, 244);
            this.listBoxBookings.TabIndex = 0;
            // 
            // buttonGetBookings
            // 
            this.buttonGetBookings.Location = new System.Drawing.Point(54, 82);
            this.buttonGetBookings.Name = "buttonGetBookings";
            this.buttonGetBookings.Size = new System.Drawing.Size(135, 29);
            this.buttonGetBookings.TabIndex = 1;
            this.buttonGetBookings.Text = "Get All Bookings";
            this.buttonGetBookings.UseVisualStyleBackColor = true;
            this.buttonGetBookings.Click += new System.EventHandler(this.buttonGetBookings_Click);
            // 
            // labelProcessText
            // 
            this.labelProcessText.AutoSize = true;
            this.labelProcessText.Location = new System.Drawing.Point(54, 26);
            this.labelProcessText.Name = "labelProcessText";
            this.labelProcessText.Size = new System.Drawing.Size(97, 20);
            this.labelProcessText.TabIndex = 2;
            this.labelProcessText.Text = "Get Bookings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProcessText);
            this.Controls.Add(this.buttonGetBookings);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxBookings;
        private System.Windows.Forms.Button buttonGetBookings;
        private System.Windows.Forms.Label labelProcessText;
    }
}

