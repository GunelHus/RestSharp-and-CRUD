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
    public partial class Usersfrm : Form
    {
        UserDbContext userDb;
        int SelectedUserId;


        public Usersfrm()
        {
            InitializeComponent();
             userDb = new UserDbContext();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Usersfrm_Load(object sender, EventArgs e)
        {
            List<User> users = userDb.Users.Include("Posts").ToList();
            foreach (var item in users)
            {
                DgvUsers.Rows.Add(item.Id, item.Fullname, item.Username, item.Email, item.Website, item.Posts.Count());
            }
        }

        private void DgvUsers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }
    }
}
