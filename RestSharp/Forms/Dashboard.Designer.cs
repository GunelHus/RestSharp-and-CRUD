namespace RestSharp.Forms
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentsToolStripMenuItem,
            this.postsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.commentsToolStripMenuItem.Text = "Comments";
            this.commentsToolStripMenuItem.Click += new System.EventHandler(this.CommentsToolStripMenuItem_Click);
            // 
            // postsToolStripMenuItem
            // 
            this.postsToolStripMenuItem.Name = "postsToolStripMenuItem";
            this.postsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.postsToolStripMenuItem.Text = "Posts";
            this.postsToolStripMenuItem.Click += new System.EventHandler(this.PostsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AllowUserToDeleteRows = false;
            this.dgvDashboard.AllowUserToResizeColumns = false;
            this.dgvDashboard.AllowUserToResizeRows = false;
            this.dgvDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fullname,
            this.Username,
            this.Email,
            this.PostsCount});
            this.dgvDashboard.Location = new System.Drawing.Point(3, 40);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.Size = new System.Drawing.Size(671, 398);
            this.dgvDashboard.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
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
            // PostsCount
            // 
            this.PostsCount.HeaderText = "PostsCount";
            this.PostsCount.Name = "PostsCount";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.dgvDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostsCount;
    }
}