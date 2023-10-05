using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.FacebookAppUI
{
    public partial class FormMonthlyBirthdays : Form, ILightDarkMode
    {
        private MonthlyBirthdays m_MonthlyBirthdays = null;
        private const string k_PictureIndex = "{0}/{1}";
        private const string k_NothingToShow = "No birthdays to show this month!";
        private FacebookObjectCollection<User> m_MonthlyBirthdayUsers = null;
        private int m_BirthdayKidIndex;
        private LightDarkMode m_LightDarkMode;

        public FormMonthlyBirthdays(User i_LoggedInUser, LightDarkMode i_LightDarkMode)
        {
            m_MonthlyBirthdays = new MonthlyBirthdays(i_LoggedInUser);
            InitializeComponent();
            pictureBoxBirthdayBox.Visible = false;
            executeMonthlyBirthdayFetching();
            m_LightDarkMode = i_LightDarkMode;
            m_LightDarkMode.OnChanged += SwitchMode;
        }

        public void SwitchMode(Image i_BackgroundImage)
        {
            panelMainPanel.BackgroundImage = i_BackgroundImage;
            panelMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void setFriendsWhoCelebrateBdayThisMonth()
        {
            m_MonthlyBirthdayUsers = new FacebookObjectCollection<User>();

            foreach (User friend in m_MonthlyBirthdays) 
            {
                m_MonthlyBirthdayUsers.Add(friend);
            }
        }
        private void executeMonthlyBirthdayFetching() 
        {
            setFriendsWhoCelebrateBdayThisMonth();
            if (m_MonthlyBirthdayUsers.Count != 0)
            {
                m_BirthdayKidIndex = 0;
                pictureBoxBirthdayBox.LoadAsync(m_MonthlyBirthdayUsers[m_BirthdayKidIndex].PictureNormalURL);
                updateAlbumPictureIndexLabel(ref labelNumberOfPhoto, m_BirthdayKidIndex + 1, m_MonthlyBirthdayUsers.Count);
                labelNameOfBirthdayKid.Text = m_MonthlyBirthdayUsers[m_BirthdayKidIndex].Name;
                pictureBoxBirthdayBox.Visible = true;
            }
            else
            {
                labelNameOfBirthdayKid.Text = k_NothingToShow;
            }
        }

        private void pictureBoxBirthdayBox_Click(object sender, EventArgs e)
        {
            m_BirthdayKidIndex++;
            if (m_MonthlyBirthdayUsers.Count - 1 < m_BirthdayKidIndex) 
            {
                m_BirthdayKidIndex = 0;
            }

            pictureBoxBirthdayBox.LoadAsync(m_MonthlyBirthdayUsers[m_BirthdayKidIndex].PictureNormalURL);
            updateAlbumPictureIndexLabel(ref labelNumberOfPhoto, m_BirthdayKidIndex + 1, m_MonthlyBirthdayUsers.Count);
            labelNameOfBirthdayKid.Text = m_MonthlyBirthdayUsers[m_BirthdayKidIndex].Name;
        }

        private void updateAlbumPictureIndexLabel(ref Label i_labelToUpdate, int i_CurrentIndex, int i_TotalAmountOfPhotos)
        {
            i_labelToUpdate.Text = String.Format(k_PictureIndex, i_CurrentIndex, i_TotalAmountOfPhotos);
        }
    }
}
