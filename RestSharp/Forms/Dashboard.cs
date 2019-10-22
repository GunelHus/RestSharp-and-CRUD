using Newtonsoft.Json;
using RestSharp.DAL;
using RestSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestSharp.Forms
{

    public partial class Dashboard : Form
    {

        RestClient client = new RestClient("https://jsonplaceholder.typicode.com");
        UserDbContext userDb;
        public Dashboard()
        {
            InitializeComponent();
            userDb = new UserDbContext();
        }

        private void CommentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comments comm = new Comments();
            comm.ShowDialog();
        }

        private void PostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvPosts pst = new DgvPosts();
            pst.ShowDialog();

        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usersfrm userForm = new Usersfrm();
            userForm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var requestUser = new RestRequest("users");
            string RequestContentUser = client.Execute(requestUser).Content;
            List<User> users = JsonConvert.DeserializeObject<List<User>>(RequestContentUser);

            var requestPost = new RestRequest("posts");
            string RequestContentPost = client.Execute(requestPost).Content;
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(RequestContentPost);

            var requestComment = new RestRequest("comments");
            string RequestContentComment = client.Execute(requestComment).Content;
            List<Comment> comments = JsonConvert.DeserializeObject<List<Comment>>(RequestContentComment);

            userDb.Users.AddRange(users);
            userDb.Posts.AddRange(posts);
            userDb.Comments.AddRange(comments);
            userDb.SaveChanges();

            foreach (var item in users)
            {
                dgvDashboard.Rows.Add(item.Id,item.Fullname,item.Username,item.Email,item.Posts.Count());
            }
        }
    }
}
