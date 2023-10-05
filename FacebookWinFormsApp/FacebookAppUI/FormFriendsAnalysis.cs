using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures.FacebookAppUI
{
    public partial class FormFriendsAnalysis : Form, ILightDarkMode
    {
        private const string k_FemalePercentage = "{0}% of your friends are females";
        private const string k_MalePercentage = "{0}% of your friends are males";
        private const string k_FriendsLocation = "{0}% of your friends are from {1}{2}";
        private const string k_NoLocationInfo = "There is no location info to show";
        private FriendsAnalysis m_FriendsAnalysis = null;
        private LightDarkMode m_LightDarkMode;

        public FormFriendsAnalysis(User i_LoggedInUser, LightDarkMode i_LightDarkMode)
        {
            m_FriendsAnalysis = new FriendsAnalysis(i_LoggedInUser);
            InitializeComponent();
            analyze();
            m_LightDarkMode = i_LightDarkMode;
            m_LightDarkMode.OnChanged += SwitchMode;
        }

        public void SwitchMode(Image i_BackgroundImage)
        {
            panelMainPanel.BackgroundImage = i_BackgroundImage;
            panelMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void analyze()
        {
            m_FriendsAnalysis.AnalyzeFriends();
            updateFriendsGenderGraph();
            updateFriendsLocationLabels();
            updateFriendsAgesLabels();
        }

        private void updateFriendsGenderGraph()
        {
            labelFemalePercentage.Text = String.Format(k_FemalePercentage, 
                m_FriendsAnalysis.FriendsAnalysisInfo.FemalePercentage);
            labelMalePercentage.Text = String.Format(k_MalePercentage, 
                m_FriendsAnalysis.FriendsAnalysisInfo.MalePercentage);
        }

        private void updateFriendsAgesLabels()
        {
            chartFriendsAges.Series.Clear();
            Series series = new Series("AgeGroups");
            Dictionary<AgeGroup, double> ageAnalysis = m_FriendsAnalysis.FriendsAnalysisInfo.FriendsAgeAnalysis;
            int index = 0;

            if (ageAnalysis != null) 
            {
                chartFriendsAges.Series.Add(series);
                foreach (AgeGroup ageGroup in ageAnalysis.Keys)
                {
                    DataPoint point = new DataPoint(index, ageAnalysis[ageGroup]);
                    point.AxisLabel = ageGroup.Label;
                    point.Label = ageAnalysis[ageGroup].ToString("0.00") + "%";
                    series.Points.Add(point);
                    index++;
                }

                chartFriendsAges.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartFriendsAges.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
        }

        private void updateFriendsLocationLabels() 
        {
            Dictionary<string, double> FriendsLocation = m_FriendsAnalysis.FriendsAnalysisInfo.FriendsHometownAnalysis;

            if (FriendsLocation == null)
            {
                labelFriendsHometown.Text = k_NoLocationInfo;
            }
            else
            {
                StringBuilder friendsHometownLabel = new StringBuilder();

                foreach (string city in FriendsLocation.Keys)
                {
                    friendsHometownLabel.AppendFormat(k_FriendsLocation, FriendsLocation[city], Environment.NewLine, city);
                    friendsHometownLabel.Append(Environment.NewLine);
                }

                labelFriendsHometown.Text = friendsHometownLabel.ToString();
            }
        }
    }
}
