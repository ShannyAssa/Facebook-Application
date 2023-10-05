using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace BasicFacebookFeatures.FacebookAppUI
{
    public class LightDarkMode
    {
        public event Action<Image> OnChanged;
        private readonly Image r_LightModeBackgroundImage = global::BasicFacebookFeatures.Properties.Resources.photo;
        private readonly Image r_DarkModeBackgroundImage = global::BasicFacebookFeatures.Properties.Resources.dark_mode_photo;

        public LightDarkMode()
        {
            Mode = eMode.LightMode;
        }
        public eMode Mode { get; private set; }

        public void OnModeChanged()
        {
            if (Mode == eMode.LightMode) 
            {
                Mode = eMode.DarkMode;
                OnChanged.Invoke(r_DarkModeBackgroundImage);
            }
            else
            {
                Mode = eMode.LightMode;
                OnChanged.Invoke(r_LightModeBackgroundImage);
            }
        }
    }
}
