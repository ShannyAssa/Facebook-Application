using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;



namespace BasicFacebookFeatures.FacebookAppUI
{
    public class PostsBuilder
    {
        private FormPosts m_FormPosts;
        private readonly DateTime r_StartDate;
        private readonly DateTime r_EndDate;
        private readonly string r_PostType;
        private const string k_allPosts = "all posts";
        private readonly FacebookObjectCollection<Post> r_Posts;
        private FacebookObjectCollection<Post> m_FilteredPosts;

        public PostsBuilder(DateTime i_StartDate, DateTime i_EndDate, string i_PostType, 
            FacebookObjectCollection<Post> i_Posts)
        {
            r_StartDate = i_StartDate;
            r_EndDate = i_EndDate;
            r_PostType = i_PostType;
            r_Posts = i_Posts;
            m_FilteredPosts = new FacebookObjectCollection<Post>();
            filterPosts();
            displayFormChosenPosts();
        }

        private void displayFormChosenPosts()
        {
            if (m_FilteredPosts.Count > 0) 
            {
                m_FormPosts = new FormPosts(m_FilteredPosts);
                m_FormPosts.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }

        private void filterPosts()
        {
            try
            {
                foreach (Post post in r_Posts)
                {
                    if (checkIfDesiredPost(post))
                    {
                        m_FilteredPosts.Add(post);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private bool checkIfDesiredPost(Post i_Post)
        {
            return i_Post.CreatedTime >= r_StartDate && i_Post.CreatedTime <= r_EndDate
                && (r_PostType.Equals(k_allPosts) || i_Post.Type.ToString().Equals(r_PostType));
        }
    }
}

