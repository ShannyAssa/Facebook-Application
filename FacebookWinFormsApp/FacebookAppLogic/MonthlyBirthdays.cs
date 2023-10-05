using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.FacebookAppLogic
{
    public class MonthlyBirthdays : IEnumerable<User>
    {
        private readonly User r_LoggedInUser = null; 

        public MonthlyBirthdays(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        private bool IsCelebratingBdayThisMonth(User i_Friend)
        {
            DateTime friendBday = DateTime.ParseExact(i_Friend.Birthday, "MM/dd/yyyy", null);

            return DateTime.Now.Month == friendBday.Month;
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (IsCelebratingBdayThisMonth(friend))
                {
                    yield return friend;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
