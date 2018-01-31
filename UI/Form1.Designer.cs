namespace BanglaBank
{
    partial class BanglaBankUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.accountButton = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bangla Bank";
            // 
            // accountButton
            // 
            this.accountButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountButton.Location = new System.Drawing.Point(66, 152);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(198, 65);
            this.accountButton.TabIndex = 1;
            this.accountButton.Text = "Create Account";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionButton.Location = new System.Drawing.Point(287, 152);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(198, 65);
            this.transactionButton.TabIndex = 1;
            this.transactionButton.Text = "Transaction";
            this.transactionButton.UseVisualStyleBackColor = true;
            this.transactionButton.Click += new System.EventHandler(this.transactionButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(511, 152);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(198, 65);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search Account";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // BanglaBankUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 315);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.label1);
            this.Name = "BanglaBankUI";
            this.Text = "Bangla Bank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button searchButton;
    }
}

