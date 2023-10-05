using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;


namespace BasicFacebookFeatures.FacebookAppLogic
{
    public sealed class LoginManager
    {
        public LoginResult LoginResult { get; private set; }
        
        public AppSettings AppSettings { get; set; }
        
        public bool IsAccessTokenValid { get; set; }
        
        public LoginManager()
        {
            LoginResult = null;
            IsAccessTokenValid = false;
        }

        public void SaveAppSettings(bool i_IsRememberMeChecked)
        {
            AppSettings.RememberUser = i_IsRememberMeChecked;
            AppSettings.LastAccessToken = i_IsRememberMeChecked ? LoginResult.AccessToken : null;

            try
            {
                AppSettings.SaveToFile();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LoadAppSettingsIfExists()
        {
            AppSettings = AppSettings.LoadFromFile();
            if (AppSettings.RememberUser && !string.IsNullOrEmpty(AppSettings.LastAccessToken)) 
            {
                LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
                IsAccessTokenValid = !string.IsNullOrEmpty(LoginResult.AccessToken);
            }

            return IsAccessTokenValid;
        }

        public bool LoginToFacebook()
        {
            return IsAccessTokenValid ? loginWithExistToken() : loginWithNewToken();
        }

        private bool loginWithExistToken()
        {
            LoginResult = FacebookService.Connect(LoginResult.AccessToken);

            return !string.IsNullOrEmpty(LoginResult.AccessToken);
        }

        private bool loginWithNewToken()
        {
            LoginResult = FacebookService.Login(
                    "123957587411503",
                    "email",
                    "public_profile",
                    "user_events",
                    "user_friends",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "user_birthday",
                    "user_gender",
                    "user_hometown");

            return !string.IsNullOrEmpty(LoginResult.AccessToken);
        }
    }
}
