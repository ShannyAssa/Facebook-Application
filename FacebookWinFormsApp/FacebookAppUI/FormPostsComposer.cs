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
    public partial class FormPostsComposer : Form, ILightDarkMode
    {
        private User m_LoggedInUser;
        private PostsBuilder m_PostsBuilder;
        private LightDarkMode m_LightDarkMode;

        public FormPostsComposer(User i_LoggedInUser, LightDarkMode i_LightDarkMode)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            m_LightDarkMode = i_LightDarkMode;
            m_LightDarkMode.OnChanged += SwitchMode;
        }

        public void SwitchMode(Image i_BackgroundImage)
        {
            BackgroundImage = i_BackgroundImage;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void buttonShowFilteredPosts_Click(object sender, EventArgs e)
        {
            if (comboBoxPostType.SelectedItem == null) 
            {
                MessageBox.Show("You must choose one of the options", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK) 
            {
                m_PostsBuilder = new PostsBuilder(dateTimePickerStart.Value, dateTimePickerEnd.Value, 
                    comboBoxPostType.SelectedItem.ToString(), m_LoggedInUser.Posts);
            }

            base.OnClosing(e);
        }
    }
}
