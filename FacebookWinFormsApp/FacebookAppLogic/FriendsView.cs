using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.FacebookAppLogic.OnlineStatusFiltering;

namespace BasicFacebookFeatures.FacebookAppLogic
{
    public class FriendsView
    {
        private readonly FacebookObjectCollection<User> r_UserFriends;
        private IOnlineStatusFilter m_FriendsOnlineStatusFilter;
        private const string k_ActiveStatus = "Active";
        private const string k_OfflineStatus = "Offline";
        private const string k_UnknownStatus = "Unknown";
        private const string k_NoFilter = "No Filter";

        public FriendsView(FacebookObjectCollection<User> i_UserFriends)
        {
            r_UserFriends = i_UserFriends;
        }

        private void extractFilterByUserChoice(string i_UserChoice)
        {
            switch(i_UserChoice)
            {
                case k_ActiveStatus:
                    m_FriendsOnlineStatusFilter = new ActiveFilter();
                    break;
                case k_OfflineStatus:
                    m_FriendsOnlineStatusFilter = new OfflineFilter();
                    break;
                case k_UnknownStatus:
                    m_FriendsOnlineStatusFilter = new UnkownFilter();
                    break;
                case k_NoFilter:
                    m_FriendsOnlineStatusFilter = new NoFilter();
                    break;
            }
        }

        public FacebookObjectCollection<User> UserFriendsWhoMatchChosenOnlineStatus(string i_OnlineStatus)
        {
            extractFilterByUserChoice(i_OnlineStatus);
            FacebookObjectCollection<User> UserFriends = new FacebookObjectCollection<User>();

            foreach (User friend in r_UserFriends) 
            {
                if (m_FriendsOnlineStatusFilter.FilterFriendByOnlineStatus(friend))  
                {
                    UserFriends.Add(friend);
                }
            }

            return UserFriends;
        }
    }
}
