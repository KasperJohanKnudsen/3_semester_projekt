
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
            this.WarningLabel = new System.Windows.Forms.Label();
            this.EnteredShowingId = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.DeleteStatus = new System.Windows.Forms.Label();
            this.CreateShowingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Location = new System.Drawing.Point(502, 13);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 15);
            this.WarningLabel.TabIndex = 8;
            // 
            // EnteredShowingId
            // 
            this.EnteredShowingId.Location = new System.Drawing.Point(12, 265);
            this.EnteredShowingId.Name = "EnteredShowingId";
            this.EnteredShowingId.Size = new System.Drawing.Size(100, 23);
            this.EnteredShowingId.TabIndex = 9;
            this.EnteredShowingId.TextChanged += new System.EventHandler(this.EnteredShowingId_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 294);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Slet";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteLabel
            // 
            this.DeleteLabel.AutoSize = true;
            this.DeleteLabel.Location = new System.Drawing.Point(12, 247);
            this.DeleteLabel.Name = "DeleteLabel";
            this.DeleteLabel.Size = new System.Drawing.Size(216, 15);
            this.DeleteLabel.TabIndex = 11;
            this.DeleteLabel.Text = "Indtast id på forestilling som skal slettes";
            // 
            // DeleteStatus
            // 
            this.DeleteStatus.AutoSize = true;
            this.DeleteStatus.Location = new System.Drawing.Point(468, 186);
            this.DeleteStatus.Name = "DeleteStatus";
            this.DeleteStatus.Size = new System.Drawing.Size(0, 15);
            this.DeleteStatus.TabIndex = 12;
            // 
            // CreateShowingBtn
            // 
            this.CreateShowingBtn.Location = new System.Drawing.Point(12, 23);
            this.CreateShowingBtn.Name = "CreateShowingBtn";
            this.CreateShowingBtn.Size = new System.Drawing.Size(135, 23);
            this.CreateShowingBtn.TabIndex = 13;
            this.CreateShowingBtn.Text = "Opret ny Showing";
            this.CreateShowingBtn.UseVisualStyleBackColor = true;
            this.CreateShowingBtn.Click += new System.EventHandler(this.CreateShowingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.CreateShowingBtn);
            this.Controls.Add(this.DeleteStatus);
            this.Controls.Add(this.DeleteLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EnteredShowingId);
            this.Controls.Add(this.WarningLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.TextBox EnteredShowingId;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Label DeleteStatus;
        private System.Windows.Forms.Button CreateShowingBtn;
    }
}

