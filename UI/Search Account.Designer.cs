namespace BanglaBank.UI
{
    partial class Search_Account
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(362, 38);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(481, 33);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(881, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(280, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search Account Number";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl,
            this.name,
            this.mobile,
            this.email,
            this.address,
            this.gender,
            this.balance,
            this.acnumber,
            this.date});
            this.accountDataGridView.Location = new System.Drawing.Point(116, 90);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.Size = new System.Drawing.Size(1045, 401);
            this.accountDataGridView.TabIndex = 2;
            this.accountDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountDataGridView_CellContentClick);
            // 
            // sl
            // 
            this.sl.DataPropertyName = "Id";
            this.sl.HeaderText = "SL";
            this.sl.Name = "sl";
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Customer Name";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "Mobile";
            this.mobile.HeaderText = "Mobile";
            this.mobile.Name = "mobile";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // balance
            // 
            this.balance.DataPropertyName = "Balance";
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            // 
            // acnumber
            // 
            this.acnumber.DataPropertyName = "AcNumber";
            this.acnumber.HeaderText = "Account Number";
            this.acnumber.Name = "acnumber";
            this.acnumber.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // Search_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 503);
            this.Controls.Add(this.accountDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Name = "Search_Account";
            this.Text = "Search_Account";
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn acnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}