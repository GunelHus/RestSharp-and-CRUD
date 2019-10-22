namespace RestSharp.Forms
{
    partial class DgvPosts
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
            this.LblPostTitle = new System.Windows.Forms.Label();
            this.TxtBoxPost = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblBodyPost = new System.Windows.Forms.Label();
            this.lblAuthorPosts = new System.Windows.Forms.Label();
            this.CmbxPosts = new System.Windows.Forms.ComboBox();
            this.BtnDeletePosts = new System.Windows.Forms.Button();
            this.BtnUpdatePosts = new System.Windows.Forms.Button();
            this.DataGvPost = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGvPost)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPostTitle
            // 
            this.LblPostTitle.AutoSize = true;
            this.LblPostTitle.Location = new System.Drawing.Point(28, 9);
            this.LblPostTitle.Name = "LblPostTitle";
            this.LblPostTitle.Size = new System.Drawing.Size(27, 13);
            this.LblPostTitle.TabIndex = 0;
            this.LblPostTitle.Text = "Title";
            // 
            // TxtBoxPost
            // 
            this.TxtBoxPost.Location = new System.Drawing.Point(31, 37);
            this.TxtBoxPost.Name = "TxtBoxPost";
            this.TxtBoxPost.Size = new System.Drawing.Size(226, 20);
            this.TxtBoxPost.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(226, 183);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LblBodyPost
            // 
            this.LblBodyPost.AutoSize = true;
            this.LblBodyPost.Location = new System.Drawing.Point(34, 67);
            this.LblBodyPost.Name = "LblBodyPost";
            this.LblBodyPost.Size = new System.Drawing.Size(31, 13);
            this.LblBodyPost.TabIndex = 3;
            this.LblBodyPost.Text = "Body";
            // 
            // lblAuthorPosts
            // 
            this.lblAuthorPosts.AutoSize = true;
            this.lblAuthorPosts.Location = new System.Drawing.Point(28, 299);
            this.lblAuthorPosts.Name = "lblAuthorPosts";
            this.lblAuthorPosts.Size = new System.Drawing.Size(38, 13);
            this.lblAuthorPosts.TabIndex = 4;
            this.lblAuthorPosts.Text = "Author";
            // 
            // CmbxPosts
            // 
            this.CmbxPosts.FormattingEnabled = true;
            this.CmbxPosts.Location = new System.Drawing.Point(31, 328);
            this.CmbxPosts.Name = "CmbxPosts";
            this.CmbxPosts.Size = new System.Drawing.Size(226, 21);
            this.CmbxPosts.TabIndex = 5;
            // 
            // BtnDeletePosts
            // 
            this.BtnDeletePosts.Location = new System.Drawing.Point(31, 369);
            this.BtnDeletePosts.Name = "BtnDeletePosts";
            this.BtnDeletePosts.Size = new System.Drawing.Size(97, 23);
            this.BtnDeletePosts.TabIndex = 6;
            this.BtnDeletePosts.Text = "Delete";
            this.BtnDeletePosts.UseVisualStyleBackColor = true;
            // 
            // BtnUpdatePosts
            // 
            this.BtnUpdatePosts.Location = new System.Drawing.Point(168, 369);
            this.BtnUpdatePosts.Name = "BtnUpdatePosts";
            this.BtnUpdatePosts.Size = new System.Drawing.Size(89, 23);
            this.BtnUpdatePosts.TabIndex = 7;
            this.BtnUpdatePosts.Text = "Update";
            this.BtnUpdatePosts.UseVisualStyleBackColor = true;
            // 
            // DataGvPost
            // 
            this.DataGvPost.AllowUserToAddRows = false;
            this.DataGvPost.AllowUserToDeleteRows = false;
            this.DataGvPost.AllowUserToResizeColumns = false;
            this.DataGvPost.AllowUserToResizeRows = false;
            this.DataGvPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGvPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGvPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGvPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Body,
            this.Author});
            this.DataGvPost.Location = new System.Drawing.Point(295, 12);
            this.DataGvPost.Name = "DataGvPost";
            this.DataGvPost.Size = new System.Drawing.Size(484, 380);
            this.DataGvPost.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Body
            // 
            this.Body.HeaderText = "Body";
            this.Body.Name = "Body";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // DgvPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGvPost);
            this.Controls.Add(this.BtnUpdatePosts);
            this.Controls.Add(this.BtnDeletePosts);
            this.Controls.Add(this.CmbxPosts);
            this.Controls.Add(this.lblAuthorPosts);
            this.Controls.Add(this.LblBodyPost);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtBoxPost);
            this.Controls.Add(this.LblPostTitle);
            this.Name = "DgvPosts";
            this.Text = "Posts";
            this.Load += new System.EventHandler(this.DgvPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGvPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPostTitle;
        private System.Windows.Forms.TextBox TxtBoxPost;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LblBodyPost;
        private System.Windows.Forms.Label lblAuthorPosts;
        private System.Windows.Forms.ComboBox CmbxPosts;
        private System.Windows.Forms.Button BtnDeletePosts;
        private System.Windows.Forms.Button BtnUpdatePosts;
        private System.Windows.Forms.DataGridView DataGvPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
    }
}