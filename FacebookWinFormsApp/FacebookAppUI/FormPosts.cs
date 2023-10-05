using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.FacebookAppUI
{
    public partial class FormPosts : Form
    {
        private readonly FacebookObjectCollection<Post> r_Posts;

        public FormPosts(FacebookObjectCollection<Post> i_Posts)
        {
            r_Posts = i_Posts;
            InitializeComponent();
            populateListBoxWithPosts();
        }

        private void populateListBoxWithPosts()
        {
            listBoxPosts.Items.Clear();
            foreach (Post post in r_Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
            }
        }
    }
}
