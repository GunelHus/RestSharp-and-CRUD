namespace RestSharp.Forms
{
    partial class Usersfrm
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
            this.LblUserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblUsName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LblUserWeb = new System.Windows.Forms.Label();
            this.BtnUserDelete = new System.Windows.Forms.Button();
            this.BtnUserUpdate = new System.Windows.Forms.Button();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(37, 20);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(35, 13);
            this.LblUserName.TabIndex = 0;
            this.LblUserName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 3;
            // 
            // LblUsName
            // 
            this.LblUsName.AutoSize = true;
            this.LblUsName.Location = new System.Drawing.Point(35, 88);
            this.LblUsName.Name = "LblUsName";
            this.LblUsName.Size = new System.Drawing.Size(55, 13);
            this.LblUsName.TabIndex = 2;
            this.LblUsName.Text = "Username";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 20);
            this.textBox3.TabIndex = 5;
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Location = new System.Drawing.Point(39, 149);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(32, 13);
            this.LblUserEmail.TabIndex = 4;
            this.LblUserEmail.Text = "Email";
            this.LblUserEmail.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 20);
            this.textBox4.TabIndex = 7;
            // 
            // LblUserWeb
            // 
            this.LblUserWeb.AutoSize = true;
            this.LblUserWeb.Location = new System.Drawing.Point(40, 211);
            this.LblUserWeb.Name = "LblUserWeb";
            this.LblUserWeb.Size = new System.Drawing.Size(46, 13);
            this.LblUserWeb.TabIndex = 6;
            this.LblUserWeb.Text = "Website";
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.Location = new System.Drawing.Point(33, 288);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(101, 23);
            this.BtnUserDelete.TabIndex = 8;
            this.BtnUserDelete.Text = "Delete";
            this.BtnUserDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUserUpdate
            // 
            this.BtnUserUpdate.Location = new System.Drawing.Point(140, 288);
            this.BtnUserUpdate.Name = "BtnUserUpdate";
            this.BtnUserUpdate.Size = new System.Drawing.Size(98, 23);
            this.BtnUserUpdate.TabIndex = 9;
            this.BtnUserUpdate.Text = "Update";
            this.BtnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // DgvUsers
            // 
            this.DgvUsers.AllowUserToAddRows = false;
            this.DgvUsers.AllowUserToDeleteRows = false;
            this.DgvUsers.AllowUserToResizeColumns = false;
            this.DgvUsers.AllowUserToResizeRows = false;
            this.DgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cName,
            this.Username,
            this.Email,
            this.Website,
            this.PostsCount});
            this.DgvUsers.Location = new System.Drawing.Point(264, 12);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.Size = new System.Drawing.Size(524, 346);
            this.DgvUsers.TabIndex = 10;
            this.DgvUsers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUsers_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Website
            // 
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            // 
            // PostsCount
            // 
            this.PostsCount.HeaderText = "PostsCount";
            this.PostsCount.Name = "PostsCount";
            // 
            // Usersfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.BtnUserUpdate);
            this.Controls.Add(this.BtnUserDelete);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LblUserWeb);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblUsName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblUserName);
            this.Name = "Usersfrm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Usersfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblUsName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LblUserEmail;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LblUserWeb;
        private System.Windows.Forms.Button BtnUserDelete;
        private System.Windows.Forms.Button BtnUserUpdate;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostsCount;
    }
}