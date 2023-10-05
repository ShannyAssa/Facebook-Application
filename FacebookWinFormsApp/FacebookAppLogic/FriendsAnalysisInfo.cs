using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookAppLogic
{
    public class FriendsAnalysisInfo
    {
        public double MalePercentage { get; set; }

        public double FemalePercentage { get; set; }

        public Dictionary<string, double> FriendsHometownAnalysis { get; set; }

        public Dictionary<AgeGroup, double> FriendsAgeAnalysis { get; set; }
    }
}
