
namespace BasicFacebookFeatures.FacebookAppUI
{
    partial class FormFriendsAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendsAnalysis));
            this.panelMainPanel = new System.Windows.Forms.Panel();
            this.chartFriendsAges = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelFriendsHometown = new System.Windows.Forms.Label();
            this.pictureBoxMapPhoto = new System.Windows.Forms.PictureBox();
            this.labelMalePercentage = new System.Windows.Forms.Label();
            this.pictureBoxMalePhoto = new System.Windows.Forms.PictureBox();
            this.labelFemalePercentage = new System.Windows.Forms.Label();
            this.pictureBoxFemalePhoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFriendsAges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMalePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFemalePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.photo;
            this.panelMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainPanel.Controls.Add(this.chartFriendsAges);
            this.panelMainPanel.Controls.Add(this.labelFriendsHometown);
            this.panelMainPanel.Controls.Add(this.pictureBoxMapPhoto);
            this.panelMainPanel.Controls.Add(this.labelMalePercentage);
            this.panelMainPanel.Controls.Add(this.pictureBoxMalePhoto);
            this.panelMainPanel.Controls.Add(this.labelFemalePercentage);
            this.panelMainPanel.Controls.Add(this.pictureBoxFemalePhoto);
            this.panelMainPanel.Controls.Add(this.label3);
            this.panelMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPanel.Location = new System.Drawing.Point(0, 0);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.Size = new System.Drawing.Size(800, 758);
            this.panelMainPanel.TabIndex = 1;
            // 
            // chartFriendsAges
            // 
            this.chartFriendsAges.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartFriendsAges";
            this.chartFriendsAges.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFriendsAges.Legends.Add(legend1);
            this.chartFriendsAges.Location = new System.Drawing.Point(12, 352);
            this.chartFriendsAges.Name = "chartFriendsAges";
            this.chartFriendsAges.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartFriendsAges";
            series1.Legend = "Legend1";
            series1.Name = "Friends Ages";
            this.chartFriendsAges.Series.Add(series1);
            this.chartFriendsAges.Size = new System.Drawing.Size(732, 129);
            this.chartFriendsAges.TabIndex = 23;
            this.chartFriendsAges.Text = "Friends Ages";
            // 
            // labelFriendsHometown
            // 
            this.labelFriendsHometown.AutoSize = true;
            this.labelFriendsHometown.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendsHometown.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsHometown.Location = new System.Drawing.Point(254, 537);
            this.labelFriendsHometown.Name = "labelFriendsHometown";
            this.labelFriendsHometown.Size = new System.Drawing.Size(439, 45);
            this.labelFriendsHometown.TabIndex = 20;
            this.labelFriendsHometown.Text = "50% of your friends are from";
            // 
            // pictureBoxMapPhoto
            // 
            this.pictureBoxMapPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMapPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMapPhoto.Image = global::BasicFacebookFeatures.Properties.Resources.map;
            this.pictureBoxMapPhoto.Location = new System.Drawing.Point(42, 525);
            this.pictureBoxMapPhoto.Name = "pictureBoxMapPhoto";
            this.pictureBoxMapPhoto.Size = new System.Drawing.Size(191, 197);
            this.pictureBoxMapPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMapPhoto.TabIndex = 19;
            this.pictureBoxMapPhoto.TabStop = false;
            // 
            // labelMalePercentage
            // 
            this.labelMalePercentage.AutoSize = true;
            this.labelMalePercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelMalePercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMalePercentage.Location = new System.Drawing.Point(151, 234);
            this.labelMalePercentage.Name = "labelMalePercentage";
            this.labelMalePercentage.Size = new System.Drawing.Size(453, 45);
            this.labelMalePercentage.TabIndex = 18;
            this.labelMalePercentage.Text = "50% of your friends are males";
            // 
            // pictureBoxMalePhoto
            // 
            this.pictureBoxMalePhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMalePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMalePhoto.Image = global::BasicFacebookFeatures.Properties.Resources.male;
            this.pictureBoxMalePhoto.Location = new System.Drawing.Point(57, 223);
            this.pictureBoxMalePhoto.Name = "pictureBoxMalePhoto";
            this.pictureBoxMalePhoto.Size = new System.Drawing.Size(74, 91);
            this.pictureBoxMalePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMalePhoto.TabIndex = 17;
            this.pictureBoxMalePhoto.TabStop = false;
            // 
            // labelFemalePercentage
            // 
            this.labelFemalePercentage.AutoSize = true;
            this.labelFemalePercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelFemalePercentage.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemalePercentage.Location = new System.Drawing.Point(151, 138);
            this.labelFemalePercentage.Name = "labelFemalePercentage";
            this.labelFemalePercentage.Size = new System.Drawing.Size(481, 45);
            this.labelFemalePercentage.TabIndex = 16;
            this.labelFemalePercentage.Text = "50% of your friends are females";
            // 
            // pictureBoxFemalePhoto
            // 
            this.pictureBoxFemalePhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFemalePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFemalePhoto.Image = global::BasicFacebookFeatures.Properties.Resources.female;
            this.pictureBoxFemalePhoto.Location = new System.Drawing.Point(57, 106);
            this.pictureBoxFemalePhoto.Name = "pictureBoxFemalePhoto";
            this.pictureBoxFemalePhoto.Size = new System.Drawing.Size(74, 91);
            this.pictureBoxFemalePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFemalePhoto.TabIndex = 15;
            this.pictureBoxFemalePhoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "Friends Analysis";
            // 
            // FormFriendsAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 758);
            this.Controls.Add(this.panelMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFriendsAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook - Friends Analysis";
            this.panelMainPanel.ResumeLayout(false);
            this.panelMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFriendsAges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMalePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFemalePhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFriendsAges;
        private System.Windows.Forms.Label labelFriendsHometown;
        private System.Windows.Forms.PictureBox pictureBoxMapPhoto;
        private System.Windows.Forms.Label labelMalePercentage;
        private System.Windows.Forms.PictureBox pictureBoxMalePhoto;
        private System.Windows.Forms.Label labelFemalePercentage;
        private System.Windows.Forms.PictureBox pictureBoxFemalePhoto;
        private System.Windows.Forms.Label label3;
    }
}