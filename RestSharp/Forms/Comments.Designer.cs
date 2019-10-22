namespace RestSharp.Forms
{
    partial class Comments
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
            this.CommentsLblName = new System.Windows.Forms.Label();
            this.CommentsNameTxt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CommentsLblEmail = new System.Windows.Forms.Label();
            this.CommentsRchtxtboxBody = new System.Windows.Forms.RichTextBox();
            this.CommentsLblPost = new System.Windows.Forms.Label();
            this.CommentsCmbx = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DgvComments = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsLblBody = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // CommentsLblName
            // 
            this.CommentsLblName.AutoSize = true;
            this.CommentsLblName.Location = new System.Drawing.Point(49, 9);
            this.CommentsLblName.Name = "CommentsLblName";
            this.CommentsLblName.Size = new System.Drawing.Size(35, 13);
            this.CommentsLblName.TabIndex = 0;
            this.CommentsLblName.Text = "Name";
            // 
            // CommentsNameTxt
            // 
            this.CommentsNameTxt.Location = new System.Drawing.Point(52, 36);
            this.CommentsNameTxt.Name = "CommentsNameTxt";
            this.CommentsNameTxt.Size = new System.Drawing.Size(204, 20);
            this.CommentsNameTxt.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 20);
            this.textBox2.TabIndex = 3;
            // 
            // CommentsLblEmail
            // 
            this.CommentsLblEmail.AutoSize = true;
            this.CommentsLblEmail.Location = new System.Drawing.Point(49, 70);
            this.CommentsLblEmail.Name = "CommentsLblEmail";
            this.CommentsLblEmail.Size = new System.Drawing.Size(32, 13);
            this.CommentsLblEmail.TabIndex = 2;
            this.CommentsLblEmail.Text = "Email";
            // 
            // CommentsRchtxtboxBody
            // 
            this.CommentsRchtxtboxBody.Location = new System.Drawing.Point(52, 151);
            this.CommentsRchtxtboxBody.Name = "CommentsRchtxtboxBody";
            this.CommentsRchtxtboxBody.Size = new System.Drawing.Size(213, 144);
            this.CommentsRchtxtboxBody.TabIndex = 4;
            this.CommentsRchtxtboxBody.Text = "";
            // 
            // CommentsLblPost
            // 
            this.CommentsLblPost.AutoSize = true;
            this.CommentsLblPost.Location = new System.Drawing.Point(56, 323);
            this.CommentsLblPost.Name = "CommentsLblPost";
            this.CommentsLblPost.Size = new System.Drawing.Size(28, 13);
            this.CommentsLblPost.TabIndex = 5;
            this.CommentsLblPost.Text = "Post";
            // 
            // CommentsCmbx
            // 
            this.CommentsCmbx.FormattingEnabled = true;
            this.CommentsCmbx.Location = new System.Drawing.Point(52, 348);
            this.CommentsCmbx.Name = "CommentsCmbx";
            this.CommentsCmbx.Size = new System.Drawing.Size(213, 21);
            this.CommentsCmbx.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DgvComments
            // 
            this.DgvComments.AllowUserToAddRows = false;
            this.DgvComments.AllowUserToDeleteRows = false;
            this.DgvComments.AllowUserToResizeColumns = false;
            this.DgvComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CommentsName,
            this.Email,
            this.Body,
            this.Author});
            this.DgvComments.Location = new System.Drawing.Point(304, 36);
            this.DgvComments.Name = "DgvComments";
            this.DgvComments.Size = new System.Drawing.Size(470, 393);
            this.DgvComments.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // CommentsName
            // 
            this.CommentsName.HeaderText = "Name";
            this.CommentsName.Name = "CommentsName";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
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
            // CommentsLblBody
            // 
            this.CommentsLblBody.AutoSize = true;
            this.CommentsLblBody.Location = new System.Drawing.Point(49, 127);
            this.CommentsLblBody.Name = "CommentsLblBody";
            this.CommentsLblBody.Size = new System.Drawing.Size(31, 13);
            this.CommentsLblBody.TabIndex = 10;
            this.CommentsLblBody.Text = "Body";
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommentsLblBody);
            this.Controls.Add(this.DgvComments);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CommentsCmbx);
            this.Controls.Add(this.CommentsLblPost);
            this.Controls.Add(this.CommentsRchtxtboxBody);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CommentsLblEmail);
            this.Controls.Add(this.CommentsNameTxt);
            this.Controls.Add(this.CommentsLblName);
            this.Name = "Comments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CommentsLblName;
        private System.Windows.Forms.TextBox CommentsNameTxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label CommentsLblEmail;
        private System.Windows.Forms.RichTextBox CommentsRchtxtboxBody;
        private System.Windows.Forms.Label CommentsLblPost;
        private System.Windows.Forms.ComboBox CommentsCmbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DgvComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.Label CommentsLblBody;
    }
}