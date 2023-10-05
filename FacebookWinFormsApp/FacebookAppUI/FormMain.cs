using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.FacebookAppLogic;
using System.Windows.Forms.DataVisualization.Charting;
using BasicFacebookFeatures.FacebookAppUI;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form, ILightDarkMode
    {
        private const string k_Hometown = "From {0}";
        private const string k_School = "Went to {0}";
        private const string k_Workplace = "Works at {0}";
        private const string k_NameMember = "Name";
        private const string k_NoUserErrorMessage = "This action cannot be done - no user is logged in.";
        private const string k_DarkModeLabel = "switch to Dark Mode";
        private const string k_LightModeLabel = "switch to Light Mode";
        private bool m_isLoggedIn;
        private FormAlbumsAndPhotos m_FormAlbumsAndPhotos;
        private FormFriendsAnalysis m_FormFriendsAnalysis;
        private FormMonthlyBirthdays m_FormMonthlyBirthday;
        private FormPostsComposer m_FormPostsComposer;
        private FriendsView m_FriendsView;
        private LightDarkMode m_LightDarkMode;

        public LoginManager LoginManager { get; private set; }
        
        public bool RememberUserInPrevSession { get; set; }
        
        public FormMain(LightDarkMode i_LightDarkMode)
        {
            LoginManager = new LoginManager();
            m_LightDarkMode = i_LightDarkMode;
            InitializeComponent();
            disableUserDataAndEvents();
            fetchUserInfoIfPossible();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_LightDarkMode.OnChanged += SwitchMode;
        }

        public void SwitchMode(Image i_BackgroundImage)
        {
            panelMainPanel.BackgroundImage = i_BackgroundImage;
            panelMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            if (m_LightDarkMode.Mode == eMode.DarkMode) 
            {
                checkBoxLightDarkMode.Text = k_LightModeLabel;
            }
            else
            {
                checkBoxLightDarkMode.Text = k_DarkModeLabel;
            }
        }

        private void fetchUserInfoIfPossible()
        {
            checkBoxRememberUser.Checked = LoginManager.LoadAppSettingsIfExists();
            RememberUserInPrevSession = checkBoxRememberUser.Checked;
            if (RememberUserInPrevSession) 
            {
                configureUIWithExistingToken();
            }
        }

        private void disableUserDataAndEvents()
        {
            m_isLoggedIn = false;
            buttonLogout.Enabled = false;
            checkBoxRememberUser.Enabled = false;
            buttonLogin.Enabled = true;
            buttonAlbumsAndPhotos.Enabled = false;
            buttonFriendsAnalysis.Enabled = false;
            buttonMonthlyBirthdays.Enabled = false;
            buttonPosts.Enabled = false;
            buttonFriendsOnlineStatus.Enabled = false;
            comboBoxFriendsOnlineStatus.Enabled = false;
            hideUninitializedData();
            emptyFormOfContent();
        }

        private void emptyFormOfContent()
        {
            listBoxFriends.Visible = false;
            listBoxEvents.Visible = false;
            listBoxGroups.Visible = false;
            listBoxPages.Visible = false;
        }

        private void enableUserDataAndEvents()
        {
            m_isLoggedIn = true;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            checkBoxRememberUser.Enabled = true;
            labelUserFullName.Visible = true;
            pictureBoxProfilePic.Visible = true;
            buttonAlbumsAndPhotos.Enabled = true;
            buttonFriendsAnalysis.Enabled = true;
            buttonMonthlyBirthdays.Enabled = true;
            buttonPosts.Enabled = true;
            listBoxFriends.Visible = true;
            listBoxEvents.Visible = true;
            listBoxGroups.Visible = true;
            listBoxPages.Visible = true;
            buttonFriendsOnlineStatus.Enabled = true;
            comboBoxFriendsOnlineStatus.Enabled = true;
        }

        private void configureUIWithExistingToken()
        {
            pictureBoxProfilePic.LoadAsync(LoginManager.LoginResult.LoggedInUser.PictureNormalURL);
            loadBasicInfo();
            initializeForms();
            enableUserDataAndEvents();
        }

         private void initializeForms()
        {
            new Thread(initializeFormAlbumsAndPhotos).Start();
            new Thread(initializeFormFriendsAnalysis).Start();
            new Thread(initializeFormMonthlyBirthdays).Start();
            new Thread(initializeFormPostsComposer).Start();
        }

        private void initializeFriendsView()
        {
            m_FriendsView = new FriendsView(LoginManager.LoginResult.LoggedInUser.Friends);
        }

        private void initializeFormPostsComposer()
        {
            m_FormPostsComposer = FormFactory.CreateForm
                (eFormType.PostsComposer, LoginManager.LoginResult.LoggedInUser, m_LightDarkMode) as FormPostsComposer;
        }

        private void initializeFormAlbumsAndPhotos()
        {
            m_FormAlbumsAndPhotos = FormFactory.CreateForm
                (eFormType.AlbumsAndPhotos, LoginManager.LoginResult.LoggedInUser, m_LightDarkMode) as FormAlbumsAndPhotos;
        }

        private void initializeFormFriendsAnalysis()
        {
            m_FormFriendsAnalysis = FormFactory.CreateForm
                (eFormType.FriendsAnalysis, LoginManager.LoginResult.LoggedInUser, m_LightDarkMode) as FormFriendsAnalysis;
        }

        private void initializeFormMonthlyBirthdays()
        {
            m_FormMonthlyBirthday = FormFactory.CreateForm
                (eFormType.MonthlyBirthdays, LoginManager.LoginResult.LoggedInUser, m_LightDarkMode) as FormMonthlyBirthdays;
        }

        private void loadBasicInfo()
        {
            string userHometown, userEducation, userWorkplace;

            labelUserFullName.Text = LoginManager.LoginResult.LoggedInUser.Name;
            if (LoginManager.LoginResult.LoggedInUser.Hometown != null) 
            {
                userHometown = LoginManager.LoginResult.LoggedInUser.Hometown.Name;
                labelHometown.Text = String.Format(k_Hometown, userHometown);
            }

            if (LoginManager.LoginResult.LoggedInUser.Educations != null) 
            {
                userEducation = LoginManager.LoginResult.LoggedInUser.Educations[0].ToString();
                labelSchools.Text = String.Format(k_School, userEducation);
            }

            if (LoginManager.LoginResult.LoggedInUser.WorkExperiences != null) 
            {
                userWorkplace = LoginManager.LoginResult.LoggedInUser.WorkExperiences[0].Name;
                labelWorkplace.Text = String.Format(k_Workplace, userWorkplace);
            }

            new Thread(initializeFriendsView).Start();
        }

        private void hideUninitializedData()
        {
            labelUserFullName.Visible = false;
            pictureBoxProfilePic.Visible = false;
        }

        private void executeLoginAction()
        {
            bool isLoginSucceeded = LoginManager.LoginToFacebook();

            if (isLoginSucceeded) 
            {
                configureUIWithExistingToken();
                enableUserDataAndEvents();
            }
            else
            {
                MessageBox.Show(LoginManager.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            disableUserDataAndEvents();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {
                LoginManager.SaveAppSettings(checkBoxRememberUser.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabelFetchPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_isLoggedIn) 
            {
                listBoxPages.Invoke(new Action(fetchPages));
            }
            else
            {
                MessageBox.Show(k_NoUserErrorMessage);
            }
        }

        private void fetchPages()
        {
            pageBindingSource.DataSource = LoginManager.LoginResult.LoggedInUser.LikedPages;

            if (listBoxPages.Items.Count == 0) 
            {
                MessageBox.Show("No Pages to retrieve");
            }
        }

        private void linkLabelFetchGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (m_isLoggedIn)
                {
                    listBoxGroups.Invoke(new Action(fetchGroups));
                }
                else
                {
                    MessageBox.Show(k_NoUserErrorMessage);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fetchGroups()
        {
            groupBindingSource.DataSource = LoginManager.LoginResult.LoggedInUser.Groups;
            if (listBoxGroups.Items.Count == 0) 
            {
                MessageBox.Show("No groups to retrieve");
            }
        }

        private void linkLabelFetchEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_isLoggedIn) 
            {
                listBoxEvents.Invoke(new Action(fetchEvents));
            }
            else
            {
                MessageBox.Show(k_NoUserErrorMessage);
            }
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = LoginManager.LoginResult.LoggedInUser.Events;
            if (listBoxEvents.Items.Count == 0) 
            {
                MessageBox.Show("No Events to retrieve");
            }
        }   

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            executeLoginAction();
        }

        private void buttonAlbumsAndPhotos_Click(object sender, EventArgs e)
        {
            m_FormAlbumsAndPhotos.ShowDialog();
        }

        private void buttonFriendsAnalysis_Click(object sender, EventArgs e)
        {
            m_FormFriendsAnalysis.ShowDialog();
        }

        private void buttonMonthlyBirthdays_Click(object sender, EventArgs e)
        {
            m_FormMonthlyBirthday.ShowDialog();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            m_FormPostsComposer.ShowDialog();
        }

        private void buttonFriendsOnlineStatus_Click(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            if (m_isLoggedIn)
            {
                if (comboBoxFriendsOnlineStatus.SelectedItem == null)
                {
                    MessageBox.Show("You must choose one of the combo box's options!");
                }
                else
                {
                    listBoxFriends.Invoke(new Action(fetchFilteredFriends));
                }
            }
        }

        private void fetchFilteredFriends()
        {
            FacebookObjectCollection<User> filteredFriends = m_FriendsView.UserFriendsWhoMatchChosenOnlineStatus
                    (comboBoxFriendsOnlineStatus.SelectedItem.ToString());

            listBoxFriends.DisplayMember = k_NameMember;
            foreach (User friend in filteredFriends)
            {
                listBoxFriends.Items.Add(friend);
            }

            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve");
            }
        }

        private void checkBoxLightDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            m_LightDarkMode.OnModeChanged();
        }
    }
}
