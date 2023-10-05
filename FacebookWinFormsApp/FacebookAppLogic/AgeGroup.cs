using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookAppLogic
{
    public class AgeGroup
    {
        private const string k_AgeGroupPattern = "{0}-{1}";
        private const string k_NotLimitedAgeGroup = "{0}+";

        public int MinAge { get; private set; }

        public int MaxAge { get; private set; }

        public string Label { get; private set; }

        public AgeGroup(int i_MinAge, int i_MaxAge)
        {
            MinAge = i_MinAge;
            MaxAge = i_MaxAge;
            Label = String.Format(k_AgeGroupPattern, MinAge, MaxAge);
        }

        public AgeGroup(int i_MinAge)
        {
            MinAge = i_MinAge;
            MaxAge = Int32.MaxValue;
            Label = String.Format(k_NotLimitedAgeGroup, MinAge);
        }

        public AgeGroup(int i_MinAge, string i_Label)
        {
            MinAge = i_MinAge;
            MaxAge = Int32.MaxValue;
            Label = i_Label;
        }
    }
}
