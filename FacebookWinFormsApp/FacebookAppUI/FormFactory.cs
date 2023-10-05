using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.FacebookAppUI
{
    public class FormFactory
    {
        public static Form CreateForm(eFormType i_FormType, User i_LoggedInUser, LightDarkMode i_LightDarkMode)
        {
            Form createdForm = null;

            switch (i_FormType)
            {
                case eFormType.Main:
                    createdForm = new FormMain(new LightDarkMode());
                    break;
                case eFormType.AlbumsAndPhotos:
                    createdForm = new FormAlbumsAndPhotos(i_LoggedInUser, i_LightDarkMode);
                    break;
                case eFormType.FriendsAnalysis:
                    createdForm = new FormFriendsAnalysis(i_LoggedInUser, i_LightDarkMode);
                    break;
                case eFormType.MonthlyBirthdays:
                    createdForm = new FormMonthlyBirthdays(i_LoggedInUser, i_LightDarkMode);
                    break;
                case eFormType.PostsComposer:
                    createdForm = new FormPostsComposer(i_LoggedInUser, i_LightDarkMode);
                    break;
            }

            return createdForm;
        }
    }
}
