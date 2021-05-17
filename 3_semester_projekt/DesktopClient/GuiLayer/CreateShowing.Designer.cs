namespace DesktopClient {
    partial class CreateShowing {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CreateShowingHeaderLbl = new System.Windows.Forms.Label();
            this.CreateShowingSubmit = new System.Windows.Forms.Button();
            this.SelectMovieBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SelectTheaterBox = new System.Windows.Forms.ComboBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateShowingHeaderLbl
            // 
            this.CreateShowingHeaderLbl.AutoSize = true;
            this.CreateShowingHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateShowingHeaderLbl.Location = new System.Drawing.Point(295, 9);
            this.CreateShowingHeaderLbl.Name = "CreateShowingHeaderLbl";
            this.CreateShowingHeaderLbl.Size = new System.Drawing.Size(233, 45);
            this.CreateShowingHeaderLbl.TabIndex = 0;
            this.CreateShowingHeaderLbl.Text = "Opret Showing";
            // 
            // CreateShowingSubmit
            // 
            this.CreateShowingSubmit.Location = new System.Drawing.Point(341, 403);
            this.CreateShowingSubmit.Name = "CreateShowingSubmit";
            this.CreateShowingSubmit.Size = new System.Drawing.Size(120, 29);
            this.CreateShowingSubmit.TabIndex = 1;
            this.CreateShowingSubmit.Text = "Opret Showing";
            this.CreateShowingSubmit.UseVisualStyleBackColor = true;
            this.CreateShowingSubmit.Click += new System.EventHandler(this.CreateShowingSubmit_Click);
            // 
            // SelectMovieBox
            // 
            this.SelectMovieBox.FormattingEnabled = true;
            this.SelectMovieBox.Items.AddRange(new object[] {
            "Løvernes Konge"});
            this.SelectMovieBox.Location = new System.Drawing.Point(63, 126);
            this.SelectMovieBox.Name = "SelectMovieBox";
            this.SelectMovieBox.Size = new System.Drawing.Size(227, 23);
            this.SelectMovieBox.TabIndex = 4;
            this.SelectMovieBox.Text = "Vælg Film";
            this.SelectMovieBox.SelectedIndexChanged += new System.EventHandler(this.SelectMovieBox_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(63, 270);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // SelectTheaterBox
            // 
            this.SelectTheaterBox.FormattingEnabled = true;
            this.SelectTheaterBox.Items.AddRange(new object[] {
            "10"});
            this.SelectTheaterBox.Location = new System.Drawing.Point(63, 166);
            this.SelectTheaterBox.Name = "SelectTheaterBox";
            this.SelectTheaterBox.Size = new System.Drawing.Size(227, 23);
            this.SelectTheaterBox.TabIndex = 6;
            this.SelectTheaterBox.Text = "Vælg Teater";
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Location = new System.Drawing.Point(341, 361);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 15);
            this.ErrorLbl.TabIndex = 7;
            // 
            // CreateShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.SelectTheaterBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.SelectMovieBox);
            this.Controls.Add(this.CreateShowingSubmit);
            this.Controls.Add(this.CreateShowingHeaderLbl);
            this.Name = "CreateShowing";
            this.Text = "CreateShowing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateShowingHeaderLbl;
        private System.Windows.Forms.Button CreateShowingSubmit;
        private System.Windows.Forms.ComboBox SelectMovieBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox SelectTheaterBox;
        private System.Windows.Forms.Label ErrorLbl;
    }
}