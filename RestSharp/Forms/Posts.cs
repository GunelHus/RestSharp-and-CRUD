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
    public partial class DgvPosts : Form
    {
        UserDbContext userDb;
        public DgvPosts()
        {
            InitializeComponent();
            userDb = new UserDbContext();
        }

        private void DgvPosts_Load(object sender, EventArgs e)
        {
            List<Post> posts = userDb.Posts.ToList();
            foreach (var item in posts)
            {
                DataGvPost.Rows.Add(item.Id, item.Title, item.Body, userDb.Users.Find(item.UserId).Fullname);
            }
        }
    }
}
