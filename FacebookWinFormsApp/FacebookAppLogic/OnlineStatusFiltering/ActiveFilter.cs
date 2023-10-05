using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.FacebookAppLogic.OnlineStatusFiltering
{
    public class ActiveFilter : IOnlineStatusFilter
    {
        public bool FilterFriendByOnlineStatus(User i_Friend)
        {
            return i_Friend.OnlineStatus == User.eOnlineStatus.active;
        }
    }
}
