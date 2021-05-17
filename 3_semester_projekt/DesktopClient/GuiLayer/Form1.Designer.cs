
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
            this.listBoxShowings = new System.Windows.Forms.ListBox();
            this.GetAllShowings = new System.Windows.Forms.Button();
            this.labelProcessText = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBoxSeatsInShowing = new System.Windows.Forms.ListBox();
            this.ChooseSeatLabel = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.EnteredShowingId = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteLabel = new System.Windows.Forms.Label();
            this.DeleteStatus = new System.Windows.Forms.Label();
            this.CreateShowingBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxShowings);
            this.groupBox1.Location = new System.Drawing.Point(41, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(180, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listBoxShowings
            // 
            this.listBoxShowings.FormattingEnabled = true;
            this.listBoxShowings.ItemHeight = 15;
            this.listBoxShowings.Location = new System.Drawing.Point(6, 20);
            this.listBoxShowings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxShowings.Name = "listBoxShowings";
            this.listBoxShowings.Size = new System.Drawing.Size(170, 169);
            this.listBoxShowings.TabIndex = 0;
            // 
            // GetAllShowings
            // 
            this.GetAllShowings.Location = new System.Drawing.Point(47, 62);
            this.GetAllShowings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetAllShowings.Name = "GetAllShowings";
            this.GetAllShowings.Size = new System.Drawing.Size(118, 22);
            this.GetAllShowings.TabIndex = 1;
            this.GetAllShowings.Text = "Vis Forestillinger";
            this.GetAllShowings.UseVisualStyleBackColor = true;
            this.GetAllShowings.Click += new System.EventHandler(this.buttonGetBookings_Click);
            // 
            // labelProcessText
            // 
            this.labelProcessText.AutoSize = true;
            this.labelProcessText.Location = new System.Drawing.Point(41, 314);
            this.labelProcessText.Name = "labelProcessText";
            this.labelProcessText.Size = new System.Drawing.Size(39, 15);
            this.labelProcessText.TabIndex = 2;
            this.labelProcessText.Text = "Status";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(502, 268);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Køb";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(502, 201);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(135, 15);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Indtast Telefon Nummer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBoxSeatsInShowing);
            this.groupBox2.Location = new System.Drawing.Point(272, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 191);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // ListBoxSeatsInShowing
            // 
            this.ListBoxSeatsInShowing.FormattingEnabled = true;
            this.ListBoxSeatsInShowing.ItemHeight = 15;
            this.ListBoxSeatsInShowing.Location = new System.Drawing.Point(7, 20);
            this.ListBoxSeatsInShowing.Name = "ListBoxSeatsInShowing";
            this.ListBoxSeatsInShowing.Size = new System.Drawing.Size(177, 169);
            this.ListBoxSeatsInShowing.TabIndex = 0;
            // 
            // ChooseSeatLabel
            // 
            this.ChooseSeatLabel.AutoSize = true;
            this.ChooseSeatLabel.Location = new System.Drawing.Point(279, 69);
            this.ChooseSeatLabel.Name = "ChooseSeatLabel";
            this.ChooseSeatLabel.Size = new System.Drawing.Size(162, 15);
            this.ChooseSeatLabel.TabIndex = 7;
            this.ChooseSeatLabel.Text = "Vælg et sæde til forestillingen";
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
            this.EnteredShowingId.Location = new System.Drawing.Point(502, 124);
            this.EnteredShowingId.Name = "EnteredShowingId";
            this.EnteredShowingId.Size = new System.Drawing.Size(100, 23);
            this.EnteredShowingId.TabIndex = 9;
            this.EnteredShowingId.TextChanged += new System.EventHandler(this.EnteredShowingId_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(502, 153);
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
            this.DeleteLabel.Location = new System.Drawing.Point(462, 106);
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
            this.CreateShowingBtn.Location = new System.Drawing.Point(502, 61);
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
            this.Controls.Add(this.ChooseSeatLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.labelProcessText);
            this.Controls.Add(this.GetAllShowings);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxShowings;
        private System.Windows.Forms.Button GetAllShowings;
        private System.Windows.Forms.Label labelProcessText;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListBoxSeatsInShowing;
        private System.Windows.Forms.Label ChooseSeatLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.TextBox EnteredShowingId;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeleteLabel;
        private System.Windows.Forms.Label DeleteStatus;
        private System.Windows.Forms.Button CreateShowingBtn;
    }
}

