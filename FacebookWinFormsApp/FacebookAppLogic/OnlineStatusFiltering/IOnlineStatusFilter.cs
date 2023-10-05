using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures.FacebookAppLogic.OnlineStatusFiltering
{
    public interface IOnlineStatusFilter
    {
        bool FilterFriendByOnlineStatus(User i_Friend);
    }
}
