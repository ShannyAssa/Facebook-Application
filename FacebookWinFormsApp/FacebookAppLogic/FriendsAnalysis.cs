using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.FacebookAppLogic
{
    public class FriendsAnalysis
    {
        private readonly User r_LoggedInUser = null;
        private AgeGroup m_NotMentionedAge = new AgeGroup(0, k_NotMentioned);
        private readonly Dictionary<string, int> r_FriendsHometowns = new Dictionary<string, int>();
        private readonly Dictionary<AgeGroup, int> r_AgeGroups = new Dictionary<AgeGroup, int>();
        private FacebookObjectCollection<User> m_Friends = null;
        private const string k_OtherLocation = "Other";
        private const string k_NotMentioned = "Not Mentioned";

        public FriendsAnalysisInfo FriendsAnalysisInfo { get; private set; }

        public FriendsAnalysis(User i_LoggedInUser)
        {
            configureAgeGroups();
            FriendsAnalysisInfo = new FriendsAnalysisInfo();
            r_LoggedInUser = i_LoggedInUser;
        }
        
        public void AnalyzeFriends()
        {
            m_Friends = r_LoggedInUser.Friends;
            analyzeFriendsGender();
            analyzeFriendsAges();
            analyzeFriendsHometown();
        }

        private void analyzeFriendsHometown()
        {
            int numberOfFriends = 0;

            r_FriendsHometowns.Clear();
            r_FriendsHometowns.Add(k_OtherLocation, 0);
            foreach (User friend in m_Friends) 
            {
                if (friend.Hometown != null) 
                {
                    if (r_FriendsHometowns.ContainsKey(friend.Hometown.Name)) 
                    {
                        r_FriendsHometowns[friend.Hometown.Name]++;
                    }
                    else
                    {
                        r_FriendsHometowns.Add(friend.Hometown.Name, 1);
                    }
                }
                else
                {
                    r_FriendsHometowns[k_OtherLocation]++;
                }
                
                numberOfFriends++;
            }

            if (numberOfFriends != 0)
            {
                configureFriendsHometownAnalysis(numberOfFriends);
            }
        }

        private void configureFriendsHometownAnalysis(int i_NumOfFriends)
        {
            if (FriendsAnalysisInfo.FriendsHometownAnalysis == null) 
            {
                FriendsAnalysisInfo.FriendsHometownAnalysis = new Dictionary<string, double>();
            }
            else
            {
                FriendsAnalysisInfo.FriendsHometownAnalysis.Clear();
            }
            
            IEnumerable<KeyValuePair<string, int>> mostPopulatedHometowns = 
                r_FriendsHometowns.OrderByDescending(kv => kv.Value).Take(3);

            foreach (KeyValuePair<string, int> city in mostPopulatedHometowns) 
            {
                FriendsAnalysisInfo.FriendsHometownAnalysis.Add(city.Key, city.Value / i_NumOfFriends * 100);
            }
        }

        private void analyzeFriendsAges()
        {
            DateTime friendBirthday;
            int friendAge, friendsNumber = 0;

            foreach (User friend in m_Friends) 
            {
                if (friend.Birthday != null) 
                {
                    friendBirthday = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", null);
                    friendAge = (DateTime.Now - friendBirthday).Days / 365;
                    addFriendToAgeGroup(friendAge);
                }
                else
                {
                    r_AgeGroups[m_NotMentionedAge]++;
                }

                friendsNumber++;
            }

            if (friendsNumber != 0)
            {
                setAgesPercentage(friendsNumber);
            }
        }

        private void setAgesPercentage(int i_FriendsNumber)
        {
            if (FriendsAnalysisInfo.FriendsAgeAnalysis == null) 
            {
                FriendsAnalysisInfo.FriendsAgeAnalysis = new Dictionary<AgeGroup, double>();
            }
            else
            {
                FriendsAnalysisInfo.FriendsAgeAnalysis.Clear();
            }

            foreach (AgeGroup ageGroup in r_AgeGroups.Keys) 
            {
                FriendsAnalysisInfo.FriendsAgeAnalysis.Add(ageGroup, r_AgeGroups[ageGroup] / i_FriendsNumber * 100);
            }
        }

        private void addFriendToAgeGroup(int i_FriendAge)
        {
            AgeGroup friendAgeGroup = null;

            foreach (AgeGroup ageGroup in r_AgeGroups.Keys) 
            {
                if (ageGroup.Label != k_NotMentioned &&
                    ageGroup.MinAge <= i_FriendAge && ageGroup.MaxAge >= i_FriendAge) 
                {
                    friendAgeGroup = ageGroup;
                    break;
                }
            }

            if (friendAgeGroup != null) 
            {
                r_AgeGroups[friendAgeGroup]++;
            }
        }

        private void analyzeFriendsGender()
        {
            int male = 0, female = 0;

            foreach (User friend in m_Friends) 
            {
                if (friend.Gender.HasValue) 
                {
                    if (friend.Gender.ToString().Equals("female"))  
                    {
                        female++;
                    }
                    else
                    {
                        male++;
                    }
                }
            }

            if (male + female != 0)
            {
                FriendsAnalysisInfo.FemalePercentage = female / (female + male) * 100;
                FriendsAnalysisInfo.MalePercentage = male / (female + male) * 100;
            }
            else
            {
                FriendsAnalysisInfo.FemalePercentage = 0;
                FriendsAnalysisInfo.MalePercentage = 0;
            }
        }

        private void configureAgeGroups()
        {
            r_AgeGroups.Add(new AgeGroup(12, 18), 0);
            r_AgeGroups.Add(new AgeGroup(19, 25), 0);
            r_AgeGroups.Add(new AgeGroup(26, 34), 0);
            r_AgeGroups.Add(new AgeGroup(35), 0);
            r_AgeGroups.Add(m_NotMentionedAge,0);
        }
    }
}
